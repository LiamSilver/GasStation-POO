namespace GasStation.View.User
{
    partial class deleteUser
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
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(399, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(399, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 32);
            this.btnSearch.TabIndex = 2;
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
            this.cbxState.Location = new System.Drawing.Point(462, 275);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(64, 32);
            this.cbxState.TabIndex = 61;
            // 
            // mtxbZipCode
            // 
            this.mtxbZipCode.Enabled = false;
            this.mtxbZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbZipCode.Location = new System.Drawing.Point(462, 224);
            this.mtxbZipCode.Mask = "00000-000";
            this.mtxbZipCode.Name = "mtxbZipCode";
            this.mtxbZipCode.Size = new System.Drawing.Size(92, 28);
            this.mtxbZipCode.TabIndex = 60;
            this.mtxbZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbZipCode.ValidatingType = typeof(int);
            // 
            // mtxbPhone2
            // 
            this.mtxbPhone2.Enabled = false;
            this.mtxbPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone2.Location = new System.Drawing.Point(141, 335);
            this.mtxbPhone2.Mask = "(00) 00000-0000";
            this.mtxbPhone2.Name = "mtxbPhone2";
            this.mtxbPhone2.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone2.TabIndex = 59;
            this.mtxbPhone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone2.ValidatingType = typeof(int);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(26, 224);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Nome: ";
            // 
            // mtxbPhone
            // 
            this.mtxbPhone.Enabled = false;
            this.mtxbPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbPhone.Location = new System.Drawing.Point(141, 280);
            this.mtxbPhone.Mask = "(00) 00000-0000";
            this.mtxbPhone.Name = "mtxbPhone";
            this.mtxbPhone.Size = new System.Drawing.Size(206, 28);
            this.mtxbPhone.TabIndex = 58;
            this.mtxbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxbPhone.ValidatingType = typeof(int);
            // 
            // txbName
            // 
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbName.Location = new System.Drawing.Point(141, 224);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 28);
            this.txbName.TabIndex = 57;
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxbCpf.Location = new System.Drawing.Point(141, 163);
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
            this.lblState.Location = new System.Drawing.Point(399, 280);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 24);
            this.lblState.TabIndex = 74;
            this.lblState.Text = "UF: ";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(26, 169);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(53, 24);
            this.lblCpf.TabIndex = 67;
            this.lblCpf.Text = "CPF: ";
            // 
            // txbNeighbourhood
            // 
            this.txbNeighbourhood.Enabled = false;
            this.txbNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNeighbourhood.Location = new System.Drawing.Point(721, 224);
            this.txbNeighbourhood.Name = "txbNeighbourhood";
            this.txbNeighbourhood.Size = new System.Drawing.Size(204, 28);
            this.txbNeighbourhood.TabIndex = 62;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(26, 280);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 24);
            this.lblPhone.TabIndex = 68;
            this.lblPhone.Text = "Telefone: ";
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNeighbourhood.Location = new System.Drawing.Point(621, 224);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(67, 24);
            this.lblNeighbourhood.TabIndex = 73;
            this.lblNeighbourhood.Text = "Bairro:";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone2.Location = new System.Drawing.Point(26, 335);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(100, 24);
            this.lblPhone2.TabIndex = 69;
            this.lblPhone2.Text = "Telefone 2:";
            // 
            // txbCity
            // 
            this.txbCity.Enabled = false;
            this.txbCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCity.Location = new System.Drawing.Point(719, 338);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(206, 28);
            this.txbCity.TabIndex = 64;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(621, 338);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(75, 24);
            this.lblCity.TabIndex = 72;
            this.lblCity.Text = "Cidade:";
            // 
            // txbStreet
            // 
            this.txbStreet.Enabled = false;
            this.txbStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbStreet.Location = new System.Drawing.Point(719, 281);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(206, 28);
            this.txbStreet.TabIndex = 63;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreet.Location = new System.Drawing.Point(621, 284);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(47, 24);
            this.lblStreet.TabIndex = 71;
            this.lblStreet.Text = "Rua:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipCode.Location = new System.Drawing.Point(399, 224);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 24);
            this.lblZipCode.TabIndex = 70;
            this.lblZipCode.Text = "CEP:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(380, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 32);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Deletar Usuário";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 418);
            this.Controls.Add(this.btnDelete);
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
            this.Name = "deleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar o usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
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
    }
}