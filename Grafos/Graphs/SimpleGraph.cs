using Graphs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Graphs
{
    public class SimpleGraph : BaseGraph
    {
        private List<NodeItem> nodes = new List<NodeItem>();
        public SimpleGraph(List<DataItem> data) { 
        
            BuildGraph(data);
        }

        public override void BuildGraph(List<DataItem> dataItems)
        {
            //Create the nodes
            dataItems.ForEach(item => nodes.Add(item.CreateNode()));

            //Attach node childs
            nodes.Where(n => n.Id != n.IdRoot).ToList().ForEach(nd1 =>
            {
                if(nodes.Any(nd2 => nd1.IdRoot == nd2.Id))
                {
                    nodes.Find(nd2 => nd1.IdRoot == nd2.Id).AddChild(nd1);
                }
            });
        }

        public override void AddItemInGraph(DataItem item)
        {
            throw new NotImplementedException();
        }

        

        public override void RemoveItemInGraph(string IdItem)
        {
            throw new NotImplementedException();
        }

        public override void UpdateItemInGraph(DataItem item)
        {
            throw new NotImplementedException();
        }

        public override void ViewGraph()
        {
            nodes.Where(roots => roots.Root == null).ToList().ForEach(root =>
            {
                root.View();
                Console.WriteLine("============================");
            });
        }
    }
}
