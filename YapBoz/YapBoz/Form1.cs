using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapBoz
{
    public partial class Form1 : Form
    {
        PictureBox[] kutular;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kutular = new PictureBox[] { pb0, pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8 };
            resmiParcala();
        }

        private void resmiParcala()
        {
            Bitmap resim = new Bitmap( pictureBox_Resim.Image, 450, 450);

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    int indeks = i * 3 + j;

                    
                    Bitmap parca=resim.Clone(new Rectangle (j*150,i*150,150,150),resim.PixelFormat);
                    Graphics cizer= Graphics.FromImage(parca);
                    cizer.DrawString(indeks.ToString(), Font, Brushes.White,15,15);
                    kutular[indeks].Image = parca;
                }
            }


        }

        private void pictureBox_Resim_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox_Resim.Image = Image.FromFile(openFileDialog1.FileName);
                resmiParcala();

            
            }
        }

        private void button_karistir_Click(object sender, EventArgs e)
        {
            pb8.Visible= false;
        }

        private void pb0_Click(object sender, EventArgs e)
        {
            oynat((PictureBox)sender);
        }

        private void oynat(PictureBox kutu)
        {
            if(kutu.Left +152 == pb8.Left && kutu.Top == pb8.Top ||
               kutu.Left -152 == pb8.Left && kutu.Top == pb8.Top ||
               kutu.Left == pb8.Left && kutu.Top -152 == pb8.Top ||
               kutu.Left == pb8.Left && kutu.Top +152 == pb8.Top)
            {
                Point gecici=kutu.Location;
                kutu.Location = pb8.Location;
                pb8.Location = gecici;
            }
        }
    }
}
