using GasStation.View.Pump;
using GasStation.View.Sale;
using GasStation.View.User;
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

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteUser delete = new();
            delete.Show();
        }

        private void adicionarClienteNaFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleGas sale = new();
            sale.Show();
        }

        private void alterarPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pumpControl pump = new();
            pump.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultUser consult = new();
            consult.Show();
        }
    }
}
