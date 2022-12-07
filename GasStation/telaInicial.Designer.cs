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
            this.bombaDeCombustívelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(176, 28);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // bombaDeCombustívelToolStripMenuItem
            // 
            this.bombaDeCombustívelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlPumpToolStripMenuItem});
            this.bombaDeCombustívelToolStripMenuItem.Name = "bombaDeCombustívelToolStripMenuItem";
            this.bombaDeCombustívelToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bombaDeCombustívelToolStripMenuItem.Text = "Bomba de combustível";
            // 
            // controlPumpToolStripMenuItem
            // 
            this.controlPumpToolStripMenuItem.Name = "controlPumpToolStripMenuItem";
            this.controlPumpToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.controlPumpToolStripMenuItem.Text = "Controle";
            this.controlPumpToolStripMenuItem.Click += new System.EventHandler(this.alterarPreçoToolStripMenuItem_Click);
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
            this.realizarVendaToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.realizarVendaToolStripMenuItem.Text = "Realizar abastecimento";
            this.realizarVendaToolStripMenuItem.Click += new System.EventHandler(this.realizarVendaToolStripMenuItem_Click);
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
            this.MaximizeBox = false;
            this.Name = "telaInicial";
            this.ShowIcon = false;
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
        private ToolStripMenuItem bombaDeCombustívelToolStripMenuItem;
        private ToolStripMenuItem controlPumpToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem realizarVendaToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
    }
}