using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetIA
{
    class NodeGraph : GenericNode
    {
        private static string EndNode;
        private static int[,] Matrice;
        private double poidsPrecedent;
        

        public NodeGraph(string nom)
            : base(nom)
        {
            poidsPrecedent = 0;

        }

        public NodeGraph(string nom, double poidsPrecedent)
            : base(nom)
        {
            this.poidsPrecedent = poidsPrecedent;
        }


        public override double GetArcCost(GenericNode N2)
        {
            int ligne = Convert.ToInt32(this.GetNom()[0]) - 65;
            int colonne = Convert.ToInt32(N2.GetNom()[0]) - 65;
                       
            return Matrice[ligne,colonne];
        }

        public override bool EndState()
        {
            return (this.Name == EndNode);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> Succ = new List<GenericNode>();

            int ligne = Convert.ToInt32(this.GetNom()[0]) - 65;

            for (int i = 0; i < Matrice.GetUpperBound(0)+1; i++)
            {
                if (Matrice[ligne, i] != -1)
                {
                    NodeGraph Enfant = new NodeGraph(Convert.ToChar(i + 65).ToString());
                    Enfant.SetNoeud_Parent(this);
                    Succ.Add(Enfant);
                }
            }

            return Succ;
        }

        public override void CalculeHCost()
        {
            int h = 0;
            SetEstimation(h);
        }

        public void setEndNode(string newEnd)
        {
            EndNode = newEnd;
        }

        public void setMatrice(int[,] matrice)
        {
            Matrice = matrice;
        }

        public override double getPoidsPrecedent()
        {
            return this.poidsPrecedent;
        }

    
    
}
}
