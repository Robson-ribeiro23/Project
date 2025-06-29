using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acelera2025.Views.Tools;

namespace Acelera2025.Views
{
    public partial class CardParticipantes: UserControl
    {

        public CardParticipantes()
        {
            InitializeComponent();
        }

        public void SetImage(string path)
        {
            picturePerfil.Image = Image.FromFile(path);
        }

        private void CardParticipantes_Load(object sender, EventArgs e)
        {

        }
    }
}
