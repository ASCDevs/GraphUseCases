using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphs.Entities;

namespace Graphs.Graphs
{
    public abstract class BaseGraph
    {
        public abstract void BuildGraph(List<DataItem> dataItems);
        public abstract void ViewGraph();
        public abstract void AddItemInGraph(DataItem item);
        public abstract void RemoveItemInGraph(string IdItem);
        public abstract void UpdateItemInGraph(DataItem item);
    }
}
