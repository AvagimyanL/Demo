namespace TemplateApp
{
    partial class Register
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
            button2 = new Button();
            Email1 = new TextBox();
            Bio1 = new TextBox();
            Password1 = new TextBox();
            Login1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(177, 369);
            button2.Name = "button2";
            button2.Size = new Size(154, 23);
            button2.TabIndex = 7;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Email1
            // 
            Email1.Location = new Point(163, 89);
            Email1.Name = "Email1";
            Email1.Size = new Size(181, 23);
            Email1.TabIndex = 6;
            // 
            // Bio1
            // 
            Bio1.Location = new Point(163, 34);
            Bio1.Name = "Bio1";
            Bio1.Size = new Size(181, 23);
            Bio1.TabIndex = 5;
            // 
            // Password1
            // 
            Password1.Location = new Point(163, 190);
            Password1.Name = "Password1";
            Password1.Size = new Size(181, 23);
            Password1.TabIndex = 9;
            // 
            // Login1
            // 
            Login1.Location = new Point(163, 135);
            Login1.Name = "Login1";
            Login1.Size = new Size(181, 23);
            Login1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(175, 323);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 4;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(Password1);
            Controls.Add(Login1);
            Controls.Add(button2);
            Controls.Add(Email1);
            Controls.Add(Bio1);
            Controls.Add(button1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox Email1;
        private TextBox Bio1;
        private TextBox Password1;
        private TextBox Login1;
        private Button button1;
    }
}