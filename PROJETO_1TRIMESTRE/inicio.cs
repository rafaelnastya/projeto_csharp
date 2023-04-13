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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1F1_Click(object sender, EventArgs e)
        {
            //a função do botão é basicamente ir para o formulário 2 sem fechar o formulário 1, iniciando o teste. 
            ask1 p1 = new ask1();
            p1.Show();
            this.Hide();
            
            //Usar o método hide para esconder a primeira pag e dar continuidade ao teste(usar o método close resulta no projeto fechado e não permite continuar o teste).
        }
    }
}
