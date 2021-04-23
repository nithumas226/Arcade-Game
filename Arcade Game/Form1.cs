using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Arcade_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelGo_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Changing background colour of form
            this.BackColor = Color.Blue;

            //Making button and labels not visible
            playButton.Visible = false;

            //Creating starting sound and playing
            SoundPlayer player = new SoundPlayer(Properties.Resources.start);
            player.Play();

            //Pausing Countdown
            Thread.Sleep(1000);
            
            //Making label visible
            countdownLabel3.Visible = true;

            //Making countdown sound
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.tick);
            player1.Play();

            //Pausing countdown
            Refresh();             
            Thread.Sleep(1000);

            //Making labels visible
            countdownLabel3.Visible = false;
            countdownLabel2.Visible = true;

            //Making countdown sound
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.tick);
            player1.Play();

            //Pausing Countdown
            Refresh();
            Thread.Sleep(1000);

            //Making labels visible
            countdownLabel2.Visible = false;
            labelCountdown1.Visible = true;

            //Making countdown sound
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.tick);
            player1.Play();

            //Pausing countdown
            Refresh();
            Thread.Sleep(1000);

            //Changing Form background
            this.BackColor = Color.Green;

            //Making labels visible
            labelCountdown1.Visible = false;
            labelGo.Visible = true;

            //Making end sound
            SoundPlayer player4 = new SoundPlayer(Properties.Resources.winning);
            player4.Play();




        }
    }
}
