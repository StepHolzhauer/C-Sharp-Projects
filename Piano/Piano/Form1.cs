using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
/*
 * Piano with autoplay function requieres sound files for keys
 */
namespace Piano
{
    public partial class Form1 : Form
    {
        string[] songArray;

        string[] song1Array = new string[]
        {
            "C", "D", "E", "F", "G", "G", "A", "A", "A", "A", "G", "A", "A", "A", "A", "G", "F", "F", "F", "F", "E", "E", "D", "D", "D", "D", "C" 
        };

        int arrayLength = 0;
        int currentLength = 0;
        int volumeLevel = 100;

        public Form1()
        {
            InitializeComponent();
        }

        public void songplayer()
        {
            foreach (string s in songArray)
            {
                arrayLength++;
            }
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            wplayerC.settings.volume = volumeLevel;
            wplayerC.URL = @"Sound/C.mp3";
            wplayerC.Ctlcontrols.play();
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            wplayerD.settings.volume = volumeLevel;
            wplayerD.URL = @"Sound/D.mp3";
            wplayerD.Ctlcontrols.play();
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            wplayerE.settings.volume = volumeLevel;
            wplayerE.URL = @"Sound/E.mp3";
            wplayerE.Ctlcontrols.play();
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            wplayerF.settings.volume = volumeLevel;
            wplayerF.URL = @"Sound/F.mp3";
            wplayerF.Ctlcontrols.play();
        }

        private void gButton_Click(object sender, EventArgs e)
        {
            wplayerG.settings.volume = volumeLevel;
            wplayerG.URL = @"Sound/G.mp3";
            wplayerG.Ctlcontrols.play();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            wplayerA.settings.volume = volumeLevel;
            wplayerA.URL = @"Sound/A.mp3";
            wplayerA.Ctlcontrols.play();
        }

        private void hButton_Click(object sender, EventArgs e)
        {
            wplayerH.settings.volume = volumeLevel;
            wplayerH.URL = @"Sound/H.mp3";
            wplayerH.Ctlcontrols.play();
        }

        private void c2Button_Click(object sender, EventArgs e)
        {
            wplayerC2.settings.volume = volumeLevel;
            wplayerC2.URL = @"Sound/C2.mp3";
            wplayerC2.Ctlcontrols.play();
        }

        private void playSong_Click(object sender, EventArgs e)
        {
            songArray=song1Array;
            songplayer();
            autoPlayTimer.Enabled = true;
            playSong.Enabled = false;
        }

        private void customPlaySong_Click(object sender, EventArgs e)
        {
            string[] Separators = {" "};
            songArray = customSongText.Text.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
            songplayer();
            autoPlayTimer.Enabled = true;
            customPlaySong.Enabled = false; 
        } 

        private void autoPlayTimer_Tick(object sender, EventArgs e)
        {
            if (currentLength < arrayLength)
            {
                switch (songArray[currentLength])
                {
                    case "C":
                        cButton.PerformClick();
                        currentLength++;
                        break;
                    case "D":
                        dButton.PerformClick();
                        currentLength++;
                        break;
                    case "E":
                        eButton.PerformClick();
                        currentLength++;
                        break;
                    case "F":
                        fButton.PerformClick();
                        currentLength++;
                        break;
                    case "G":
                        gButton.PerformClick();
                        currentLength++;
                        break;
                    case "A":
                        aButton.PerformClick();
                        currentLength++;
                        break;
                    case "H":
                        hButton.PerformClick();
                        currentLength++;
                        break;
                    case "C2":
                        c2Button.PerformClick();
                        currentLength++;
                        break;
                }
            }
            else
            {
                arrayLength = 0;
                currentLength = 0;
                playSong.Enabled = true;
                customPlaySong.Enabled = true;
                autoPlayTimer.Enabled = false;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            volumeLevel = Convert.ToInt32(numericUpDown1.Value);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
