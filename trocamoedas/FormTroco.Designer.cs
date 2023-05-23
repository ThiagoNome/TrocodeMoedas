namespace trocamoedas
{
    partial class FormTroco
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
            this.lbl_ValorCompra = new System.Windows.Forms.Label();
            this.lbl_ValorPago = new System.Windows.Forms.Label();
            this.lbl_ValorTroco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Moeda1 = new System.Windows.Forms.Label();
            this.lbl_Moeda50 = new System.Windows.Forms.Label();
            this.lbl_Moeda25 = new System.Windows.Forms.Label();
            this.lbl_Moeda10 = new System.Windows.Forms.Label();
            this.lbl_Moeda05 = new System.Windows.Forms.Label();
            this.lbl_Moeda01 = new System.Windows.Forms.Label();
            this.lbl_calcular = new System.Windows.Forms.Button();
            this.lbl_troco1 = new System.Windows.Forms.Label();
            this.lbl_troco50 = new System.Windows.Forms.Label();
            this.lbl_troco25 = new System.Windows.Forms.Label();
            this.lbl_troco10 = new System.Windows.Forms.Label();
            this.lbl_troco05 = new System.Windows.Forms.Label();
            this.lbl_troco01 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Compra = new System.Windows.Forms.TextBox();
            this.textBox_Pago = new System.Windows.Forms.TextBox();
            this.textBox_Troco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_ValorCompra
            // 
            this.lbl_ValorCompra.AutoSize = true;
            this.lbl_ValorCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorCompra.Location = new System.Drawing.Point(30, 96);
            this.lbl_ValorCompra.Name = "lbl_ValorCompra";
            this.lbl_ValorCompra.Size = new System.Drawing.Size(98, 15);
            this.lbl_ValorCompra.TabIndex = 0;
            this.lbl_ValorCompra.Text = "Valor de Compra";
            // 
            // lbl_ValorPago
            // 
            this.lbl_ValorPago.AutoSize = true;
            this.lbl_ValorPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorPago.Location = new System.Drawing.Point(30, 141);
            this.lbl_ValorPago.Name = "lbl_ValorPago";
            this.lbl_ValorPago.Size = new System.Drawing.Size(137, 15);
            this.lbl_ValorPago.TabIndex = 1;
            this.lbl_ValorPago.Text = "Valor Pago em Dinheiro";
            // 
            // lbl_ValorTroco
            // 
            this.lbl_ValorTroco.AutoSize = true;
            this.lbl_ValorTroco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorTroco.Location = new System.Drawing.Point(30, 190);
            this.lbl_ValorTroco.Name = "lbl_ValorTroco";
            this.lbl_ValorTroco.Size = new System.Drawing.Size(86, 15);
            this.lbl_ValorTroco.TabIndex = 2;
            this.lbl_ValorTroco.Text = "Valor do Troco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite os valores abaixo";
            // 
            // lbl_Moeda1
            // 
            this.lbl_Moeda1.AutoSize = true;
            this.lbl_Moeda1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moeda1.Location = new System.Drawing.Point(540, 88);
            this.lbl_Moeda1.Name = "lbl_Moeda1";
            this.lbl_Moeda1.Size = new System.Drawing.Size(112, 15);
            this.lbl_Moeda1.TabIndex = 4;
            this.lbl_Moeda1.Text = "Moedas de R$ 1,00";
            this.lbl_Moeda1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Moeda50
            // 
            this.lbl_Moeda50.AutoSize = true;
            this.lbl_Moeda50.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moeda50.Location = new System.Drawing.Point(540, 118);
            this.lbl_Moeda50.Name = "lbl_Moeda50";
            this.lbl_Moeda50.Size = new System.Drawing.Size(112, 15);
            this.lbl_Moeda50.TabIndex = 5;
            this.lbl_Moeda50.Text = "Moedas de R$ 0,50";
            this.lbl_Moeda50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Moeda25
            // 
            this.lbl_Moeda25.AutoSize = true;
            this.lbl_Moeda25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moeda25.Location = new System.Drawing.Point(540, 153);
            this.lbl_Moeda25.Name = "lbl_Moeda25";
            this.lbl_Moeda25.Size = new System.Drawing.Size(112, 15);
            this.lbl_Moeda25.TabIndex = 6;
            this.lbl_Moeda25.Text = "Moedas de R$ 0,25";
            this.lbl_Moeda25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Moeda10
            // 
            this.lbl_Moeda10.AutoSize = true;
            this.lbl_Moeda10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moeda10.Location = new System.Drawing.Point(540, 185);
            this.lbl_Moeda10.Name = "lbl_Moeda10";
            this.lbl_Moeda10.Size = new System.Drawing.Size(112, 15);
            this.lbl_Moeda10.TabIndex = 7;
            this.lbl_Moeda10.Text = "Moedas de R$ 0,10";
            this.lbl_Moeda10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Moeda05
            // 
            this.lbl_Moeda05.AutoSize = true;
            this.lbl_Moeda05.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moeda05.Location = new System.Drawing.Point(540, 225);
            this.lbl_Moeda05.Name = "lbl_Moeda05";
            this.lbl_Moeda05.Size = new System.Drawing.Size(112, 15);
            this.lbl_Moeda05.TabIndex = 8;
            this.lbl_Moeda05.Text = "Moedas de R$ 0,05";
            this.lbl_Moeda05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Moeda01
            // 
            this.lbl_Moeda01.AutoSize = true;
            this.lbl_Moeda01.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Moeda01.Location = new System.Drawing.Point(540, 264);
            this.lbl_Moeda01.Name = "lbl_Moeda01";
            this.lbl_Moeda01.Size = new System.Drawing.Size(112, 15);
            this.lbl_Moeda01.TabIndex = 9;
            this.lbl_Moeda01.Text = "Moedas de R$ 0,01";
            this.lbl_Moeda01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_calcular
            // 
            this.lbl_calcular.AutoSize = true;
            this.lbl_calcular.Location = new System.Drawing.Point(115, 264);
            this.lbl_calcular.Name = "lbl_calcular";
            this.lbl_calcular.Size = new System.Drawing.Size(261, 46);
            this.lbl_calcular.TabIndex = 10;
            this.lbl_calcular.Text = "Calcular";
            this.lbl_calcular.UseVisualStyleBackColor = true;
            this.lbl_calcular.Click += new System.EventHandler(this.lbl_calcular_Click);
            // 
            // lbl_troco1
            // 
            this.lbl_troco1.AutoSize = true;
            this.lbl_troco1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_troco1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco1.Location = new System.Drawing.Point(496, 88);
            this.lbl_troco1.Name = "lbl_troco1";
            this.lbl_troco1.Size = new System.Drawing.Size(16, 17);
            this.lbl_troco1.TabIndex = 11;
            this.lbl_troco1.Text = "0";
            this.lbl_troco1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_troco50
            // 
            this.lbl_troco50.AutoSize = true;
            this.lbl_troco50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_troco50.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco50.Location = new System.Drawing.Point(496, 118);
            this.lbl_troco50.Name = "lbl_troco50";
            this.lbl_troco50.Size = new System.Drawing.Size(16, 17);
            this.lbl_troco50.TabIndex = 12;
            this.lbl_troco50.Text = "0";
            this.lbl_troco50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_troco25
            // 
            this.lbl_troco25.AutoSize = true;
            this.lbl_troco25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_troco25.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco25.Location = new System.Drawing.Point(496, 151);
            this.lbl_troco25.Name = "lbl_troco25";
            this.lbl_troco25.Size = new System.Drawing.Size(16, 17);
            this.lbl_troco25.TabIndex = 14;
            this.lbl_troco25.Text = "0";
            this.lbl_troco25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_troco10
            // 
            this.lbl_troco10.AutoSize = true;
            this.lbl_troco10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_troco10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco10.Location = new System.Drawing.Point(496, 185);
            this.lbl_troco10.Name = "lbl_troco10";
            this.lbl_troco10.Size = new System.Drawing.Size(16, 17);
            this.lbl_troco10.TabIndex = 15;
            this.lbl_troco10.Text = "0";
            this.lbl_troco10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_troco05
            // 
            this.lbl_troco05.AutoSize = true;
            this.lbl_troco05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_troco05.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco05.Location = new System.Drawing.Point(496, 225);
            this.lbl_troco05.Name = "lbl_troco05";
            this.lbl_troco05.Size = new System.Drawing.Size(16, 17);
            this.lbl_troco05.TabIndex = 16;
            this.lbl_troco05.Text = "0";
            this.lbl_troco05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_troco01
            // 
            this.lbl_troco01.AutoSize = true;
            this.lbl_troco01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_troco01.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_troco01.Location = new System.Drawing.Point(496, 262);
            this.lbl_troco01.Name = "lbl_troco01";
            this.lbl_troco01.Size = new System.Drawing.Size(16, 17);
            this.lbl_troco01.TabIndex = 17;
            this.lbl_troco01.Text = "0";
            this.lbl_troco01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(496, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 25);
            this.label17.TabIndex = 18;
            this.label17.Text = "Moedas para Troco";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBox_Compra
            // 
            this.textBox_Compra.Location = new System.Drawing.Point(208, 88);
            this.textBox_Compra.Name = "textBox_Compra";
            this.textBox_Compra.Size = new System.Drawing.Size(168, 23);
            this.textBox_Compra.TabIndex = 19;
            // 
            // textBox_Pago
            // 
            this.textBox_Pago.Location = new System.Drawing.Point(208, 133);
            this.textBox_Pago.Name = "textBox_Pago";
            this.textBox_Pago.Size = new System.Drawing.Size(168, 23);
            this.textBox_Pago.TabIndex = 20;
            // 
            // textBox_Troco
            // 
            this.textBox_Troco.Location = new System.Drawing.Point(208, 182);
            this.textBox_Troco.Name = "textBox_Troco";
            this.textBox_Troco.Size = new System.Drawing.Size(168, 23);
            this.textBox_Troco.TabIndex = 21;
            // 
            // FormTroco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 334);
            this.Controls.Add(this.textBox_Troco);
            this.Controls.Add(this.textBox_Pago);
            this.Controls.Add(this.textBox_Compra);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_troco01);
            this.Controls.Add(this.lbl_troco05);
            this.Controls.Add(this.lbl_troco10);
            this.Controls.Add(this.lbl_troco25);
            this.Controls.Add(this.lbl_troco50);
            this.Controls.Add(this.lbl_troco1);
            this.Controls.Add(this.lbl_calcular);
            this.Controls.Add(this.lbl_Moeda01);
            this.Controls.Add(this.lbl_Moeda05);
            this.Controls.Add(this.lbl_Moeda10);
            this.Controls.Add(this.lbl_Moeda25);
            this.Controls.Add(this.lbl_Moeda50);
            this.Controls.Add(this.lbl_Moeda1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ValorTroco);
            this.Controls.Add(this.lbl_ValorPago);
            this.Controls.Add(this.lbl_ValorCompra);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "FormTroco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troco de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ValorCompra;
        private Label lbl_ValorPago;
        private Label lbl_ValorTroco;
        private Label label4;
        private Label lbl_Moeda1;
        private Label lbl_Moeda50;
        private Label lbl_Moeda25;
        private Label lbl_Moeda10;
        private Label lbl_Moeda05;
        private Label lbl_Moeda01;
        private Button lbl_calcular;
        private Label lbl_troco1;
        private Label lbl_troco50;
        private Label lbl_troco25;
        private Label lbl_troco10;
        private Label lbl_troco05;
        private Label lbl_troco01;
        private Label label17;
        private TextBox textBox_Compra;
        private TextBox textBox_Pago;
        private TextBox textBox_Troco;
    }
}