namespace GasStation
{
    partial class cadUsuario
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
            this.mtxbPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txbNeighbourhood = new System.Windows.Forms.TextBox();
            this.lblNeighbourhood = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtxbZipCode = new System.Windows.Forms.MaskedTextBox();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.mtxbPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxbPhone
            // 
            this.mtxbPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone.Location = new System.Drawing.Point(157, 211);
            this.mtxbPhone.Mask = "(00) 00000-0000";
            this.mtxbPhone.Name = "mtxbPhone";
            this.mtxbPhone.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone.TabIndex = 2;
            this.mtxbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone.ValidatingType = typeof(int);
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbCpf.Location = new System.Drawing.Point(157, 154);
            this.mtxbCpf.Mask = "000.000.000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(206, 28);
            this.mtxbCpf.TabIndex = 1;
            this.mtxbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbCpf.ValidatingType = typeof(int);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(393, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastro de usuário";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.Location = new System.Drawing.Point(775, 105);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 24);
            this.lblState.TabIndex = 35;
            this.lblState.Text = "UF: ";
            // 
            // txbNeighbourhood
            // 
            this.txbNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNeighbourhood.Location = new System.Drawing.Point(529, 269);
            this.txbNeighbourhood.Name = "txbNeighbourhood";
            this.txbNeighbourhood.Size = new System.Drawing.Size(438, 28);
            this.txbNeighbourhood.TabIndex = 7;
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNeighbourhood.Location = new System.Drawing.Point(429, 269);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(63, 24);
            this.lblNeighbourhood.TabIndex = 33;
            this.lblNeighbourhood.Text = "Bairro";
            // 
            // txbCity
            // 
            this.txbCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCity.Location = new System.Drawing.Point(529, 214);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(438, 28);
            this.txbCity.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(431, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(71, 24);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "Cidade";
            // 
            // txbStreet
            // 
            this.txbStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbStreet.Location = new System.Drawing.Point(529, 157);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(438, 28);
            this.txbStreet.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(431, 160);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(43, 24);
            this.lblStreet.TabIndex = 29;
            this.lblStreet.Text = "Rua";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(430, 102);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 24);
            this.lblZipCode.TabIndex = 27;
            this.lblZipCode.Text = "CEP:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(42, 211);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 24);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Telefone: ";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(42, 160);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(53, 24);
            this.lblCpf.TabIndex = 24;
            this.lblCpf.Text = "CPF: ";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(157, 102);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 28);
            this.txbName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(42, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Nome: ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(408, 359);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 47);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mtxbZipCode
            // 
            this.mtxbZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbZipCode.Location = new System.Drawing.Point(529, 102);
            this.mtxbZipCode.Mask = "00000-000";
            this.mtxbZipCode.Name = "mtxbZipCode";
            this.mtxbZipCode.Size = new System.Drawing.Size(206, 28);
            this.mtxbZipCode.TabIndex = 5;
            this.mtxbZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbZipCode.ValidatingType = typeof(int);
            this.mtxbZipCode.Leave += new System.EventHandler(this.mtxbZipCode_Leave);
            // 
            // cbxState
            // 
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
            this.cbxState.Location = new System.Drawing.Point(816, 105);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(51, 32);
            this.cbxState.TabIndex = 8;
            // 
            // mtxbPhone2
            // 
            this.mtxbPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone2.Location = new System.Drawing.Point(157, 266);
            this.mtxbPhone2.Mask = "(00) 00000-0000";
            this.mtxbPhone2.Name = "mtxbPhone2";
            this.mtxbPhone2.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone2.TabIndex = 3;
            this.mtxbPhone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone2.ValidatingType = typeof(int);
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone2.Location = new System.Drawing.Point(42, 266);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(100, 24);
            this.lblPhone2.TabIndex = 26;
            this.lblPhone2.Text = "Telefone 2:";
            // 
            // cadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 418);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.mtxbZipCode);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mtxbPhone2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mtxbPhone);
            this.Controls.Add(this.lblTitle);
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
            this.MaximizeBox = false;
            this.Name = "cadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaskedTextBox mtxbPhone;
        private MaskedTextBox mtxbCpf;
        private Label lblTitle;
        private Label lblState;
        private TextBox txbNeighbourhood;
        private Label lblNeighbourhood;
        private TextBox txbCity;
        private Label lblCity;
        private TextBox txbStreet;
        private Label lblStreet;
        private Label lblZipCode;
        private Label lblPhone;
        private Label lblCpf;
        private TextBox txbName;
        private Label lblName;
        private Button btnCadastrar;
        private MaskedTextBox mtxbZipCode;
        private ComboBox cbxState;
        private MaskedTextBox mtxbPhone2;
        private Label lblPhone2;
    }
}