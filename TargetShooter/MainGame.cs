using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using TargetShooter.UserControls;

namespace TargetShooter
{
    public partial class MainGame : Form
    {
        int points = 0;
        Timer mainTimer;
        Timer cleanupTimer;
        Random random = new Random();

        public MainGame()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            SetupTimers();
        }

        private void SetupTimers()
        {
            mainTimer = new Timer();
            mainTimer.Interval = 2000;
            mainTimer.Tick += MainTimer_Tick;
            mainTimer.Start();

            cleanupTimer = new Timer();
            cleanupTimer.Interval = 5000;
            cleanupTimer.Tick += CleanupTimer_Tick;
            cleanupTimer.Start();
        }

        private void CleanupTimer_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            var x = random.Next(Screen.PrimaryScreen.Bounds.Width - target1.Width);
            var y = random.Next(Screen.PrimaryScreen.Bounds.Height - target1.Height);
            target1.Location = new Point(x, y);

            for (int i = 0; i < 3; i++)
            {
                var x_bomb = random.Next(Screen.PrimaryScreen.Bounds.Width);
                var y_bomb = random.Next(Screen.PrimaryScreen.Bounds.Height);

                Bomb bomb = new Bomb();
                bomb.Location = new Point(x_bomb, y_bomb);
                bomb.Die += Bomb_Die;
                bomb.Exploded += Bomb_Exploded;
                Controls.Add(bomb);
            }

        }

        private void Bomb_Die(object sender, EventArgs e)
        {
            Bomb bomb = (Bomb)sender;
            Controls.Remove(bomb);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            points -= Constants.MISS_PENALTY;
            DisplayStatus("MISS! YOU LOSE " + Constants.MISS_PENALTY + " POINTS!");
            DisplayPoints();
            new SoundPlayer("..//..//sounds//gunshot2.wav").Play();
        }

        private void Bomb_Exploded(object sender, EventArgs e)
        {
            points -= Constants.BOMB_DAMAGE;
            DisplayStatus("YOU HIT A BOMB! " + Constants.BOMB_DAMAGE + "-POINT PENALTY!");
            DisplayPoints();
        }

        private void Target_Fired(object sender, FiredEventArgs e)
        {
            points += e.Points;
            DisplayStatus("NICE JOB! " + e.Points + " POINTS!");
            DisplayPoints();
        }

        private void DisplayPoints()
        {
            lblPoints.Text = "Points: " + points.ToString();
            pnlScore.BackColor = points >= 0 ? Color.LightSlateGray : Color.OrangeRed;
        }

        private void DisplayStatus(string statusText)
        {
            lblStatus.Text = statusText;
        }
    }
}
