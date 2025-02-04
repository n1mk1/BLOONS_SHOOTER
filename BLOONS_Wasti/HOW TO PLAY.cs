using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOONS_Wasti
{
    public partial class HOW_TO_PLAY : Form
    {
        public HOW_TO_PLAY()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();//HIDE CURRENT FORM
            MAIN_MENU mainmenu = new MAIN_MENU();

            mainmenu.ShowDialog();//GO TO NEXT FORM
        }
    }
}
