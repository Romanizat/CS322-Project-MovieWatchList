namespace CS322_PZ_MarkoJosifovic4494.Forms
{
    partial class CreateMovieForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(208, 302);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "Save Movie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(53, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(208, 56);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(296, 184);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "Movie Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 38);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Summary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 113);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "IMDB URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 189);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Image URL";
            // 
            // CreateMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 377);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "CreateMovieForm";
            Text = "CreateMovieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}