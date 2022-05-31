﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.AbstractData
{
    public interface IEmployee 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Post { get; set; }
    }
}
