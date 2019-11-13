using System;
using System.Collections.Generic;
using System.Text;

namespace SeckillPro.Com.Model.CrmModel
{
    public class MoShopping
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int MaxNum { get; set; }
        public int MaxGouNum { get; set; }
        public decimal Price { get; set; }
        public string Des { get; set; }
        public string Url { get; set; }

    }
}
