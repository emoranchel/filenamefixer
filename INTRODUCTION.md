# Introduction #

File Name Fix is a simple utility that allows you to remove patterns from filenames, it can fix files or folders. For example suppose you download a big image pack from a site but all the images contains the website in the filename as well as an md5 signature, usually such data is contained in parenthesis or brackets.

# Details #

This utility allows you the easy removal of such patterns, it can remove whatever is inside the parenthesis and brackets, as well as patterns specified by you.
Lets assume your files are like this
  * Photo1\_www.picasa.comm42221sda? (cool trip).jpg
  * Photo2\_www.picasa.comppsod3412? (cool trip).jpg
  * Photo3\_www.picasa.comajsndiena? (cool trip).jpg
  * Photo4\_www.picasa.com828173912? (cool trip).jpg
with the default options you will get the files as:
  * Photo1\_www.picasa.com.jpg
  * Photo2\_www.picasa.com.jpg
  * Photo3\_www.picasa.com.jpg
  * Photo4\_www.picasa.com.jpg
And now try adding "www.picasa.com" in the patterns text box The result will be:
  * Photo1.jpg
  * Photo2.jpg
  * Photo3.jpg
  * Photo4.jpg
The main idea is to make this application a perfect companion for downloads or files that contain such annoying data inside, and to fix the filenames and make them a lot shorter and easier to read and to distribute.