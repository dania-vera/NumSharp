using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;

namespace NumSharp.Shared
{
   internal static partial class Multiplication
   {
        //start 1 
        internal static Int32[] MultiplyInt32ArrayToInt32Array(Int32[] np1, Int32[]np2)
        {
            return np1.Select((x,idx) => x * np2[idx]).ToArray();
        }
        //end 1
        //start 2
        internal static Int32[] MultiplyInt32ToInt32Array(Int32[] np1, Int32 np2)
        {
            return np1.Select((x) => x * np2).ToArray();
        }
        //end 2
        //start 3 
        internal static Int32[][] MultiplyInt32MatrixToInt32Matrix(Int32[][] np1, Int32[][]np2)
        {
            return np1.Select((x,idx) => x.Select((y,jdx) => y * np2[idx][jdx] ).ToArray()).ToArray();
        }
        //end 3
        //start 4
        internal static Int32[][] MultiplyInt32ToInt32Matrix(Int32[][] np1, Int32 np2)
        {
            return np1.Select((x) => x.Select((y) => y * np2 ).ToArray()).ToArray();
        }
        //end 4
   }
}