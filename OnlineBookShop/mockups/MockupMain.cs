using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop.mockups
{
    public partial class MockupMain : Form
    {
        public MockupMain()
        {
            InitializeComponent();


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Search product"))
            {
                textBox1.Text.Equals("");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }
    }
}
