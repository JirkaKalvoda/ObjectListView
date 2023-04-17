using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;

namespace TestProject1
{
    public class Gun
    {
        //[OLVColumn("使能")]
        public bool IsEnable { get; set; }

        //[OLVColumn("公司")]
        public string Company { get; set; }

        //[OLVColumn("名字")]
        public string Name { get; set; }

        //[OLVColumn("口径")]
        public double Caliber { get; set; }
        
    }
}
