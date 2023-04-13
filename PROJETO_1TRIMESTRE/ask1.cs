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
    public partial class ask1 : Form
    {
        public ask1()
        {
            InitializeComponent();
        }

        private void button1F2_Click(object sender, EventArgs e)
        {
            //duas condicionais if, uma para cada botão radio, caso o primeiro seja selecionado, manda +1 ponto para a variável destinada, o mesmo para o segundo.
                if (radioButton1F2.Checked)
                {
                    MMSR.MAGO();
                }

                if (radioButton2F2.Checked)
                {
                    MMSR.GUERREIRO();
                }
            
            //torna o formulário uma variável
            ask2 p2 = new ask2();
            //uso o formulário que se tornou uma variável para usar o método "show", que mostra ele após o evento do botão.
            p2.Show();
            this.Close();
            // nesse caso posso usar o método close, pois fechar esse formulário não interfere na funcionalidade nem no resultado do teste.
        }
    }
}
