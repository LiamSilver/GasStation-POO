using GasStation.View.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GasStation
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUser cadastrar = new();
            cadastrar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateUser update = new();
            update.Show();
        }
    }
}
