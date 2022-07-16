namespace prycertamen2
{
    partial class Form1
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.lsb1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(39, 57);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(58, 17);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(318, 57);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(58, 17);
            this.lblnumero.TabIndex = 1;
            this.lblnumero.Text = "Numero";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(126, 54);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(155, 22);
            this.txb1.TabIndex = 2;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(403, 54);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(137, 22);
            this.txb2.TabIndex = 3;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(571, 41);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(106, 49);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            // 
            // lsb1
            // 
            this.lsb1.FormattingEnabled = true;
            this.lsb1.ItemHeight = 16;
            this.lsb1.Location = new System.Drawing.Point(144, 114);
            this.lsb1.Name = "lsb1";
            this.lsb1.Size = new System.Drawing.Size(326, 292);
            this.lsb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 444);
            this.Controls.Add(this.lsb1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblnombre);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Agenda Telefónica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ListBox lsb1;
    }
}

