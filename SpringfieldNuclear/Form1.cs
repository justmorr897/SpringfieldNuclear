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


namespace SpringfieldNuclear
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Alert);
            player.Play();

            outputLabel.Text = "Meltdown imminent";
            enableButton.Text = "We gonna die";

            radiationLabel.Visible = true;

            outputLabel.BackColor = Color.Red;

            //for loop for changing back and forth
            for (int i = 0; i < 5; i++)
            {
                reactor1StateLabel.BackColor = Color.Red;
                reactor2StateLabel.BackColor = Color.Red;

                iconLabel1.Visible = true;
                iconLabel2.Visible = true;

                Refresh();
                Thread.Sleep(500);

                reactor1StateLabel.BackColor = Color.White;
                reactor2StateLabel.BackColor = Color.White;

                iconLabel1.Visible= false;
                iconLabel2.Visible= false;

                Refresh();
                Thread.Sleep(500);
               
            } //end of for loop

            reactor1StateLabel.BackColor = Color.Lime;
            reactor2StateLabel.BackColor = Color.Lime;

            outputLabel.BackColor= Color.White;

            outputLabel.Text = "Reactors Stable";
            enableButton.Text = "Start Reactor";

            radiationLabel.Visible= false;

           

        }

        private void background_Load(object sender, EventArgs e)
        {

        }
    }
}
