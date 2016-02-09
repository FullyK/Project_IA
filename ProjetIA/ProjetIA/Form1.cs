using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetIA
{
    public partial class Form1 : Form
    {
        public int[,] matriceAdjacente;

        public Form1()
        {
            InitializeComponent();
            int[,] matrice = new int[23, 23];

            matriceAdjacente = new int[,]
            {
                {-1,4,5,6,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {4,-1,-1,-1,5,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {5,-1,-1,4,6,-1,8,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {6,-1,4,-1,-1,9,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,5,6,-1,-1,-1,-1,4,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,9,-1,-1,-1,-1,-1,-1,-1,9,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,8,-1,-1,-1,-1,8,-1,-1,8,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,4,-1,8,-1,2,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,2,-1,3,4,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,3,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,8,-1,4,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,7},
                {-1,-1,-1,-1,-1,9,-1,-1,-1,-1,-1,-1,2,4,-1,-1,-1,-1,-1,-1,-1,-1,10},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,2,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,4,-1,-1,7,3,-1,-1,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,7,-1,3,-1,-1,8,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,3,3,-1,-1,5,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,7,-1,-1,-1,-1,-1,3,-1,-1,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,5,3,-1,-1,6,-1,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,8,-1,-1,-1,-1,-1,7,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,6,-1,-1,5,-1,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,7,5,-1,11,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,11,-1,6},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,7,10,-1,-1,-1,-1,-1,-1,-1,-1,-1,6,-1}
            };
        }

        private void buttonImpasse_Click(object sender, EventArgs e)
        {
            
            int[] compteurImpasse = new int[matriceAdjacente.GetLength(1)];

            for (int i = 0; i < matriceAdjacente.GetLength(0); i++)
            {
                for (int j = 0; j < matriceAdjacente.GetLength(1); j++)
                {

                    if (matriceAdjacente[i, j] != -1)
                    {
                        compteurImpasse[i]++;
                    }

                }

            }

            string reponse = "Les résultats sont : ";

            for (int i = 0; i < compteurImpasse.GetLength(0); i++)
            {
                if (compteurImpasse[i] == 1)
                {

                    reponse = reponse + " " + Convert.ToChar(i+65).ToString() + ", ";
                    
                }
            }


            MessageBox.Show(reponse, "Nombre d'impasse", MessageBoxButtons.OK);

        }

        private void Chemin_Click(object sender, EventArgs e)
        {
            NodeGraph depart = new NodeGraph(Depart.Text[0].ToString().ToUpper());
            depart.setMatrice(matriceAdjacente);

            NodeGraph arrive = new NodeGraph(Arrive.Text[0].ToString().ToUpper());
            depart.setEndNode(arrive.GetNom());

            Graph g = new Graph();
            List<GenericNode> Solution = g.RechercheSolutionAEtoile(depart);

            string reponse = "Le chemin est : ";

            foreach (GenericNode Gn in Solution)
            {
                reponse += Gn.GetNom() + " ";
            }

            MessageBox.Show(reponse);
        }
    }
    
}
