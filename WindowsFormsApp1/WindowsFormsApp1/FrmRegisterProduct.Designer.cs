﻿
namespace WindowsFormsApp1
{
    partial class FrmRegisterProduct
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantity = new WindowsFormsApp1.Controls.txtInt();
            this.txtMoeda = new WindowsFormsApp1.Controls.txtMoeda();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtName.Location = new System.Drawing.Point(142, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 24);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblName.Location = new System.Drawing.Point(16, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPrice.Location = new System.Drawing.Point(16, 82);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 26);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "label2";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblQuantity.Location = new System.Drawing.Point(16, 142);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(113, 24);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "label3";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnRegister.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegister.Location = new System.Drawing.Point(3, 239);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(290, 32);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "button1";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtMoeda);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 473);
            this.panel1.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(142, 142);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(71, 24);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtMoeda
            // 
            this.txtMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMoeda.Location = new System.Drawing.Point(142, 84);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(71, 24);
            this.txtMoeda.TabIndex = 10;
            // 
            // FrmRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegisterProduct";
            this.Size = new System.Drawing.Size(689, 479);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel1;
        private Controls.txtMoeda txtMoeda;
        private Controls.txtInt txtQuantity;
    }
}
