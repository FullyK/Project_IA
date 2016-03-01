using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                {-1,-1,-1,-1,-1,9,-1,-1,-1,-1,-1,-1,2,4,-1,-1,7,-1,-1,-1,-1,-1,10},
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
            string poids = "Son poids est : ";
            foreach (GenericNode Gn in Solution)
            {
                reponse += Gn.GetNom() + " ";
            }

            MessageBox.Show(reponse + "\n" + poids + CalculPoids(Solution).ToString());
        }

        private int[,] matriceEtape(List<string> etapesList)
        {

            etapesList.Insert(0, "A");

            int taille = etapesList.Count;

            int[,] matriceLaiterie = new int[taille, taille];

            for (int i = 0; i < taille; i++)
            {

                for (int j = 0; j < taille; j++)
                {
                    if (i != j)
                    {

                        NodeGraph depart = new NodeGraph((etapesList[i]));
                        depart.setMatrice(matriceAdjacente);

                        Graph Graphe = new Graph();

                        depart.setEndNode(etapesList[j]);

                        List<GenericNode> SolutionTmp = Graphe.RechercheSolutionAEtoile(depart);

                        matriceLaiterie[i, j] = Convert.ToInt32(CalculPoids(SolutionTmp));

                    }
                    else
                    {

                        matriceLaiterie[i, j] = -1;

                    }

                }


            }

            return matriceLaiterie;

        }

        private void CheminLaiterie_Click(object sender, EventArgs e)
        {
            string etape = this.EtapeLaiterie.Text;
            Regex myRegex = new Regex("(,)");
            etape = myRegex.Replace(etape, "");
            //N*N-1 Génération de parcours
            List<char> listeChar = new List<char>();
            List<String> ListesChemins = new List<string>();

            List<String> etapesList = new List<string>();

            foreach (char lettre in etape)
            {
                etapesList.Add(lettre.ToString());
                listeChar.Add(lettre);
            }
            
            #region Calcul d'une heuristique avec glouton
            /**Calcul rapide d'une heuristique en utilisant un algoithme glouton**/
            NodeGraph depart = new NodeGraph("A");
            depart.setMatrice(matriceAdjacente);
            double poidsMin = int.MaxValue;
            List<GenericNode> SolutionEtape = new List<GenericNode>();

            string EtapeName = "A";
            List<GenericNode> Solution = new List<GenericNode>();
            Graph Graphe = new Graph();

            while (etapesList.Count != 0)
            {
                foreach (String nodeName in etapesList)
                {
                    depart.setEndNode(nodeName);
                    List<GenericNode> SolutionTmp = Graphe.RechercheSolutionAEtoile(depart);
                    if (poidsMin > CalculPoids(SolutionTmp))
                    {
                        EtapeName = nodeName;
                        poidsMin = CalculPoids(SolutionTmp);
                        SolutionEtape = SolutionTmp;
                    }
                }
                poidsMin = int.MaxValue;
                foreach (GenericNode Gn in SolutionEtape)
                {
                    if(Solution.Count != 0)
                    {
                        if(Solution.Last().GetNom() != Gn.GetNom())
                        {
                            Solution.Add(Gn);
                        }
                    }
                    else
                        Solution.Add(Gn);

                }
                depart = new NodeGraph(EtapeName);
                etapesList.Remove(EtapeName);
            }

            NodeGraph retourDepart = new NodeGraph(Solution.Last().GetNom());
            retourDepart.setEndNode("A");
            SolutionEtape = Graphe.RechercheSolutionAEtoile(retourDepart);
            foreach (GenericNode Gn in SolutionEtape)
            {
                if (Solution.Count != 0)
                {
                    if (Solution.Last().GetNom() != Gn.GetNom())
                    {
                        Solution.Add(Gn);
                    }
                }
                else
                    Solution.Add(Gn);
            }


            string reponse = "Le chemin est : ";
            string poids = "Son poids est : ";
            foreach (GenericNode Gn in Solution)
            {
                reponse += Gn.GetNom() + " ";
            }

            MessageBox.Show(reponse + "\n" + poids + CalculPoids(Solution).ToString());

            double borneMax = CalculPoids(Solution);
            #endregion


            #region Algorithme du voyageur du commerce

            GraphVoyageur Voyageur = new GraphVoyageur();

            MethodeRecursive("", listeChar, ListesChemins);
            List<GenericNode> SolutionOptimale = new List<GenericNode>();
            double poidsVoyageur = int.MaxValue;
            double poidsCourant = 0;
            foreach (string combinaison in ListesChemins)
            {
                List<String> CheminVoyageur = new List<string>();
                
                
                List<GenericNode> SolutionTmp = new List<GenericNode>();
                List<GenericNode> SolutionEtapeVoyageur = new List<GenericNode>();

                foreach (char etapeVoyageur in combinaison)
                {
                    CheminVoyageur.Add(etapeVoyageur.ToString());
                }

                NodeGraph departVoyageur = new NodeGraph("A", poidsCourant);

                foreach (String nodeName in CheminVoyageur)
                {
                    double poidsTemp = CalculPoids(SolutionTmp);
                    if (poidsTemp < borneMax)
                    {
                        departVoyageur.setEndNode(nodeName);
                        SolutionEtapeVoyageur = Voyageur.RechercheSolutionAEtoile(departVoyageur);

                        foreach (GenericNode Gn in SolutionEtapeVoyageur)
                        {
                            if (SolutionTmp.Count != 0)
                            {
                                if (SolutionTmp.Last().GetNom() != Gn.GetNom())
                                {
                                    SolutionTmp.Add(Gn);
                                }
                            }
                            else
                                SolutionTmp.Add(Gn);

                        }
                        poidsCourant = CalculPoids(SolutionTmp);
                        departVoyageur = new NodeGraph(nodeName, poidsCourant);
                    }
                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
                departVoyageur.setEndNode("A");
                SolutionEtapeVoyageur = Voyageur.RechercheSolutionAEtoile(departVoyageur);

                foreach (GenericNode Gn in SolutionEtapeVoyageur)
                {
                    if (SolutionTmp.Count != 0)
                    {
                        if (SolutionTmp.Last().GetNom() != Gn.GetNom())
                        {
                            SolutionTmp.Add(Gn);
                        }
                    }
                    else
                        SolutionTmp.Add(Gn);

                }
                
                if (poidsVoyageur > CalculPoids(SolutionTmp))
                {                    
                    poidsVoyageur = CalculPoids(SolutionTmp);
                    SolutionOptimale = SolutionTmp;
                }
                /*
                string reponseTmp = "Le chemin optimal est : ";
                string poidsTmp = "Son poids est : ";
                foreach (GenericNode Gn in SolutionTmp)
                {
                    reponseTmp += Gn.GetNom() + " ";
                }

                MessageBox.Show(reponseTmp + "\n" + poidsTmp + CalculPoids(SolutionTmp).ToString());*/
            }

            string reponseOptimale = "Le chemin optimal est : ";
            string poidsOptimal = "Son poids est : ";
            foreach (GenericNode Gn in SolutionOptimale)
            {
                reponseOptimale += Gn.GetNom() + " ";
            }

            MessageBox.Show(reponseOptimale + "\n" + poidsOptimal + CalculPoids(SolutionOptimale).ToString());
            #endregion


        }

        private double CalculPoids(List<GenericNode> chemins)
        {
            double poids = 0;

            for (int i = 0; i < chemins.Count-1; i++)
            {
                poids += chemins[i].GetArcCost(chemins[i + 1]);
            }

            return poids;
        }


        public static void MethodeRecursive(string combinaison, List<char> listeDesCaracteres, List<string> listeDesCombinaisons)
        {

            // Variable servant à la vérification de l'existance d'un caractère précis dans la combinaison actuelle
            bool existeDeja = false;

            // Si la taille de la combinaison actuelle est égale au nombre de caractères de la liste originelle
            // Alors on ajoute cette combinaison à la liste des combinaison
            if (combinaison.Length == listeDesCaracteres.Count)
                listeDesCombinaisons.Add(combinaison);

            // Pour chaque caractère de la liste originelle
            for (int i = 0; i < listeDesCaracteres.Count; i++)
            {

                // Pour chaque caractère de la combinaison actuelle
                for (int j = 0; j < combinaison.Length; j++)
                {

                    // Si le caractère actuelle de la liste originelle est déjà dans la combinaison actuelle
                    if (combinaison[j] == listeDesCaracteres.ElementAt(i))
                    {
                        // Alors existeDeja prend la valeur "vrai" et la boucle s'arrête
                        existeDeja = true;
                        break;
                    }
                    // Sinon existeDeja prend la valeur "faux"
                    else existeDeja = false;
                }

                // Si existeDeja a la valeur "faux" alors on lance la récursivité en appellant cette méthode à l'intérieur d'elle-même
                if (!existeDeja)
                    MethodeRecursive(combinaison + listeDesCaracteres.ElementAt(i), listeDesCaracteres, listeDesCombinaisons);
            }

        }
    }
    
}
