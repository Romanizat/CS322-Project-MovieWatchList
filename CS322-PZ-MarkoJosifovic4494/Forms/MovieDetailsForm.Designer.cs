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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(510, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 359);
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
            label3.Location = new Point(36, 314);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "IMDb URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 371);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Rating:";
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
            linkLabel1.Location = new Point(122, 314);
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
            label6.Location = new Point(122, 360);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}