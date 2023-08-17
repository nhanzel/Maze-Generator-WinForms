namespace Maze_Generator
{
    partial class MazeGenerator
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
            this.Panel = new System.Windows.Forms.Panel();
            this.InitialButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ColorTB1 = new System.Windows.Forms.ComboBox();
            this.ColorL1 = new System.Windows.Forms.Label();
            this.ShowFrontGB = new System.Windows.Forms.GroupBox();
            this.NoRB = new System.Windows.Forms.RadioButton();
            this.YesRB = new System.Windows.Forms.RadioButton();
            this.SizeTB = new System.Windows.Forms.TextBox();
            this.SpeedTB = new System.Windows.Forms.TextBox();
            this.SizeL = new System.Windows.Forms.Label();
            this.SpeedL = new System.Windows.Forms.Label();
            this.ColorL2 = new System.Windows.Forms.Label();
            this.ColorTB2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowFrontGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(401, 401);
            this.Panel.TabIndex = 0;
            // 
            // InitialButton
            // 
            this.InitialButton.Location = new System.Drawing.Point(425, 12);
            this.InitialButton.Name = "InitialButton";
            this.InitialButton.Size = new System.Drawing.Size(177, 23);
            this.InitialButton.TabIndex = 1;
            this.InitialButton.Text = "Draw Map";
            this.InitialButton.UseVisualStyleBackColor = true;
            this.InitialButton.Click += new System.EventHandler(this.InitialButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(425, 41);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(177, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Create Maze";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ColorTB1
            // 
            this.ColorTB1.FormattingEnabled = true;
            this.ColorTB1.Items.AddRange(new object[] {
            "Light Yellow",
            "Yellow",
            "Dark Yellow",
            "Light Orange",
            "Orange",
            "Dark Orange",
            "Light Red",
            "Red",
            "Dark Red",
            "Light Green",
            "Green",
            "Dark Green",
            "Light Blue",
            "Blue",
            "Dark Blue",
            "Light Purple",
            "Purple",
            "Dark Purple"});
            this.ColorTB1.Location = new System.Drawing.Point(425, 105);
            this.ColorTB1.Name = "ColorTB1";
            this.ColorTB1.Size = new System.Drawing.Size(177, 21);
            this.ColorTB1.TabIndex = 3;
            // 
            // ColorL1
            // 
            this.ColorL1.AutoSize = true;
            this.ColorL1.Location = new System.Drawing.Point(425, 80);
            this.ColorL1.Name = "ColorL1";
            this.ColorL1.Size = new System.Drawing.Size(60, 13);
            this.ColorL1.TabIndex = 4;
            this.ColorL1.Text = "Main Color:";
            // 
            // ShowFrontGB
            // 
            this.ShowFrontGB.Controls.Add(this.NoRB);
            this.ShowFrontGB.Controls.Add(this.YesRB);
            this.ShowFrontGB.Location = new System.Drawing.Point(425, 207);
            this.ShowFrontGB.Name = "ShowFrontGB";
            this.ShowFrontGB.Size = new System.Drawing.Size(177, 59);
            this.ShowFrontGB.TabIndex = 5;
            this.ShowFrontGB.TabStop = false;
            this.ShowFrontGB.Text = "Show Front";
            // 
            // NoRB
            // 
            this.NoRB.AutoSize = true;
            this.NoRB.Location = new System.Drawing.Point(104, 30);
            this.NoRB.Name = "NoRB";
            this.NoRB.Size = new System.Drawing.Size(39, 17);
            this.NoRB.TabIndex = 1;
            this.NoRB.TabStop = true;
            this.NoRB.Text = "No";
            this.NoRB.UseVisualStyleBackColor = true;
            // 
            // YesRB
            // 
            this.YesRB.AutoSize = true;
            this.YesRB.Location = new System.Drawing.Point(27, 30);
            this.YesRB.Name = "YesRB";
            this.YesRB.Size = new System.Drawing.Size(43, 17);
            this.YesRB.TabIndex = 0;
            this.YesRB.TabStop = true;
            this.YesRB.Text = "Yes";
            this.YesRB.UseVisualStyleBackColor = true;
            // 
            // SizeTB
            // 
            this.SizeTB.Location = new System.Drawing.Point(502, 294);
            this.SizeTB.Name = "SizeTB";
            this.SizeTB.Size = new System.Drawing.Size(100, 20);
            this.SizeTB.TabIndex = 6;
            // 
            // SpeedTB
            // 
            this.SpeedTB.Location = new System.Drawing.Point(502, 356);
            this.SpeedTB.Name = "SpeedTB";
            this.SpeedTB.Size = new System.Drawing.Size(100, 20);
            this.SpeedTB.TabIndex = 7;
            // 
            // SizeL
            // 
            this.SizeL.AutoSize = true;
            this.SizeL.Location = new System.Drawing.Point(425, 297);
            this.SizeL.Name = "SizeL";
            this.SizeL.Size = new System.Drawing.Size(30, 13);
            this.SizeL.TabIndex = 8;
            this.SizeL.Text = "Size:";
            // 
            // SpeedL
            // 
            this.SpeedL.AutoSize = true;
            this.SpeedL.Location = new System.Drawing.Point(425, 359);
            this.SpeedL.Name = "SpeedL";
            this.SpeedL.Size = new System.Drawing.Size(41, 13);
            this.SpeedL.TabIndex = 9;
            this.SpeedL.Text = "Speed:";
            // 
            // ColorL2
            // 
            this.ColorL2.AutoSize = true;
            this.ColorL2.Location = new System.Drawing.Point(425, 141);
            this.ColorL2.Name = "ColorL2";
            this.ColorL2.Size = new System.Drawing.Size(61, 13);
            this.ColorL2.TabIndex = 10;
            this.ColorL2.Text = "Front Color:";
            // 
            // ColorTB2
            // 
            this.ColorTB2.FormattingEnabled = true;
            this.ColorTB2.Items.AddRange(new object[] {
            "Light Yellow",
            "Yellow",
            "Dark Yellow",
            "Light Orange",
            "Orange",
            "Dark Orange",
            "Light Red",
            "Red",
            "Dark Red",
            "Light Green",
            "Green",
            "Dark Green",
            "Light Blue",
            "Blue",
            "Dark Blue",
            "Light Purple",
            "Purple",
            "Dark Purple"});
            this.ColorTB2.Location = new System.Drawing.Point(425, 169);
            this.ColorTB2.Name = "ColorTB2";
            this.ColorTB2.Size = new System.Drawing.Size(177, 21);
            this.ColorTB2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*Speed up to 5000";
            // 
            // MazeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(614, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorTB2);
            this.Controls.Add(this.ColorL2);
            this.Controls.Add(this.SpeedL);
            this.Controls.Add(this.SizeL);
            this.Controls.Add(this.SpeedTB);
            this.Controls.Add(this.SizeTB);
            this.Controls.Add(this.ShowFrontGB);
            this.Controls.Add(this.ColorL1);
            this.Controls.Add(this.ColorTB1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InitialButton);
            this.Controls.Add(this.Panel);
            this.Name = "MazeGenerator";
            this.Text = "Maze Generator";
            this.ShowFrontGB.ResumeLayout(false);
            this.ShowFrontGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button InitialButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ComboBox ColorTB1;
        private System.Windows.Forms.Label ColorL1;
        private System.Windows.Forms.GroupBox ShowFrontGB;
        private System.Windows.Forms.RadioButton NoRB;
        private System.Windows.Forms.RadioButton YesRB;
        private System.Windows.Forms.TextBox SizeTB;
        private System.Windows.Forms.TextBox SpeedTB;
        private System.Windows.Forms.Label SizeL;
        private System.Windows.Forms.Label SpeedL;
        private System.Windows.Forms.Label ColorL2;
        private System.Windows.Forms.ComboBox ColorTB2;
        private System.Windows.Forms.Label label1;
    }
}

