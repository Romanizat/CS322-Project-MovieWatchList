namespace CS322_PZ_MarkoJosifovic4494
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            registerToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            loginButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(507, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 102);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 94);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(231, 162);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 239);
            Controls.Add(loginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Moview Watch List | Login";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registerToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loginButton;
    }
}
