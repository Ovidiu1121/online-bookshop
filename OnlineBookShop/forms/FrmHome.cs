using OnlineBookShop.models;
using OnlineBookShop.panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop.forms
{
    public partial class FrmHome : Form
    {

        private User user;
        public Panel activepanel;
        public Panel header;
        public Panel choosegenre;

        public FrmHome()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.user = new User();
            this.header=new PnlHeader(this, this.user);
            this.Controls.Add(this.header);

            this.choosegenre=new PnlChooseGenre(this);
            this.Controls.Add(this.choosegenre);

            this.activepanel=new PnlHome(this,this.user);
            this.Controls.Add(this.activepanel);


        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
