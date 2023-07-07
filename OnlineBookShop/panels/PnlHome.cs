using OnlineBookShop.forms;
using OnlineBookShop.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop.panels
{
    public class PnlHome:Panel
    {

        private FrmHome frmhome;
        private User user;
        private Panel pnlslideshow;
        private Panel pnlcards;



        public PnlHome(FrmHome frmhome,User user)
        {
            this.frmhome = frmhome;
            this.user=user;

            this.Location=new Point(0,110);
            this.Size =new Size(1950,900);
            this.BackColor = Color.White;
            this.Name="pnlhome";

            this.pnlslideshow=new PnlSlideShow();
            this.Controls.Add(this.pnlslideshow);
            this.pnlslideshow.Location=new Point(370, 0);
            this.pnlslideshow.Size=new Size(1200, 350);
            

        }



    }
}
