using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BLOONS_Wasti
{
    public partial class HIGH_SCORE : Form
    {
        public HIGH_SCORE()
        {
            InitializeComponent();
        }
        string strName = "";
        public static int SCORE;
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            strName = txtName.Text;
            StreamWriter w = new StreamWriter("highscores");
            w.WriteLine( strName + " has " + SCORE + " points ");
            w.Close();

            StreamReader re = File.OpenText("highscores");
            string input = null;
            while ((input = re.ReadLine()) != null)
            {
                txtShowHighScores.Text =input;
            }
            re.Close();


        }

        
    }
}
