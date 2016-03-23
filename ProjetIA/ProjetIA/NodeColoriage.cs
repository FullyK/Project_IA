using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetIA
{
    class NodeColoriage : NodeGraph
    {
        private List<String> successeur;
        private string statue;

        public string Statue
        {
            get { return statue; }
            set { statue = value; }
        }

        public List<String> Successeur
        {
            get { return successeur; }
            set { successeur = value; }
        }

        public NodeColoriage(string nom)
            : base(nom)
        {
            successeur = new List<string>();
            statue = null;
        }


        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> Succ = new List<GenericNode>();
            int ligne = Convert.ToInt32(this.GetNom()[0]) - 65;

            for (int i = 0; i < Matrice.GetUpperBound(0) + 1; i++)
            {
                if (Matrice[ligne, i] != -1)
                {
                    NodeGraph Enfant = new NodeGraph(Convert.ToChar(i + 65).ToString());
                    Enfant.SetNoeud_Parent(this);
                    Succ.Add(Enfant);
                    successeur.Add(Enfant.GetNom());
                }
            }
            return Succ;
        }
    }
}
