namespace ProyectoTienda.vistas
{
    partial class Ticket
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
            this.pbTicket = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicket)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTicket
            // 
            this.pbTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTicket.Location = new System.Drawing.Point(0, 0);
            this.pbTicket.Name = "pbTicket";
            this.pbTicket.Size = new System.Drawing.Size(584, 749);
            this.pbTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTicket.TabIndex = 15;
            this.pbTicket.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 100);
            this.panel1.TabIndex = 16;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(78)))), ((int)(((byte)(254)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(39, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(545, 88);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbTicket);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTicket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pbTicket;
        private Panel panel1;
        private Button btnConfirmar;
    }
}