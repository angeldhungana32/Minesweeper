namespace Minesweeper
{
    partial class Minesweeper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minesweeper));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.New_Game = new System.Windows.Forms.ToolStripTextBox();
            this.Exit_Game = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripTextBox();
            this.minesweeperPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.NumOfMines = new System.Windows.Forms.Label();
            this.ResetPanel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(684, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_Game,
            this.Exit_Game});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // New_Game
            // 
            this.New_Game.Name = "New_Game";
            this.New_Game.Size = new System.Drawing.Size(100, 23);
            this.New_Game.Text = "New";
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // Exit_Game
            // 
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(100, 23);
            this.Exit_Game.Text = "Exit";
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem2.Text = "Game";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(100, 23);
            this.Help.Text = "Help";
            this.Help.ToolTipText = "Help";
            // 
            // minesweeperPanel
            // 
            this.minesweeperPanel.AutoSize = true;
            this.minesweeperPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minesweeperPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minesweeperPanel.Location = new System.Drawing.Point(0, 24);
            this.minesweeperPanel.Name = "minesweeperPanel";
            this.minesweeperPanel.Size = new System.Drawing.Size(0, 0);
            this.minesweeperPanel.TabIndex = 1;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GamePanel.Controls.Add(this.NumOfMines);
            this.GamePanel.Controls.Add(this.ResetPanel);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GamePanel.Location = new System.Drawing.Point(0, 24);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(684, 43);
            this.GamePanel.TabIndex = 2;
            // 
            // NumOfMines
            // 
            this.NumOfMines.AutoSize = true;
            this.NumOfMines.BackColor = System.Drawing.Color.Transparent;
            this.NumOfMines.Dock = System.Windows.Forms.DockStyle.Left;
            this.NumOfMines.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumOfMines.ForeColor = System.Drawing.Color.Maroon;
            this.NumOfMines.Location = new System.Drawing.Point(0, 0);
            this.NumOfMines.Name = "NumOfMines";
            this.NumOfMines.Size = new System.Drawing.Size(93, 42);
            this.NumOfMines.TabIndex = 1;
            this.NumOfMines.Text = "000";
            // 
            // ResetPanel
            // 
            this.ResetPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResetPanel.Location = new System.Drawing.Point(623, 0);
            this.ResetPanel.Name = "ResetPanel";
            this.ResetPanel.Size = new System.Drawing.Size(61, 43);
            this.ResetPanel.TabIndex = 0;
            this.ResetPanel.UseVisualStyleBackColor = true;
            this.ResetPanel.Click += new System.EventHandler(this.ResetPanel_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.minesweeperPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox New_Game;
        private ToolStripTextBox Exit_Game;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripTextBox Help;
        private Panel minesweeperPanel;
        private Panel GamePanel;
        private System.Windows.Forms.Timer timer1;
        private Label NumOfMines;
        private Button ResetPanel;
    }
}