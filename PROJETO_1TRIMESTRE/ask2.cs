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
    public partial class ask2 : Form
    {
        public ask2()
        {
            InitializeComponent();
        }

        private void button1F3_Click(object sender, EventArgs e)
        {
            //duas condicionais if, uma para cada botão radio, caso o primeiro seja selecionado, manda +1 ponto para a variável destinada, o mesmo para o segundo.
            if (radioButton1F3.Checked)
            {
                MMSR.MAGO();
            }
            if (radioButton2F3.Checked)
            {
                MMSR.GUERREIRO();
            }
            //mostra o novo formulário
            ask3 p3 = new ask3();
            p3.Show();
            this.Close();
            // nesse caso posso usar o método close, pois fechar esse formulário não interfere na funcionalidade nem no resultado do teste.
        }
    }
}
