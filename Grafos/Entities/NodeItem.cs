using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Entities
{
    public class NodeItem
    {
        public NodeItem? Root { get; set; }
        public List<NodeItem> Children { get; set; } = new List<NodeItem>();
        public string Name { get; set; }
        public string Id { get; set; }
        public string? IdRoot { get; set; }

        public NodeItem(string name, string id, string? idRoot)
        {
            Name = name;
            Id = id;
            IdRoot = idRoot;
        }

        public void AddChild(NodeItem newChild) 
        {
            newChild.Root = this;
            Children.Add(newChild);
        }

        public void View(int nivel = 0)
        {
            Console.WriteLine(new String('-', nivel*2)+" "+Name);
            foreach (NodeItem itemChild in Children)
            {
                itemChild.View(nivel+1);
            }
        }
    }
}
