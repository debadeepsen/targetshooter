using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace TargetShooter.UserControls
{
    public partial class Target : ClosableOnEscape
    {
        public Target()
        {
            InitializeComponent();
            DisplayPointsValue();
        }

        private void DisplayPointsValue()
        {
            label1.Text = Constants.OUTER_POINTS.ToString();
            label2.Text = Constants.MID_POINTS.ToString();
            label3.Text = Constants.INNER_POINTS.ToString();
        }

        public event EventHandler<FiredEventArgs> Fired;

        private void btn_Click(object sender, EventArgs e)
        {
            var button = (Panel)sender;

            int pointsGained = 0;
            switch (button.Name)
            {
                case "btnOuter":
                    pointsGained = Constants.OUTER_POINTS;
                    break;
                case "btnMid":
                    pointsGained = Constants.MID_POINTS;
                    break;
                case "btnInner":
                    pointsGained = Constants.INNER_POINTS;
                    break;
                default:
                    break;
            }

            Fire(pointsGained);
        }

        private void label_Click(object sender, EventArgs e)
        {
            var parent = (Panel)((Label)sender).Parent;
            int pointsGained = 0;
            switch (parent.Name)
            {
                case "btnOuter":
                    pointsGained = Constants.OUTER_POINTS;
                    break;
                case "btnMid":
                    pointsGained = Constants.MID_POINTS;
                    break;
                case "btnInner":
                    pointsGained = Constants.INNER_POINTS;
                    break;
                default:
                    break;
            }

            Fire(pointsGained);

        }

        private void Fire(int pointsGained)
        {
            if (Fired != null)
                Fired(this, new FiredEventArgs { Points = pointsGained });
            new SoundPlayer("..//..//sounds//gunshot2.wav").Play();
        }
    }

    public class FiredEventArgs : EventArgs
    {
        public int Points { get; set; }
    }
}
