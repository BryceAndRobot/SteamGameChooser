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

namespace SteamGameChooser
{
    public partial class SteamGameChooserForm : Form
    {
        private static readonly string GAME_SYMBOL = "<div class=\"gameListRowItemName ellipsis \">";
        private static readonly string END_SYMBOL = "</div>";

        private static readonly string ERROR_BAD_FILE = "Could not read selected file.";

        private List<string> GameNames = new List<string>();
        private static Random RNG = new Random((int)DateTime.Now.Ticks);

        public SteamGameChooserForm()
        {
            InitializeComponent();
        }

        private void SelectGamesListButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    if (string.IsNullOrWhiteSpace(fileContent))
                    {
                        GamesSourceLabel.Text = ERROR_BAD_FILE;
                        return;
                    }

                    GamesSourceLabel.Text = filePath;
                    GameNames.Clear();

                    // Process file contents
                    var symbols = new string[] { GAME_SYMBOL };
                    var chunks = fileContent.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                    if (chunks.Length > 1)
                    {
                        for (int i = 1; i < chunks.Length; ++i)
                        {
                            string gameName = chunks[i].Substring(0, chunks[i].IndexOf(END_SYMBOL));
                            GameNames.Add(gameName);
                        }
                    }

                    WhatShouldIPlayButton.Enabled = GameNames.Count > 0;
                }
            }
        }

        private void WhatShouldIPlayButton_Click(object sender, EventArgs e)
        {
            int roll = RNG.Next(GameNames.Count);
            GameLabel.Text = GameNames[roll];
        }
    }
}
