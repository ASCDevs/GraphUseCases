using Graphs.Entities;
using Graphs.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public static class DataForGraphs
    {

        public static List<DataItem> GetData(GraphDataModel dataModel)
        {
            if(dataModel.Equals(GraphDataModel.DM1)) return Modelo1();
            if(dataModel.Equals(GraphDataModel.DM2)) return Modelo2();

            return new List<DataItem>();
        }

        private static List<DataItem> Modelo1()
        {
            return new List<DataItem>(){
                new DataItem("M3","doc16","doc6"),
                new DataItem("H2","doc7","doc18"),
                new DataItem("A1","doc1"),
                new DataItem("C2","doc2","doc1"),
                new DataItem("I3","doc8","doc2"),
                new DataItem("O4","doc9","doc8"),
                new DataItem("J3","doc10","doc3"),
                new DataItem("D2","doc3","doc1"),
                new DataItem("E2","doc4","doc1"),
                new DataItem("P4","doc12","doc10"),
                new DataItem("R5","doc13","doc12"),
                new DataItem("K3","doc11","doc3"),
                new DataItem("B1","doc18"),
                new DataItem("F2","doc5","doc18"),
                new DataItem("Q4","doc14","doc11"),
                new DataItem("L3","doc15","doc5"),
                new DataItem("G2","doc6","doc18"),
                new DataItem("N3","doc17","doc7")
            };
        }

        private static List<DataItem> Modelo2()
        {
            return new List<DataItem>();
        }

    }
}
