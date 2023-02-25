namespace CesarLanza
{
    partial class Ejercicio3
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
            this.Valores = new System.Windows.Forms.ListBox();
            this.Mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valores
            // 
            this.Valores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Valores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 16;
            this.Valores.Location = new System.Drawing.Point(304, 105);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(188, 292);
            this.Valores.TabIndex = 5;
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.Color.White;
            this.Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.Location = new System.Drawing.Point(326, 63);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(149, 36);
            this.Mostrar.TabIndex = 4;
            this.Mostrar.Text = "Mostrar ";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.Mostrar);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Button Mostrar;
    }
}