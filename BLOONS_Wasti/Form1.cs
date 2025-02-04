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
    public partial class MAIN_MENU : Form
    {
        public MAIN_MENU()
        {
            InitializeComponent();
            

        }
        
        
        
        private void btnPLAY_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHOICE Choice = new CHOICE();
            Choice.ShowDialog();
            
        }

        

        private void btnHTP_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOW_TO_PLAY HTP = new HOW_TO_PLAY();
            HTP.ShowDialog();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            this.Hide();
            HIGH_SCORE HS = new HIGH_SCORE();
            HS.ShowDialog();
        }
    }
}
