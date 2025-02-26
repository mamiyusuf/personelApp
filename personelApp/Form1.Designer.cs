namespace personelApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            lbpersoneller = new ListBox();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtYas = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTel = new TextBox();
            txtAdres = new TextBox();
            btnSil = new Button();
            btn2 = new Button();
            btn3 = new Button();
            pbyeni = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbyeni).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 72);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(643, 1);
            button1.Name = "button1";
            button1.Size = new Size(106, 71);
            button1.TabIndex = 2;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(106, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 72);
            label1.TabIndex = 0;
            label1.Text = "Personel Takibi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Controls.Add(lbpersoneller);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 378);
            panel2.TabIndex = 1;
            // 
            // lbpersoneller
            // 
            lbpersoneller.FormattingEnabled = true;
            lbpersoneller.ItemHeight = 15;
            lbpersoneller.Location = new Point(3, 40);
            lbpersoneller.Name = "lbpersoneller";
            lbpersoneller.Size = new Size(194, 334);
            lbpersoneller.TabIndex = 1;
            lbpersoneller.SelectedIndexChanged += lbpersoneller_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.LightSkyBlue;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(200, 37);
            label7.TabIndex = 0;
            label7.Text = "Personel Listesi";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(283, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 30);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 137);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 3;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(284, 185);
            label4.Name = "label4";
            label4.Size = new Size(43, 30);
            label4.TabIndex = 4;
            label4.Text = "Yas";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(353, 107);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(295, 23);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(353, 146);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(295, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(353, 194);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(85, 23);
            txtYas.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(284, 230);
            label5.Name = "label5";
            label5.Size = new Size(38, 30);
            label5.TabIndex = 4;
            label5.Text = "Tel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(281, 274);
            label6.Name = "label6";
            label6.Size = new Size(66, 30);
            label6.TabIndex = 4;
            label6.Text = "Adres";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(353, 230);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(192, 23);
            txtTel.TabIndex = 5;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(353, 274);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(298, 106);
            txtAdres.TabIndex = 5;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(378, 401);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 39);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Lime;
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(570, 399);
            btn2.Name = "btn2";
            btn2.Size = new Size(161, 39);
            btn2.TabIndex = 6;
            btn2.Text = "Ekle/Güncelle";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(470, 401);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 39);
            btn3.TabIndex = 6;
            btn3.Text = "YENİ";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // pbyeni
            // 
            pbyeni.Image = Properties.Resources._new;
            pbyeni.Location = new Point(643, 72);
            pbyeni.Name = "pbyeni";
            pbyeni.Size = new Size(100, 67);
            pbyeni.SizeMode = PictureBoxSizeMode.StretchImage;
            pbyeni.TabIndex = 7;
            pbyeni.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(743, 450);
            Controls.Add(pbyeni);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnSil);
            Controls.Add(txtAdres);
            Controls.Add(txtTel);
            Controls.Add(txtYas);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbyeni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private Label label5;
        private Label label6;
        private TextBox txtTel;
        private TextBox txtAdres;
        private Button btnSil;
        private Button btn2;
        private PictureBox pictureBox2;
        private Button btn3;
        private PictureBox pbyeni;
        private Label label7;
        private ListBox lbpersoneller;
        private Button button1;
    }
}