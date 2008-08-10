namespace FileNameFixer {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chTrimUnderscores = new System.Windows.Forms.CheckBox();
      this.chTrimSpaces = new System.Windows.Forms.CheckBox();
      this.chConvertSpaces = new System.Windows.Forms.CheckBox();
      this.chRemoveParenthesis = new System.Windows.Forms.CheckBox();
      this.chRemoveBrackets = new System.Windows.Forms.CheckBox();
      this.radioDirectories = new System.Windows.Forms.RadioButton();
      this.radioFiles = new System.Windows.Forms.RadioButton();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txtPattern = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtDirPath = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.chRecursive = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.listView1 = new System.Windows.Forms.ListView();
      this.columnStatus = new System.Windows.Forms.ColumnHeader();
      this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.panel3);
      this.groupBox1.Controls.Add(this.panel2);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(833, 95);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.chTrimUnderscores);
      this.panel1.Controls.Add(this.chTrimSpaces);
      this.panel1.Controls.Add(this.chConvertSpaces);
      this.panel1.Controls.Add(this.chRemoveParenthesis);
      this.panel1.Controls.Add(this.chRemoveBrackets);
      this.panel1.Controls.Add(this.radioDirectories);
      this.panel1.Controls.Add(this.radioFiles);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 68);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(696, 24);
      this.panel1.TabIndex = 8;
      // 
      // chTrimUnderscores
      // 
      this.chTrimUnderscores.AutoSize = true;
      this.chTrimUnderscores.Checked = true;
      this.chTrimUnderscores.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chTrimUnderscores.Dock = System.Windows.Forms.DockStyle.Left;
      this.chTrimUnderscores.Location = new System.Drawing.Point(542, 0);
      this.chTrimUnderscores.Name = "chTrimUnderscores";
      this.chTrimUnderscores.Size = new System.Drawing.Size(109, 24);
      this.chTrimUnderscores.TabIndex = 11;
      this.chTrimUnderscores.Text = "Trim Underscores";
      this.chTrimUnderscores.UseVisualStyleBackColor = true;
      // 
      // chTrimSpaces
      // 
      this.chTrimSpaces.AutoSize = true;
      this.chTrimSpaces.Checked = true;
      this.chTrimSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chTrimSpaces.Dock = System.Windows.Forms.DockStyle.Left;
      this.chTrimSpaces.Location = new System.Drawing.Point(457, 0);
      this.chTrimSpaces.Name = "chTrimSpaces";
      this.chTrimSpaces.Size = new System.Drawing.Size(85, 24);
      this.chTrimSpaces.TabIndex = 10;
      this.chTrimSpaces.Text = "Trim Spaces";
      this.chTrimSpaces.UseVisualStyleBackColor = true;
      // 
      // chConvertSpaces
      // 
      this.chConvertSpaces.AutoSize = true;
      this.chConvertSpaces.Checked = true;
      this.chConvertSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chConvertSpaces.Dock = System.Windows.Forms.DockStyle.Left;
      this.chConvertSpaces.Location = new System.Drawing.Point(355, 0);
      this.chConvertSpaces.Name = "chConvertSpaces";
      this.chConvertSpaces.Size = new System.Drawing.Size(102, 24);
      this.chConvertSpaces.TabIndex = 9;
      this.chConvertSpaces.Text = "Convert Spaces";
      this.chConvertSpaces.UseVisualStyleBackColor = true;
      // 
      // chRemoveParenthesis
      // 
      this.chRemoveParenthesis.AutoSize = true;
      this.chRemoveParenthesis.Checked = true;
      this.chRemoveParenthesis.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chRemoveParenthesis.Dock = System.Windows.Forms.DockStyle.Left;
      this.chRemoveParenthesis.Location = new System.Drawing.Point(231, 0);
      this.chRemoveParenthesis.Name = "chRemoveParenthesis";
      this.chRemoveParenthesis.Size = new System.Drawing.Size(124, 24);
      this.chRemoveParenthesis.TabIndex = 8;
      this.chRemoveParenthesis.Text = "Remove Parenthesis";
      this.chRemoveParenthesis.UseVisualStyleBackColor = true;
      // 
      // chRemoveBrackets
      // 
      this.chRemoveBrackets.AutoSize = true;
      this.chRemoveBrackets.Checked = true;
      this.chRemoveBrackets.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chRemoveBrackets.Dock = System.Windows.Forms.DockStyle.Left;
      this.chRemoveBrackets.Location = new System.Drawing.Point(121, 0);
      this.chRemoveBrackets.Name = "chRemoveBrackets";
      this.chRemoveBrackets.Size = new System.Drawing.Size(110, 24);
      this.chRemoveBrackets.TabIndex = 7;
      this.chRemoveBrackets.Text = "Remove brackets";
      this.chRemoveBrackets.UseVisualStyleBackColor = true;
      // 
      // radioDirectories
      // 
      this.radioDirectories.AutoSize = true;
      this.radioDirectories.Dock = System.Windows.Forms.DockStyle.Left;
      this.radioDirectories.Location = new System.Drawing.Point(46, 0);
      this.radioDirectories.Name = "radioDirectories";
      this.radioDirectories.Size = new System.Drawing.Size(75, 24);
      this.radioDirectories.TabIndex = 13;
      this.radioDirectories.Text = "Directories";
      this.radioDirectories.UseVisualStyleBackColor = true;
      // 
      // radioFiles
      // 
      this.radioFiles.AutoSize = true;
      this.radioFiles.Checked = true;
      this.radioFiles.Dock = System.Windows.Forms.DockStyle.Left;
      this.radioFiles.Location = new System.Drawing.Point(0, 0);
      this.radioFiles.Name = "radioFiles";
      this.radioFiles.Size = new System.Drawing.Size(46, 24);
      this.radioFiles.TabIndex = 12;
      this.radioFiles.TabStop = true;
      this.radioFiles.Text = "Files";
      this.radioFiles.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.txtPattern);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(3, 41);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(696, 27);
      this.panel3.TabIndex = 7;
      // 
      // txtPattern
      // 
      this.txtPattern.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtPattern.Location = new System.Drawing.Point(88, 0);
      this.txtPattern.Name = "txtPattern";
      this.txtPattern.Size = new System.Drawing.Size(608, 20);
      this.txtPattern.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Left;
      this.label3.Location = new System.Drawing.Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(88, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Patern to remove";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txtDirPath);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.chRecursive);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 16);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(696, 25);
      this.panel2.TabIndex = 1;
      // 
      // txtDirPath
      // 
      this.txtDirPath.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtDirPath.Location = new System.Drawing.Point(32, 0);
      this.txtDirPath.Name = "txtDirPath";
      this.txtDirPath.Size = new System.Drawing.Size(458, 20);
      this.txtDirPath.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Right;
      this.button1.Location = new System.Drawing.Point(490, 0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 25);
      this.button1.TabIndex = 1;
      this.button1.Text = "Browse";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // chRecursive
      // 
      this.chRecursive.AutoSize = true;
      this.chRecursive.Dock = System.Windows.Forms.DockStyle.Right;
      this.chRecursive.Location = new System.Drawing.Point(565, 0);
      this.chRecursive.Name = "chRecursive";
      this.chRecursive.Size = new System.Drawing.Size(131, 25);
      this.chRecursive.TabIndex = 3;
      this.chRecursive.Text = "Include Subdirectories";
      this.chRecursive.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Left;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Path:";
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Right;
      this.button2.Location = new System.Drawing.Point(699, 16);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(131, 76);
      this.button2.TabIndex = 3;
      this.button2.Text = "Find Fix";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // listView1
      // 
      this.listView1.AllowColumnReorder = true;
      this.listView1.CheckBoxes = true;
      this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStatus,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.listView1.HideSelection = false;
      listViewItem1.StateImageIndex = 0;
      this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
      this.listView1.Location = new System.Drawing.Point(3, 16);
      this.listView1.Name = "listView1";
      this.listView1.ShowItemToolTips = true;
      this.listView1.Size = new System.Drawing.Size(827, 373);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Details;
      // 
      // columnStatus
      // 
      this.columnStatus.Text = "Status";
      this.columnStatus.Width = 50;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Old Filename";
      this.columnHeader1.Width = 200;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "New Filename";
      this.columnHeader2.Width = 200;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Path";
      this.columnHeader3.Width = 350;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.listView1);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 95);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(833, 392);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "groupBox2";
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.button6);
      this.panel4.Controls.Add(this.button5);
      this.panel4.Controls.Add(this.button4);
      this.panel4.Controls.Add(this.button3);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel4.Location = new System.Drawing.Point(0, 510);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(833, 50);
      this.panel4.TabIndex = 3;
      // 
      // button6
      // 
      this.button6.Dock = System.Windows.Forms.DockStyle.Left;
      this.button6.Location = new System.Drawing.Point(324, 0);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(162, 50);
      this.button6.TabIndex = 3;
      this.button6.Text = "Check None";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button5
      // 
      this.button5.Dock = System.Windows.Forms.DockStyle.Left;
      this.button5.Location = new System.Drawing.Point(162, 0);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(162, 50);
      this.button5.TabIndex = 2;
      this.button5.Text = "Check All";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button4
      // 
      this.button4.Dock = System.Windows.Forms.DockStyle.Left;
      this.button4.Location = new System.Drawing.Point(0, 0);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(162, 50);
      this.button4.TabIndex = 1;
      this.button4.Text = "Check Selected";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Right;
      this.button3.Location = new System.Drawing.Point(671, 0);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(162, 50);
      this.button3.TabIndex = 0;
      this.button3.Text = "FIX";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBar1.Location = new System.Drawing.Point(0, 487);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(833, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(833, 560);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.panel4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtDirPath;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox chRecursive;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox txtPattern;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.CheckBox chRemoveParenthesis;
    private System.Windows.Forms.CheckBox chRemoveBrackets;
    private System.Windows.Forms.CheckBox chConvertSpaces;
    private System.Windows.Forms.CheckBox chTrimUnderscores;
    private System.Windows.Forms.CheckBox chTrimSpaces;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton radioDirectories;
    private System.Windows.Forms.RadioButton radioFiles;
    private System.Windows.Forms.ColumnHeader columnStatus;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

