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

namespace AksiyonAğTarama
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreatRoundRectRng")]
        private static extern IntPtr CreatRoundRectRng
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );


        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreatRoundRectRng(0, 0, Width, Height, 25, 25));
        }

        private void BtnİzlemePaneli_Click(object sender, EventArgs e)
        {
            
        }
    }
}
