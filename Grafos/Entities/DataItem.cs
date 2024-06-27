using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Entities
{
    public class DataItem
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string? IdRoot { get; set; }

        public DataItem(string name, string id, string idRoot)
        {
            Name = name;
            Id = id;
            IdRoot = idRoot;
        }

        public DataItem(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public NodeItem CreateNode()
        {
            return new NodeItem(Name, Id,IdRoot);
        }
    }
}
