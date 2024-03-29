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
            logOutToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Summary = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(817, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(62, 20);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(25, 639);
            button1.Name = "button1";
            button1.Size = new Size(184, 23);
            button1.TabIndex = 2;
            button1.Text = "View Watched Movies";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(606, 639);
            button2.Name = "button2";
            button2.Size = new Size(184, 23);
            button2.TabIndex = 3;
            button2.Text = "View Watch List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(25, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Search Movies in DB...";
            textBox1.Enter += textBox1_Enter_1;
            textBox1.Leave += textBox1_Leave_1;
            // 
            // button3
            // 
            button3.Location = new Point(410, 38);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 6;
            button3.Text = "Search All Movies";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Summary, Rating, Details });
            dataGridView1.Location = new Point(25, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(765, 512);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 200;
            // 
            // Summary
            // 
            Summary.HeaderText = "Summary";
            Summary.Name = "Summary";
            Summary.ReadOnly = true;
            Summary.Width = 320;
            // 
            // Rating
            // 
            Rating.HeaderText = "Rating";
            Rating.Name = "Rating";
            Rating.ReadOnly = true;
            // 
            // Details
            // 
            Details.HeaderText = "Details";
            Details.Name = "Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 24);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 8;
            label1.Text = "The movie you're looking for is not present?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(655, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Add it here!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 671);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Movie Watch List";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Summary;
        private DataGridViewTextBoxColumn Rating;
        private DataGridViewButtonColumn Details;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}