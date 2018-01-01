using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace P6MCR_2
{
    public partial class Form1 : Form
    {
        bool folderExists = false;
        bool xuid01Good = false;
        bool xuid02Good = false;
        bool xuid03Good = false;
        bool xuid04Good = false;
        bool xuid05Good = false;
        bool xuid06Good = false;
        bool xuid07Good = false;
        bool xuid08Good = false;
        bool xuid09Good = false;
        bool xuid10Good = false;
        bool xuid11Good = false;
        bool xuid12Good = false;
        bool xuid13Good = false;
        bool xuid14Good = false;
        bool xuid15Good = false;
        bool stopError = false;
        int configLineCount = 0;

        StreamWriter configStreamWriter;
        StreamReader configStreamReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            xuidTextBox01.Select();
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            xuid01Good = false;
            xuid02Good = false;
            xuid03Good = false;
            xuid04Good = false;
            xuid05Good = false;
            xuid06Good = false;
            xuid07Good = false;
            xuid08Good = false;
            xuid09Good = false;
            xuid10Good = false;
            xuid11Good = false;
            xuid12Good = false;
            xuid13Good = false;
            xuid14Good = false;
            xuid15Good = false;
            stopError = false;

            folderExists = false;

            if (xuidTextBox01.Text.Length == 0)
            {
                xuid01Good = false;
            } else if (xuidTextBox01.Text.Length == 16)
            {
                xuid01Good = true;
            }
            else
            {
                xuid01Good = false;
                MessageBox.Show("XUID 01 not correct length.", "Invalid XUID",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xuidTextBox01.Focus();
                xuidTextBox01.SelectAll();
                stopError = true;
            }

            if (stopError == false)
            {
                if (xuidTextBox02.Text.Length == 0)
                {
                    xuid02Good = false;
                }
                else if (xuidTextBox02.Text.Length == 16)
                {
                    xuid02Good = true;
                }
                else
                {
                    xuid02Good = false;
                    MessageBox.Show("XUID 02 not correct length.", "Invalid XUID",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    xuidTextBox02.Focus();
                    xuidTextBox02.SelectAll();
                    stopError = true;
                }
            }

            if (stopError == false)
            {
                if (xuidTextBox03.Text.Length == 0)
                {
                    xuid03Good = false;
                }
                else if (xuidTextBox03.Text.Length == 16)
                {
                    xuid03Good = true;
                }
                else
                {
                    xuid03Good = false;
                    MessageBox.Show("XUID 03 not correct length.", "Invalid XUID",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    xuidTextBox03.Focus();
                    xuidTextBox03.SelectAll();
                    stopError = true;
                }

                if (stopError == false)
                {
                    if (xuidTextBox04.Text.Length == 0)
                    {
                        xuid04Good = false;
                    }
                    else if (xuidTextBox04.Text.Length == 16)
                    {
                        xuid04Good = true;
                    }
                    else
                    {
                        xuid04Good = false;
                        MessageBox.Show("XUID 04 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox04.Focus();
                        xuidTextBox04.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox05.Text.Length == 0)
                    {
                        xuid05Good = false;
                    }
                    else if (xuidTextBox05.Text.Length == 16)
                    {
                        xuid05Good = true;
                    }
                    else
                    {
                        xuid05Good = false;
                        MessageBox.Show("XUID 05 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox05.Focus();
                        xuidTextBox05.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox06.Text.Length == 0)
                    {
                        xuid06Good = false;
                    }
                    else if (xuidTextBox06.Text.Length == 16)
                    {
                        xuid06Good = true;
                    }
                    else
                    {
                        xuid06Good = false;
                        MessageBox.Show("XUID 06 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox06.Focus();
                        xuidTextBox06.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox07.Text.Length == 0)
                    {
                        xuid07Good = false;
                    }
                    else if (xuidTextBox07.Text.Length == 16)
                    {
                        xuid07Good = true;
                    }
                    else
                    {
                        xuid07Good = false;
                        MessageBox.Show("XUID 07 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox07.Focus();
                        xuidTextBox07.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox08.Text.Length == 0)
                    {
                        xuid08Good = false;
                    }
                    else if (xuidTextBox08.Text.Length == 16)
                    {
                        xuid08Good = true;
                    }
                    else
                    {
                        xuid08Good = false;
                        MessageBox.Show("XUID 08 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox08.Focus();
                        xuidTextBox08.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox09.Text.Length == 0)
                    {
                        xuid09Good = false;
                    }
                    else if (xuidTextBox09.Text.Length == 16)
                    {
                        xuid09Good = true;
                    }
                    else
                    {
                        xuid09Good = false;
                        MessageBox.Show("XUID 09 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox09.Focus();
                        xuidTextBox09.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox10.Text.Length == 0)
                    {
                        xuid10Good = false;
                    }
                    else if (xuidTextBox10.Text.Length == 16)
                    {
                        xuid10Good = true;
                    }
                    else
                    {
                        xuid10Good = false;
                        MessageBox.Show("XUID 10 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox10.Focus();
                        xuidTextBox10.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox11.Text.Length == 0)
                    {
                        xuid11Good = false;
                    }
                    else if (xuidTextBox11.Text.Length == 16)
                    {
                        xuid11Good = true;
                    }
                    else
                    {
                        xuid11Good = false;
                        MessageBox.Show("XUID 11 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox11.Focus();
                        xuidTextBox11.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox12.Text.Length == 0)
                    {
                        xuid12Good = false;
                    }
                    else if (xuidTextBox12.Text.Length == 16)
                    {
                        xuid12Good = true;
                    }
                    else
                    {
                        xuid12Good = false;
                        MessageBox.Show("XUID 12 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox12.Focus();
                        xuidTextBox12.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox13.Text.Length == 0)
                    {
                        xuid13Good = false;
                    }
                    else if (xuidTextBox13.Text.Length == 16)
                    {
                        xuid13Good = true;
                    }
                    else
                    {
                        xuid13Good = false;
                        MessageBox.Show("XUID 13 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox13.Focus();
                        xuidTextBox13.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox14.Text.Length == 0)
                    {
                        xuid14Good = false;
                    }
                    else if (xuidTextBox14.Text.Length == 16)
                    {
                        xuid14Good = true;
                    }
                    else
                    {
                        xuid14Good = false;
                        MessageBox.Show("XUID 14 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox14.Focus();
                        xuidTextBox14.SelectAll();
                        stopError = true;
                    }
                }

                if (stopError == false)
                {
                    if (xuidTextBox15.Text.Length == 0)
                    {
                        xuid15Good = false;
                    }
                    else if (xuidTextBox15.Text.Length == 16)
                    {
                        xuid15Good = true;
                    }
                    else
                    {
                        xuid15Good = false;
                        MessageBox.Show("XUID 15 not correct length.", "Invalid XUID",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xuidTextBox15.Focus();
                        xuidTextBox15.SelectAll();
                        stopError = true;
                    }
                }

            }

            if (stopError == false &&
                xuid01Good == false &&
                xuid02Good == false &&
                xuid03Good == false &&
                xuid04Good == false &&
                xuid05Good == false &&
                xuid06Good == false &&
                xuid07Good == false &&
                xuid08Good == false &&
                xuid09Good == false &&
                xuid10Good == false &&
                xuid11Good == false &&
                xuid12Good == false &&
                xuid13Good == false &&
                xuid14Good == false &&
                xuid15Good == false)
            {
                stopError = true;
                MessageBox.Show("No XUID entered to patch.", "XUID Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xuidTextBox01.Focus();
                xuidTextBox01.SelectAll();
            }

            if (stopError == false)
            {

                try
                {
                    folderExists = System.IO.Directory.Exists(folderTextBox.Text);
                    if (folderExists == false)
                    {
                        MessageBox.Show("Folder does not exist.", "Invalid Folder",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        folderTextBox.Focus();
                        folderTextBox.SelectAll();
                        stopError = true;
                    }
                }
                catch
                {
                    folderExists = false;
                    MessageBox.Show("Folder does not exist.", "Invalid Folder",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    folderTextBox.Focus();
                    folderTextBox.SelectAll();
                    stopError = true;
                }
            }

            if (stopError == false)
            {

                string[] filePaths = Directory.GetFiles(folderTextBox.Text, "*", SearchOption.AllDirectories);

                byte[] xuid01Array = new byte[8];
                byte[] xuid02Array = new byte[8];
                byte[] xuid03Array = new byte[8];
                byte[] xuid04Array = new byte[8];
                byte[] xuid05Array = new byte[8];
                byte[] xuid06Array = new byte[8];
                byte[] xuid07Array = new byte[8];
                byte[] xuid08Array = new byte[8];
                byte[] xuid09Array = new byte[8];
                byte[] xuid10Array = new byte[8];
                byte[] xuid11Array = new byte[8];
                byte[] xuid12Array = new byte[8];
                byte[] xuid13Array = new byte[8];
                byte[] xuid14Array = new byte[8];
                byte[] xuid15Array = new byte[8];
                byte[] fillerArray = new byte[8] { 0, 0, 0, 1, 0, 0, 0, 1 };

                if (xuid01Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid01Array[i / 2] = Convert.ToByte(xuidTextBox01.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid02Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid02Array[i / 2] = Convert.ToByte(xuidTextBox02.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid03Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid03Array[i / 2] = Convert.ToByte(xuidTextBox03.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid04Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid04Array[i / 2] = Convert.ToByte(xuidTextBox04.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid05Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid05Array[i / 2] = Convert.ToByte(xuidTextBox05.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid06Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid06Array[i / 2] = Convert.ToByte(xuidTextBox06.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid07Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid07Array[i / 2] = Convert.ToByte(xuidTextBox07.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid08Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid08Array[i / 2] = Convert.ToByte(xuidTextBox08.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid09Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid09Array[i / 2] = Convert.ToByte(xuidTextBox09.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid10Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid10Array[i / 2] = Convert.ToByte(xuidTextBox10.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid11Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid11Array[i / 2] = Convert.ToByte(xuidTextBox11.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid12Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid12Array[i / 2] = Convert.ToByte(xuidTextBox12.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid13Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid13Array[i / 2] = Convert.ToByte(xuidTextBox13.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid14Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid14Array[i / 2] = Convert.ToByte(xuidTextBox14.Text.Substring(i, 2), 16);
                    }
                }

                if (xuid15Good == true)
                {
                    for (int i = 0; i < 16; i += 2)
                    {
                        xuid15Array[i / 2] = Convert.ToByte(xuidTextBox15.Text.Substring(i, 2), 16);
                    }
                }


                for (int j = 0; j < filePaths.Length; j++)
                {
                    FileStream fileStream = new FileStream(filePaths[j], FileMode.Open);

                    if (xuid01Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(572, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid01Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid01Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid02Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(588, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid02Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid02Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid03Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(604, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid03Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid03Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid04Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(620, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid04Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid04Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid05Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(636, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid05Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid05Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid06Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(652, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid06Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid06Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid07Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(668, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid07Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid07Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid08Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(684, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid08Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid08Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid09Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(700, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid09Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid09Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid10Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(716, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid10Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid10Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid11Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(732, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid11Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid11Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid12Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(748, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid12Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid12Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid13Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(764, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid13Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid13Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid14Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(780, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid14Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid14Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    if (xuid15Good == true)
                    {
                        // Set the stream position to the beginning of the file.
                        fileStream.Seek(796, SeekOrigin.Begin);

                        // Write the data to the file, byte by byte.
                        for (int i = 0; i < xuid15Array.Length; i++)
                        {
                            fileStream.WriteByte(xuid15Array[i]);
                        }
                        // Write filler data to the file, byte by byte.
                        for (int i = 0; i < fillerArray.Length; i++)
                        {
                            fileStream.WriteByte(fillerArray[i]);
                        }
                    }

                    fileStream.Close();

                    }
                    
                MessageBox.Show("All files patched!", "Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            configStreamWriter = new StreamWriter("avpatch.cfg");
            configStreamWriter.WriteLine(xuidTextBox01.Text);
            configStreamWriter.WriteLine(xuidTextBox02.Text);
            configStreamWriter.WriteLine(xuidTextBox03.Text);
            configStreamWriter.WriteLine(xuidTextBox04.Text);
            configStreamWriter.WriteLine(xuidTextBox05.Text);
            configStreamWriter.WriteLine(xuidTextBox06.Text);
            configStreamWriter.WriteLine(xuidTextBox07.Text);
            configStreamWriter.WriteLine(xuidTextBox08.Text);
            configStreamWriter.WriteLine(xuidTextBox09.Text);
            configStreamWriter.WriteLine(xuidTextBox10.Text);
            configStreamWriter.WriteLine(xuidTextBox11.Text);
            configStreamWriter.WriteLine(xuidTextBox12.Text);
            configStreamWriter.WriteLine(xuidTextBox13.Text);
            configStreamWriter.WriteLine(xuidTextBox14.Text);
            configStreamWriter.WriteLine(xuidTextBox15.Text);
            configStreamWriter.WriteLine(folderTextBox.Text);
            configStreamWriter.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            configLineCount = 0;

            try
            {
                configStreamReader = new StreamReader("avpatch.cfg");

                while (configStreamReader.Peek() != -1)
                {
                    configStreamReader.ReadLine();
                    configLineCount++;
                }

                configStreamReader.Close();

                if (configLineCount != 16)
                {
                    MessageBox.Show("Config File Invalid", "Config Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    configStreamReader = new StreamReader("avpatch.cfg");

                    xuidTextBox01.Text = (configStreamReader.ReadLine());
                    xuidTextBox02.Text = (configStreamReader.ReadLine());
                    xuidTextBox03.Text = (configStreamReader.ReadLine());
                    xuidTextBox04.Text = (configStreamReader.ReadLine());
                    xuidTextBox05.Text = (configStreamReader.ReadLine());
                    xuidTextBox06.Text = (configStreamReader.ReadLine());
                    xuidTextBox07.Text = (configStreamReader.ReadLine());
                    xuidTextBox08.Text = (configStreamReader.ReadLine());
                    xuidTextBox09.Text = (configStreamReader.ReadLine());
                    xuidTextBox10.Text = (configStreamReader.ReadLine());
                    xuidTextBox11.Text = (configStreamReader.ReadLine());
                    xuidTextBox12.Text = (configStreamReader.ReadLine());
                    xuidTextBox13.Text = (configStreamReader.ReadLine());
                    xuidTextBox14.Text = (configStreamReader.ReadLine());
                    xuidTextBox15.Text = (configStreamReader.ReadLine());
                    folderTextBox.Text = (configStreamReader.ReadLine());

                    configStreamReader.Close();

                    patchButton.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Config file does not exist.", "File not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            xuidTextBox01.Clear();
            xuidTextBox02.Clear();
            xuidTextBox03.Clear();
            xuidTextBox04.Clear();
            xuidTextBox05.Clear();
            xuidTextBox06.Clear();
            xuidTextBox07.Clear();
            xuidTextBox08.Clear();
            xuidTextBox09.Clear();
            xuidTextBox10.Clear();
            xuidTextBox11.Clear();
            xuidTextBox12.Clear();
            xuidTextBox13.Clear();
            xuidTextBox14.Clear();
            xuidTextBox15.Clear();
            folderTextBox.Clear();
            xuidTextBox01.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
