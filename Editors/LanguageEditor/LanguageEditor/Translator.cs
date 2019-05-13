using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageEditor
{
    public partial class Translator : Form
    {
        private string folderLocation = "";
        private Dictionary<string, string> languageFiles;
        private Dictionary<string, string> englishKeys;
        private Dictionary<string, string> currentKeys;

        public Translator()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            windowContent_panel.Visible = false;
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Developer dev = new Developer())
            {
                dev.ShowDialog();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = folder_fbd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                folderLocation = folder_fbd.SelectedPath;
                bool validLocation = !folderLocation.Equals("");

                saveToolStripMenuItem.Enabled = validLocation;
                windowContent_panel.Visible = validLocation;

                workingDirectory_te.Text = folderLocation;
                if (validLocation)
                {
                    languageFiles = new Dictionary<string, string>();
                    foreach (string file in Directory.EnumerateFiles(folderLocation, "*.txt"))
                    {
                        string[] substring = file.Split('\\');
                        string filename = substring[substring.Length - 1];
                        if (filename.Equals("english.txt"))
                        {
                            englishKeys = new Dictionary<string, string>();

                            string[] rows = File.ReadAllText(file).Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                            foreach (string line in rows)
                            {
                                if (line.Contains("<SPACE>"))
                                {
                                    string[] lineElems = line.Split(new[] { " <SPACE> " }, System.StringSplitOptions.None);
                                    englishKeys.Add(lineElems[0], lineElems[1]);
                                    keyList_lb.Items.Add(lineElems[0]);
                                }
                            }
                        }
                        else
                        {
                            languageFiles.Add(filename, File.ReadAllText(file));
                        }
                    }
                }

                languageBox_cb.Items.Clear();
                languageBox_cb.Items.AddRange(languageFiles.Keys.ToArray());


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void languageBox_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyList_lb.Items.Clear();
            currentKeys = new Dictionary<string, string>();

            string[] rows = languageFiles[languageBox_cb.SelectedItem as string].Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in rows)
            {
                if (line.Contains("<SPACE>"))
                {
                    string[] lineElems = line.Split(new[] { " <SPACE> " }, System.StringSplitOptions.None);
                    currentKeys.Add(lineElems[0], lineElems[1]);
                    keyList_lb.Items.Add(lineElems[0]);
                }
            }
        }

        private void keyList_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(languageBox_cb.Text != null && !languageBox_cb.Text.Equals(""))
            {
                english_tb.Text = englishKeys[keyList_lb.SelectedItem as string];
                languageKeyText_tb.Text = currentKeys[keyList_lb.SelectedItem as string];
            }
        }

        private void languageKeyText_tb_TextChanged(object sender, EventArgs e)
        {
            currentKeys[keyList_lb.SelectedItem as string] = languageKeyText_tb.Text;
        }
    }
}
