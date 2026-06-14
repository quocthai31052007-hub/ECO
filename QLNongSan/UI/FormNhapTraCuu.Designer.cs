namespace QLNongSan.UI
{
    partial class FormNhapTraCuu
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
            idInput = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(237, 254);
            button1.Name = "button1";
            button1.Size = new Size(257, 122);
            button1.TabIndex = 0;
            button1.Text = "Lấy thông tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onIdSubmitClick;
            // 
            // idInput
            // 
            idInput.Location = new Point(237, 94);
            idInput.Name = "idInput";
            idInput.Size = new Size(257, 27);
            idInput.TabIndex = 1;
            // 
            // FormNhapTraCuu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idInput);
            Controls.Add(button1);
            Name = "FormNhapTraCuu";
            Text = "FormNhapTraCuu";
            Load += FormNhapTraCuu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox idInput;
    }
}