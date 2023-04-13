using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_1TRIMESTRE
{
    public partial class avaliacao : Form
    {
        public avaliacao()
        {
            InitializeComponent();
        }
        // cria uma lista pública que contém as imagens que serão requisitadas no trackbar / panel.
        public Image[] images = { Properties.Resources.VERYBAD, Properties.Resources.BAD, Properties.Resources.OK, Properties.Resources.GOOD, Properties.Resources.VERYGOOD };

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // a imagem representada no painel é de acordo com o valor inserido na trackbar (de 1 a 5).
            panel1.BackgroundImage = images[trackBar1.Value];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio iop = new inicio();
            iop.Show();
            iop.Close();
            this.Close();
            //fecha o formulário que sustenta o projeto(inicio) e finaliza tudo.. ou deveria finalizar, não sei porque não funfou. =(
        }
    }
}
