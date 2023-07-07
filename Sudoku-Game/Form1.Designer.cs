namespace Sudoku_Game
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckInput = new System.Windows.Forms.Button();
            this.ClearInput = new System.Windows.Forms.Button();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.IntermediateLevel = new System.Windows.Forms.RadioButton();
            this.AdvancedLevel = new System.Windows.Forms.RadioButton();
            this.Level = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Wins = new System.Windows.Forms.Label();
            this.Losses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 401);
            this.panel1.TabIndex = 0;
            // 
            // CheckInput
            // 
            this.CheckInput.Location = new System.Drawing.Point(425, 27);
            this.CheckInput.Name = "CheckInput";
            this.CheckInput.Size = new System.Drawing.Size(168, 49);
            this.CheckInput.TabIndex = 1;
            this.CheckInput.Text = "CheckInput";
            this.CheckInput.UseVisualStyleBackColor = true;
            this.CheckInput.Click += new System.EventHandler(this.CheckInput_Click);
            // 
            // ClearInput
            // 
            this.ClearInput.Location = new System.Drawing.Point(425, 103);
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(168, 30);
            this.ClearInput.TabIndex = 2;
            this.ClearInput.Text = "Clear Input";
            this.ClearInput.UseVisualStyleBackColor = true;
            this.ClearInput.Click += new System.EventHandler(this.ClearInput_Click);
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Location = new System.Drawing.Point(445, 221);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(67, 17);
            this.beginnerLevel.TabIndex = 3;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "Beginner";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // IntermediateLevel
            // 
            this.IntermediateLevel.AutoSize = true;
            this.IntermediateLevel.Location = new System.Drawing.Point(445, 244);
            this.IntermediateLevel.Name = "IntermediateLevel";
            this.IntermediateLevel.Size = new System.Drawing.Size(85, 17);
            this.IntermediateLevel.TabIndex = 3;
            this.IntermediateLevel.TabStop = true;
            this.IntermediateLevel.Text = "intermediate ";
            this.IntermediateLevel.UseVisualStyleBackColor = true;
            // 
            // AdvancedLevel
            // 
            this.AdvancedLevel.AutoSize = true;
            this.AdvancedLevel.Location = new System.Drawing.Point(445, 267);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(73, 17);
            this.AdvancedLevel.TabIndex = 3;
            this.AdvancedLevel.TabStop = true;
            this.AdvancedLevel.Text = "advanced";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(445, 202);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(33, 13);
            this.Level.TabIndex = 4;
            this.Level.Text = "Level";
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(425, 290);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(134, 40);
            this.NewGame.TabIndex = 5;
            this.NewGame.Text = "Start New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Location = new System.Drawing.Point(422, 400);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(67, 13);
            this.Wins.TabIndex = 6;
            this.Wins.Text = "Total Wins - ";
            // 
            // Losses
            // 
            this.Losses.AutoSize = true;
            this.Losses.Location = new System.Drawing.Point(422, 371);
            this.Losses.Name = "Losses";
            this.Losses.Size = new System.Drawing.Size(76, 13);
            this.Losses.TabIndex = 7;
            this.Losses.Text = "Total Losses - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 475);
            this.Controls.Add(this.Losses);
            this.Controls.Add(this.Wins);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.AdvancedLevel);
            this.Controls.Add(this.IntermediateLevel);
            this.Controls.Add(this.beginnerLevel);
            this.Controls.Add(this.ClearInput);
            this.Controls.Add(this.CheckInput);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckInput;
        private System.Windows.Forms.Button ClearInput;
        private System.Windows.Forms.RadioButton beginnerLevel;
        private System.Windows.Forms.RadioButton IntermediateLevel;
        private System.Windows.Forms.RadioButton AdvancedLevel;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label Losses;
    }
}

