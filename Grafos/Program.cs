// See https://aka.ms/new-console-template for more information
using Grafos;
using Graphs.Graphs;

Console.WriteLine("--INICIO--");


var SimpleGraphM1 = new SimpleGraph(DataForGraphs.GetData(Graphs.Enums.GraphDataModel.DM1));
SimpleGraphM1.ViewGraph();


var stop = true;
