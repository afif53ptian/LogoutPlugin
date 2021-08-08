using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grimoire.Game;

namespace ExamplePacketPlugin
{
    public partial class Main : Form
    {
        public static Main Instance { get; } = new Main();
        Stopwatch stopwatch = new Stopwatch();
        int logCount = 0;
        bool isRunning = false;

        public Main()
        {
            InitializeComponent();
        }

        private async void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnable.Checked)
            {
                timer.Enabled = true;
                stopwatch.Stop();
                stopwatch.Reset();
                disableUI();
            }
            else if(!cbEnable.Checked)
            {
                timer.Enabled = false;
                stopwatch.Reset();
                enableUI();
            }

            if (isRunning) return;
            isRunning = true;

            while (cbEnable.Checked)
            {
                while(!Player.IsLoggedIn)
                {
                    await Task.Delay(1500);
                }

                int sec = ((int)numSS.Value) + ((int)numMM.Value * 60) + ((int)numHH.Value * 3600);
                long msec = (long)sec * 1000;

                stopwatch.Reset();
                stopwatch.Start();

                while (stopwatch.Elapsed.TotalMilliseconds < msec && cbEnable.Checked)
                {
                    await Task.Delay(1000);


                    if (!Player.IsLoggedIn)
                    {
                        logCount++;
                        tbLog.Text += $"[{logCount}] oof? {lbTimer.Text}\r\n";
                        break;
                    }
                }

                if (Player.IsLoggedIn && cbEnable.Checked)
                {
                    logCount++;
                    tbLog.Text += $"[{logCount}] saved {lbTimer.Text}\r\n";
                    Player.Logout();
                }

                stopwatch.Stop();
            }

            isRunning = false;
        }

        private void disableUI()
        {
            numHH.Enabled = false;
            numMM.Enabled = false;
            numSS.Enabled = false;
        }

        private void enableUI()
        {
            numHH.Enabled = true;
            numMM.Enabled = true;
            numSS.Enabled = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            tbLog.SelectionStart = tbLog.TextLength;
            tbLog.ScrollToCaret();
        }

        int temptbLogSize;
        private void lblHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(tbLog.Visible)
            {
                lblHide.Text = "[Show]";
                temptbLogSize = tbLog.Height;
                this.ClientSize = new System.Drawing.Size(ClientSize.Width, ClientSize.Height - tbLog.Height - 10 - 12);
                tbLog.Visible = false;
                lblClearLog.Visible = false;
            }
            else if(!tbLog.Visible)
            {
                lblHide.Text = "[Hide]";
                this.ClientSize = new System.Drawing.Size(ClientSize.Width, ClientSize.Height + temptbLogSize + 10 + 12);
                tbLog.Visible = true;
                lblClearLog.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = string.Format("({0:hh\\:mm\\:ss})", stopwatch.Elapsed);
        }

        private void lblClearLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.logCount = 0;
            tbLog.Text = String.Empty;
        }
    }
}
