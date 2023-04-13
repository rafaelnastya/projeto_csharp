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
    public partial class ask3 : Form
    {
        public ask3()
        {
            InitializeComponent();
        }

        private void button1F3_Click(object sender, EventArgs e)
        {
            //quatro condicionais if, uma para cada botão radio, caso o primeiro seja selecionado, manda +1 ponto para a variável destinada, o mesmo para o segundo, assim por diante.
            if (radioButton4F4.Checked)
            {
                MMSR.MAGO();
            }
            if (radioButton1F4.Checked)
            {
                MMSR.MAGO();
            }
            if (radioButton2F4.Checked)
            {
                MMSR.GUERREIRO();
            }
            if (radioButton3F4.Checked)
            {
                MMSR.GUERREIRO();
            }

            resultado result = new resultado();
            result.Show();
            this.Close();
        }

        //ao clicar em algum botão do menu será direcionado para uma representação da arma, como ela funciona. (o formulário fechará automaticamente).
        private void iMPSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            impstaffrep imprep = new impstaffrep();
            imprep.Show();
        }

        private void pHANTASMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phantasmrep phanrep = new phantasmrep();
            phanrep.Show();
        }

        private void sAPPHIRESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sapphirestaffrep sapprep = new sapphirestaffrep();
            sapprep.Show();
        }

        private void tERRABLADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terrabladerep terrarep = new terrabladerep();
            terrarep.Show();
        }
    }
}
