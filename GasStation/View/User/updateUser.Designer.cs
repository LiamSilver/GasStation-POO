namespace GasStation.View.User
{
    partial class updateUser
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
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(319, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Atualização de usuário";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cbxState.Location = new System.Drawing.Point(780, 258);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(64, 32);
            this.cbxState.TabIndex = 10;
            // 
            // mtxbZipCode
            // 
            this.mtxbZipCode.Enabled = false;
            this.mtxbZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbZipCode.Location = new System.Drawing.Point(780, 202);
            this.mtxbZipCode.Mask = "00000-000";
            this.mtxbZipCode.Name = "mtxbZipCode";
            this.mtxbZipCode.Size = new System.Drawing.Size(110, 28);
            this.mtxbZipCode.TabIndex = 9;
            this.mtxbZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbZipCode.ValidatingType = typeof(int);
            this.mtxbZipCode.Leave += new System.EventHandler(this.mtxbZipCode_Leave);
            // 
            // mtxbPhone2
            // 
            this.mtxbPhone2.Enabled = false;
            this.mtxbPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone2.Location = new System.Drawing.Point(127, 313);
            this.mtxbPhone2.Mask = "(00) 00000-0000";
            this.mtxbPhone2.Name = "mtxbPhone2";
            this.mtxbPhone2.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone2.TabIndex = 5;
            this.mtxbPhone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone2.ValidatingType = typeof(int);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 202);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Nome: ";
            // 
            // mtxbPhone
            // 
            this.mtxbPhone.Enabled = false;
            this.mtxbPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone.Location = new System.Drawing.Point(127, 258);
            this.mtxbPhone.Mask = "(00) 00000-0000";
            this.mtxbPhone.Name = "mtxbPhone";
            this.mtxbPhone.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone.TabIndex = 4;
            this.mtxbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone.ValidatingType = typeof(int);
            // 
            // txbName
            // 
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(127, 202);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 28);
            this.txbName.TabIndex = 3;
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbCpf.Location = new System.Drawing.Point(127, 141);
            this.mtxbCpf.Mask = "000.000.000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(206, 28);
            this.mtxbCpf.TabIndex = 1;
            this.mtxbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbCpf.ValidatingType = typeof(int);
            this.mtxbCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxbCpf_KeyUp);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.Location = new System.Drawing.Point(717, 263);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 24);
            this.lblState.TabIndex = 53;
            this.lblState.Text = "UF: ";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(12, 147);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(53, 24);
            this.lblCpf.TabIndex = 46;
            this.lblCpf.Text = "CPF: ";
            // 
            // txbNeighbourhood
            // 
            this.txbNeighbourhood.Enabled = false;
            this.txbNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNeighbourhood.Location = new System.Drawing.Point(477, 202);
            this.txbNeighbourhood.Name = "txbNeighbourhood";
            this.txbNeighbourhood.Size = new System.Drawing.Size(204, 28);
            this.txbNeighbourhood.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(12, 258);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 24);
            this.lblPhone.TabIndex = 47;
            this.lblPhone.Text = "Telefone: ";
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNeighbourhood.Location = new System.Drawing.Point(377, 202);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(67, 24);
            this.lblNeighbourhood.TabIndex = 52;
            this.lblNeighbourhood.Text = "Bairro:";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone2.Location = new System.Drawing.Point(12, 313);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(100, 24);
            this.lblPhone2.TabIndex = 48;
            this.lblPhone2.Text = "Telefone 2:";
            // 
            // txbCity
            // 
            this.txbCity.Enabled = false;
            this.txbCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCity.Location = new System.Drawing.Point(475, 316);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(206, 28);
            this.txbCity.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(377, 316);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(75, 24);
            this.lblCity.TabIndex = 51;
            this.lblCity.Text = "Cidade:";
            // 
            // txbStreet
            // 
            this.txbStreet.Enabled = false;
            this.txbStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbStreet.Location = new System.Drawing.Point(475, 259);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(206, 28);
            this.txbStreet.TabIndex = 7;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(377, 262);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(47, 24);
            this.lblStreet.TabIndex = 50;
            this.lblStreet.Text = "Rua:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(717, 202);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 24);
            this.lblZipCode.TabIndex = 49;
            this.lblZipCode.Text = "CEP:";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(385, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(385, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 47);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 488);
            this.Controls.Add(this.btnUpdate);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar dados do usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
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
        private Button btnSearch;
        private Button btnUpdate;
    }
}