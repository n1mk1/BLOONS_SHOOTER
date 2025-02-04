using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BLOONS_Wasti
{
    class bullet
    {     
        public string direction; 
        public int intspeed = 20; //bulletspeed
        PictureBox Bullet = new PictureBox(); // create a picture box 
        Timer SHOOTIMER = new Timer(); // create a new timer called tm. 

        public int bulletLeft;
        public int bulletTop;
        public void mkBullet(GAME form)
        {           
            // CALLED FROM THE BLOONS CLASS

            Bullet.BackColor = System.Drawing.Color.White; 
            Bullet.Size = new Size(10, 10);
            Bullet.Tag = "bullet"; // set the tag to bullet
            Bullet.Left = bulletLeft; // set bullet left 
            Bullet.Top = bulletTop; // set bullet right
            Bullet.BringToFront(); // bring the bullet to front of other objects
            form.Controls.Add(Bullet); // add the bullet to the screen

            SHOOTIMER.Interval = intspeed; // set the timer interval to intspeed
            SHOOTIMER.Tick += new EventHandler(SHOOTIMER_Tick); // TIMER TICK EVENT
            SHOOTIMER.Start(); // start the timer

        }

        public void SHOOTIMER_Tick(object sender, EventArgs e)
        {
            // IF DIRECTION IS LEFT
            if (direction == "left")
            {
                Bullet.Left -= intspeed; // move bullet towards the left 
            }
            // IF DIRECTION IS RIGHT
            if (direction == "right")
            {
                Bullet.Left += intspeed; // move bullet towards the right 
            }
            // IF DIRECTION IS UP
            if (direction == "up")
            {
                Bullet.Top -= intspeed; // move the bullet towards top 
            }
            // IF DIRECTION IS DOWN
            if (direction == "down")
            {
                Bullet.Top += intspeed; // move the bullet bottom 
            }

            
            // THE FOLLOWING CODE EXECUTES IF THE BULLETS GETS TOO CLOSE TO THE BORDERS OF THE SCREEN
            if (Bullet.Left < 16 || Bullet.Left > 860 || Bullet.Top < 10 || Bullet.Top > 616)
            {
                SHOOTIMER.Stop(); // stop the timer
                SHOOTIMER.Dispose(); // dispose the timer event 
                Bullet.Dispose(); // dispose the bullet
                SHOOTIMER = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
        }

    }
}
