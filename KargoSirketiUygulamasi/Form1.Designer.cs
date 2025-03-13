namespace KargoSirketiUygulamasi
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
            label1 = new Label();
            txtKargo = new TextBox();
            btnNoEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "KARGO NUMARASI";
            // 
            // txtKargo
            // 
            txtKargo.Location = new Point(158, 56);
            txtKargo.Name = "txtKargo";
            txtKargo.Size = new Size(174, 27);
            txtKargo.TabIndex = 1;
            // 
            // btnNoEkle
            // 
            btnNoEkle.Location = new Point(198, 99);
            btnNoEkle.Name = "btnNoEkle";
            btnNoEkle.Size = new Size(94, 29);
            btnNoEkle.TabIndex = 2;
            btnNoEkle.Text = "Ekle";
            btnNoEkle.UseVisualStyleBackColor = true;
            btnNoEkle.Click += btnNoEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 171);
            Controls.Add(btnNoEkle);
            Controls.Add(txtKargo);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kargo Takip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKargo;
        private Button btnNoEkle;
    }
}
