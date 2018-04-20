using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordBell
{
   class Graph
   {
      public int n { set; get; }
     public int[,] a { set; get; }
      public void Gan(Graph g)
      {
         for(int i = 0; i < n; i++)
         {
            for (int j = 0; j < n; j++)
               a[i, j] = g.a[i,j];
         }
      }

   }
}
