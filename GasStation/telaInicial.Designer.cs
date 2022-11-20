namespace GasStation
{
    partial class telaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msNavegacao = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bombaDeCombustívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abastecerABombaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimas24HorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimos7DiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacao
            // 
            this.msNavegacao.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msNavegacao.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNavegacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.bombaDeCombustívelToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.históricoToolStripMenuItem1,
            this.ajudaToolStripMenuItem});
            this.msNavegacao.Location = new System.Drawing.Point(0, 0);
            this.msNavegacao.Name = "msNavegacao";
            this.msNavegacao.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msNavegacao.Size = new System.Drawing.Size(1420, 32);
            this.msNavegacao.TabIndex = 0;
            this.msNavegacao.Text = "Menu";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.históricoToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // bombaDeCombustívelToolStripMenuItem
            // 
            this.bombaDeCombustívelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarPreçoToolStripMenuItem,
            this.abastecerABombaToolStripMenuItem});
            this.bombaDeCombustívelToolStripMenuItem.Name = "bombaDeCombustívelToolStripMenuItem";
            this.bombaDeCombustívelToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bombaDeCombustívelToolStripMenuItem.Text = "Bomba de combustível";
            // 
            // alterarPreçoToolStripMenuItem
            // 
            this.alterarPreçoToolStripMenuItem.Name = "alterarPreçoToolStripMenuItem";
            this.alterarPreçoToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.alterarPreçoToolStripMenuItem.Text = "Alterar preço";
            // 
            // abastecerABombaToolStripMenuItem
            // 
            this.abastecerABombaToolStripMenuItem.Name = "abastecerABombaToolStripMenuItem";
            this.abastecerABombaToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.abastecerABombaToolStripMenuItem.Text = "Abastecer a bomba";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVendaToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // realizarVendaToolStripMenuItem
            // 
            this.realizarVendaToolStripMenuItem.Name = "realizarVendaToolStripMenuItem";
            this.realizarVendaToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.realizarVendaToolStripMenuItem.Text = "Realizar venda";
            // 
            // históricoToolStripMenuItem1
            // 
            this.históricoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ultimas24HorasToolStripMenuItem,
            this.ultimos7DiasToolStripMenuItem,
            this.ultimoMêsToolStripMenuItem,
            this.selecionarDataToolStripMenuItem});
            this.históricoToolStripMenuItem1.Name = "históricoToolStripMenuItem1";
            this.históricoToolStripMenuItem1.Size = new System.Drawing.Size(102, 28);
            this.históricoToolStripMenuItem1.Text = "Histórico";
            // 
            // ultimas24HorasToolStripMenuItem
            // 
            this.ultimas24HorasToolStripMenuItem.Name = "ultimas24HorasToolStripMenuItem";
            this.ultimas24HorasToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.ultimas24HorasToolStripMenuItem.Text = "Ultimas 24 horas";
            // 
            // ultimos7DiasToolStripMenuItem
            // 
            this.ultimos7DiasToolStripMenuItem.Name = "ultimos7DiasToolStripMenuItem";
            this.ultimos7DiasToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.ultimos7DiasToolStripMenuItem.Text = "Ultimos 7 dias";
            // 
            // ultimoMêsToolStripMenuItem
            // 
            this.ultimoMêsToolStripMenuItem.Name = "ultimoMêsToolStripMenuItem";
            this.ultimoMêsToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.ultimoMêsToolStripMenuItem.Text = "Ultimo mês";
            // 
            // selecionarDataToolStripMenuItem
            // 
            this.selecionarDataToolStripMenuItem.Name = "selecionarDataToolStripMenuItem";
            this.selecionarDataToolStripMenuItem.Size = new System.Drawing.Size(234, 28);
            this.selecionarDataToolStripMenuItem.Text = "Selecionar data";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 655);
            this.Controls.Add(this.msNavegacao);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.msNavegacao;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "telaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página inicial";
            this.msNavegacao.ResumeLayout(false);
            this.msNavegacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msNavegacao;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem dadosToolStripMenuItem;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private ToolStripMenuItem bombaDeCombustívelToolStripMenuItem;
        private ToolStripMenuItem alterarPreçoToolStripMenuItem;
        private ToolStripMenuItem abastecerABombaToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem realizarVendaToolStripMenuItem;
        private ToolStripMenuItem históricoToolStripMenuItem1;
        private ToolStripMenuItem ultimas24HorasToolStripMenuItem;
        private ToolStripMenuItem ultimos7DiasToolStripMenuItem;
        private ToolStripMenuItem ultimoMêsToolStripMenuItem;
        private ToolStripMenuItem selecionarDataToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
    }
}