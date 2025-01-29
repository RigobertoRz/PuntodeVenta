namespace ProyectoTienda.vistas
{
    partial class Factura
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFactura = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(78)))), ((int)(((byte)(254)))));
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(0, 0);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(584, 100);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 100);
            this.panel1.TabIndex = 17;
            // 
            // pbFactura
            // 
            this.pbFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFactura.Location = new System.Drawing.Point(0, 0);
            this.pbFactura.Name = "pbFactura";
            this.pbFactura.Size = new System.Drawing.Size(584, 649);
            this.pbFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFactura.TabIndex = 18;
            this.pbFactura.TabStop = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 749);
            this.Controls.Add(this.pbFactura);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConfirmar;
        private Panel panel1;
        private PictureBox pbFactura;
    }
}