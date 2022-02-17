namespace APIOrganisms
{
    internal class Organism
    {

        private string id;
        private string name;
        private string parent;


        public Organism(string id, string name, string parent)
        {
            this.id = id;
            this.name = name;
            this.parent = parent;
        }

        public string Id { get => id; }
        public string Name { get => name; }
        public string Parent { get => parent;  }
    }
}