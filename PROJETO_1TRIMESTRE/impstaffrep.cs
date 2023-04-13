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
    public partial class impstaffrep : Form
    {
        public impstaffrep()
        {
            InitializeComponent();
            //o timer começa a contagem
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //após a contagem de segundos o formulário é fechado automaticamente
            this.Close();
        }
    }
}
