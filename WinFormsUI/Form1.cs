using DataAccess.Concrete.Adonet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDataReader_Click(object sender, EventArgs e)
        {
            AdoProductDal productDal = new AdoProductDal();
            foreach (var item in productDal.GetAll())
            {
                Console.WriteLine("Product : " + item.ProductID + " " + item.ProductName);
            }
        }
    }
}
