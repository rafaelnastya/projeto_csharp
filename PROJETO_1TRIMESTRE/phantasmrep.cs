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
    public partial class phantasmrep : Form
    {
        public phantasmrep()
        {
            InitializeComponent();
            //inicia o timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fecha o formulário após o tempo definido no timer
            this.Close();
        }
    }
}
