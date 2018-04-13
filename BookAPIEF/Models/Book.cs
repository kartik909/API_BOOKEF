﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAPIEF.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Book()
        {
            Id = 0;
            Name = string.Empty;
          }
    }
}