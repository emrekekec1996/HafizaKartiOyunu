namespace HafizaKartiOyunu.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblSkor;
        private Label lblEslesmeSayisi;
        private Button btnYenidenBaslat;

        // 16 Kart Butonu İçin Ayrı Ayrı Tanımlamalar
        private Button btnKart1, btnKart2, btnKart3, btnKart4;
        private Button btnKart5, btnKart6, btnKart7, btnKart8;
        private Button btnKart9, btnKart10, btnKart11, btnKart12;
        private Button btnKart13, btnKart14, btnKart15, btnKart16;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSkor = new Label();
            lblEslesmeSayisi = new Label();
            btnYenidenBaslat = new Button();
            btnKart1 = new Button();
            btnKart2 = new Button();
            btnKart3 = new Button();
            btnKart4 = new Button();
            btnKart5 = new Button();
            btnKart6 = new Button();
            btnKart7 = new Button();
            btnKart8 = new Button();
            btnKart9 = new Button();
            btnKart10 = new Button();
            btnKart11 = new Button();
            btnKart12 = new Button();
            btnKart13 = new Button();
            btnKart14 = new Button();
            btnKart15 = new Button();
            btnKart16 = new Button();
            SuspendLayout();
            // 
            // lblSkor
            // 
            lblSkor.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblSkor.Location = new Point(20, 20);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(180, 40);
            lblSkor.TabIndex = 0;
            lblSkor.Text = "Skor: 0";
            // 
            // lblEslesmeSayisi
            // 
            lblEslesmeSayisi.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblEslesmeSayisi.Location = new Point(220, 20);
            lblEslesmeSayisi.Name = "lblEslesmeSayisi";
            lblEslesmeSayisi.Size = new Size(200, 40);
            lblEslesmeSayisi.TabIndex = 1;
            lblEslesmeSayisi.Text = "Eşleşme: 0";
            // 
            // btnYenidenBaslat
            // 
            btnYenidenBaslat.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnYenidenBaslat.Location = new Point(426, 3);
            btnYenidenBaslat.Name = "btnYenidenBaslat";
            btnYenidenBaslat.Size = new Size(120, 57);
            btnYenidenBaslat.TabIndex = 2;
            btnYenidenBaslat.Text = "Yeniden Başlat";
            btnYenidenBaslat.Click += BtnYenidenBaslat_Click;
            // 
            // btnKart1
            // 
            btnKart1.Location = new Point(0, 0);
            btnKart1.Name = "btnKart1";
            btnKart1.Size = new Size(75, 23);
            btnKart1.TabIndex = 0;
            // 
            // btnKart2
            // 
            btnKart2.Location = new Point(0, 0);
            btnKart2.Name = "btnKart2";
            btnKart2.Size = new Size(75, 23);
            btnKart2.TabIndex = 0;
            // 
            // btnKart3
            // 
            btnKart3.Location = new Point(0, 0);
            btnKart3.Name = "btnKart3";
            btnKart3.Size = new Size(75, 23);
            btnKart3.TabIndex = 0;
            // 
            // btnKart4
            // 
            btnKart4.Location = new Point(0, 0);
            btnKart4.Name = "btnKart4";
            btnKart4.Size = new Size(75, 23);
            btnKart4.TabIndex = 0;
            // 
            // btnKart5
            // 
            btnKart5.Location = new Point(0, 0);
            btnKart5.Name = "btnKart5";
            btnKart5.Size = new Size(75, 23);
            btnKart5.TabIndex = 0;
            // 
            // btnKart6
            // 
            btnKart6.Location = new Point(0, 0);
            btnKart6.Name = "btnKart6";
            btnKart6.Size = new Size(75, 23);
            btnKart6.TabIndex = 0;
            // 
            // btnKart7
            // 
            btnKart7.Location = new Point(0, 0);
            btnKart7.Name = "btnKart7";
            btnKart7.Size = new Size(75, 23);
            btnKart7.TabIndex = 0;
            // 
            // btnKart8
            // 
            btnKart8.Location = new Point(0, 0);
            btnKart8.Name = "btnKart8";
            btnKart8.Size = new Size(75, 23);
            btnKart8.TabIndex = 0;
            // 
            // btnKart9
            // 
            btnKart9.Location = new Point(0, 0);
            btnKart9.Name = "btnKart9";
            btnKart9.Size = new Size(75, 23);
            btnKart9.TabIndex = 0;
            // 
            // btnKart10
            // 
            btnKart10.Location = new Point(0, 0);
            btnKart10.Name = "btnKart10";
            btnKart10.Size = new Size(75, 23);
            btnKart10.TabIndex = 0;
            // 
            // btnKart11
            // 
            btnKart11.Location = new Point(0, 0);
            btnKart11.Name = "btnKart11";
            btnKart11.Size = new Size(75, 23);
            btnKart11.TabIndex = 0;
            // 
            // btnKart12
            // 
            btnKart12.Location = new Point(0, 0);
            btnKart12.Name = "btnKart12";
            btnKart12.Size = new Size(75, 23);
            btnKart12.TabIndex = 0;
            // 
            // btnKart13
            // 
            btnKart13.Location = new Point(0, 0);
            btnKart13.Name = "btnKart13";
            btnKart13.Size = new Size(75, 23);
            btnKart13.TabIndex = 0;
            // 
            // btnKart14
            // 
            btnKart14.Location = new Point(0, 0);
            btnKart14.Name = "btnKart14";
            btnKart14.Size = new Size(75, 23);
            btnKart14.TabIndex = 0;
            // 
            // btnKart15
            // 
            btnKart15.Location = new Point(0, 0);
            btnKart15.Name = "btnKart15";
            btnKart15.Size = new Size(75, 23);
            btnKart15.TabIndex = 0;
            // 
            // btnKart16
            // 
            btnKart16.Location = new Point(0, 0);
            btnKart16.Name = "btnKart16";
            btnKart16.Size = new Size(75, 23);
            btnKart16.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = Color.LightBlue;
            ClientSize = new Size(600, 600);
            Controls.Add(lblSkor);
            Controls.Add(lblEslesmeSayisi);
            Controls.Add(btnYenidenBaslat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hafıza Kartı Oyunu";
            ResumeLayout(false);
        }
    }
}
