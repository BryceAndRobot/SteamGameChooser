
namespace SteamGameChooser
{
    partial class SteamGameChooserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamGameChooserForm));
            this.SelectGamesListButton = new System.Windows.Forms.Button();
            this.GamesSourceLabel = new System.Windows.Forms.Label();
            this.WhatShouldIPlayButton = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.Label();
            this.InstructionsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectGamesListButton
            // 
            this.SelectGamesListButton.Location = new System.Drawing.Point(12, 347);
            this.SelectGamesListButton.Name = "SelectGamesListButton";
            this.SelectGamesListButton.Size = new System.Drawing.Size(201, 45);
            this.SelectGamesListButton.TabIndex = 0;
            this.SelectGamesListButton.Text = "Select Games List";
            this.SelectGamesListButton.UseVisualStyleBackColor = true;
            this.SelectGamesListButton.Click += new System.EventHandler(this.SelectGamesListButton_Click);
            // 
            // GamesSourceLabel
            // 
            this.GamesSourceLabel.AutoEllipsis = true;
            this.GamesSourceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GamesSourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GamesSourceLabel.Location = new System.Drawing.Point(219, 347);
            this.GamesSourceLabel.Name = "GamesSourceLabel";
            this.GamesSourceLabel.Size = new System.Drawing.Size(721, 45);
            this.GamesSourceLabel.TabIndex = 2;
            this.GamesSourceLabel.Text = "No Games List Selected";
            this.GamesSourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WhatShouldIPlayButton
            // 
            this.WhatShouldIPlayButton.Enabled = false;
            this.WhatShouldIPlayButton.Location = new System.Drawing.Point(12, 398);
            this.WhatShouldIPlayButton.Name = "WhatShouldIPlayButton";
            this.WhatShouldIPlayButton.Size = new System.Drawing.Size(928, 55);
            this.WhatShouldIPlayButton.TabIndex = 3;
            this.WhatShouldIPlayButton.Text = "What Should I Play?";
            this.WhatShouldIPlayButton.UseVisualStyleBackColor = true;
            this.WhatShouldIPlayButton.Click += new System.EventHandler(this.WhatShouldIPlayButton_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.Location = new System.Drawing.Point(12, 460);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(928, 204);
            this.GameLabel.TabIndex = 4;
            this.GameLabel.Text = "...";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionsTextBox
            // 
            this.InstructionsTextBox.Location = new System.Drawing.Point(12, 12);
            this.InstructionsTextBox.Multiline = true;
            this.InstructionsTextBox.Name = "InstructionsTextBox";
            this.InstructionsTextBox.ReadOnly = true;
            this.InstructionsTextBox.Size = new System.Drawing.Size(928, 284);
            this.InstructionsTextBox.TabIndex = 5;
            this.InstructionsTextBox.Text = resources.GetString("InstructionsTextBox.Text");
            // 
            // SteamGameChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 673);
            this.Controls.Add(this.InstructionsTextBox);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.WhatShouldIPlayButton);
            this.Controls.Add(this.GamesSourceLabel);
            this.Controls.Add(this.SelectGamesListButton);
            this.Name = "SteamGameChooserForm";
            this.Text = "Steam Game Chooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectGamesListButton;
        private System.Windows.Forms.Label GamesSourceLabel;
        private System.Windows.Forms.Button WhatShouldIPlayButton;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.TextBox InstructionsTextBox;
    }
}

