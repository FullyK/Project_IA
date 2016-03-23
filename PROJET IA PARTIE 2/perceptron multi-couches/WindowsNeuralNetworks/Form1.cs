using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Graphics g;
        static Bitmap bmp;
         Random rnd = new Random();

        Reseau reseau;

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialisation d'un réseau de neurones avec le nombre d'entrées, 
            // le nombre de couches et le nbre de neurones par couches
            reseau = new Reseau(Convert.ToInt32(textBoxnbentrees.Text),
                                        Convert.ToInt32(textBoxnbcouches.Text),
                                        Convert.ToInt32(textBoxnbneurcouche.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
             List<List<double>> lvecteursentrees = new List<List<double>>();
             List<double> lsortiesdesirees = new List<double>();


             System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\jalbouys\Downloads\PROJET IA PARTIE 2\donneespb3.txt");
             for (int i = 0; i < 3000; i++)
             {
                 List<double> vect = new List<double>();
                 

                 string line;

                 List<String> ligneLue = new List<String>();

                 line = file.ReadLine();
                 char[] delimiteur = new char[] {' '};
                 string[] parts = line.Split(delimiteur, StringSplitOptions.RemoveEmptyEntries);
                 
                 double x = double.Parse(parts[0]);
                 double y = double.Parse(parts[1]);
                 vect.Add(Math.Floor(x));
                 vect.Add(Math.Floor(y));


                 lvecteursentrees.Add(vect);
                 lsortiesdesirees.Add(double.Parse(parts[2]));

                 int zdesire = (int)(double.Parse(parts[2]) * 255);
                 Color newColor = Color.FromArgb(zdesire, zdesire, zdesire);
                 bmp.SetPixel((int)x, (int)y, newColor);
                 bmp.Save("Test.bmp");
                 
             }

             reseau.backprop(lvecteursentrees, lsortiesdesirees ,
                                Convert.ToDouble(textBoxalpha.Text),
                                Convert.ToInt32(textBoxnbiter.Text));

            Tests( g, bmp,lsortiesdesirees);
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            reseau.AfficheInfoNeurone(Convert.ToInt32(textBoxnumcouche.Text),
                                       Convert.ToInt32(textBoxnumneur.Text),
                                       listBox1);

        }
        /*****************************************************************/
        // Attention, la fonction à apprendre doit fournir des valeurs entre 0 et 1 !!!
        double fonctionmodele(double x)
        {
            // return Math.Sin(x * 20) / 2.5 + 0.5;
            if (x < 0.2 || x > 0.8) return 0.8;
            else return 0.2;
        }

        /**********************************************************************/
        public void Tests(Graphics g, Bitmap bmp, List<double> lsortiesdesirees)
        {
            int x, z, zdesire;
            double z2;
            for (x = 0; x < bmp.Width; x++)
                for (z = 0; z < bmp.Height; z++)
                    bmp.SetPixel(x, z, Color.Black);

            List<List<double>> lvecteursentrees = new List<List<double>>();
            List<double> lsortiesobtenues; 

            for (x = 0; x < 500; x++)
            {
                for (int y = 0; y < 500; y++)
                {                 
                    // Initialisation des activations  ai correspondant aux entrées xi
                    // Le premier neurone est une constante égale à 1
                    List<double> vect = new List<double>();
                    vect.Add(x); 
                    vect.Add(y);
                    lvecteursentrees.Add(vect);
                }
            }

            lsortiesobtenues = reseau.ResultatsEnSortie( lvecteursentrees );
            
            
            int cpt = 0;
             for (x = 0; x < 500; x++)
             {
                 for (int y = 0; y < 500; y++)
                 {
                     z2 = lsortiesobtenues[cpt];
                     z = (int)(z2 * 255);
                     zdesire = (int)(lsortiesdesirees[x] * 255);
                     Color newColor = Color.FromArgb(z, z, z);
                     bmp.SetPixel(x, y, newColor);
                     cpt++;
                 }                
            }

        }
        
    }
}
