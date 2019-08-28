using NAudio.CoreAudioApi;
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
using System.Diagnostics;
using NAudio.Wave;
using System.Media;

namespace voicegame
{
    public partial class level2 : Form
    {
        SoundPlayer win = new SoundPlayer(@"Resources\win.wav");
        SoundPlayer loss = new SoundPlayer(@"Resources\loss.wav");
        public int voice;
        bool choix = true;//choix du champion pigeon or ur img
        bool crier = true;//calmly or loudly 


        public level2()
        {
            InitializeComponent();
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            comboBox2.Items.AddRange(devices.ToArray());
            comboBox2.SelectedIndex = 0;


            var waveIn = new WaveInEvent();//pour activer micro
            waveIn.StartRecording();//pour activer micro

        }

        private void hfinal_Click(object sender, EventArgs e)
        {

        }

        private void level2_Load(object sender, EventArgs e)
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

            if (h4.Left > 0)
            { h4.Left += -2; }
            else
            { h4.Left = 1600; }

            if (h5.Left > 0)
            { h5.Left += -2; }
            else
            { h5.Left = 1600; }


           /* if (heagle.Left > 0)
            { heagle.Left += -5; }
            else
            { heagle.Left = 9000; }
            */
            if (hfinal.Left > 0)
            { hfinal.Left += -2; }
            else
            { hfinal.Left = 5000; }

         /*   if (hhunter.Left > 0)
            { hhunter.Left += -2; }
            else
            { hhunter.Left = 8000; }

            if (hbullet.Left > 0 /*&& hbullet.Top>)
            { hbullet.Left += 1;
               hbullet.Top += -2;
            }
            else
            { hbullet.Left = 8000;
               // hbullet.Top = 400;
            } 
            */
        }
        void gameover()
        {
            if (choix)
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
                    var result = MessageBox.Show("Congratulation you passed level 2 , so you want to go next level ?", "well play", MessageBoxButtons.YesNo);
                    //  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Hide();
                        level3 lv = new level3();
                        lv.Show();

                        // cancel the closure of the form.
                    }
                    else
                    {
                        panel1.Visible = true;

                    }
                }
                if (h1.Bounds.IntersectsWith(hPigeon.Bounds) || h2.Bounds.IntersectsWith(hPigeon.Bounds) ||
                    h3.Bounds.IntersectsWith(hPigeon.Bounds) || hba2.Bounds.IntersectsWith(hPigeon.Bounds) ||
                    h4.Bounds.IntersectsWith(hPigeon.Bounds) || h5.Bounds.IntersectsWith(hPigeon.Bounds))


                {
                    timer1.Stop();
                    timer2.Stop();

                    lblGameover.Visible = true;
                    loss.Play();

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
                    var result = MessageBox.Show("Congratulation you passed level 2 , so you want to go next level ?", "well play", MessageBoxButtons.YesNo);
                    //  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Hide();
                        level3 lv = new level3();
                        lv.Show();

                        // cancel the closure of the form.
                    }
                    else
                    {
                        panel1.Visible = true;

                    }
                }
                if (h1.Bounds.IntersectsWith(hYourImg.Bounds) || h2.Bounds.IntersectsWith(hYourImg.Bounds) ||
                    h3.Bounds.IntersectsWith(hYourImg.Bounds) || hba2.Bounds.IntersectsWith(hYourImg.Bounds) ||
                    h4.Bounds.IntersectsWith(hYourImg.Bounds) || h5.Bounds.IntersectsWith(hYourImg.Bounds))


                {
                    timer1.Stop();
                    timer2.Stop();

                    lblGameover.Visible = true;
                    loss.Play();

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                var selected = (MMDevice)comboBox2.SelectedItem;
                selected.AudioEndpointVolume.Mute = false;
                voice = (int)(selected.AudioMeterInformation.MasterPeakValue * 100 );
                progressBar2.Value = voice;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
            timer2.Enabled = false;
           
            lblGameover.Visible = false;
            h1.Left = 1000;
            h2.Left = 1200;
            h3.Left = 1400;
            h4.Left = 2000;
            h5.Left = 2000;
           // hbullet.Left =280;
          //  hbullet.Top = 400;

            //hhunter.Left = 180;

          //  heagle.Left = 1500;
            hbas.Top = 900;
            htop.Top = 0;
            hfinal.Left = 5000;
            hPigeon.Top = 50;
           // lblgo.Visible = true;
            
           System.Threading.Thread.Sleep(1000);



            timer1.Enabled = true;
            timer2.Enabled = true;


        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (choix)
            {
                panel1.Visible = false;
                timer1.Enabled = true;
                timer2.Enabled = true;
                lblGameover.Visible = false;
                h1.Left = 1000;
                h2.Left = 1200;
                h3.Left = 1400;
                h4.Left = 2000;
                h5.Left = 2000;
                hbas.Top = 900;
                htop.Top = 0;
                hfinal.Left = 5000;
                hPigeon.Top = 50;

            }
            else
            {
                hPigeon.Visible = false;
                panel1.Visible = false;
                timer1.Enabled = true;
                timer2.Enabled = true;
                lblGameover.Visible = false;
                hYourImg.Visible = true;
                h1.Left = 1000;
                h2.Left = 1200;
                h3.Left = 1400;
                h4.Left = 2000;
                h5.Left = 2000;
                hbas.Top = 900;
                htop.Top = 0;
                hfinal.Left = 5000;
                hYourImg.Top = 50;

            }
        }

        private void lblGameover_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblGameover.Visible = false;
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
