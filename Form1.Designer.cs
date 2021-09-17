
namespace AksiyonAğTarama
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAyarlar = new System.Windows.Forms.Button();
            this.BtnFullTarama = new System.Windows.Forms.Button();
            this.BtnMailKontrol = new System.Windows.Forms.Button();
            this.BtnİzlemePaneli = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Altmetin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ATmetin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PnlFrmLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnAyarlar);
            this.panel1.Controls.Add(this.BtnFullTarama);
            this.panel1.Controls.Add(this.BtnMailKontrol);
            this.panel1.Controls.Add(this.BtnİzlemePaneli);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 188);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 0;
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAyarlar.FlatAppearance.BorderSize = 0;
            this.BtnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyarlar.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyarlar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.Image")));
            this.BtnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyarlar.Location = new System.Drawing.Point(0, 405);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.Size = new System.Drawing.Size(150, 45);
            this.BtnAyarlar.TabIndex = 5;
            this.BtnAyarlar.Text = "AYARLAR";
            this.BtnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAyarlar.UseVisualStyleBackColor = true;
            this.BtnAyarlar.Click += new System.EventHandler(this.BtnAyarlar_Click);
            this.BtnAyarlar.Leave += new System.EventHandler(this.BtnAyarlar_Leave);
            // 
            // BtnFullTarama
            // 
            this.BtnFullTarama.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFullTarama.FlatAppearance.BorderSize = 0;
            this.BtnFullTarama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFullTarama.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFullTarama.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnFullTarama.Image = ((System.Drawing.Image)(resources.GetObject("BtnFullTarama.Image")));
            this.BtnFullTarama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFullTarama.Location = new System.Drawing.Point(0, 213);
            this.BtnFullTarama.Name = "BtnFullTarama";
            this.BtnFullTarama.Size = new System.Drawing.Size(150, 45);
            this.BtnFullTarama.TabIndex = 4;
            this.BtnFullTarama.Text = "FULL TARAMA ";
            this.BtnFullTarama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFullTarama.UseVisualStyleBackColor = true;
            this.BtnFullTarama.Click += new System.EventHandler(this.BtnFullTarama_Click);
            this.BtnFullTarama.Leave += new System.EventHandler(this.BtnFullTarama_Leave);
            // 
            // BtnMailKontrol
            // 
            this.BtnMailKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMailKontrol.FlatAppearance.BorderSize = 0;
            this.BtnMailKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailKontrol.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMailKontrol.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMailKontrol.Image = ((System.Drawing.Image)(resources.GetObject("BtnMailKontrol.Image")));
            this.BtnMailKontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMailKontrol.Location = new System.Drawing.Point(0, 168);
            this.BtnMailKontrol.Name = "BtnMailKontrol";
            this.BtnMailKontrol.Size = new System.Drawing.Size(150, 45);
            this.BtnMailKontrol.TabIndex = 3;
            this.BtnMailKontrol.Text = "MAİL KONTROL";
            this.BtnMailKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMailKontrol.UseVisualStyleBackColor = true;
            this.BtnMailKontrol.Click += new System.EventHandler(this.BtnMailKontrol_Click);
            this.BtnMailKontrol.Leave += new System.EventHandler(this.BtnMailKontrol_Leave);
            // 
            // BtnİzlemePaneli
            // 
            this.BtnİzlemePaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnİzlemePaneli.FlatAppearance.BorderSize = 0;
            this.BtnİzlemePaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnİzlemePaneli.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnİzlemePaneli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BtnİzlemePaneli.Image = ((System.Drawing.Image)(resources.GetObject("BtnİzlemePaneli.Image")));
            this.BtnİzlemePaneli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnİzlemePaneli.Location = new System.Drawing.Point(0, 123);
            this.BtnİzlemePaneli.Name = "BtnİzlemePaneli";
            this.BtnİzlemePaneli.Size = new System.Drawing.Size(150, 45);
            this.BtnİzlemePaneli.TabIndex = 2;
            this.BtnİzlemePaneli.Text = "İZLEME PANELİ";
            this.BtnİzlemePaneli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnİzlemePaneli.UseVisualStyleBackColor = true;
            this.BtnİzlemePaneli.Click += new System.EventHandler(this.BtnİzlemePaneli_Click);
            this.BtnİzlemePaneli.Leave += new System.EventHandler(this.BtnİzlemePaneli_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.Altmetin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ATmetin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 123);
            this.panel2.TabIndex = 1;
            // 
            // Altmetin
            // 
            this.Altmetin.AutoSize = true;
            this.Altmetin.Font = new System.Drawing.Font("Arial Unicode MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Altmetin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Altmetin.Location = new System.Drawing.Point(12, 97);
            this.Altmetin.Name = "Altmetin";
            this.Altmetin.Size = new System.Drawing.Size(105, 12);
            this.Altmetin.TabIndex = 1;
            this.Altmetin.Text = "Ağ tarama programı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ATmetin
            // 
            this.ATmetin.AutoSize = true;
            this.ATmetin.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ATmetin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ATmetin.Location = new System.Drawing.Point(1, 78);
            this.ATmetin.Name = "ATmetin";
            this.ATmetin.Size = new System.Drawing.Size(147, 16);
            this.ATmetin.TabIndex = 1;
            this.ATmetin.Text = "AKSİYON TEKNOLOJİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AksiyonAğTarama.Properties.Resources.fi_rr_cross_small;
            this.pictureBox2.Location = new System.Drawing.Point(766, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(198, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "İZLEME PANELİ";
            // 
            // PnlFrmLoader
            // 
            this.PnlFrmLoader.Location = new System.Drawing.Point(150, 51);
            this.PnlFrmLoader.Name = "PnlFrmLoader";
            this.PnlFrmLoader.Size = new System.Drawing.Size(650, 398);
            this.PnlFrmLoader.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlFrmLoader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnİzlemePaneli;
        private System.Windows.Forms.Label Altmetin;
        private System.Windows.Forms.Label ATmetin;
        private System.Windows.Forms.Button BtnAyarlar;
        private System.Windows.Forms.Button BtnFullTarama;
        private System.Windows.Forms.Button BtnMailKontrol;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PnlFrmLoader;
        private System.Windows.Forms.FlowLayoutPanel PnlNav;
    }
}

