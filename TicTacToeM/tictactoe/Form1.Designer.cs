namespace tictactoe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A5 = new System.Windows.Forms.Button();
            this.A6 = new System.Windows.Forms.Button();
            this.A7 = new System.Windows.Forms.Button();
            this.A8 = new System.Windows.Forms.Button();
            this.A9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.X_Win_Count = new System.Windows.Forms.Label();
            this.O_Win_Count = new System.Windows.Forms.Label();
            this.Remis_Count = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.setPlayerDefoultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(339, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.setPlayerDefoultToolStripMenuItem,
            this.resetWinCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetWinCountToolStripMenuItem
            // 
            this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
            this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(45, 48);
            this.A1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(125, 48);
            this.A2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(207, 48);
            this.A3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A4
            // 
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A4.Location = new System.Drawing.Point(45, 129);
            this.A4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(75, 75);
            this.A4.TabIndex = 4;
            this.A4.UseVisualStyleBackColor = true;
            this.A4.Click += new System.EventHandler(this.button_click);
            this.A4.MouseEnter += new System.EventHandler(this.button_enter);
            this.A4.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A5
            // 
            this.A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A5.Location = new System.Drawing.Point(125, 129);
            this.A5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(75, 75);
            this.A5.TabIndex = 5;
            this.A5.UseVisualStyleBackColor = true;
            this.A5.Click += new System.EventHandler(this.button_click);
            this.A5.MouseEnter += new System.EventHandler(this.button_enter);
            this.A5.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A6
            // 
            this.A6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A6.Location = new System.Drawing.Point(207, 129);
            this.A6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(75, 75);
            this.A6.TabIndex = 6;
            this.A6.UseVisualStyleBackColor = true;
            this.A6.Click += new System.EventHandler(this.button_click);
            this.A6.MouseEnter += new System.EventHandler(this.button_enter);
            this.A6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_leave);
            // 
            // A7
            // 
            this.A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A7.Location = new System.Drawing.Point(45, 210);
            this.A7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(75, 75);
            this.A7.TabIndex = 7;
            this.A7.UseVisualStyleBackColor = true;
            this.A7.Click += new System.EventHandler(this.button_click);
            this.A7.MouseEnter += new System.EventHandler(this.button_enter);
            this.A7.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A8
            // 
            this.A8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A8.Location = new System.Drawing.Point(125, 210);
            this.A8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(75, 75);
            this.A8.TabIndex = 8;
            this.A8.UseVisualStyleBackColor = true;
            this.A8.Click += new System.EventHandler(this.button_click);
            this.A8.MouseEnter += new System.EventHandler(this.button_enter);
            this.A8.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A9
            // 
            this.A9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A9.Location = new System.Drawing.Point(207, 210);
            this.A9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(75, 75);
            this.A9.TabIndex = 9;
            this.A9.UseVisualStyleBackColor = true;
            this.A9.Click += new System.EventHandler(this.button_click);
            this.A9.MouseEnter += new System.EventHandler(this.button_enter);
            this.A9.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(123, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Remis Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // X_Win_Count
            // 
            this.X_Win_Count.AutoSize = true;
            this.X_Win_Count.Location = new System.Drawing.Point(47, 337);
            this.X_Win_Count.Name = "X_Win_Count";
            this.X_Win_Count.Size = new System.Drawing.Size(16, 17);
            this.X_Win_Count.TabIndex = 13;
            this.X_Win_Count.Text = "0";
            this.X_Win_Count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // O_Win_Count
            // 
            this.O_Win_Count.AutoSize = true;
            this.O_Win_Count.Location = new System.Drawing.Point(265, 337);
            this.O_Win_Count.Name = "O_Win_Count";
            this.O_Win_Count.Size = new System.Drawing.Size(16, 17);
            this.O_Win_Count.TabIndex = 14;
            this.O_Win_Count.Text = "0";
            this.O_Win_Count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Remis_Count
            // 
            this.Remis_Count.AutoSize = true;
            this.Remis_Count.Location = new System.Drawing.Point(157, 337);
            this.Remis_Count.Name = "Remis_Count";
            this.Remis_Count.Size = new System.Drawing.Size(16, 17);
            this.Remis_Count.TabIndex = 15;
            this.Remis_Count.Text = "0";
            this.Remis_Count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // P1
            // 
            this.P1.Location = new System.Drawing.Point(16, 304);
            this.P1.Margin = new System.Windows.Forms.Padding(4);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(104, 22);
            this.P1.TabIndex = 16;
            this.P1.Text = "Player 1";
            this.P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P2
            // 
            this.P2.Location = new System.Drawing.Point(233, 304);
            this.P2.Margin = new System.Windows.Forms.Padding(4);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(104, 22);
            this.P2.TabIndex = 17;
            this.P2.Text = "Player 2";
            this.P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P2.TextChanged += new System.EventHandler(this.P2_TextChanged);
            // 
            // setPlayerDefoultToolStripMenuItem
            // 
            this.setPlayerDefoultToolStripMenuItem.Name = "setPlayerDefoultToolStripMenuItem";
            this.setPlayerDefoultToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.setPlayerDefoultToolStripMenuItem.Text = "Set Player Defoult";
            this.setPlayerDefoultToolStripMenuItem.Click += new System.EventHandler(this.setPlayerDefoultToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 363);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Remis_Count);
            this.Controls.Add(this.O_Win_Count);
            this.Controls.Add(this.X_Win_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A4;
        private System.Windows.Forms.Button A5;
        private System.Windows.Forms.Button A6;
        private System.Windows.Forms.Button A7;
        private System.Windows.Forms.Button A8;
        private System.Windows.Forms.Button A9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label X_Win_Count;
        private System.Windows.Forms.Label O_Win_Count;
        private System.Windows.Forms.Label Remis_Count;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.ToolStripMenuItem setPlayerDefoultToolStripMenuItem;
    }
}

