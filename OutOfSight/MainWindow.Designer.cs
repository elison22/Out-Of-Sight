namespace OutOfSight {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.Card5 = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.Die1 = new System.Windows.Forms.PictureBox();
            this.Die2 = new System.Windows.Forms.PictureBox();
            this.Die3 = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_Preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help_Rules = new System.Windows.Forms.ToolStripMenuItem();
            this.WipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die3)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card1.Location = new System.Drawing.Point(28, 42);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(98, 149);
            this.Card1.TabIndex = 0;
            this.Card1.Text = "12";
            this.Card1.UseVisualStyleBackColor = false;
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.Color.Yellow;
            this.Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card2.Location = new System.Drawing.Point(128, 42);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(98, 149);
            this.Card2.TabIndex = 1;
            this.Card2.Text = "5";
            this.Card2.UseVisualStyleBackColor = false;
            // 
            // Card3
            // 
            this.Card3.BackColor = System.Drawing.Color.Violet;
            this.Card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card3.Location = new System.Drawing.Point(228, 42);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(98, 149);
            this.Card3.TabIndex = 2;
            this.Card3.Text = "2";
            this.Card3.UseVisualStyleBackColor = false;
            // 
            // Card4
            // 
            this.Card4.BackColor = System.Drawing.Color.SpringGreen;
            this.Card4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card4.Location = new System.Drawing.Point(328, 42);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(98, 149);
            this.Card4.TabIndex = 3;
            this.Card4.Text = "8";
            this.Card4.UseVisualStyleBackColor = false;
            // 
            // Card5
            // 
            this.Card5.BackColor = System.Drawing.Color.Red;
            this.Card5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card5.Location = new System.Drawing.Point(428, 42);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(98, 149);
            this.Card5.TabIndex = 4;
            this.Card5.Text = "10";
            this.Card5.UseVisualStyleBackColor = false;
            // 
            // FlipButton
            // 
            this.FlipButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlipButton.FlatAppearance.BorderSize = 3;
            this.FlipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipButton.Location = new System.Drawing.Point(28, 211);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(94, 39);
            this.FlipButton.TabIndex = 5;
            this.FlipButton.Text = "FLIP";
            this.FlipButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton.Location = new System.Drawing.Point(396, 211);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(130, 84);
            this.AcceptButton.TabIndex = 6;
            this.AcceptButton.Text = "Start Game";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Die1
            // 
            this.Die1.Image = ((System.Drawing.Image)(resources.GetObject("Die1.Image")));
            this.Die1.InitialImage = null;
            this.Die1.Location = new System.Drawing.Point(141, 216);
            this.Die1.Name = "Die1";
            this.Die1.Size = new System.Drawing.Size(75, 75);
            this.Die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Die1.TabIndex = 12;
            this.Die1.TabStop = false;
            // 
            // Die2
            // 
            this.Die2.Image = ((System.Drawing.Image)(resources.GetObject("Die2.Image")));
            this.Die2.InitialImage = null;
            this.Die2.Location = new System.Drawing.Point(222, 216);
            this.Die2.Name = "Die2";
            this.Die2.Size = new System.Drawing.Size(75, 75);
            this.Die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Die2.TabIndex = 13;
            this.Die2.TabStop = false;
            // 
            // Die3
            // 
            this.Die3.Image = ((System.Drawing.Image)(resources.GetObject("Die3.Image")));
            this.Die3.InitialImage = null;
            this.Die3.Location = new System.Drawing.Point(303, 216);
            this.Die3.Name = "Die3";
            this.Die3.Size = new System.Drawing.Size(75, 75);
            this.Die3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Die3.TabIndex = 14;
            this.Die3.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(557, 24);
            this.MainMenu.TabIndex = 15;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File_NewGame,
            this.MenuItem_File_Preferences,
            this.MenuItem_File_Exit});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(37, 20);
            this.MenuItem_File.Text = "File";
            // 
            // MenuItem_File_NewGame
            // 
            this.MenuItem_File_NewGame.Name = "MenuItem_File_NewGame";
            this.MenuItem_File_NewGame.Size = new System.Drawing.Size(135, 22);
            this.MenuItem_File_NewGame.Text = "New Game";
            this.MenuItem_File_NewGame.Click += new System.EventHandler(this.MenuItem_File_NewGame_Click);
            // 
            // MenuItem_File_Preferences
            // 
            this.MenuItem_File_Preferences.Name = "MenuItem_File_Preferences";
            this.MenuItem_File_Preferences.Size = new System.Drawing.Size(135, 22);
            this.MenuItem_File_Preferences.Text = "Preferences";
            // 
            // MenuItem_File_Exit
            // 
            this.MenuItem_File_Exit.Name = "MenuItem_File_Exit";
            this.MenuItem_File_Exit.Size = new System.Drawing.Size(135, 22);
            this.MenuItem_File_Exit.Text = "Exit";
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Help_Rules});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuItem_Help.Text = "Help";
            // 
            // MenuItem_Help_Rules
            // 
            this.MenuItem_Help_Rules.Name = "MenuItem_Help_Rules";
            this.MenuItem_Help_Rules.Size = new System.Drawing.Size(102, 22);
            this.MenuItem_Help_Rules.Text = "Rules";
            // 
            // WipeButton
            // 
            this.WipeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WipeButton.FlatAppearance.BorderSize = 3;
            this.WipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WipeButton.Location = new System.Drawing.Point(28, 256);
            this.WipeButton.Name = "WipeButton";
            this.WipeButton.Size = new System.Drawing.Size(94, 39);
            this.WipeButton.TabIndex = 16;
            this.WipeButton.Text = "WIPE";
            this.WipeButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 398);
            this.Controls.Add(this.WipeButton);
            this.Controls.Add(this.Die3);
            this.Controls.Add(this.Die2);
            this.Controls.Add(this.Die1);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Out Of Sight";
            ((System.ComponentModel.ISupportInitialize)(this.Die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Die3)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Card5;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.PictureBox Die1;
        private System.Windows.Forms.PictureBox Die2;
        private System.Windows.Forms.PictureBox Die3;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_NewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_Preferences;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help_Rules;
        private System.Windows.Forms.Button WipeButton;
    }
}

