namespace GasStation.View.Pump
{
    partial class pumpControl
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
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.txbFuelPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.lblPriceFuel = new System.Windows.Forms.Label();
            this.lblFuelName = new System.Windows.Forms.Label();
            this.lblDescFuel = new System.Windows.Forms.Label();
            this.gbPump = new System.Windows.Forms.GroupBox();
            this.btnFillPump = new System.Windows.Forms.Button();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblPumpName = new System.Windows.Forms.Label();
            this.lblAvailableFuel = new System.Windows.Forms.Label();
            this.lblPumpCapacity = new System.Windows.Forms.Label();
            this.lblPumpDesc = new System.Windows.Forms.Label();
            this.btnNextPump = new System.Windows.Forms.Button();
            this.btnPreviousPump = new System.Windows.Forms.Button();
            this.gbFuel.SuspendLayout();
            this.gbPump.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(395, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Controle da bomba";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbFuel
            // 
            this.gbFuel.Controls.Add(this.txbFuelPrice);
            this.gbFuel.Controls.Add(this.btnCancel);
            this.gbFuel.Controls.Add(this.btnChangePrice);
            this.gbFuel.Controls.Add(this.lblPriceFuel);
            this.gbFuel.Controls.Add(this.lblFuelName);
            this.gbFuel.Controls.Add(this.lblDescFuel);
            this.gbFuel.Location = new System.Drawing.Point(89, 170);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Size = new System.Drawing.Size(414, 273);
            this.gbFuel.TabIndex = 1;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Informação do combustível";
            // 
            // txbFuelPrice
            // 
            this.txbFuelPrice.Enabled = false;
            this.txbFuelPrice.Location = new System.Drawing.Point(165, 124);
            this.txbFuelPrice.MaxLength = 6;
            this.txbFuelPrice.Name = "txbFuelPrice";
            this.txbFuelPrice.Size = new System.Drawing.Size(165, 24);
            this.txbFuelPrice.TabIndex = 6;
            this.txbFuelPrice.TextChanged += new System.EventHandler(this.txbFuelPrice_TextChanged);
            this.txbFuelPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFuelPrice_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(355, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Location = new System.Drawing.Point(19, 168);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(356, 35);
            this.btnChangePrice.TabIndex = 1;
            this.btnChangePrice.Text = "Alterar Preço";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // lblPriceFuel
            // 
            this.lblPriceFuel.AutoSize = true;
            this.lblPriceFuel.Location = new System.Drawing.Point(20, 128);
            this.lblPriceFuel.Name = "lblPriceFuel";
            this.lblPriceFuel.Size = new System.Drawing.Size(123, 20);
            this.lblPriceFuel.TabIndex = 2;
            this.lblPriceFuel.Text = "Preço (litro):  R$";
            // 
            // lblFuelName
            // 
            this.lblFuelName.AutoSize = true;
            this.lblFuelName.Location = new System.Drawing.Point(165, 64);
            this.lblFuelName.Name = "lblFuelName";
            this.lblFuelName.Size = new System.Drawing.Size(165, 20);
            this.lblFuelName.TabIndex = 1;
            this.lblFuelName.Text = "Nome do combustível";
            // 
            // lblDescFuel
            // 
            this.lblDescFuel.AutoSize = true;
            this.lblDescFuel.Location = new System.Drawing.Point(19, 64);
            this.lblDescFuel.Name = "lblDescFuel";
            this.lblDescFuel.Size = new System.Drawing.Size(105, 20);
            this.lblDescFuel.TabIndex = 0;
            this.lblDescFuel.Text = "Combustível: ";
            // 
            // gbPump
            // 
            this.gbPump.Controls.Add(this.btnFillPump);
            this.gbPump.Controls.Add(this.lblFuel);
            this.gbPump.Controls.Add(this.lblCapacity);
            this.gbPump.Controls.Add(this.lblPumpName);
            this.gbPump.Controls.Add(this.lblAvailableFuel);
            this.gbPump.Controls.Add(this.lblPumpCapacity);
            this.gbPump.Controls.Add(this.lblPumpDesc);
            this.gbPump.Location = new System.Drawing.Point(582, 177);
            this.gbPump.Name = "gbPump";
            this.gbPump.Size = new System.Drawing.Size(379, 266);
            this.gbPump.TabIndex = 2;
            this.gbPump.TabStop = false;
            this.gbPump.Text = "Informação da Bomba";
            // 
            // btnFillPump
            // 
            this.btnFillPump.Location = new System.Drawing.Point(32, 212);
            this.btnFillPump.Name = "btnFillPump";
            this.btnFillPump.Size = new System.Drawing.Size(307, 35);
            this.btnFillPump.TabIndex = 2;
            this.btnFillPump.Text = "Encher Bomba";
            this.btnFillPump.UseVisualStyleBackColor = true;
            this.btnFillPump.Click += new System.EventHandler(this.btnFillPump_Click);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(247, 168);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(76, 20);
            this.lblFuel.TabIndex = 5;
            this.lblFuel.Text = "100 Litros";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(249, 117);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(74, 20);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "123 Litros";
            // 
            // lblPumpName
            // 
            this.lblPumpName.AutoSize = true;
            this.lblPumpName.Location = new System.Drawing.Point(249, 60);
            this.lblPumpName.Name = "lblPumpName";
            this.lblPumpName.Size = new System.Drawing.Size(61, 20);
            this.lblPumpName.TabIndex = 3;
            this.lblPumpName.Text = "Bomba";
            // 
            // lblAvailableFuel
            // 
            this.lblAvailableFuel.AutoSize = true;
            this.lblAvailableFuel.Location = new System.Drawing.Point(22, 168);
            this.lblAvailableFuel.Name = "lblAvailableFuel";
            this.lblAvailableFuel.Size = new System.Drawing.Size(176, 20);
            this.lblAvailableFuel.TabIndex = 2;
            this.lblAvailableFuel.Text = "Combustível disponivel:";
            // 
            // lblPumpCapacity
            // 
            this.lblPumpCapacity.AutoSize = true;
            this.lblPumpCapacity.Location = new System.Drawing.Point(22, 117);
            this.lblPumpCapacity.Name = "lblPumpCapacity";
            this.lblPumpCapacity.Size = new System.Drawing.Size(154, 20);
            this.lblPumpCapacity.TabIndex = 1;
            this.lblPumpCapacity.Text = "Capacidade máxima:";
            // 
            // lblPumpDesc
            // 
            this.lblPumpDesc.AutoSize = true;
            this.lblPumpDesc.Location = new System.Drawing.Point(22, 60);
            this.lblPumpDesc.Name = "lblPumpDesc";
            this.lblPumpDesc.Size = new System.Drawing.Size(68, 20);
            this.lblPumpDesc.TabIndex = 0;
            this.lblPumpDesc.Text = "Bomba: ";
            // 
            // btnNextPump
            // 
            this.btnNextPump.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextPump.Location = new System.Drawing.Point(582, 490);
            this.btnNextPump.Name = "btnNextPump";
            this.btnNextPump.Size = new System.Drawing.Size(92, 72);
            this.btnNextPump.TabIndex = 4;
            this.btnNextPump.Text = ">";
            this.btnNextPump.UseVisualStyleBackColor = true;
            this.btnNextPump.Click += new System.EventHandler(this.btnNextPump_Click);
            // 
            // btnPreviousPump
            // 
            this.btnPreviousPump.Enabled = false;
            this.btnPreviousPump.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousPump.Location = new System.Drawing.Point(411, 490);
            this.btnPreviousPump.Name = "btnPreviousPump";
            this.btnPreviousPump.Size = new System.Drawing.Size(92, 72);
            this.btnPreviousPump.TabIndex = 3;
            this.btnPreviousPump.Text = "<";
            this.btnPreviousPump.UseVisualStyleBackColor = true;
            this.btnPreviousPump.Click += new System.EventHandler(this.btnPreviousPump_Click);
            // 
            // pumpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 574);
            this.Controls.Add(this.btnPreviousPump);
            this.Controls.Add(this.btnNextPump);
            this.Controls.Add(this.gbPump);
            this.Controls.Add(this.gbFuel);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pumpControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle da bomba";
            this.gbFuel.ResumeLayout(false);
            this.gbFuel.PerformLayout();
            this.gbPump.ResumeLayout(false);
            this.gbPump.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private GroupBox gbFuel;
        private Label lblDescFuel;
        private Label lblPriceFuel;
        private Label lblFuelName;
        private GroupBox gbPump;
        private Button btnChangePrice;
        private Button btnFillPump;
        private Label lblFuel;
        private Label lblCapacity;
        private Label lblPumpName;
        private Label lblAvailableFuel;
        private Label lblPumpCapacity;
        private Label lblPumpDesc;
        private Button btnNextPump;
        private Button btnPreviousPump;
        private Button btnCancel;
        private TextBox txbFuelPrice;
    }
}