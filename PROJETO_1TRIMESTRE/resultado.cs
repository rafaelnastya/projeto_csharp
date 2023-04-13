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
    public partial class resultado : Form
    {
        public resultado()
        {
            InitializeComponent();
        }

        private void resultado_Load(object sender, EventArgs e)
        {
            if(MMSR.guerr >= 2)
            {
                label1FR.Text = "Parabéns, você seria um poderoso guerreiro... Ou uma grande batalhadora!\n\n\n\nClique no botão abaixo para deixar uma avaliação para o teste, obrigado!";  
            }

            if(MMSR.mage >=2)
            {
                label1FR.Text = "Parabéns, você seria um grande feiticeiro... Ou uma bruxa!\n\n\n\nClique no botão abaixo para deixar uma avaliação para o teste, obrigado!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avaliacao av = new avaliacao();
            av.Show();
            this.Close();

        }
    }
}
