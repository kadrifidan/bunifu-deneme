using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class anasayfaF : Form
    {
        public anasayfaF()
        {
            InitializeComponent();
        }

        private void anasayfaF_Load(object sender, EventArgs e)
        {

        }

        private void btnkapa_Click(object sender, EventArgs e)
        {
            Formkapa fr=new Formkapa();
            fr.ShowDialog();
        }

        private void filmbtn_MouseEnter(object sender, EventArgs e)
        {
            labelfilm.ForeColor=Color.Crimson;
            labelfilm.Font = new Font("Century Gothic", 30);
        }

        private void filmbtn_MouseLeave(object sender, EventArgs e)
        {
            labelfilm.ForeColor = Color.Gold;
            labelfilm.Font = new Font("Century Gothic", 25);


        }

        private void istatbtn_MouseEnter(object sender, EventArgs e)
        {
            labelist.ForeColor=Color.Crimson;
            labelist.Font = new Font("Century Gothic", 30);

        }

        private void istatbtn_MouseLeave(object sender, EventArgs e)
        {
            labelist.ForeColor = Color.Gold;
            labelist.Font = new Font("Century Gothic", 25);
        }

        private void cekbtn_MouseEnter(object sender, EventArgs e)
        {
            labelcek.ForeColor = Color.Crimson;
            labelcek.Font = new Font("Century Gothic", 30);
        }

        private void cekbtn_MouseLeave(object sender, EventArgs e)
        {
            labelcek.ForeColor = Color.Gold;
            labelcek.Font = new Font("Century Gothic", 25);
        }


        bool tutus;
        int farex, farey;

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                Left = Cursor.Position.X - farex;
                Top = Cursor.Position.Y - farey;
            }
        }

        private void bunifuPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            farex = 0;
            farey = 0;
        }

        private void btnsimge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void filmbtn_Click(object sender, EventArgs e)
        {
            Formfilmler fr=new Formfilmler();
            fr.Show();
            this.Hide();
        }

        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            farex = Cursor.Position.X - Left;
            farey = Cursor.Position.Y - Top;
        }
    }
}
