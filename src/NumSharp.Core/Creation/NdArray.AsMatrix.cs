﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NumSharp.Extensions
{
    public static partial class NDArrayExtensions
    {
        public static matrix AsMatrix(this NDArray nd)
        {
            var npAsMatrix = new matrix(nd);

            return npAsMatrix;
        }
    }
}
