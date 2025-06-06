namespace TemplateApp
{
    partial class AddPage
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
            Main1 = new Panel();
            tempBox1 = new GroupBox();
            tempText1 = new TextBox();
            panel2 = new Panel();
            Cancel1 = new Button();
            Save1 = new Button();
            Main1.SuspendLayout();
            tempBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Main1
            // 
            Main1.AutoScroll = true;
            Main1.BorderStyle = BorderStyle.FixedSingle;
            Main1.Controls.Add(tempBox1);
            Main1.Dock = DockStyle.Fill;
            Main1.Location = new Point(0, 0);
            Main1.Name = "Main1";
            Main1.Size = new Size(369, 382);
            Main1.TabIndex = 0;
            // 
            // tempBox1
            // 
            tempBox1.Controls.Add(tempText1);
            tempBox1.Dock = DockStyle.Top;
            tempBox1.Location = new Point(0, 0);
            tempBox1.Name = "tempBox1";
            tempBox1.Size = new Size(367, 52);
            tempBox1.TabIndex = 0;
            tempBox1.TabStop = false;
            tempBox1.Text = "groupBox1";
            // 
            // tempText1
            // 
            tempText1.Dock = DockStyle.Top;
            tempText1.Location = new Point(3, 19);
            tempText1.Name = "tempText1";
            tempText1.Size = new Size(361, 23);
            tempText1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Cancel1);
            panel2.Controls.Add(Save1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 75);
            panel2.TabIndex = 1;
            // 
            // Cancel1
            // 
            Cancel1.DialogResult = DialogResult.Cancel;
            Cancel1.Location = new Point(31, 24);
            Cancel1.Name = "Cancel1";
            Cancel1.Size = new Size(93, 39);
            Cancel1.TabIndex = 1;
            Cancel1.Text = "Отмена";
            Cancel1.UseVisualStyleBackColor = true;
            // 
            // Save1
            // 
            Save1.Location = new Point(241, 24);
            Save1.Name = "Save1";
            Save1.Size = new Size(93, 39);
            Save1.TabIndex = 0;
            Save1.Text = "Сохранить";
            Save1.UseVisualStyleBackColor = true;
            Save1.Click += Save1_Click;
            // 
            // AddPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 382);
            Controls.Add(panel2);
            Controls.Add(Main1);
            Name = "AddPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPage";
            Main1.ResumeLayout(false);
            tempBox1.ResumeLayout(false);
            tempBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Main1;
        private Panel panel2;
        private GroupBox tempBox1;
        private TextBox tempText1;
        private Button Cancel1;
        private Button Save1;
    }
}