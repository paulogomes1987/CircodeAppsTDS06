﻿
namespace CircoApp3
{
    partial class FrmBuscaCEP
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNovoCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNovoEndereco = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNovoBairro = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNovaCidade = new System.Windows.Forms.Label();
            this.lblNovoComplemento = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblNovaUF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(273, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNovoCEP
            // 
            this.lblNovoCEP.AutoSize = true;
            this.lblNovoCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoCEP.Location = new System.Drawing.Point(25, 9);
            this.lblNovoCEP.Name = "lblNovoCEP";
            this.lblNovoCEP.Size = new System.Drawing.Size(79, 13);
            this.lblNovoCEP.TabIndex = 1;
            this.lblNovoCEP.Text = "Digite o CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(12, 51);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(224, 20);
            this.txtCEP.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(384, 54);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNovoEndereco
            // 
            this.lblNovoEndereco.AutoSize = true;
            this.lblNovoEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoEndereco.Location = new System.Drawing.Point(25, 110);
            this.lblNovoEndereco.Name = "lblNovoEndereco";
            this.lblNovoEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblNovoEndereco.TabIndex = 4;
            this.lblNovoEndereco.Text = "Endereço";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(25, 144);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 13);
            this.lblEndereco.TabIndex = 5;
            // 
            // lblNovoBairro
            // 
            this.lblNovoBairro.AutoSize = true;
            this.lblNovoBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoBairro.Location = new System.Drawing.Point(25, 180);
            this.lblNovoBairro.Name = "lblNovoBairro";
            this.lblNovoBairro.Size = new System.Drawing.Size(40, 13);
            this.lblNovoBairro.TabIndex = 6;
            this.lblNovoBairro.Text = "Bairro";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(25, 215);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(0, 13);
            this.lblBairro.TabIndex = 7;
            // 
            // lblNovaCidade
            // 
            this.lblNovaCidade.AutoSize = true;
            this.lblNovaCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaCidade.Location = new System.Drawing.Point(25, 251);
            this.lblNovaCidade.Name = "lblNovaCidade";
            this.lblNovaCidade.Size = new System.Drawing.Size(46, 13);
            this.lblNovaCidade.TabIndex = 8;
            this.lblNovaCidade.Text = "Cidade";
            // 
            // lblNovoComplemento
            // 
            this.lblNovoComplemento.AutoSize = true;
            this.lblNovoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoComplemento.Location = new System.Drawing.Point(296, 110);
            this.lblNovoComplemento.Name = "lblNovoComplemento";
            this.lblNovoComplemento.Size = new System.Drawing.Size(82, 13);
            this.lblNovoComplemento.TabIndex = 9;
            this.lblNovoComplemento.Text = "Complemento";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(296, 144);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(0, 13);
            this.lblComplemento.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(25, 290);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(0, 13);
            this.lblCidade.TabIndex = 11;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(313, 290);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(0, 13);
            this.lblUF.TabIndex = 13;
            // 
            // lblNovaUF
            // 
            this.lblNovaUF.AutoSize = true;
            this.lblNovaUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaUF.Location = new System.Drawing.Point(313, 251);
            this.lblNovaUF.Name = "lblNovaUF";
            this.lblNovaUF.Size = new System.Drawing.Size(23, 13);
            this.lblNovaUF.TabIndex = 12;
            this.lblNovaUF.Text = "UF";
            // 
            // FrmBuscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 302);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblNovaUF);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNovoComplemento);
            this.Controls.Add(this.lblNovaCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNovoBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNovoEndereco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblNovoCEP);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscaCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNovoCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNovoEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNovoBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNovaCidade;
        private System.Windows.Forms.Label lblNovoComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblNovaUF;
    }
}