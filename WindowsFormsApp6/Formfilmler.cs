using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp6
{
    public partial class Formfilmler : Form
    {
        public Formfilmler()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfaF fr = new anasayfaF();
            fr.Show();
            this.Close();

        }

        bool tutus;
        int farex, farey;

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                Left = Cursor.Position.X - farex;
                Top = Cursor.Position.Y - farey;
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            farex = 0;
            farey = 0;
        }

        private void Formfilmler_Load(object sender, EventArgs e)
        {
            this.filmtblTableAdapter.Fill(this.e60mdbDataSet.filmtbl);
        }

        

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            farex = Cursor.Position.X - Left;
            farey = Cursor.Position.Y - Top;
        }
    }
}
