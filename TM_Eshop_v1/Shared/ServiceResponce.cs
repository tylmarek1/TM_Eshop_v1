﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_Eshop_v1.Shared
{
    public class ServiceResponce<T>
    {
        public T? Data { get; set;}
        public bool Success { get; set;} = true;
        public string Message { get; set;} = string.Empty;
    }
}
