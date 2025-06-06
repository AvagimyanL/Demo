namespace TemplateApp
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
            button1 = new Button();
            Login1 = new TextBox();
            Password1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(241, 264);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 0;
            button1.Text = "Авторизация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login1
            // 
            Login1.Location = new Point(227, 153);
            Login1.Name = "Login1";
            Login1.Size = new Size(181, 23);
            Login1.TabIndex = 1;
            // 
            // Password1
            // 
            Password1.Location = new Point(227, 208);
            Password1.Name = "Password1";
            Password1.Size = new Size(181, 23);
            Password1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(243, 310);
            button2.Name = "button2";
            button2.Size = new Size(154, 23);
            button2.TabIndex = 3;
            button2.Text = "Регистрация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 459);
            Controls.Add(button2);
            Controls.Add(Password1);
            Controls.Add(Login1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Login1;
        private TextBox Password1;
        private Button button2;
    }
}
