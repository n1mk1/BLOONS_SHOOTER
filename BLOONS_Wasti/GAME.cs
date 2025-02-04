//========================================
//  NAME- WASTI, AS                     ||
//  SUBMISSIONDATE- 20 JANUARY, 2020    ||
//  CODE FINISHED ON- 19 JANUARY, 2020  ||
//  TITLE- BLOONS                       ||
//  PURPOSE- TO CREATE A C# GAME        ||
//========================================
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
    public partial class GAME : Form
    {
        public GAME()
        {
            InitializeComponent();
        }
        //===================================== 
        //--------DESIGN PURPOSES--------//
        //AVATARS                          //
        public static bool CODER;         //
        public static bool TANK;         //
        public static bool QUINCY;      //
        //MAPS                         //
        public static bool egypt;     //
        public static bool garden;   //
        public static bool jungle;  //
        public static int intlevel;//
        //========================//

        //PROGRAMMING PURPOSES
        bool goup; // THIS BOOLEAN WILL BE USED FOR THE PLAYERS TO GO UP THE SCREEN
        bool godown; // THIS BOOLEAN WILL BE USED FOR THE PLAYERS TO GO DOWN TO THE SCREEN
        bool goleft; // THIS BOOLEAN WILL BE USED FOR THE PLAYERS TO GO LEFT TO THE SCREEN
        bool goright; // THIS BOOLEAN WILL BE USED FOR THE PLAYERS TO GO RIGHT TO THE SCREEN
        bool space; // THIS BOOLEAN WILL BE USED TO SHOOT 
        bool gameOver = false; // DETERMINES WHEN THE GAME IS FINISHED

        string facing = "up"; //USED TO GUIDE THE BULLETS === LATER USED IN THE BULLET CLASS

        double dblplayerHealth = 100; //SETS PLAYER HEALTH TO PROGRESS BAR

        int intspeed =25; // SPEED OF THE PLAYER
        int ammo = 10; // NUMBER OF AMMO THE PLAYER HAS AT THE START OF THE GAME
        int intblimpintspeed = 5; // this integer will hold the intspeed which the zombies move in the game
        int pcbammoX;
        double pcbammoY;
        public static int score = 0; // this integer will hold the score the player achieved through the game        
        
        Random rnd = new Random(); // RANDOM CLASS: USED TO CREATE RANDOM NUMBERS  
        PictureBox[] blimp; // PICTURE BOX ARRAW OF BLIMPS ==>  DEPENDS ON THE CHOSEN LEVEL FROM EARLIER FORM
        PictureBox pcbammo = new PictureBox();//Dropammo

        private void GAME_Load(object sender, EventArgs e) //SETTING PLAYER PICTURE || SETTING MAP/BACKGROUND 
        {
            //==============================================
            // TITLE- GAME                                ||
            // EVENT- LOAD                                ||
            // PURPOSE- > SETTING PLAYER PICTURES         ||
            //          > SETTING MAP / BACKGROUN         ||
            //============================================||
            
            //THIS BLOCK SETS THE PLAYER PICTURE OF THE CHOSEN AVATAR FROM EARLIER
            
            //Setting player picture
            //=======================
            if (CODER == true)
            {
                //player picture: coder
                pcbplayer.Image = BLOONS_Wasti.Properties.Resources.CUP1; 

            }
            else if (TANK == true)
            {
                //player picture: tank
                pcbplayer.Image = BLOONS_Wasti.Properties.Resources.TUP1;
            }
            else if (QUINCY == true)
            {
                //player picture: quincy
                pcbplayer.Image = BLOONS_Wasti.Properties.Resources.QUP;
            }


            //THIS BLOCK SETS THE PLAYER PICTURE OF THE CHOSEN MAP FROM EARLIER

            //setting map/background image
            //============================
            if (egypt == true)
            {
                //set map/background to egypt
                BackgroundImage = BLOONS_Wasti.Properties.Resources.EGYPT;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (garden == true)
            {
                //set map/background to garden
                BackgroundImage = BLOONS_Wasti.Properties.Resources.GARDEN;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (jungle == true)
            {
                //set map/background to jungle
                BackgroundImage = BLOONS_Wasti.Properties.Resources.JUNGLE;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void keyisdown(object sender, KeyEventArgs e) // KEYDOWN SELELCTIONS FOR W/A/S/D/SPACE 
        {
            //====================================================================
            //  TITLE-KEYISDOWN                                 ||  W = UP      ||
            //  PURPOSE > CHECKS GAMEOVER STATUS                ||  A = LEFT    ||
            //          > LETS THE PLAYER CONTROLL THE AVAATR   ||  S = DOWN    ||
            //          > ROTATES PLAYERPICTURE ACCORDING TO    ||  D = RIGHT   ||
            //            DIRECTION                             ||              ||
            //====================================================================
           
            if (gameOver) return; // if game over is true then do nothing in this event

            // if the left key is pressed then do the following
            if (e.KeyCode == Keys.A)
            {
                goleft = true; // change go left to true                
                facing = "left"; //change facing to lef || LATER USED IN THE BULLET CLASS
                if (CODER == true)
                {
                    pcbplayer.Image = Properties.Resources.CLEFT1; // coder left pic
                }
                if (TANK == true)
                {
                    pcbplayer.Image = Properties.Resources.TLEFT1; // tank left pic
                }
                if (QUINCY == true)
                {
                    pcbplayer.Image = Properties.Resources.QLEFT; // quincy left pic
                }

            }

            // end of left key selection

            // if the right key is pressed then do the following
            if (e.KeyCode == Keys.D)
            {
                goright = true; // change go right to true
                facing = "right"; // change facing to right || LATER USED IN THE BULLET CLASS
                if (CODER == true)
                {
                    pcbplayer.Image = Properties.Resources.CRIGHT1; // coder RIGHT pic
                }
                if (TANK == true)
                {
                    pcbplayer.Image = Properties.Resources.TRIGHT1; // tank RIGHT pic
                }
                if (QUINCY == true)
                {
                    pcbplayer.Image = Properties.Resources.QRIGHT; // quincy RIGHT pic
                }

            }
            // end of right key selection

            // if the up key is pressed then do the following
            if (e.KeyCode == Keys.W)
            {
                facing = "up"; // change facing to up || LATER USED IN THE BULLET CLASS
                goup = true; // change go up to true
                if (CODER == true)
                {
                    pcbplayer.Image = Properties.Resources.CUP1; // coder UP pic
                }
                if (TANK == true)
                {
                    pcbplayer.Image = Properties.Resources.TUP1; // tank UP pic
                }
                if (QUINCY == true)
                {
                    pcbplayer.Image = Properties.Resources.QUP; // quincy UP pic
                }

            }

            // end of up key selection

            // if the down key is pressed then do the following
            if (e.KeyCode == Keys.S)
            {
                facing = "down"; // change facing to down || LATER USED IN THE BULLET CLASS
                godown = true; // change go down to true
                if (CODER == true)
                {
                    pcbplayer.Image = Properties.Resources.CDOWN1; // coder DOWN pic
                }
                if (TANK == true)
                {
                    pcbplayer.Image = Properties.Resources.TDOWN_1; // tank DOWN pic
                }
                if (QUINCY == true)
                {
                    pcbplayer.Image = Properties.Resources.QDOWN; // quincy DOWN pic
                }

            }
            // end of the down key selection

            if (e.KeyCode == Keys.Space)
            {

                space = true;
            }
           
        }
        private void keyisup(object sender, KeyEventArgs e) // KEYUP SELELCTIONS FOR W/A/S/D/SPACE 
        {
            //================================================
            //  TITLE- KEYISUP                              ||
            //  PURPOSE- TO SET THE UP SELECTION OF KEYS    ||
            //      > W = UP                                ||
            //      > A = LEFT                              ||
            //      > D = RIGHT                             ||
            //      > S = DOWN                              ||
            //================================================
            if (gameOver) return; // if game is over then do nothing in this event

            // UP SELECTION FOR THE LEFT KEY
            if (e.KeyCode == Keys.A)
            {
                goleft = false; // change the go left boolean to false
            }

            // UP SELECTION FOR THE RIGHT KEY
            if (e.KeyCode == Keys.D)
            {
                goright = false; // change the go right boolean to false
            }
            // UP SELECTION FOR THE UP KEY
            if (e.KeyCode == Keys.W)
            {
                goup = false; // change the go up boolean to false
            }
            // UP SELECTION FOR THE DOWN KEY
            if (e.KeyCode == Keys.S)
            {
                godown = false; // change the go down boolean to false
            }

            //below is the key up selection for the space key
            if (e.KeyCode == Keys.Space) // in this if statement we are checking if the space bar is up and ammo is more than 0
            {
                space = false;
            }
        }
        private void DropAmmo() // DROPS AMMO REFILL WHEN PLAYER RUNS OUT OF BULLETS 
        {
            //=========================================
            //  TITLE- DROP AMMO                     ||
            //  PURPOSE > CREATE AMMO PICTUREBOX     ||
            //          > SET PROPERTIES             ||
            //          > DETERMINE RANDOM LOCATION  ||
            //            TO DROM AMMO BOX           ||
            //=======================================||

            //CREATE PICTURE BOX AND SET PROPERTIES
            
            pcbammo.Image = Properties.Resources.ammo_Image;
            pcbammo.SizeMode = PictureBoxSizeMode.AutoSize;
            pcbammo.Tag = "ammo"; // set the tag to ammo 

            //DETERMINE RANDOM DROP LOCATION
            pcbammo.Left = rnd.Next(10, 890);
            pcbammo.Top = rnd.Next(50, 600);
            this.Controls.Add(pcbammo); // add the ammo picture box to the screen

            //bring ammo and player to front for safety
            pcbammo.BringToFront();
            pcbplayer.BringToFront();

            pcbammoX = pcbammo.Location.X;
            
        }     
        public void generateBlimps() // CREATE BLIMPS FOR PLAYER TO SHOOT DOWN 
        {
            //===============================================
            //  TITLE- GENERATE BLIMPS                     ||
            //  PURPOSE > CREATE  PICTUREBOX FOR BLIMPS    ||
            //          > SET PROPERTIES                   ||
            //          > DETERMINE RANDOM LOCATION TODROP ||
            //=============================================||

            blimp = new PictureBox[intlevel];//How many blimps show up depends on the level ==> Can be 1/2/3

            for (int i = 0; i < blimp.Length; i++)
            {

                //CREATE AND SET PROPERTIES FOR PICTUREBOX BLIMPS
                blimp[i] = new PictureBox();
                blimp[i].Tag = "blimp";
                blimp[i].Image = Properties.Resources.zdown;
                blimp[i].SizeMode = PictureBoxSizeMode.Zoom;
                blimp[i].BackColor = Color.Transparent;
                //DROP BLIMPS AT RANDOM LOCATION
                blimp[i].Left = rnd.Next(0, 900);
                blimp[i].Top = rnd.Next(0, 800);

                this.Controls.Add(blimp[i]); // add the picture box to the screen
                pcbplayer.BringToFront();
            }
        }
        private void gameEngine(object sender, EventArgs e) //gameTimer 
        {
            //============================================================================
            //  TITLE- GAMEENGINE                                                       ||
            //  EVENT- TICK                                                             ||
            //  PURPOSE- THIS IS THE ACTUAL TIMER OF THE GAME, JUST NAMED DIFFERENTLY   ||
            //          > TO UPDATE PLAYER HEALTH AND CHEACK IF GAME IS OVER            ||
            //          > TO UPDATE SCORE AND AMMO                                      ||
            //          > TO MOVE PLAYER                                                ||
            //          > TO SHOOT WITH SPACE BAR, THEN RELOAD                          ||
            //          > TO CHECK IF PLAYER PICKS UP AMMO                              ||
            //          > TO CHECK IF PLAYER COLLIDES WITH BLIMP                        ||
            //          > TO CHECK IF BULLET HITS BLIMP                                 ||
            //          > TO MOVE BLIMP TOWARDS THE PLAYER BASED ON LOCAITON            ||
            //          > RESTRICT BULLET MOVEMENT                                      ||
            //============================================================================          

            gameover();
            math();//Math function
            
            if (pcbammo.Tag =="ammo")
            {
                pcbammo.Location = new Point(pcbammoX, (int)pcbammoY);
                pcbammoX++;
            }
            lblAMMO.Text = "   Ammo:  " + ammo; // show ammo amount 
            lblSCORE.Text = "SCORE: " + score; // show score

            // PLAYER MOVEMENT
            if (goleft == true && pcbplayer.Left > 0)
            {
                pcbplayer.Left -= intspeed;
                // if moving left is true AND PLAYER is 1 pixel more from the left 
                // then move the player to the LEFT
            }
            if (goright == true && pcbplayer.Left + pcbplayer.Width < 930)
            {
                pcbplayer.Left += intspeed; // if moving RIGHT is true AND player left + player width is less than 930 pixels 
                                         // then move the player to the RIGHT 
            }
            if (goup == true && pcbplayer.Top > 60)
            {
                pcbplayer.Top -= intspeed;
                // if moving TOP is true AND player is 60 pixel more from the top 
                // then move the player to the UP
            }

            if (godown == true && pcbplayer.Top + pcbplayer.Height < 700)
            {
                pcbplayer.Top += intspeed;
                // if moving DOWN is true AND player top + player height is less than 700 pixels
                // then move the player to the DOWN
            }
            if (space == true && ammo > 0) // in this if statement we are checking if the space bar is up and ammo is more than 0
            {
                ammo--; // reduce ammo by 1 from the total number
                shoot(facing); // invoke the shoot function with the facing string inside it
                               //facing will transfer up, down, left or right to the function and that will shoot the bullet that way. 

                if (ammo < 1) // if ammo is less than 1 { DROM AMMO }
                    DropAmmo(); // invoke the drop ammo function 
            }
            //if player picks up ammo
            // if the bullets hits the 4 borders of the game
            // below is the if statement which will be checking if the player hits a zombie
            //if zombie is killed
            {
                foreach (Control x in this.Controls)
                {
                    // if the X is a picture box and X has a tag AMMO

                    if (x is PictureBox && x.Tag == "ammo")
                    {
                        // check is X in hitting the player picture box

                        if (((PictureBox)x).Bounds.IntersectsWith(pcbplayer.Bounds))
                        {
                            // once the player picks up the ammo

                            this.Controls.Remove(((PictureBox)x)); // remove the ammo picture box

                            ((PictureBox)x).Dispose(); // dispose the picture box completely from the program
                            ammo += 5; // add 5 ammo to the integer
                        }
                    }

                    // if the bullets hits the 4 borders of the game
                    // if x is a picture box and x has the tag of bullet

                    if (x is PictureBox && x.Tag == "bullet")
                    {
                        // if the bullet is less the 1 pixel to the left
                        // if the bullet is more then 930 pixels to the right
                        // if the bullet is 10 pixels from the top
                        // if the bullet is 700 pixels to the buttom

                        if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                        {
                            this.Controls.Remove(((PictureBox)x)); // remove the bullet from the display
                            ((PictureBox)x).Dispose(); // dispose the bullet from the program
                        }
                    }

                    // below is the if statement which will be checking if the player hits a zombie


                    if (x is PictureBox && x.Tag == "blimp")
                    {

                        // below is the if statament thats checking the bounds of the player and the zombie

                        if (((PictureBox)x).Bounds.IntersectsWith(pcbplayer.Bounds))
                        {
                            dblplayerHealth -= 1; // if the zombie hits the player then we decrease the health by 1
                        }

                        //move zombie towards the player picture box

                        if (((PictureBox)x).Left > pcbplayer.Left)
                        {
                            ((PictureBox)x).Left -= intblimpintspeed; // move zombie towards the left of the player
                            ((PictureBox)x).Image = Properties.Resources.zleft; // change the zombie image to the left
                        }

                        if (((PictureBox)x).Top > pcbplayer.Top)
                        {
                            ((PictureBox)x).Top -= intblimpintspeed; // move zombie upwards towards the players top
                            ((PictureBox)x).Image = Properties.Resources.zup; // change the zombie picture to the top pointing image
                        }
                        if (((PictureBox)x).Left < pcbplayer.Left)
                        {
                            ((PictureBox)x).Left += intblimpintspeed; // move zombie towards the right of the player
                            ((PictureBox)x).Image = Properties.Resources.zright; // change the image to the right image
                        }
                        if (((PictureBox)x).Top < pcbplayer.Top)
                        {
                            ((PictureBox)x).Top += intblimpintspeed; // move the zombie towards the bottom of the player
                            ((PictureBox)x).Image = Properties.Resources.zdown; // change the image to the down zombie
                        }
                    }

                    // below is the second for loop, this is nexted inside the first one
                    // the bullet and zombie needs to be different than each other
                    // then we can use that to determine if the hit each other

                    foreach (Control j in this.Controls)
                    {
                        // below is the selection thats identifying the bullet and zombie

                        if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "blimp"))
                        {
                            // below is the if statement thats checking if bullet hits the zombie
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++; // increase the kill score by 1 
                                this.Controls.Remove(j); // this will remove the bullet from the screen
                                j.Dispose(); // this will dispose the bullet all together from the program
                                this.Controls.Remove(x); // this will remove the zombie from the screen
                                x.Dispose(); // this will dispose the zombie from the program
                                generateBlimps(); // this function will invoke the make zombies function to add another zombie to the game
                            }
                        }
                    }
                }
            }

           
        }
        public void gameover()
        {
            //=====================================================
            //  CHECKS TO SEE IF PLAYER DIES TO DISPLAY GAMEOVER  |
            //=====================================================


            // if player health is greater than 1
            if (dblplayerHealth > 1)
            {
                progressBar1.Value = Convert.ToInt32(dblplayerHealth); // assign the progress bar to the player health integer
            }

            // if the player health is less than 20
            if (dblplayerHealth < 20)
            {
                progressBar1.ForeColor = Color.Red; // change the progress bar colour to red. 

            }

            // if the player health is less than 1
            if (dblplayerHealth == 2)
            {
                dblplayerHealth = -99;
                pcbplayer.Image = Properties.Resources.DISAPPOINT;
                pcbplayer.BringToFront();
                MessageBox.Show("LOL you died");
                gametmr.Stop(); // stop timer
                gameOver = true;
                HIGH_SCORE.SCORE = score; //send score to high score form to update text file
                HIGH_SCORE HS = new HIGH_SCORE();
                HS.Show();
                this.Hide();
            }     
            
        }
        public void shoot(string direct) // MAKES BULLETS FROM THE BULLET CLASS
        {
            //===============================================================
            //  TITLE- SHOOT                                               ||
            //  PURPOSE- MAKES BULLETS IN THE GAME FROM THE BULLET CLASS   ||
            //  DATE- 18 JANUARY, 2020                                     ||
            //===============================================================

            bullet shoot = new bullet(); // create a new instance of the bullet class
            shoot.direction = direct; // assignment the direction to the bullet
            shoot.bulletLeft = pcbplayer.Left + (pcbplayer.Width / 2); // position bullet to left half of the player
            shoot.bulletTop = pcbplayer.Top + (pcbplayer.Height / 2); // position bullet on top half of the player
            shoot.mkBullet(this); // run the function mkBullet from the bullet class.
        }
        public void math()
        {
            pcbammoY = Math.Sin((double)pcbammoX);
            
        }

        
    }
}
