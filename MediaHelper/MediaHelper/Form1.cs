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
using WMPLib;

namespace MediaHelper
{
    public partial class Form1 : Form
    {
        public string[] files;
        public string path; //@"C:\Users\SunRay\source\repos\MediaHelper\MediaHelper\Music"
        public WMPLib.WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        public int index = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            files = new string[0];
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            Music_listb.Items.Clear();
            Array.Clear(files, 0, files.Length);
            files = System.IO.Directory.GetFiles(path);
            int i = 0;
            while (i < files.Length)
            {
                Music_listb.Items.Add(files[i].Remove(0, path.Length + 1));
                i++;
            }
            Play_btn.Enabled = false;
            Pause_btn.Enabled = false;
            Stop_btn.Enabled = false;
            Next_btn.Enabled = false;
            Previous_btn.Enabled = false;
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (Music_listb.SelectedIndex != -1)
            {
                if (wmp.controls.currentItem == null)
                {
                    wmp.controls.stop();
                    index = Music_listb.SelectedIndex;
                    wmp.URL = files[Music_listb.SelectedIndex];
                    wmp.controls.play();
                }
                else
                {
                    index = Music_listb.SelectedIndex;
                    wmp.URL = files[Music_listb.SelectedIndex];
                    wmp.controls.play();
                }
                Playing_track.Text = Music_listb.Items[Music_listb.SelectedIndex].ToString();
            }
        }

        private void Music_listb_Click(object sender, EventArgs e)
        {
            if (Play_btn.Enabled == false && Music_listb.SelectedIndex != -1)
                Play_btn.Enabled = true;
        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }


        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (wmp.controls.currentItem != null && index != Music_listb.Items.Count - 1)
            {
                wmp.URL = files[++index];
                wmp.controls.play();
                Music_listb.SelectedIndex = index;
                Playing_track.Text = Music_listb.Items[Music_listb.SelectedIndex].ToString();
            }
        }

        private void Previous_btn_Click(object sender, EventArgs e)
        {
            if (wmp.controls.currentItem != null && index != 0)
            {
                wmp.URL = files[--index];
                wmp.controls.play();
                Music_listb.SelectedIndex = index;
                Playing_track.Text = Music_listb.Items[Music_listb.SelectedIndex].ToString();
            }
        }

        private void btnControl_Tick(object sender, EventArgs e)
        {
            if (index == Music_listb.Items.Count - 1 || wmp.playState == WMPPlayState.wmppsUndefined)
            {
                Next_btn.Enabled = false;
            }
            else Next_btn.Enabled = true;
            if (index == 0 || wmp.playState == WMPPlayState.wmppsUndefined)
            {
                Previous_btn.Enabled = false;
            }
            else Previous_btn.Enabled = true;
            //Music_listb_SelectedIndexChanged
            if (Music_listb.SelectedIndex != index)
            {
                Play_btn.Text = "Play";
            }
            else if (wmp.playState == WMPPlayState.wmppsPaused) Play_btn.Text = "Continue";
            else if (wmp.playState == WMPPlayState.wmppsStopped) Play_btn.Text = "Play";
            else if (wmp.playState == WMPPlayState.wmppsPlaying) Play_btn.Text = "Replay";
            //
            if (wmp.playState == WMPPlayState.wmppsPaused)
                Pause_btn.Enabled = false;
            else if (wmp.playState == WMPPlayState.wmppsStopped)
            {
                Stop_btn.Enabled = false;
                Pause_btn.Enabled = false;
            }
            else if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                Stop_btn.Enabled = true;
                Pause_btn.Enabled = true;
            }
            log.Text = wmp.playState.ToString();
        }

        private void Playing_track_Click(object sender, EventArgs e)
        {
            if (Playing_track.Text != "")
            {
                for (int i = 0; i < Music_listb.Items.Count; i++)
                {
                    if (Playing_track.Text == (string)Music_listb.Items[i])
                        Music_listb.SelectedIndex = i;
                }
            }
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            path = Path_tb.Text;
        }
    }
}
