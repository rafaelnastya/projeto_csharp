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
    public partial class terrabladerep : Form
    {
        public terrabladerep()
        {
            InitializeComponent();
            timer1.Start();
            //o timer começa a contagem
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //após a contagem de segundos o formulário é fechado automaticamente
            this.Close();
        }
    }
}
