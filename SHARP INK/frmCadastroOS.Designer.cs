﻿namespace SHARP_INK
{
    partial class frmCadastroOS
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
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroOS = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtProprietario = new System.Windows.Forms.ComboBox();
            this.txtCor = new System.Windows.Forms.ComboBox();
            this.txtTamanho = new System.Windows.Forms.ComboBox();
            this.txtPLaca = new System.Windows.Forms.MaskedTextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnCabecalho.SuspendLayout();
            this.btnFechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.Black;
            this.pnCabecalho.Controls.Add(this.lblTituloForm);
            this.pnCabecalho.Controls.Add(this.pnFavIcon);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(459, 35);
            this.pnCabecalho.TabIndex = 2;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            this.pnCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseUp);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(56, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(325, 20);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP INK - Cadastro de Ordem de Serviço";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFechar.Controls.Add(this.label1);
            this.btnFechar.Location = new System.Drawing.Point(424, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnFavIcon
            // 
            this.pnFavIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnFavIcon.BackgroundImage = global::SHARP_INK.Properties.Resources.FavIcon_25px_;
            this.pnFavIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnFavIcon.Location = new System.Drawing.Point(10, 0);
            this.pnFavIcon.Name = "pnFavIcon";
            this.pnFavIcon.Size = new System.Drawing.Size(35, 35);
            this.pnFavIcon.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Silver;
            this.lblID.Location = new System.Drawing.Point(12, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Numero OS";
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.ForeColor = System.Drawing.Color.Silver;
            this.lblProprietario.Location = new System.Drawing.Point(12, 84);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(60, 13);
            this.lblProprietario.TabIndex = 4;
            this.lblProprietario.Text = "Proprietário";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.lblVeiculo.Location = new System.Drawing.Point(12, 116);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(42, 13);
            this.lblVeiculo.TabIndex = 5;
            this.lblVeiculo.Text = "Veiculo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.ForeColor = System.Drawing.Color.Silver;
            this.lblPlaca.Location = new System.Drawing.Point(12, 148);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 6;
            this.lblPlaca.Text = "Placa";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.ForeColor = System.Drawing.Color.Silver;
            this.lblCor.Location = new System.Drawing.Point(12, 180);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 7;
            this.lblCor.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tamanho";
            // 
            // txtNumeroOS
            // 
            this.txtNumeroOS.Location = new System.Drawing.Point(93, 48);
            this.txtNumeroOS.Name = "txtNumeroOS";
            this.txtNumeroOS.Size = new System.Drawing.Size(128, 20);
            this.txtNumeroOS.TabIndex = 0;
            this.txtNumeroOS.Validated += new System.EventHandler(this.txtNumeroOS_Validated);
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(93, 111);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(335, 20);
            this.txtVeiculo.TabIndex = 2;
            // 
            // txtProprietario
            // 
            this.txtProprietario.FormattingEnabled = true;
            this.txtProprietario.Location = new System.Drawing.Point(93, 79);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(335, 21);
            this.txtProprietario.TabIndex = 1;
            // 
            // txtCor
            // 
            this.txtCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCor.FormattingEnabled = true;
            this.txtCor.Location = new System.Drawing.Point(93, 173);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(335, 21);
            this.txtCor.TabIndex = 4;
            // 
            // txtTamanho
            // 
            this.txtTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTamanho.FormattingEnabled = true;
            this.txtTamanho.Location = new System.Drawing.Point(93, 205);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(335, 21);
            this.txtTamanho.TabIndex = 5;
            // 
            // txtPLaca
            // 
            this.txtPLaca.Location = new System.Drawing.Point(93, 142);
            this.txtPLaca.Mask = "AAA-9999";
            this.txtPLaca.Name = "txtPLaca";
            this.txtPLaca.Size = new System.Drawing.Size(128, 20);
            this.txtPLaca.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(86, 250);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(286, 40);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Cadastrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmCadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(459, 307);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtPLaca);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.txtNumeroOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroOS";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.btnFechar.ResumeLayout(false);
            this.btnFechar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroOS;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtVeiculo;
        public System.Windows.Forms.ComboBox txtProprietario;
        public System.Windows.Forms.ComboBox txtCor;
        public System.Windows.Forms.ComboBox txtTamanho;
        public System.Windows.Forms.MaskedTextBox txtPLaca;
    }
}