using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            //change the message in the output label
            outputLabel.Text = "Meltdown Imminent";

            //change the colour of the state labels
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            
        }
        

    }
}
