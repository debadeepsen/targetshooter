using System;
using System.Media;
using System.Windows.Forms;

namespace TargetShooter.UserControls
{
    public partial class Bomb : ClosableOnEscape
    {
        Timer displayExplosion;
        Timer lifeTimeTimer;

        public event EventHandler Exploded;
        public event EventHandler Die;

        public Bomb()
        {
            InitializeComponent();
            SetupTimer();
        }

        private void SetupTimer()
        {
            displayExplosion = new Timer();
            displayExplosion.Interval = 700;
            displayExplosion.Stop();
            displayExplosion.Tick += DisplayExplosion_Tick;

            lifeTimeTimer = new Timer();
            lifeTimeTimer.Interval = 3000;
            lifeTimeTimer.Start();
            lifeTimeTimer.Tick += LifeTimeTimer_Tick;
        }

        private void LifeTimeTimer_Tick(object sender, EventArgs e)
        {
            if (Die != null)
                Die(this, EventArgs.Empty);
        }

        private void DisplayExplosion_Tick(object sender, EventArgs e)
        {
            displayExplosion.Stop();
            if (Die != null)
                Die(this, EventArgs.Empty);
        }

        private void Explode()
        {
            new SoundPlayer("..//..//sounds//boom-01.wav").Play();
            imgExplosion.Show();
            displayExplosion.Start();
        }

        private void imgBomb_Click(object sender, EventArgs e)
        {
            if (Exploded != null)
            {
                Explode();
                Exploded(this, EventArgs.Empty);
            }
        }
    }
}
