namespace CS322_PZ_MarkoJosifovic4494.Forms
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            searchToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { searchToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(648, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "Search";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(62, 20);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(158, 104);
            label1.Name = "label1";
            label1.Size = new Size(331, 89);
            label1.TabIndex = 1;
            label1.Text = "Welcome!";
            // 
            // button1
            // 
            button1.Location = new Point(50, 305);
            button1.Name = "button1";
            button1.Size = new Size(184, 23);
            button1.TabIndex = 2;
            button1.Text = "View Watched Movies";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(412, 305);
            button2.Name = "button2";
            button2.Size = new Size(184, 23);
            button2.TabIndex = 3;
            button2.Text = "View Watch List";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 465);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Movie Watch List";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}