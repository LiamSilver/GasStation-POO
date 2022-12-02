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
            this.gbClient.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(6, 35);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 18);
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
            this.mtxbCpf.Size = new System.Drawing.Size(125, 23);
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
            this.lblTitle.Size = new System.Drawing.Size(72, 26);
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
            this.lblLablePhone.Size = new System.Drawing.Size(65, 18);
            this.lblLablePhone.TabIndex = 6;
            this.lblLablePhone.Text = "Telefone:";
            // 
            // lblLabelName
            // 
            this.lblLabelName.AutoSize = true;
            this.lblLabelName.Location = new System.Drawing.Point(6, 131);
            this.lblLabelName.Name = "lblLabelName";
            this.lblLabelName.Size = new System.Drawing.Size(52, 18);
            this.lblLabelName.TabIndex = 5;
            this.lblLabelName.Text = "Nome:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(97, 173);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 18);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Telefone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(97, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Enabled = false;
            this.btnSearchClient.Location = new System.Drawing.Point(58, 73);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(257, 29);
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
            this.cbCpfAdmin.Size = new System.Drawing.Size(103, 22);
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
            this.lblLabelFuelAvailable.Size = new System.Drawing.Size(160, 18);
            this.lblLabelFuelAvailable.TabIndex = 4;
            this.lblLabelFuelAvailable.Text = "Combustível disponível:";
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.AutoSize = true;
            this.lblFuelPrice.Location = new System.Drawing.Point(6, 93);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(31, 18);
            this.lblFuelPrice.TabIndex = 3;
            this.lblFuelPrice.Text = "R$: ";
            // 
            // lblPump
            // 
            this.lblPump.AutoSize = true;
            this.lblPump.Location = new System.Drawing.Point(6, 157);
            this.lblPump.Name = "lblPump";
            this.lblPump.Size = new System.Drawing.Size(65, 18);
            this.lblPump.TabIndex = 2;
            this.lblPump.Text = "Bomba 1";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(6, 53);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(92, 18);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "Combustível:";
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(145, 50);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(164, 26);
            this.cbFuel.TabIndex = 0;
            this.cbFuel.SelectedIndexChanged += new System.EventHandler(this.cbFuel_SelectedIndexChanged);
            this.cbFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFuel_KeyPress);
            // 
            // saleGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 571);
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
    }
}