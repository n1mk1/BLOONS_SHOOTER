using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLOONS_Wasti
{
    public partial class CHOICE : Form
    {
        public CHOICE()
        {
            InitializeComponent();
        }
        //==========================================================================
        //  TITLE-CHOICE                                                           |
        //  PURPOSE-TO SET THE PLAYER AVATAR AND BACKGROUND IN A USER FRIENDLY WAY |
        //          THE PLAYER IS ALLOWED TO CONTINUE IF BOTH AVATAR AND MAP HAS   |
        //          BEEN CHOSEN.                                                   |
        //==========================================================================

        //AVATARS
        bool AVATARCHOSEN = false;
        public static bool coder = false;
        public static bool tank = false;
        public static bool quincy = false;

        //MAPS
        bool MAPCHOSEN = false;
        public static bool EGYPT = false;
        public static bool GARDEN = false;
        public static bool JUNGLE = false;
        public static int intLEVEL;
        //AVATAR BUTTONS
        private void btnCODER_Click(object sender, EventArgs e)
        {
            coder = true;
            GAME.CODER = coder;//Pass var
            AVATARCHOSEN = true;

            //CHANGE PICTURE
            btnCODER.BackgroundImage = BLOONS_Wasti.Properties.Resources.CODE;
            btnCODER.BackgroundImageLayout = ImageLayout.Stretch;

            //PLAY SOUND
            SoundPlayer CODERSOUND = new SoundPlayer();
            CODERSOUND.Stream = Properties.Resources.BTD6_Ringtone_Benjamin_Rules_Broken;
            CODERSOUND.Play();

            //ENABILITY
            btnTANK.Enabled = false;
            btnQUINCY.Enabled = false;

            //VISIBILITY
            btnTANK.Visible = false;
            btnQUINCY.Visible = false;

            //CHECKS IS SELECTION HAS BEEN DONE
            if (MAPCHOSEN == true && AVATARCHOSEN == true)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }
        }//WORKS
        private void btnTANK_Click(object sender, EventArgs e)
        {
            tank = true;
            GAME.TANK = tank;//PASS VAR
            AVATARCHOSEN = true;

            //CHANGE PICTURE
            btnTANK.BackgroundImage = BLOONS_Wasti.Properties.Resources.TANKY;
            btnTANK.BackgroundImageLayout = ImageLayout.Stretch;

            //PLAY SOUND
            SoundPlayer TANKSOUND = new SoundPlayer();
            TANKSOUND.Stream = Properties.Resources.Churchill_Hell_from_above_ringtone;
            TANKSOUND.Play();

            //ENABILITY
            btnCODER.Enabled = false;
            btnQUINCY.Enabled = false;

            //VISIBILITY
            btnCODER.Visible = false;
            btnQUINCY.Visible = false;

            //CHECKS IF SELECTION HAS BEEN DONE
            if (MAPCHOSEN == true && AVATARCHOSEN == true)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }
        }//WORKS
        private void btnQUINCY_Click(object sender, EventArgs e)
        {
            
            quincy = true;
            GAME.QUINCY = quincy;//PASS VAR
            AVATARCHOSEN = true;

            //CHANGE PICTURE
            btnQUINCY.BackgroundImage = BLOONS_Wasti.Properties.Resources.QSHOW;
            btnQUINCY.BackgroundImageLayout = ImageLayout.Stretch;

            //PLAYSOUND
            SoundPlayer QUINCYSOUND = new SoundPlayer();
            QUINCYSOUND.Stream = Properties.Resources.Quincy_nothing_gets_past_my_bow;
            QUINCYSOUND.Play();

            //ENABILITY
            btnTANK.Enabled = false;
            btnCODER.Enabled = false;

            //VISIBILITY
            btnTANK.Visible = false;
            btnCODER.Visible = false;

            //CHECKS IF SELECTION HAS BEEN DONE
            if (MAPCHOSEN == true && AVATARCHOSEN == true)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }

        }//WORKS

        //MAP BUTTON
        private void btnEGYPT_Click(object sender, EventArgs e)
        {
            EGYPT = true;
            GAME.egypt = EGYPT;//PASS VAR
            MAPCHOSEN = true;

            //ENABILITY
            btnGARDEN.Enabled = false;
            btnJUNGLE.Enabled = false;

            //VISIBILITY
            btnGARDEN.Visible = false;
            btnJUNGLE.Visible = false;

            //CHECKS IF SELECTION HAS BEEN DONE
            if (MAPCHOSEN == true && AVATARCHOSEN == true)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }

        }//WORKS
        private void btnGARDEN_Click(object sender, EventArgs e)
        {
            GARDEN = true;
            GAME.garden = GARDEN;//PASS VAR
            MAPCHOSEN = true;

            //ENABILITY
            btnEGYPT.Enabled = false;
            btnJUNGLE.Enabled = false;

            //VISIBILITY
            btnEGYPT.Visible = false;
            btnJUNGLE.Visible = false;

            //CHECKS IF SELECTION HAS BEEN DONE 
            if (MAPCHOSEN == true && AVATARCHOSEN == true)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }
        }//WORKS
        private void btnJUNGLE_Click(object sender, EventArgs e)
        {
            JUNGLE = true;
            GAME.jungle = JUNGLE;//PASS VAR
            MAPCHOSEN = true;

            //ENABILITY
            btnEGYPT.Enabled = false;
            btnGARDEN.Enabled = false;

            //VISIBILITY
            btnEGYPT.Visible = false;
            btnGARDEN.Visible = false;

            //CHEKS IF SELECTION HAS BEEN DONE
            if (MAPCHOSEN == true && AVATARCHOSEN == true)
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }
        }//WORKS

        private void btnBACK_Click(object sender, EventArgs e)
        {
            //RESET ALL THE CHOICES MADE
            RESET();
            this.Hide();//HIDE CURRENT FORM
            MAIN_MENU mainmenu = new MAIN_MENU();

            mainmenu.ShowDialog();//GO TO NEXT FORM
           
        }//GOES BACK TO MAIN MENU
        private void RESET()
        {
            
            //AVATARS
            AVATARCHOSEN = false;
            coder=false;
            tank=false;
            quincy=false;

            //MAPS
            MAPCHOSEN = false;
            EGYPT=false;
            GARDEN=false;
            JUNGLE=false;

            InitializeComponent();

        }//RESET EVERYTHING

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            GAME GAME = new GAME();
            GAME.ShowDialog();//SHOW GAMEFORM

        }

        private void CHOICE_Load(object sender, EventArgs e)
        {

        }

        private void radEASY_CheckedChanged(object sender, EventArgs e)
        {
            intLEVEL = 1;
            grpLevels.Enabled = false;
            GAME.intlevel = intLEVEL;//Pass var
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            intLEVEL = 2;
            grpLevels.Enabled = false;
            GAME.intlevel = intLEVEL;//Pass var
        }

        private void radHARD_CheckedChanged(object sender, EventArgs e)
        {
            intLEVEL = 3;
            grpLevels.Enabled = false;
            GAME.intlevel = intLEVEL;//Pass var
        }
    }
}
