using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelera2025.Views
{
    public partial class VideoTelaCheia : Form
    {
        public VideoTelaCheia(string caminhoDoVideo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            video.URL = caminhoDoVideo;
            video.settings.volume = 5; 
            video.uiMode = "full";     
            video.Ctlcontrols.play();
            this.FormClosed += VideoTelaCheia_FormClosed;
        }

        private void VideoTelaCheia_FormClosed(object sender, FormClosedEventArgs e)
        {
            video.Ctlcontrols.stop();
        }
        private void video_Enter(object sender, EventArgs e)
        {

        }
    }
}
