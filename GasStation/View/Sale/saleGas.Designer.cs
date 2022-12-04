namespace GasStation.View.Sale
{
    partial class saleGas
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.lblLablePhone = new System.Windows.Forms.Label();
            this.lblLabelName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.cbCpfAdmin = new System.Windows.Forms.CheckBox();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.lblLabelFuelAvailable = new System.Windows.Forms.Label();
            this.lblFuelPrice = new System.Windows.Forms.Label();
            this.lblPump = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.tcSale = new System.Windows.Forms.TabControl();
            this.tcMoney = new System.Windows.Forms.TabPage();
            this.lblQtdLiter = new System.Windows.Forms.Label();
            this.lblLiterByMoney = new System.Windows.Forms.Label();
            this.lblLiter = new System.Windows.Forms.Label();
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.tcLiter = new System.Windows.Forms.TabPage();
            this.lblMoneyByLiters = new System.Windows.Forms.Label();
            this.nudLiter = new System.Windows.Forms.NumericUpDown();
            this.lblMoneyByLiter = new System.Windows.Forms.Label();
            this.lblSellLiter = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.gbClient.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.tcSale.SuspendLayout();
            this.tcMoney.SuspendLayout();
            this.tcLiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(6, 35);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(49, 24);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Enabled = false;
            this.mtxbCpf.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbCpf.Location = new System.Drawing.Point(58, 31);
            this.mtxbCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxbCpf.Mask = "000.000.000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(125, 27);
            this.mtxbCpf.TabIndex = 1;
            this.mtxbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxbCpf_KeyUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(383, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Venda";
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.lblLablePhone);
            this.gbClient.Controls.Add(this.lblLabelName);
            this.gbClient.Controls.Add(this.lblPhone);
            this.gbClient.Controls.Add(this.lblName);
            this.gbClient.Controls.Add(this.btnSearchClient);
            this.gbClient.Controls.Add(this.cbCpfAdmin);
            this.gbClient.Controls.Add(this.lblCpf);
            this.gbClient.Controls.Add(this.mtxbCpf);
            this.gbClient.Location = new System.Drawing.Point(29, 92);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(349, 201);
            this.gbClient.TabIndex = 3;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Dados do Cliente";
            // 
            // lblLablePhone
            // 
            this.lblLablePhone.AutoSize = true;
            this.lblLablePhone.Location = new System.Drawing.Point(6, 173);
            this.lblLablePhone.Name = "lblLablePhone";
            this.lblLablePhone.Size = new System.Drawing.Size(86, 24);
            this.lblLablePhone.TabIndex = 6;
            this.lblLablePhone.Text = "Telefone:";
            // 
            // lblLabelName
            // 
            this.lblLabelName.AutoSize = true;
            this.lblLabelName.Location = new System.Drawing.Point(6, 131);
            this.lblLabelName.Name = "lblLabelName";
            this.lblLabelName.Size = new System.Drawing.Size(67, 24);
            this.lblLabelName.TabIndex = 5;
            this.lblLabelName.Text = "Nome:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(97, 173);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(82, 24);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Telefone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(97, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Enabled = false;
            this.btnSearchClient.Location = new System.Drawing.Point(58, 73);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(257, 34);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "Buscar Cliente";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // cbCpfAdmin
            // 
            this.cbCpfAdmin.AutoSize = true;
            this.cbCpfAdmin.Checked = true;
            this.cbCpfAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCpfAdmin.Location = new System.Drawing.Point(212, 32);
            this.cbCpfAdmin.Name = "cbCpfAdmin";
            this.cbCpfAdmin.Size = new System.Drawing.Size(132, 28);
            this.cbCpfAdmin.TabIndex = 0;
            this.cbCpfAdmin.Text = "Usar Admin";
            this.cbCpfAdmin.UseVisualStyleBackColor = true;
            this.cbCpfAdmin.CheckedChanged += new System.EventHandler(this.cbCpfAdmin_CheckedChanged);
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.lblLabelFuelAvailable);
            this.gbFuel.Controls.Add(this.lblFuelPrice);
            this.gbFuel.Controls.Add(this.lblPump);
            this.gbFuel.Controls.Add(this.lblFuel);
            this.gbFuel.Controls.Add(this.cbFuel);
            this.gbFuel.Location = new System.Drawing.Point(452, 92);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(351, 201);
            this.gbFuel.TabIndex = 4;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Combustível";
            // 
            // lblLabelFuelAvailable
            // 
            this.lblLabelFuelAvailable.AutoSize = true;
            this.lblLabelFuelAvailable.Location = new System.Drawing.Point(6, 125);
            this.lblLabelFuelAvailable.Name = "lblLabelFuelAvailable";
            this.lblLabelFuelAvailable.Size = new System.Drawing.Size(214, 24);
            this.lblLabelFuelAvailable.TabIndex = 4;
            this.lblLabelFuelAvailable.Text = "Combustível disponível:";
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.AutoSize = true;
            this.lblFuelPrice.Location = new System.Drawing.Point(6, 93);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(40, 24);
            this.lblFuelPrice.TabIndex = 3;
            this.lblFuelPrice.Text = "R$: ";
            // 
            // lblPump
            // 
            this.lblPump.AutoSize = true;
            this.lblPump.Location = new System.Drawing.Point(6, 157);
            this.lblPump.Name = "lblPump";
            this.lblPump.Size = new System.Drawing.Size(84, 24);
            this.lblPump.TabIndex = 2;
            this.lblPump.Text = "Bomba 1";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(6, 53);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(122, 24);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "Combustível:";
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(145, 50);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(164, 30);
            this.cbFuel.TabIndex = 0;
            this.cbFuel.SelectedIndexChanged += new System.EventHandler(this.cbFuel_SelectedIndexChanged);
            this.cbFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFuel_KeyPress);
            // 
            // tcSale
            // 
            this.tcSale.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcSale.Controls.Add(this.tcMoney);
            this.tcSale.Controls.Add(this.tcLiter);
            this.tcSale.Location = new System.Drawing.Point(35, 324);
            this.tcSale.Name = "tcSale";
            this.tcSale.SelectedIndex = 0;
            this.tcSale.Size = new System.Drawing.Size(343, 204);
            this.tcSale.TabIndex = 5;
            // 
            // tcMoney
            // 
            this.tcMoney.Controls.Add(this.lblQtdLiter);
            this.tcMoney.Controls.Add(this.lblLiterByMoney);
            this.tcMoney.Controls.Add(this.lblLiter);
            this.tcMoney.Controls.Add(this.txbMoney);
            this.tcMoney.Location = new System.Drawing.Point(4, 34);
            this.tcMoney.Name = "tcMoney";
            this.tcMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tcMoney.Size = new System.Drawing.Size(335, 166);
            this.tcMoney.TabIndex = 0;
            this.tcMoney.Text = "Dinheiro";
            this.tcMoney.UseVisualStyleBackColor = true;
            // 
            // lblQtdLiter
            // 
            this.lblQtdLiter.AutoSize = true;
            this.lblQtdLiter.Location = new System.Drawing.Point(162, 83);
            this.lblQtdLiter.Name = "lblQtdLiter";
            this.lblQtdLiter.Size = new System.Drawing.Size(0, 24);
            this.lblQtdLiter.TabIndex = 3;
            // 
            // lblLiterByMoney
            // 
            this.lblLiterByMoney.AutoSize = true;
            this.lblLiterByMoney.Location = new System.Drawing.Point(6, 83);
            this.lblLiterByMoney.Name = "lblLiterByMoney";
            this.lblLiterByMoney.Size = new System.Drawing.Size(62, 24);
            this.lblLiterByMoney.TabIndex = 2;
            this.lblLiterByMoney.Text = "Litros:";
            // 
            // lblLiter
            // 
            this.lblLiter.AutoSize = true;
            this.lblLiter.Location = new System.Drawing.Point(6, 34);
            this.lblLiter.Name = "lblLiter";
            this.lblLiter.Size = new System.Drawing.Size(116, 24);
            this.lblLiter.TabIndex = 1;
            this.lblLiter.Text = "Valor em R$:";
            // 
            // txbMoney
            // 
            this.txbMoney.Location = new System.Drawing.Point(162, 34);
            this.txbMoney.MaxLength = 6;
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(87, 27);
            this.txbMoney.TabIndex = 0;
            this.txbMoney.Text = "0";
            this.txbMoney.TextChanged += new System.EventHandler(this.txbMoney_TextChanged);
            this.txbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoney_KeyPress);
            // 
            // tcLiter
            // 
            this.tcLiter.Controls.Add(this.lblMoneyByLiters);
            this.tcLiter.Controls.Add(this.nudLiter);
            this.tcLiter.Controls.Add(this.lblMoneyByLiter);
            this.tcLiter.Controls.Add(this.lblSellLiter);
            this.tcLiter.Location = new System.Drawing.Point(4, 32);
            this.tcLiter.Name = "tcLiter";
            this.tcLiter.Padding = new System.Windows.Forms.Padding(3);
            this.tcLiter.Size = new System.Drawing.Size(335, 168);
            this.tcLiter.TabIndex = 1;
            this.tcLiter.Text = "Litros";
            this.tcLiter.UseVisualStyleBackColor = true;
            // 
            // lblMoneyByLiters
            // 
            this.lblMoneyByLiters.AutoSize = true;
            this.lblMoneyByLiters.Location = new System.Drawing.Point(136, 81);
            this.lblMoneyByLiters.Name = "lblMoneyByLiters";
            this.lblMoneyByLiters.Size = new System.Drawing.Size(0, 24);
            this.lblMoneyByLiters.TabIndex = 7;
            // 
            // nudLiter
            // 
            this.nudLiter.Location = new System.Drawing.Point(138, 27);
            this.nudLiter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLiter.Name = "nudLiter";
            this.nudLiter.ReadOnly = true;
            this.nudLiter.Size = new System.Drawing.Size(126, 27);
            this.nudLiter.TabIndex = 6;
            this.nudLiter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLiter.ValueChanged += new System.EventHandler(this.nudLiter_ValueChanged);
            this.nudLiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudLiter_KeyPress);
            // 
            // lblMoneyByLiter
            // 
            this.lblMoneyByLiter.AutoSize = true;
            this.lblMoneyByLiter.Location = new System.Drawing.Point(6, 81);
            this.lblMoneyByLiter.Name = "lblMoneyByLiter";
            this.lblMoneyByLiter.Size = new System.Drawing.Size(116, 24);
            this.lblMoneyByLiter.TabIndex = 5;
            this.lblMoneyByLiter.Text = "Valor em R$:";
            // 
            // lblSellLiter
            // 
            this.lblSellLiter.AutoSize = true;
            this.lblSellLiter.Location = new System.Drawing.Point(6, 32);
            this.lblSellLiter.Name = "lblSellLiter";
            this.lblSellLiter.Size = new System.Drawing.Size(62, 24);
            this.lblSellLiter.TabIndex = 4;
            this.lblSellLiter.Text = "Litros:";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(498, 413);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(238, 50);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Realizar Venda";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // saleGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 571);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.tcSale);
            this.Controls.Add(this.gbFuel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbClient);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "saleGas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Venda";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saleGas_KeyPress);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            this.tcSale.ResumeLayout(false);
            this.tcMoney.ResumeLayout(false);
            this.tcMoney.PerformLayout();
            this.tcLiter.ResumeLayout(false);
            this.tcLiter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCpf;
        private MaskedTextBox mtxbCpf;
        private Label lblTitle;
        private GroupBox gbClient;
        private CheckBox cbCpfAdmin;
        private Button btnSearchClient;
        private Label lblPhone;
        private Label lblName;
        private Label lblLablePhone;
        private Label lblLabelName;
        private GroupBox gbFuel;
        private Label lblFuel;
        private ComboBox cbFuel;
        private Label lblFuelPrice;
        private Label lblPump;
        private Label lblLabelFuelAvailable;
        private TabControl tcSale;
        private TabPage tcMoney;
        private TextBox txbMoney;
        private TabPage tcLiter;
        private Label lblQtdLiter;
        private Label lblLiterByMoney;
        private Label lblLiter;
        private Label lblMoneyByLiter;
        private Label lblSellLiter;
        private NumericUpDown nudLiter;
        private Label lblMoneyByLiters;
        private Button btnSell;
    }
}