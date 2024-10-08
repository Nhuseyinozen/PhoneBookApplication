﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.Entities
{
    public class ContactRecord
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string WebAddress { get; set; }
        public string Explanation { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }


    }
}
