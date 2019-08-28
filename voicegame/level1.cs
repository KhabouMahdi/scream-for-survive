using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace voicegame
{
    public partial class level1 : Form
    {
        SoundPlayer win = new SoundPlayer(@"Resources\win.wav");
        SoundPlayer loss = new SoundPlayer(@"Resources\loss.wav");
        


        bool choix = true;//choix du champion pigeon or ur img
        bool crier = true;//calmly or loudly 
        public int voice;

        public level1()
        {
            InitializeComponent();
            btnPigean.BackColor = Color.Tan;


            MMDeviceEnumerator en = new MMDeviceEnumerator();

             var devices = en.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.All);
             comboBox1.Items.AddRange(devices.ToArray());
            comboBox1.SelectedIndex = 0;

           var waveIn = new WaveInEvent();//pour activer micro
            waveIn.StartRecording();//pour activer micro

        }
     


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void movehurdle() {//mouvemet des obj-img
        if (h1.Left>0)
            { h1.Left += -2; }
        else
            { h1.Left = 3000; }

            if (h2.Left > 0)
            { h2.Left += -2; }
            else
            { h2.Left = 3000; }

            if (h3.Left > 0)
            { h3.Left += -2; }
            else
            { h3.Left = 3000; }


            if (hfinal.Left > 0)
            { hfinal.Left += -2; }
            else
            { hfinal.Left = 5000; }

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
                    var result = MessageBox.Show("Congratulation you passed level 1 , so you want to go next level ?", "well play", MessageBoxButtons.YesNo);
                    //  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Hide();
                        level2 lv = new level2();
                        lv.Show();

                        // go next level 
                    }
                    else
                    {
                        panel1.Visible = true;
                        //play again
                    }
                }
                if (h1.Bounds.IntersectsWith(hPigeon.Bounds) || h2.Bounds.IntersectsWith(hPigeon.Bounds) ||
                    h3.Bounds.IntersectsWith(hPigeon.Bounds) || hbas.Bounds.IntersectsWith(hPigeon.Bounds))
                {
                    timer1.Stop();
                    timer2.Stop();

                    lblgameover.Visible = true;
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
                
                    var result = MessageBox.Show("Congratulation you passed level 1 , so you want to go next level ?", "well play", MessageBoxButtons.YesNo);
                    //  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Hide();
                        level2 lv = new level2();
                        lv.Show();
                    }
                    else
                    {
                        panel1.Visible = true;

                    }
                }
                if (h1.Bounds.IntersectsWith(hYourImg.Bounds) || h2.Bounds.IntersectsWith(hYourImg.Bounds) ||
                    h3.Bounds.IntersectsWith(hYourImg.Bounds) || hbas.Bounds.IntersectsWith(hYourImg.Bounds))
                {
                    timer1.Stop();
                    timer2.Stop();

                    lblgameover.Visible = true;
                    loss.Play();


                }


            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
              }

        private void timer1_Tick(object sender, EventArgs e)//pour mouver mon champ
        {
             if (comboBox1.SelectedItem != null)
              {
                  var selected = (MMDevice)comboBox1.SelectedItem;
               //   voice = (int)(Math.Round(selected.AudioMeterInformation.MasterPeakValue * 100));
                  voice = (int)(selected.AudioMeterInformation.MasterPeakValue * 100);

                  progressBar1.Value = voice;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)//pour mouver les img-obj
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

        private void v_Click(object sender, EventArgs e)
        {

        }

        private void lblgameover_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lblgameover.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      /*  private void btnhmema_Click(object sender, EventArgs e)
        {
            if( choix)
            {
                choix = false;
            }
        }*/

     /*   private void btnbird_Click(object sender, EventArgs e)
        {
            if (choix==false)
            {
                choix = true;
            }
        }*/


     

        private void btnchoisrplayer_Click(object sender, EventArgs e)
        {
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

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (choix)
            {
                panel1.Visible = false;
                timer1.Enabled = true;
                timer2.Enabled = true;
                lblgameover.Visible = false;
                h1.Left = 1000;
                h2.Left = 1200;
                h3.Left = 1400;
                hbas.Top = 700;
                htop.Top = 0;
                hfinal.Left = 2000;
                hPigeon.Top = 50;

            }
            else
            {
                hPigeon.Visible = false;
                panel1.Visible = false;
                timer1.Enabled = true;
                timer2.Enabled = true;
                lblgameover.Visible = false;
                hYourImg.Visible = true;
                h1.Left = 1000;
                h2.Left = 1200;
                h3.Left = 1400;
                hbas.Top = 700;
                htop.Top = 0;
                hfinal.Left = 2000;
                hYourImg.Top = 50;

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
