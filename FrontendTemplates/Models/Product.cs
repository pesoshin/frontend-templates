﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontendTemplates.Models
{
    public class Product
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual int Price { get; set; }
    }
}