namespace CesarLanza
{
    partial class Ejercicio1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_InteresesGanadosAño = new System.Windows.Forms.TextBox();
            this.Deposito = new System.Windows.Forms.Label();
            this.TotalIntereses = new System.Windows.Forms.TextBox();
            this.TotalIntereses1 = new System.Windows.Forms.Label();
            this.InteresesMensualButton = new System.Windows.Forms.Button();
            this.CantidadDepositadaTextBox = new System.Windows.Forms.TextBox();
            this.Cantidad1 = new System.Windows.Forms.Label();
            this.Meses = new System.Windows.Forms.ListBox();
            this.InteresMensual = new System.Windows.Forms.TextBox();
            this.IntereseMensual1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FechaDeposito1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_InteresesGanadosAño
            // 
            this.Txt_InteresesGanadosAño.BackColor = System.Drawing.Color.White;
            this.Txt_InteresesGanadosAño.Location = new System.Drawing.Point(367, 405);
            this.Txt_InteresesGanadosAño.Name = "Txt_InteresesGanadosAño";
            this.Txt_InteresesGanadosAño.Size = new System.Drawing.Size(125, 20);
            this.Txt_InteresesGanadosAño.TabIndex = 39;
            // 
            // Deposito
            // 
            this.Deposito.AutoSize = true;
            this.Deposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposito.Location = new System.Drawing.Point(25, 406);
            this.Deposito.Name = "Deposito";
            this.Deposito.Size = new System.Drawing.Size(321, 16);
            this.Deposito.TabIndex = 38;
            this.Deposito.Text = "Depósito con intereses ganados a fin de año:";
            // 
            // TotalIntereses
            // 
            this.TotalIntereses.Location = new System.Drawing.Point(367, 371);
            this.TotalIntereses.Name = "TotalIntereses";
            this.TotalIntereses.Size = new System.Drawing.Size(117, 20);
            this.TotalIntereses.TabIndex = 37;
            // 
            // TotalIntereses1
            // 
            this.TotalIntereses1.AutoSize = true;
            this.TotalIntereses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIntereses1.Location = new System.Drawing.Point(231, 375);
            this.TotalIntereses1.Name = "TotalIntereses1";
            this.TotalIntereses1.Size = new System.Drawing.Size(115, 16);
            this.TotalIntereses1.TabIndex = 36;
            this.TotalIntereses1.Text = "Total Intereses:";
            // 
            // InteresesMensualButton
            // 
            this.InteresesMensualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InteresesMensualButton.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteresesMensualButton.Location = new System.Drawing.Point(505, 219);
            this.InteresesMensualButton.Name = "InteresesMensualButton";
            this.InteresesMensualButton.Size = new System.Drawing.Size(94, 51);
            this.InteresesMensualButton.TabIndex = 35;
            this.InteresesMensualButton.Text = "Mostrar Intereses por mes";
            this.InteresesMensualButton.UseVisualStyleBackColor = false;
            this.InteresesMensualButton.Click += new System.EventHandler(this.InteresesMensualButton_Click);
            // 
            // CantidadDepositadaTextBox
            // 
            this.CantidadDepositadaTextBox.Location = new System.Drawing.Point(367, 92);
            this.CantidadDepositadaTextBox.Name = "CantidadDepositadaTextBox";
            this.CantidadDepositadaTextBox.ReadOnly = true;
            this.CantidadDepositadaTextBox.Size = new System.Drawing.Size(129, 20);
            this.CantidadDepositadaTextBox.TabIndex = 34;
            this.CantidadDepositadaTextBox.Text = "200000";
            // 
            // Cantidad1
            // 
            this.Cantidad1.AutoSize = true;
            this.Cantidad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad1.Location = new System.Drawing.Point(188, 92);
            this.Cantidad1.Name = "Cantidad1";
            this.Cantidad1.Size = new System.Drawing.Size(158, 16);
            this.Cantidad1.TabIndex = 33;
            this.Cantidad1.Text = "Cantidad Depositada:";
            // 
            // Meses
            // 
            this.Meses.FormattingEnabled = true;
            this.Meses.Location = new System.Drawing.Point(136, 148);
            this.Meses.Name = "Meses";
            this.Meses.Size = new System.Drawing.Size(336, 212);
            this.Meses.TabIndex = 32;
            // 
            // InteresMensual
            // 
            this.InteresMensual.Location = new System.Drawing.Point(367, 118);
            this.InteresMensual.Name = "InteresMensual";
            this.InteresMensual.Size = new System.Drawing.Size(99, 20);
            this.InteresMensual.TabIndex = 31;
            // 
            // IntereseMensual1
            // 
            this.IntereseMensual1.AutoSize = true;
            this.IntereseMensual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntereseMensual1.Location = new System.Drawing.Point(111, 119);
            this.IntereseMensual1.Name = "IntereseMensual1";
            this.IntereseMensual1.Size = new System.Drawing.Size(235, 16);
            this.IntereseMensual1.TabIndex = 30;
            this.IntereseMensual1.Text = "Cantidad de intereses cada mes:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 26);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // FechaDeposito1
            // 
            this.FechaDeposito1.AutoSize = true;
            this.FechaDeposito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeposito1.Location = new System.Drawing.Point(151, 30);
            this.FechaDeposito1.Name = "FechaDeposito1";
            this.FechaDeposito1.Size = new System.Drawing.Size(195, 16);
            this.FechaDeposito1.TabIndex = 27;
            this.FechaDeposito1.Text = "Fecha de Depóstio Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "La cantidad depositada es de L.200,000.00";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_InteresesGanadosAño);
            this.Controls.Add(this.Deposito);
            this.Controls.Add(this.TotalIntereses);
            this.Controls.Add(this.TotalIntereses1);
            this.Controls.Add(this.InteresesMensualButton);
            this.Controls.Add(this.CantidadDepositadaTextBox);
            this.Controls.Add(this.Cantidad1);
            this.Controls.Add(this.Meses);
            this.Controls.Add(this.InteresMensual);
            this.Controls.Add(this.IntereseMensual1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FechaDeposito1);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_InteresesGanadosAño;
        private System.Windows.Forms.Label Deposito;
        private System.Windows.Forms.TextBox TotalIntereses;
        private System.Windows.Forms.Label TotalIntereses1;
        private System.Windows.Forms.Button InteresesMensualButton;
        private System.Windows.Forms.TextBox CantidadDepositadaTextBox;
        private System.Windows.Forms.Label Cantidad1;
        private System.Windows.Forms.ListBox Meses;
        private System.Windows.Forms.TextBox InteresMensual;
        private System.Windows.Forms.Label IntereseMensual1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FechaDeposito1;
        private System.Windows.Forms.Label label7;
    }
}

