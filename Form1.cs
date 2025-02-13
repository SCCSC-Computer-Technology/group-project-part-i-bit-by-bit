/** 
 * GROUP PROJECT #1
 * CPT - 206 
 * 
 * SPLASH VIEW -- Opening screen for the NFL Insight application
**/

using System.Drawing;
using System.Windows.Forms;

namespace Soccer_Insights
{
    public partial class SplashView : Form
    {
        private Timer loadingTimer;
        private Timer imageTimer;
        private int imageIndex = 0;
        private Image[] images;

        public SplashView()
        {
            InitializeComponent();
            LoadImages();
            SetupUI();
            LoadingAnimation();
            ImageSlideshow();
        }

        private void LoadImages()
        {
            images = new Image[]
            {
                Properties.Resources.FIFA_Players,
                Properties.Resources.Messi_Agen,
                Properties.Resources.Player_Action,
                Properties.Resources.Self_Player,
            };
        }

        private void SetupUI()
        {
            // Progress Indicator
            loadProgress = new ProgressBar
            {
                Size = new Size(300, 10),
                Location = new Point((this.Width - 300) / 2, 450),
                Style = ProgressBarStyle.Marquee,
            };
            this.Controls.Add(loadProgress);
        }

        private void LoadingAnimation()
        {
            loadingTimer = new Timer
            {
                Interval = 80,
            };
            int progress = 0;
            loadingTimer.Tick += (s, e) =>
            {
                loadProgress.Value = progress;
                progress += 1;
                if (progress >= 100)
                {
                    loadingTimer.Stop();
                    this.Hide(); // This will hide Splah View
                    UI.LoginView loginView = new UI.LoginView();
                    loginView.Show();  // And show up the Login View
                }
            };
            loadingTimer.Start();
        }

        private void ImageSlideshow()
        {
            imageTimer = new Timer
            {
                Interval = 3000,
            };
            imageTimer.Tick += (s, e) =>
            {
                imageIndex = (imageIndex + 1) % images.Length;
                slideshowBox.Image = images[imageIndex];
                slideshowBox.Refresh();
            };
            imageTimer.Start();
        }
    }
}
