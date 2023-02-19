namespace Minesweeper
{
    partial class GameInfo
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
            this.GameInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BoardColCombo = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Mines = new System.Windows.Forms.Label();
            this.MinesCombo = new System.Windows.Forms.ComboBox();
            this.BoardSize = new System.Windows.Forms.Label();
            this.BoardRowCombo = new System.Windows.Forms.ComboBox();
            this.GameInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameInfoPanel
            // 
            this.GameInfoPanel.Controls.Add(this.label1);
            this.GameInfoPanel.Controls.Add(this.BoardColCombo);
            this.GameInfoPanel.Controls.Add(this.SaveBtn);
            this.GameInfoPanel.Controls.Add(this.Mines);
            this.GameInfoPanel.Controls.Add(this.MinesCombo);
            this.GameInfoPanel.Controls.Add(this.BoardSize);
            this.GameInfoPanel.Controls.Add(this.BoardRowCombo);
            this.GameInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.GameInfoPanel.Name = "GameInfoPanel";
            this.GameInfoPanel.Size = new System.Drawing.Size(235, 154);
            this.GameInfoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // BoardColCombo
            // 
            this.BoardColCombo.FormattingEnabled = true;
            this.BoardColCombo.Location = new System.Drawing.Point(169, 17);
            this.BoardColCombo.Name = "BoardColCombo";
            this.BoardColCombo.Size = new System.Drawing.Size(48, 23);
            this.BoardColCombo.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(37, 100);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(160, 42);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Mines
            // 
            this.Mines.AutoSize = true;
            this.Mines.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mines.Location = new System.Drawing.Point(12, 68);
            this.Mines.Name = "Mines";
            this.Mines.Size = new System.Drawing.Size(44, 17);
            this.Mines.TabIndex = 3;
            this.Mines.Text = "Mines";
            // 
            // MinesCombo
            // 
            this.MinesCombo.FormattingEnabled = true;
            this.MinesCombo.Location = new System.Drawing.Point(169, 62);
            this.MinesCombo.Name = "MinesCombo";
            this.MinesCombo.Size = new System.Drawing.Size(48, 23);
            this.MinesCombo.TabIndex = 2;
            // 
            // BoardSize
            // 
            this.BoardSize.AutoSize = true;
            this.BoardSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BoardSize.Location = new System.Drawing.Point(12, 18);
            this.BoardSize.Name = "BoardSize";
            this.BoardSize.Size = new System.Drawing.Size(71, 17);
            this.BoardSize.TabIndex = 1;
            this.BoardSize.Text = "Board Size";
            // 
            // BoardRowCombo
            // 
            this.BoardRowCombo.FormattingEnabled = true;
            this.BoardRowCombo.Location = new System.Drawing.Point(98, 17);
            this.BoardRowCombo.Name = "BoardRowCombo";
            this.BoardRowCombo.Size = new System.Drawing.Size(45, 23);
            this.BoardRowCombo.TabIndex = 0;
            // 
            // GameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 154);
            this.Controls.Add(this.GameInfoPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameInfo";
            this.GameInfoPanel.ResumeLayout(false);
            this.GameInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel GameInfoPanel;
        private Label Mines;
        private Label BoardSize;
        private Button SaveBtn;
        private ComboBox MinesCombo;
        private ComboBox BoardRowCombo;
        private ComboBox BoardColCombo;
        private Label label1;
    }
}