namespace GasStation.View.User
{
    partial class consultUser
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.mtxbZipCode = new System.Windows.Forms.MaskedTextBox();
            this.mtxbPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.mtxbPhone = new System.Windows.Forms.MaskedTextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbNeighbourhood = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNeighbourhood = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.cSellCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSituation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCodPump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(450, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 32);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxState
            // 
            this.cbxState.Enabled = false;
            this.cbxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxState.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxState.FormattingEnabled = true;
            this.cbxState.ItemHeight = 24;
            this.cbxState.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxState.Location = new System.Drawing.Point(513, 261);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(64, 32);
            this.cbxState.TabIndex = 83;
            // 
            // mtxbZipCode
            // 
            this.mtxbZipCode.Enabled = false;
            this.mtxbZipCode.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbZipCode.Location = new System.Drawing.Point(513, 210);
            this.mtxbZipCode.Mask = "00000-000";
            this.mtxbZipCode.Name = "mtxbZipCode";
            this.mtxbZipCode.Size = new System.Drawing.Size(92, 26);
            this.mtxbZipCode.TabIndex = 82;
            this.mtxbZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbZipCode.ValidatingType = typeof(int);
            // 
            // mtxbPhone2
            // 
            this.mtxbPhone2.Enabled = false;
            this.mtxbPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone2.Location = new System.Drawing.Point(192, 321);
            this.mtxbPhone2.Mask = "(00) 00000-0000";
            this.mtxbPhone2.Name = "mtxbPhone2";
            this.mtxbPhone2.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone2.TabIndex = 81;
            this.mtxbPhone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone2.ValidatingType = typeof(int);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(77, 210);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 87;
            this.lblName.Text = "Nome: ";
            // 
            // mtxbPhone
            // 
            this.mtxbPhone.Enabled = false;
            this.mtxbPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone.Location = new System.Drawing.Point(192, 266);
            this.mtxbPhone.Mask = "(00) 00000-0000";
            this.mtxbPhone.Name = "mtxbPhone";
            this.mtxbPhone.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone.TabIndex = 80;
            this.mtxbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone.ValidatingType = typeof(int);
            // 
            // txbName
            // 
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(192, 210);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 28);
            this.txbName.TabIndex = 79;
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbCpf.Location = new System.Drawing.Point(192, 149);
            this.mtxbCpf.Mask = "000.000.000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(206, 28);
            this.mtxbCpf.TabIndex = 75;
            this.mtxbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbCpf.ValidatingType = typeof(int);
            this.mtxbCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxbCpf_KeyUp);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.Location = new System.Drawing.Point(450, 266);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 24);
            this.lblState.TabIndex = 95;
            this.lblState.Text = "UF: ";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(77, 155);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(53, 24);
            this.lblCpf.TabIndex = 88;
            this.lblCpf.Text = "CPF: ";
            // 
            // txbNeighbourhood
            // 
            this.txbNeighbourhood.Enabled = false;
            this.txbNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNeighbourhood.Location = new System.Drawing.Point(772, 210);
            this.txbNeighbourhood.Name = "txbNeighbourhood";
            this.txbNeighbourhood.Size = new System.Drawing.Size(204, 28);
            this.txbNeighbourhood.TabIndex = 84;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(77, 266);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 24);
            this.lblPhone.TabIndex = 89;
            this.lblPhone.Text = "Telefone: ";
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNeighbourhood.Location = new System.Drawing.Point(672, 210);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(67, 24);
            this.lblNeighbourhood.TabIndex = 94;
            this.lblNeighbourhood.Text = "Bairro:";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone2.Location = new System.Drawing.Point(77, 321);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(100, 24);
            this.lblPhone2.TabIndex = 90;
            this.lblPhone2.Text = "Telefone 2:";
            // 
            // txbCity
            // 
            this.txbCity.Enabled = false;
            this.txbCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCity.Location = new System.Drawing.Point(770, 324);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(206, 28);
            this.txbCity.TabIndex = 86;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(672, 324);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(75, 24);
            this.lblCity.TabIndex = 93;
            this.lblCity.Text = "Cidade:";
            // 
            // txbStreet
            // 
            this.txbStreet.Enabled = false;
            this.txbStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbStreet.Location = new System.Drawing.Point(770, 267);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(206, 28);
            this.txbStreet.TabIndex = 85;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(672, 270);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(47, 24);
            this.lblStreet.TabIndex = 92;
            this.lblStreet.Text = "Rua:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(450, 210);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 24);
            this.lblZipCode.TabIndex = 91;
            this.lblZipCode.Text = "CEP:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(424, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 32);
            this.lblTitle.TabIndex = 78;
            this.lblTitle.Text = "Consultar Usuário";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSellCode,
            this.cPump,
            this.cFuel,
            this.cLiter,
            this.cPrice,
            this.vTotal,
            this.cDate,
            this.cSituation,
            this.cCodPump});
            this.dgvUser.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUser.Location = new System.Drawing.Point(77, 402);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.Size = new System.Drawing.Size(899, 188);
            this.dgvUser.TabIndex = 96;
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // cSellCode
            // 
            this.cSellCode.HeaderText = "CodVenda";
            this.cSellCode.MinimumWidth = 6;
            this.cSellCode.Name = "cSellCode";
            this.cSellCode.Visible = false;
            this.cSellCode.Width = 125;
            // 
            // cPump
            // 
            this.cPump.HeaderText = "Bomba";
            this.cPump.MinimumWidth = 6;
            this.cPump.Name = "cPump";
            this.cPump.ReadOnly = true;
            this.cPump.Width = 125;
            // 
            // cFuel
            // 
            this.cFuel.HeaderText = "Combustível";
            this.cFuel.MinimumWidth = 6;
            this.cFuel.Name = "cFuel";
            this.cFuel.ReadOnly = true;
            this.cFuel.Width = 125;
            // 
            // cLiter
            // 
            this.cLiter.HeaderText = "Litros";
            this.cLiter.MinimumWidth = 6;
            this.cLiter.Name = "cLiter";
            this.cLiter.ReadOnly = true;
            this.cLiter.Width = 125;
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Preço";
            this.cPrice.MinimumWidth = 6;
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            this.cPrice.Width = 125;
            // 
            // vTotal
            // 
            this.vTotal.HeaderText = "Valor Total";
            this.vTotal.MinimumWidth = 6;
            this.vTotal.Name = "vTotal";
            this.vTotal.ReadOnly = true;
            this.vTotal.Width = 125;
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Data da Compra";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 125;
            // 
            // cSituation
            // 
            this.cSituation.HeaderText = "Situação";
            this.cSituation.MinimumWidth = 6;
            this.cSituation.Name = "cSituation";
            this.cSituation.Width = 125;
            // 
            // cCodPump
            // 
            this.cCodPump.HeaderText = "CodPump";
            this.cCodPump.MinimumWidth = 6;
            this.cCodPump.Name = "cCodPump";
            this.cCodPump.Visible = false;
            this.cCodPump.Width = 125;
            // 
            // consultUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 644);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.mtxbZipCode);
            this.Controls.Add(this.mtxbPhone2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mtxbPhone);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.mtxbCpf);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbNeighbourhood);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblNeighbourhood);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "consultUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private ComboBox cbxState;
        private MaskedTextBox mtxbZipCode;
        private MaskedTextBox mtxbPhone2;
        private Label lblName;
        private MaskedTextBox mtxbPhone;
        private TextBox txbName;
        private MaskedTextBox mtxbCpf;
        private Label lblState;
        private Label lblCpf;
        private TextBox txbNeighbourhood;
        private Label lblPhone;
        private Label lblNeighbourhood;
        private Label lblPhone2;
        private TextBox txbCity;
        private Label lblCity;
        private TextBox txbStreet;
        private Label lblStreet;
        private Label lblZipCode;
        private Label lblTitle;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn cSellCode;
        private DataGridViewTextBoxColumn cPump;
        private DataGridViewTextBoxColumn cFuel;
        private DataGridViewTextBoxColumn cLiter;
        private DataGridViewTextBoxColumn cPrice;
        private DataGridViewTextBoxColumn vTotal;
        private DataGridViewTextBoxColumn cDate;
        private DataGridViewTextBoxColumn cSituation;
        private DataGridViewTextBoxColumn cCodPump;
    }
}