
using System;
using System.Collections.Generic;
using System.Linq;


namespace APIOrganisms
{
    internal class TreeDataStructure
    {
        List<Organism> tree = new List<Organism>();

        public void AddItemToTree(Organism organism)
        {
            tree.Add(organism);
        }


        public void PrintTree(Organism organism, String indent, bool last)
        {
            Console.WriteLine(indent + "+- " + organism.Name);
            indent += last ? "   " : "|  ";
            List<Organism> children = new List<Organism>();
            children = tree.Where(org => org.Parent == organism.Id).ToList();
            for (int i = 0; i < children.Count; i++)
            {
                PrintTree(children[i], indent, i == children.Count - 1);
            }
        }

    }
}
