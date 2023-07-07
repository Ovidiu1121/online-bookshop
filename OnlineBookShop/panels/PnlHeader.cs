using OnlineBookShop.forms;
using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OnlineBookShop.panels
{
    public class PnlHeader:Panel
    {

        private Label lbltitle;
        private TextBox txtsearch;
        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton btnaccount;
        private FontAwesome.Sharp.IconButton btncart;
        private FrmHome frmhome;
        private User user;

        public PnlHeader(FrmHome frmhome,User user)
        {
            this.frmhome = frmhome;
            this.user = user;

            this.Location =new Point(0, 0);
            this.Size =new Size(frmhome.Width, 70);
            this.BackColor = Color.LightGoldenrodYellow;
            this.Name="pnlheader";
            this.Dock = DockStyle.Top;

            this.txtsearch = new TextBox();
            this.Controls.Add(this.txtsearch);
            this.txtsearch.Location = new Point(27, 25);
            this.txtsearch.Size = new Size(400, 100);
            this.txtsearch.Text="Search books";
            this.txtsearch.Font=new Font("Arial", 15, FontStyle.Regular);
            this.txtsearch.Leave+= new EventHandler(textBox1_Leave);

            this.lbltitle=new Label();
            this.Controls.Add(this.lbltitle);
            this.lbltitle.Location=new Point(850,15);
            this.lbltitle.Size=new Size(300, 80);
            this.lbltitle.Text="BookShop";
            this.lbltitle.Font=new Font("Harlow Solid Italic", 23, FontStyle.Bold);

            this.btnaccount=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btnaccount);
            this.btnaccount.Location=new Point(1600, 17);
            this.btnaccount.Size=new Size(118, 33);
            this.btnaccount.IconChar=FontAwesome.Sharp.IconChar.User;
            this.btnaccount.IconSize=25;
            this.btnaccount.Text="My account";
            this.btnaccount.TextImageRelation=TextImageRelation.ImageBeforeText; 
            this.btnaccount.FlatAppearance.BorderSize=0;
            this.btnaccount.FlatStyle = FlatStyle.Flat;

            this.btncart=new FontAwesome.Sharp.IconButton();
            this.Controls.Add(this.btncart);
            this.btncart.Location=new Point(1740, 17);
            this.btncart.Size=new Size(150, 33);
            this.btncart.IconChar=FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btncart.IconSize=25;
            this.btncart.Text="Shopping cart";
            this.btncart.TextImageRelation=TextImageRelation.ImageBeforeText;
            this.btncart.FlatAppearance.BorderSize=0;
            this.btncart.FlatStyle = FlatStyle.Flat;


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.txtsearch.Text.Equals(""))
            {
                this.txtsearch.Text="Search product";
                this.txtsearch.ForeColor=Color.Gray;
            }
        }

    }
}
