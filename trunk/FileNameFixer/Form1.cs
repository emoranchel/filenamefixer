using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileNameFixer {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      DialogResult res = folderBrowserDialog1.ShowDialog();
      if (res != DialogResult.Cancel) {
        txtDirPath.Text = folderBrowserDialog1.SelectedPath;
      }
      button2_Click(sender, e);
    }
    private bool fileMode = true;
    private void button2_Click(object sender, EventArgs e) {
      DirectoryInfo dir = null;
      try {
        dir = new DirectoryInfo(txtDirPath.Text);
        if (dir == null) {
          throw new ArgumentNullException("Target directory is not accessible");
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.Message);
        return;
      }
      List<String> patterns = new List<string>();
      StringBuilder pattern = null;
      bool escaped = false;
      bool stringified = false;
      foreach (char c in this.txtPattern.Text) {
        if (c == '\\') {
          escaped = true;
          continue;
        }
        if (escaped) {
          escaped = false;
          pattern.Append(c);
          continue;
        }
        if (c == '"') {
          if (stringified) {
            stringified = false;
          } else {
            stringified = true;
          }
          continue;
        }
        if (stringified) {
          if (pattern == null) {
            pattern = new StringBuilder();
          }
          pattern.Append(c);
          continue;
        }
        if (c == ' ' || c == ',' || c == '\n') {
          if (pattern != null) {
            patterns.Add(pattern.ToString());
            pattern = null;
          }
          continue;
        }
        if (pattern == null) {
          pattern = new StringBuilder();
        }
        pattern.Append(c);
      }
      if (pattern != null) {
        patterns.Add(pattern.ToString());
      }
      foreach (String s in this.txtPattern.Text.Split(new char[] { ',' })) {
        String s2 = s.Trim();
        if (s2.Length > 0) {
          patterns.Add(s2);
        }
      }
      listView1.Items.Clear();
      if (radioFiles.Checked) {
        fileMode = true;
        FileInfo[] infos = dir.GetFiles();
        foreach (FileInfo f in infos) {
          string filename = f.Name;
          if (filename.Contains('.')) {
            filename = filename.Substring(0, f.Name.LastIndexOf('.'));
          }
          addData(patterns, f.DirectoryName, filename, f.Extension);
        }
      } else {
        fileMode = false;
        DirectoryInfo[] infos = dir.GetDirectories();
        foreach (DirectoryInfo d in infos) {
          addData(patterns, d.Parent.FullName, d.Name, "");
        }
      }
      button5_Click(sender, e);
    }

    private void addData(List<String> patterns, string path, string fileName, string extension) {
      string name = fileName;
      int index = 0;
      foreach (string pattern in patterns) {
        while ((index = name.IndexOf(pattern)) >= 0) {
          name = name.Remove(index, pattern.Length);
        }
      }
      StringBuilder newName = new StringBuilder();
      bool space = false;
      StringBuilder tempBracket = null;
      StringBuilder tempParenthesis = null;
      foreach (char c in name) {
        if (c == ' ' || c == '_') {
          if (space) {
            continue;
          } else {
            space = true;
          }
        } else {
          space = false;
        }
        if (c == '[' && this.chRemoveBrackets.Checked) {
          if (tempBracket != null) {
            newName.Append(tempBracket);
          }
          tempBracket = new StringBuilder();
        }
        if (tempBracket != null) {
          tempBracket.Append(c);
          if (c == ']')
            tempBracket = null;
          continue;
        }

        if (c == '(' && this.chRemoveParenthesis.Checked) {
          if (tempParenthesis != null) {
            newName.Append(tempParenthesis);
          }
          tempParenthesis = new StringBuilder();
        }
        if (tempParenthesis != null) {
          tempParenthesis.Append(c);
          if (c == ')')
            tempParenthesis = null;
          continue;
        }
        if (c == '_') {
          newName.Append(' ');
        } else {
          newName.Append(c);
        }
      }
      if (tempBracket != null) {
        newName.Append(tempBracket);
      } else if (tempParenthesis != null) {
        newName.Append(tempParenthesis);
      }

      string finalName = null;
      if (chConvertSpaces.Checked) {
        name = newName.ToString();
        newName = new StringBuilder();
        foreach (char c in name) {
          if (c == ' ') {
            newName.Append('_');
          } else {
            newName.Append(c);
          }
        }
        finalName = newName.ToString();
        if (chTrimUnderscores.Checked) {
          finalName = finalName.Trim(new char[] { '_' });
        }
      } else {
        finalName = newName.ToString();
        if (chTrimSpaces.Checked) {
          finalName = finalName.Trim();
        }
      }
      listView1.Items.Add(new ListViewItem(new String[] { "", fileName, finalName, path, extension}));
    }

    private void button3_Click(object sender, EventArgs e) {
      foreach (ListViewItem item in listView1.CheckedItems) {
        string oldFilename = item.SubItems[3].Text + "\\" + item.SubItems[1].Text + item.SubItems[4].Text;
        string newFilename = item.SubItems[3].Text + "\\" + item.SubItems[2].Text + item.SubItems[4].Text;
        if (oldFilename != newFilename) {
          try {
            if (fileMode) {
              File.Move(oldFilename, newFilename);
            } else {
              Directory.Move(oldFilename, newFilename);
            }
            item.SubItems[0].Text = "OK";
            item.SubItems[1].Text = item.SubItems[2].Text;
            item.ToolTipText = null;
          } catch (IOException ioEx) {
            item.SubItems[0].Text = "ERR";
            item.ToolTipText = "IO Error: " + ioEx.Message;
          } catch (UnauthorizedAccessException uaEx) {
            item.SubItems[0].Text = "ERR";
            item.ToolTipText = "Access denied: " + uaEx.Message;
          }
        }
      }
    }

    private void button4_Click(object sender, EventArgs e) {
      foreach (ListViewItem item in listView1.SelectedItems) {
        item.Checked = !item.Checked;
      }
    }

    private void button5_Click(object sender, EventArgs e) {
      foreach (ListViewItem item in listView1.Items) {
        item.Checked = true;
      }
    }

    private void button6_Click(object sender, EventArgs e) {
      foreach (ListViewItem item in listView1.Items) {
        item.Checked = false;
      }
    }
  }
}
