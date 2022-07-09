using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3.model
{
    internal class product
    {
       public String objname { get; set; }
        public String number { get; set; }
        public String inventoryname { get; set; }
        public String date{ get; set; }
        public String count { get; set; }
        public String price { get; set; }

        public void Save()
        {
            MessageBox.Show($"{objname}was added");
        }
    }
}
