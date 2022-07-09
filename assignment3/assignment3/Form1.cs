using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment3.model;


namespace assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        product p =new product();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            product p1 = new product()
            {
                count = txtcount.Text,
                price = txtprice.Text,
                objname = txtobjname.Text,
                number = txtnumber.Text,
                date=dt_registered_date.Text,
                inventoryname=sku.Text,

            }; 
            p1.Save();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
