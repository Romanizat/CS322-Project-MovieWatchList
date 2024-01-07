namespace CS322_PZ_MarkoJosifovic4494.Forms
{
    partial class MovieDetailsForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            trackBar1 = new TrackBar();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(625, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 500);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(92, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 91);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Summary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 329);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "IMDb URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 386);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 4;
            label4.Text = "All Users Rating:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 47);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 5;
            label5.Text = "Title:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(36, 109);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(458, 183);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(122, 329);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(134, 375);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // button1
            // 
            button1.Location = new Point(36, 506);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 9;
            button1.Text = "Add to Watched";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(429, 506);
            button2.Name = "button2";
            button2.Size = new Size(155, 23);
            button2.TabIndex = 10;
            button2.Text = "Add To Watch List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(36, 455);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 11;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 424);
            label7.Name = "label7";
            label7.Size = new Size(138, 15);
            label7.TabIndex = 12;
            label7.Text = "Rate and add to watched";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(204, 455);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 13;
            label8.Text = "Rate this movie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(694, 563);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 16;
            label9.Text = "Saw a mistake?";
            // 
            // button3
            // 
            button3.Location = new Point(799, 558);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Correct it";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 611);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MovieDetailsForm";
            Text = "MovieDetailsForm";
            Load += MovieDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel1;
        private Label label6;
        private Button button1;
        private Button button2;
        private TrackBar trackBar1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button3;
    }
}