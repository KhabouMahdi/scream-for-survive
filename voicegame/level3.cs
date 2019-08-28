using NAudio.CoreAudioApi;
using NAudio.Wave;
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

namespace voicegame
{
    public partial class level3 : Form
    {
        public int voice;
        SoundPlayer win = new SoundPlayer(@"Resources\win.wav");
        SoundPlayer loss = new SoundPlayer(@"Resources\loss.wav");
        bool choix = true;//choix du champion pigeon or ur img
        bool crier = true;//calmly or loudly 

        public level3()
        {
            InitializeComponent();
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            comboBox1.SelectedIndex = 0;

            var waveIn = new WaveInEvent();//pour activer micro
            waveIn.StartRecording();//pour activer micro

        }

        private void level3_Load(object sender, EventArgs e)
        {

        }
        void movehurdle()
        {
            if (h1.Left > 0)
            { h1.Left += -2; }
            else
            { h1.Left = 1800; }

            if (h2.Left > 0)
            { h2.Left += -2; }
            else
            { h2.Left = 1800; }

            if (h3.Left > 0)
            { h3.Left += -2; }
            else
            { h3.Left = 1800; }

            if (hbullet.Left > 0)
            { hbullet.Left += -3;
                hbullet.Top +=-2;
            }
            else
            { hbullet.Left = 800;
                hbullet.Top = 500;
            }

            if (hhunter.Left > 0)
            { hhunter.Left += -2; }
            else
            { hhunter.Left = 800; }

            if (hEagle.Left > 0)
            { hEagle.Left += -7; }
            else
            { hEagle.Left = 15000; }

            if (hfinal.Left > 0)
            { hfinal.Left += -2; }
            else
            { hfinal.Left = 15000; }
        }
        void gameover()
        {if (choix)
            {
                if (htop.Bounds.IntersectsWith(hPigeon.Bounds))
                {
                    hPigeon.Top = 30;
                }
                if (hfinal.Bounds.IntersectsWith(hPigeon.Bounds))
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    win.Play();
                    var result = MessageBox.Show("Congratulation you passed level 3 , so you want to play again ?(level4 not ready yet ,level 4 under work ", "well play", MessageBoxButtons.YesNo);
                    //  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Hide();
                        level1 lv = new level1();
                        lv.Show();

                        // cancel the closure of the form.
                    }
                    else
                    {
                        panel1.Visible = true;

                    }
                }
                if (h1.Bounds.IntersectsWith(hPigeon.Bounds) || h2.Bounds.IntersectsWith(hPigeon.Bounds) ||
                    h3.Bounds.IntersectsWith(hPigeon.Bounds) || hbas.Bounds.IntersectsWith(hPigeon.Bounds) ||
                    hhunter.Bounds.IntersectsWith(hPigeon.Bounds) || hbullet.Bounds.IntersectsWith(hPigeon.Bounds) ||
                    hEagle.Bounds.IntersectsWith(hPigeon.Bounds) || hbullet.Bounds.IntersectsWith(hPigeon.Bounds)
                    )
                {
                    timer1.Stop();
                    timer2.Stop();
                    loss.Play();

                    lbgameover2.Visible = true;
                }
            }
        else
            {
                if (htop.Bounds.IntersectsWith(hYourImg.Bounds))
                {
                    hYourImg.Top = 30;
                }
                if (hfinal.Bounds.IntersectsWith(hYourImg.Bounds))
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    win.Play();
                    var result = MessageBox.Show("Congratulation you passed level 3 , so you want to play again ?(level4 not ready yet ,level 4 under work ", "well play", MessageBoxButtons.YesNo);
                    //  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Hide();
                        level1 lv = new level1();
                        lv.Show();

                        // cancel the closure of the form.
                    }
                    else
                    {
                        panel1.Visible = true;

                    }
                }
                if (h1.Bounds.IntersectsWith(hYourImg.Bounds) || h2.Bounds.IntersectsWith(hYourImg.Bounds) ||
                    h3.Bounds.IntersectsWith(hYourImg.Bounds) || hbas.Bounds.IntersectsWith(hYourImg.Bounds) ||
                    hhunter.Bounds.IntersectsWith(hYourImg.Bounds) || hbullet.Bounds.IntersectsWith(hYourImg.Bounds) ||
                    hEagle.Bounds.IntersectsWith(hYourImg.Bounds) || hbullet.Bounds.IntersectsWith(hYourImg.Bounds)
                    )
                {
                    timer1.Stop();
                    timer2.Stop();
                    loss.Play();

                    lbgameover2.Visible = true;
                }




            }
         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var selected = (MMDevice)comboBox1.SelectedItem;
                selected.AudioEndpointVolume.Mute = false;
                voice = (int)(selected.AudioMeterInformation.MasterPeakValue * 100 );
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (crier)
                {
                    if (choix)
                    {
                        if (voice > 5)
                        {
                            hPigeon.Top += -3;
                        }
                        else
                        {
                            if (voice < 1000)
                                hPigeon.Top += 2;
                        }
                        movehurdle();
                        gameover();
                    }
                    else
                    {
                        if (voice > 5)
                        {
                            hYourImg.Top += -3;
                        }
                        else
                        {
                            if (voice < 1000)
                                hYourImg.Top += 2;
                        }
                        movehurdle();
                        gameover();

                    }
                }
                else
                {
                    if (choix)
                    {
                        if (voice > 20)
                        {
                            hPigeon.Top += -3;
                        }
                        else
                        {
                            if (voice < 1000)
                                hPigeon.Top += 2;
                        }
                        movehurdle();
                        gameover();
                    }
                    else
                    {
                        if (voice > 20)
                        {
                            hYourImg.Top += -3;
                        }
                        else
                        {
                            if (voice < 1000)
                                hYourImg.Top += 2;
                        }
                        movehurdle();
                        gameover();

                    }
                }
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;

            lbgameover2.Visible = false;
            h1.Left = 1000;
            h2.Left = 1200;
            h3.Left = 1400;
             hbullet.Left =775;
              hbullet.Top = 500;

            hhunter.Left = 800;

             hEagle.Left = 1500;
            hbas.Top = 900;
            htop.Top = 0;
            hfinal.Left = 3800;
            hPigeon.Top = 50;
           hEagle.Visible = true;
            hbullet.Visible = true;
            System.Threading.Thread.Sleep(1000);



            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void htop_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {if (choix)
            {
                panel1.Visible = false;

                timer1.Enabled = false;
                timer2.Enabled = false;

                lbgameover2.Visible = false;
                h1.Left = 1000;
                h2.Left = 1200;
                h3.Left = 1400;
                hbullet.Left = 775;
                hbullet.Top = 500;

                hhunter.Left = 800;

                hEagle.Left = 1500;
                hbas.Top = 900;
                htop.Top = 0;
                hfinal.Left = 3800;
                hPigeon.Top = 50;
                hEagle.Visible = true;
                hbullet.Visible = true;
                System.Threading.Thread.Sleep(1000);



                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                panel1.Visible = false;

                timer1.Enabled = false;
                timer2.Enabled = false;

                lbgameover2.Visible = false;
                h1.Left = 1000;
                h2.Left = 1200;
                h3.Left = 1400;
                hbullet.Left = 775;
                hbullet.Top = 500;

                hhunter.Left = 800;

                hEagle.Left = 1500;
                hbas.Top = 900;
                htop.Top = 0;
                hfinal.Left = 3800;
                hYourImg.Top = 50;
                hEagle.Visible = true;
                hbullet.Visible = true;
                System.Threading.Thread.Sleep(1000);



                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void lbgameover2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lbgameover2.Visible = false;


        }

        private void btnYourImg_Click(object sender, EventArgs e)
        {
            btnYourImg.BackColor = Color.Tan;
            btnPigean.BackColor = Color.White;

            if (choix)
            {
                choix = false;
                hYourImg.Visible = true;
                hPigeon.Visible = false;

            }
            String imageLocation = "";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imageLocation = opf.FileName;
                hYourImg.ImageLocation = imageLocation;
                hanyimg.ImageLocation = imageLocation;
            }

        }

        private void btnPigean_Click(object sender, EventArgs e)
        {
            btnPigean.BackColor = Color.Tan;
            btnYourImg.BackColor = Color.White;

            if (choix == false)
            {
                choix = true;
                hPigeon.Visible = true;
                hYourImg.Visible = false;


            }
        }

        private void btnScQui_Click(object sender, EventArgs e)
        {
            btnScrLoud.BackColor = Color.White;
            btnScQui.BackColor = Color.Tan;
            crier = true;
        }

        private void btnScrLoud_Click(object sender, EventArgs e)
        {
            btnScrLoud.BackColor = Color.Tan;
            btnScQui.BackColor = Color.White;

            crier = false;
        }
    }
}
