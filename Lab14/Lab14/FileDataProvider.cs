﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "data provider string";
        }
    }
}
