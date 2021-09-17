using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Threading;

namespace AksiyonAğTarama
{
    public partial class Form1 : Form
    {

        /* [DllImport("Gdi32.dll", EntryPoint = "CreatRoundRectRng")]
          private static extern IntPtr CreatRoundRectRng
          (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );*/



        public Form1()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreatRoundRectRng(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnİzlemePaneli.Height;
            PnlNav.Top = BtnİzlemePaneli.Top;
            PnlNav.Left = BtnİzlemePaneli.Left;
            BtnİzlemePaneli.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "İZLEME PANELİ";
            this.PnlFrmLoader.Controls.Clear();
            FrmizlemePaneli frmizlemepaneliVRB = new FrmizlemePaneli() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmizlemepaneliVRB.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmizlemepaneliVRB);
            frmizlemepaneliVRB.Show();



        }

        private void BtnİzlemePaneli_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnİzlemePaneli.Height;
            PnlNav.Top = BtnİzlemePaneli.Top;
            PnlNav.Left = BtnİzlemePaneli.Left;
            BtnİzlemePaneli.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "İZLEME PANELİ";
            this.PnlFrmLoader.Controls.Clear();
            FrmizlemePaneli frmizlemepaneliVRB = new FrmizlemePaneli() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmizlemepaneliVRB.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmizlemepaneliVRB);
            frmizlemepaneliVRB.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMailKontrol_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnMailKontrol.Height;
            PnlNav.Top = BtnMailKontrol.Top;
            BtnMailKontrol.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "MAİL KONTROL";
            this.PnlFrmLoader.Controls.Clear();
            FrmMailKontrol frmMailKontrolVRB = new FrmMailKontrol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMailKontrolVRB.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmMailKontrolVRB);
            frmMailKontrolVRB.Show();
        }

        private void BtnFullTarama_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnFullTarama.Height;
            PnlNav.Top = BtnFullTarama.Top;
            BtnFullTarama.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "FULL TARAMA";
            this.PnlFrmLoader.Controls.Clear();
            FrmFullTarama frmFullTaramaVRB = new FrmFullTarama() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFullTaramaVRB.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmFullTaramaVRB);
            frmFullTaramaVRB.Show();
        }

        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAyarlar.Height;
            PnlNav.Top = BtnAyarlar.Top;
            BtnAyarlar.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "AYARLAR PANELİ";
            this.PnlFrmLoader.Controls.Clear();
            FrmAyarlar frmAyarlarVRB = new FrmAyarlar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAyarlarVRB.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmAyarlarVRB);
            frmAyarlarVRB.Show();
        }

        private void BtnİzlemePaneli_Leave(object sender, EventArgs e)
        {
            BtnİzlemePaneli.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnMailKontrol_Leave(object sender, EventArgs e)
        {
            BtnMailKontrol.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnFullTarama_Leave(object sender, EventArgs e)
        {
            BtnFullTarama.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAyarlar_Leave(object sender, EventArgs e)
        {
            BtnAyarlar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
