﻿namespace ARES_ADM
{
    partial class frmCatalises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalises));
            this.cboFabricante = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboCatalise = new System.Windows.Forms.ComboBox();
            this.lstCatalises = new System.Windows.Forms.ListView();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorCatalise = new System.Windows.Forms.Label();
            this.lstAditivosCatalise = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTituloValorCatalise = new System.Windows.Forms.Label();
            this.btnInfotec = new System.Windows.Forms.Button();
            this.pnInfoTec = new System.Windows.Forms.Panel();
            this.txtSecagem_Cabine = new System.Windows.Forms.TextBox();
            this.txtIntervaloPassadas = new System.Windows.Forms.TextBox();
            this.txtNumeroPassadas = new System.Windows.Forms.TextBox();
            this.lblTituloAplicacao = new System.Windows.Forms.Label();
            this.lblTituloSecagemIR = new System.Windows.Forms.Label();
            this.lblTituloCabine = new System.Windows.Forms.Label();
            this.lblTituloSecagemCabine = new System.Windows.Forms.Label();
            this.txtSecagem_IRmedias = new System.Windows.Forms.TextBox();
            this.txtSecagem_IRCurtas = new System.Windows.Forms.TextBox();
            this.txtSecagem_Total = new System.Windows.Forms.TextBox();
            this.txtSecagem_Manuseio = new System.Windows.Forms.TextBox();
            this.txtSecagem_Toque = new System.Windows.Forms.TextBox();
            this.txtSecagem_LivrePo = new System.Windows.Forms.TextBox();
            this.lblTituloSecagemAr = new System.Windows.Forms.Label();
            this.lblTituloLivrePo = new System.Windows.Forms.Label();
            this.lblTituloToque = new System.Windows.Forms.Label();
            this.lblTituloManuseio = new System.Windows.Forms.Label();
            this.lblTituloCuraTotal = new System.Windows.Forms.Label();
            this.lblTituloOndasCurtas = new System.Windows.Forms.Label();
            this.lblTituloOndasMedias = new System.Windows.Forms.Label();
            this.lblTituloPassadas = new System.Windows.Forms.Label();
            this.lblTituloIntervalo = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnDatasheet = new System.Windows.Forms.Button();
            this.btnVideoAplicacao = new System.Windows.Forms.Button();
            this.btnInserirNaOS = new System.Windows.Forms.Button();
            this.pnPesagemCatalise = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnVideoAplicacao = new System.Windows.Forms.Panel();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.pnImagem = new System.Windows.Forms.Panel();
            this.picImagemCatalise = new System.Windows.Forms.PictureBox();
            this.picLogoFabricante = new System.Windows.Forms.PictureBox();
            this.pnInfoTec.SuspendLayout();
            this.pnPesagemCatalise.SuspendLayout();
            this.pnVideoAplicacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.pnCabecalho.SuspendLayout();
            this.pnImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemCatalise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFabricante)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFabricante
            // 
            this.cboFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboFabricante.FormattingEnabled = true;
            this.cboFabricante.Location = new System.Drawing.Point(227, 49);
            this.cboFabricante.Name = "cboFabricante";
            this.cboFabricante.Size = new System.Drawing.Size(410, 21);
            this.cboFabricante.TabIndex = 34;
            this.cboFabricante.SelectedIndexChanged += new System.EventHandler(this.cboFabricante_SelectedIndexChanged);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(227, 74);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(410, 21);
            this.cboCategoria.TabIndex = 35;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // cboCatalise
            // 
            this.cboCatalise.DisplayMember = "1";
            this.cboCatalise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatalise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCatalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatalise.ForeColor = System.Drawing.Color.Black;
            this.cboCatalise.FormattingEnabled = true;
            this.cboCatalise.Location = new System.Drawing.Point(227, 99);
            this.cboCatalise.Name = "cboCatalise";
            this.cboCatalise.Size = new System.Drawing.Size(410, 24);
            this.cboCatalise.TabIndex = 36;
            this.cboCatalise.ValueMember = "1";
            this.cboCatalise.SelectedIndexChanged += new System.EventHandler(this.cboCatalise_SelectedIndexChanged);
            // 
            // lstCatalises
            // 
            this.lstCatalises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstCatalises.HideSelection = false;
            this.lstCatalises.Location = new System.Drawing.Point(0, 24);
            this.lstCatalises.Name = "lstCatalises";
            this.lstCatalises.Size = new System.Drawing.Size(619, 138);
            this.lstCatalises.TabIndex = 37;
            this.lstCatalises.UseCompatibleStateImageBehavior = false;
            this.lstCatalises.SelectedIndexChanged += new System.EventHandler(this.lstCatalises_SelectedIndexChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.txtQuantidade.Location = new System.Drawing.Point(482, 279);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 31);
            this.txtQuantidade.TabIndex = 38;
            this.txtQuantidade.Text = "0";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantidade_MouseClick);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.Validated += new System.EventHandler(this.txtQuantidade_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(414, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Quantidade:";
            // 
            // lblValorCatalise
            // 
            this.lblValorCatalise.BackColor = System.Drawing.Color.Silver;
            this.lblValorCatalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorCatalise.ForeColor = System.Drawing.Color.Black;
            this.lblValorCatalise.Location = new System.Drawing.Point(494, 164);
            this.lblValorCatalise.Name = "lblValorCatalise";
            this.lblValorCatalise.Size = new System.Drawing.Size(120, 18);
            this.lblValorCatalise.TabIndex = 41;
            this.lblValorCatalise.Text = "0,00";
            this.lblValorCatalise.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lstAditivosCatalise
            // 
            this.lstAditivosCatalise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstAditivosCatalise.CheckBoxes = true;
            this.lstAditivosCatalise.Location = new System.Drawing.Point(0, 203);
            this.lstAditivosCatalise.MultiSelect = false;
            this.lstAditivosCatalise.Name = "lstAditivosCatalise";
            this.lstAditivosCatalise.Size = new System.Drawing.Size(397, 107);
            this.lstAditivosCatalise.TabIndex = 43;
            this.lstAditivosCatalise.UseCompatibleStateImageBehavior = false;
            this.lstAditivosCatalise.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstAditivosCatalise_ItemChecked);
            this.lstAditivosCatalise.SelectedIndexChanged += new System.EventHandler(this.lstAditivosCatalise_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Componentes Complementares";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(619, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Formulação Principal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloValorCatalise
            // 
            this.lblTituloValorCatalise.BackColor = System.Drawing.Color.Silver;
            this.lblTituloValorCatalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloValorCatalise.ForeColor = System.Drawing.Color.Black;
            this.lblTituloValorCatalise.Location = new System.Drawing.Point(0, 162);
            this.lblTituloValorCatalise.Name = "lblTituloValorCatalise";
            this.lblTituloValorCatalise.Size = new System.Drawing.Size(619, 20);
            this.lblTituloValorCatalise.TabIndex = 48;
            this.lblTituloValorCatalise.Text = "                                                                        Total Cat" +
    "alise";
            this.lblTituloValorCatalise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfotec
            // 
            this.btnInfotec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnInfotec.FlatAppearance.BorderSize = 0;
            this.btnInfotec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfotec.ForeColor = System.Drawing.Color.Silver;
            this.btnInfotec.Location = new System.Drawing.Point(227, 133);
            this.btnInfotec.Name = "btnInfotec";
            this.btnInfotec.Size = new System.Drawing.Size(410, 25);
            this.btnInfotec.TabIndex = 49;
            this.btnInfotec.Text = "Informações Técnicas";
            this.btnInfotec.UseVisualStyleBackColor = false;
            this.btnInfotec.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnInfoTec
            // 
            this.pnInfoTec.Controls.Add(this.txtSecagem_Cabine);
            this.pnInfoTec.Controls.Add(this.txtIntervaloPassadas);
            this.pnInfoTec.Controls.Add(this.txtNumeroPassadas);
            this.pnInfoTec.Controls.Add(this.lblTituloAplicacao);
            this.pnInfoTec.Controls.Add(this.lblTituloSecagemIR);
            this.pnInfoTec.Controls.Add(this.lblTituloCabine);
            this.pnInfoTec.Controls.Add(this.lblTituloSecagemCabine);
            this.pnInfoTec.Controls.Add(this.txtSecagem_IRmedias);
            this.pnInfoTec.Controls.Add(this.txtSecagem_IRCurtas);
            this.pnInfoTec.Controls.Add(this.txtSecagem_Total);
            this.pnInfoTec.Controls.Add(this.txtSecagem_Manuseio);
            this.pnInfoTec.Controls.Add(this.txtSecagem_Toque);
            this.pnInfoTec.Controls.Add(this.txtSecagem_LivrePo);
            this.pnInfoTec.Controls.Add(this.lblTituloSecagemAr);
            this.pnInfoTec.Controls.Add(this.lblTituloLivrePo);
            this.pnInfoTec.Controls.Add(this.lblTituloToque);
            this.pnInfoTec.Controls.Add(this.lblTituloManuseio);
            this.pnInfoTec.Controls.Add(this.lblTituloCuraTotal);
            this.pnInfoTec.Controls.Add(this.lblTituloOndasCurtas);
            this.pnInfoTec.Controls.Add(this.lblTituloOndasMedias);
            this.pnInfoTec.Controls.Add(this.lblTituloPassadas);
            this.pnInfoTec.Controls.Add(this.lblTituloIntervalo);
            this.pnInfoTec.Location = new System.Drawing.Point(23, 536);
            this.pnInfoTec.Name = "pnInfoTec";
            this.pnInfoTec.Size = new System.Drawing.Size(619, 112);
            this.pnInfoTec.TabIndex = 50;
            // 
            // txtSecagem_Cabine
            // 
            this.txtSecagem_Cabine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_Cabine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_Cabine.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_Cabine.Location = new System.Drawing.Point(527, 27);
            this.txtSecagem_Cabine.Name = "txtSecagem_Cabine";
            this.txtSecagem_Cabine.Size = new System.Drawing.Size(72, 13);
            this.txtSecagem_Cabine.TabIndex = 43;
            this.txtSecagem_Cabine.Text = "n/a";
            this.txtSecagem_Cabine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIntervaloPassadas
            // 
            this.txtIntervaloPassadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtIntervaloPassadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntervaloPassadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervaloPassadas.ForeColor = System.Drawing.Color.Silver;
            this.txtIntervaloPassadas.Location = new System.Drawing.Point(60, 47);
            this.txtIntervaloPassadas.Name = "txtIntervaloPassadas";
            this.txtIntervaloPassadas.Size = new System.Drawing.Size(161, 13);
            this.txtIntervaloPassadas.TabIndex = 42;
            this.txtIntervaloPassadas.Text = "n/a";
            this.txtIntervaloPassadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumeroPassadas
            // 
            this.txtNumeroPassadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtNumeroPassadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroPassadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPassadas.ForeColor = System.Drawing.Color.Silver;
            this.txtNumeroPassadas.Location = new System.Drawing.Point(60, 26);
            this.txtNumeroPassadas.Name = "txtNumeroPassadas";
            this.txtNumeroPassadas.Size = new System.Drawing.Size(161, 13);
            this.txtNumeroPassadas.TabIndex = 41;
            this.txtNumeroPassadas.Text = "n/a";
            this.txtNumeroPassadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTituloAplicacao
            // 
            this.lblTituloAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTituloAplicacao.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTituloAplicacao.Location = new System.Drawing.Point(0, 5);
            this.lblTituloAplicacao.Name = "lblTituloAplicacao";
            this.lblTituloAplicacao.Size = new System.Drawing.Size(230, 19);
            this.lblTituloAplicacao.TabIndex = 38;
            this.lblTituloAplicacao.Text = "Aplicação";
            this.lblTituloAplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloSecagemIR
            // 
            this.lblTituloSecagemIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTituloSecagemIR.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTituloSecagemIR.Location = new System.Drawing.Point(428, 51);
            this.lblTituloSecagemIR.Name = "lblTituloSecagemIR";
            this.lblTituloSecagemIR.Size = new System.Drawing.Size(190, 19);
            this.lblTituloSecagemIR.TabIndex = 35;
            this.lblTituloSecagemIR.Text = "Secagem Infra Vermelho";
            this.lblTituloSecagemIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloCabine
            // 
            this.lblTituloCabine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloCabine.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCabine.Location = new System.Drawing.Point(428, 24);
            this.lblTituloCabine.Name = "lblTituloCabine";
            this.lblTituloCabine.Size = new System.Drawing.Size(190, 18);
            this.lblTituloCabine.TabIndex = 34;
            this.lblTituloCabine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTituloSecagemCabine
            // 
            this.lblTituloSecagemCabine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTituloSecagemCabine.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTituloSecagemCabine.Location = new System.Drawing.Point(428, 5);
            this.lblTituloSecagemCabine.Name = "lblTituloSecagemCabine";
            this.lblTituloSecagemCabine.Size = new System.Drawing.Size(190, 19);
            this.lblTituloSecagemCabine.TabIndex = 33;
            this.lblTituloSecagemCabine.Text = "Secagem em Cabine (60º)";
            this.lblTituloSecagemCabine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSecagem_IRmedias
            // 
            this.txtSecagem_IRmedias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_IRmedias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_IRmedias.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_IRmedias.Location = new System.Drawing.Point(531, 92);
            this.txtSecagem_IRmedias.Name = "txtSecagem_IRmedias";
            this.txtSecagem_IRmedias.Size = new System.Drawing.Size(68, 13);
            this.txtSecagem_IRmedias.TabIndex = 16;
            this.txtSecagem_IRmedias.Text = "n/a";
            this.txtSecagem_IRmedias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecagem_IRCurtas
            // 
            this.txtSecagem_IRCurtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_IRCurtas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_IRCurtas.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_IRCurtas.Location = new System.Drawing.Point(531, 73);
            this.txtSecagem_IRCurtas.Name = "txtSecagem_IRCurtas";
            this.txtSecagem_IRCurtas.Size = new System.Drawing.Size(68, 13);
            this.txtSecagem_IRCurtas.TabIndex = 15;
            this.txtSecagem_IRCurtas.Text = "n/a";
            this.txtSecagem_IRCurtas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecagem_Total
            // 
            this.txtSecagem_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_Total.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_Total.Location = new System.Drawing.Point(342, 90);
            this.txtSecagem_Total.Name = "txtSecagem_Total";
            this.txtSecagem_Total.Size = new System.Drawing.Size(72, 13);
            this.txtSecagem_Total.TabIndex = 8;
            this.txtSecagem_Total.Text = "n/a";
            this.txtSecagem_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecagem_Manuseio
            // 
            this.txtSecagem_Manuseio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_Manuseio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_Manuseio.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_Manuseio.Location = new System.Drawing.Point(342, 69);
            this.txtSecagem_Manuseio.Name = "txtSecagem_Manuseio";
            this.txtSecagem_Manuseio.Size = new System.Drawing.Size(72, 13);
            this.txtSecagem_Manuseio.TabIndex = 7;
            this.txtSecagem_Manuseio.Text = "n/a";
            this.txtSecagem_Manuseio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecagem_Toque
            // 
            this.txtSecagem_Toque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_Toque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_Toque.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_Toque.Location = new System.Drawing.Point(342, 48);
            this.txtSecagem_Toque.Name = "txtSecagem_Toque";
            this.txtSecagem_Toque.Size = new System.Drawing.Size(72, 13);
            this.txtSecagem_Toque.TabIndex = 6;
            this.txtSecagem_Toque.Text = "n/a";
            this.txtSecagem_Toque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecagem_LivrePo
            // 
            this.txtSecagem_LivrePo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSecagem_LivrePo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecagem_LivrePo.ForeColor = System.Drawing.Color.Silver;
            this.txtSecagem_LivrePo.Location = new System.Drawing.Point(342, 27);
            this.txtSecagem_LivrePo.Name = "txtSecagem_LivrePo";
            this.txtSecagem_LivrePo.Size = new System.Drawing.Size(72, 13);
            this.txtSecagem_LivrePo.TabIndex = 5;
            this.txtSecagem_LivrePo.Text = "n/a";
            this.txtSecagem_LivrePo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTituloSecagemAr
            // 
            this.lblTituloSecagemAr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblTituloSecagemAr.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTituloSecagemAr.Location = new System.Drawing.Point(234, 5);
            this.lblTituloSecagemAr.Name = "lblTituloSecagemAr";
            this.lblTituloSecagemAr.Size = new System.Drawing.Size(190, 19);
            this.lblTituloSecagemAr.TabIndex = 2;
            this.lblTituloSecagemAr.Text = "Secagem ao Ar";
            this.lblTituloSecagemAr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloLivrePo
            // 
            this.lblTituloLivrePo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloLivrePo.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloLivrePo.Location = new System.Drawing.Point(234, 24);
            this.lblTituloLivrePo.Name = "lblTituloLivrePo";
            this.lblTituloLivrePo.Size = new System.Drawing.Size(190, 18);
            this.lblTituloLivrePo.TabIndex = 29;
            this.lblTituloLivrePo.Text = "  Livre de Pó :";
            this.lblTituloLivrePo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloToque
            // 
            this.lblTituloToque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloToque.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloToque.Location = new System.Drawing.Point(234, 45);
            this.lblTituloToque.Name = "lblTituloToque";
            this.lblTituloToque.Size = new System.Drawing.Size(190, 18);
            this.lblTituloToque.TabIndex = 30;
            this.lblTituloToque.Text = "  Toque :";
            this.lblTituloToque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloManuseio
            // 
            this.lblTituloManuseio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloManuseio.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloManuseio.Location = new System.Drawing.Point(234, 66);
            this.lblTituloManuseio.Name = "lblTituloManuseio";
            this.lblTituloManuseio.Size = new System.Drawing.Size(190, 18);
            this.lblTituloManuseio.TabIndex = 31;
            this.lblTituloManuseio.Text = "  Manuseio :";
            this.lblTituloManuseio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloCuraTotal
            // 
            this.lblTituloCuraTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloCuraTotal.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCuraTotal.Location = new System.Drawing.Point(234, 87);
            this.lblTituloCuraTotal.Name = "lblTituloCuraTotal";
            this.lblTituloCuraTotal.Size = new System.Drawing.Size(190, 18);
            this.lblTituloCuraTotal.TabIndex = 32;
            this.lblTituloCuraTotal.Text = "  Cura Total :";
            this.lblTituloCuraTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloOndasCurtas
            // 
            this.lblTituloOndasCurtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloOndasCurtas.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloOndasCurtas.Location = new System.Drawing.Point(428, 70);
            this.lblTituloOndasCurtas.Name = "lblTituloOndasCurtas";
            this.lblTituloOndasCurtas.Size = new System.Drawing.Size(190, 18);
            this.lblTituloOndasCurtas.TabIndex = 36;
            this.lblTituloOndasCurtas.Text = "   Ondas Curtas :";
            this.lblTituloOndasCurtas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloOndasMedias
            // 
            this.lblTituloOndasMedias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloOndasMedias.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloOndasMedias.Location = new System.Drawing.Point(428, 89);
            this.lblTituloOndasMedias.Name = "lblTituloOndasMedias";
            this.lblTituloOndasMedias.Size = new System.Drawing.Size(190, 18);
            this.lblTituloOndasMedias.TabIndex = 37;
            this.lblTituloOndasMedias.Text = "   Ondas Médias :";
            this.lblTituloOndasMedias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloPassadas
            // 
            this.lblTituloPassadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloPassadas.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloPassadas.Location = new System.Drawing.Point(0, 24);
            this.lblTituloPassadas.Name = "lblTituloPassadas";
            this.lblTituloPassadas.Size = new System.Drawing.Size(230, 18);
            this.lblTituloPassadas.TabIndex = 39;
            this.lblTituloPassadas.Text = " Passadas :";
            this.lblTituloPassadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloIntervalo
            // 
            this.lblTituloIntervalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTituloIntervalo.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloIntervalo.Location = new System.Drawing.Point(0, 45);
            this.lblTituloIntervalo.Name = "lblTituloIntervalo";
            this.lblTituloIntervalo.Size = new System.Drawing.Size(230, 18);
            this.lblTituloIntervalo.TabIndex = 40;
            this.lblTituloIntervalo.Text = " Intervalo :";
            this.lblTituloIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.webBrowser1.Location = new System.Drawing.Point(672, 52);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(467, 683);
            this.webBrowser1.TabIndex = 51;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnDatasheet
            // 
            this.btnDatasheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnDatasheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDatasheet.FlatAppearance.BorderSize = 0;
            this.btnDatasheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatasheet.ForeColor = System.Drawing.Color.Silver;
            this.btnDatasheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatasheet.Location = new System.Drawing.Point(227, 161);
            this.btnDatasheet.Name = "btnDatasheet";
            this.btnDatasheet.Size = new System.Drawing.Size(410, 25);
            this.btnDatasheet.TabIndex = 19;
            this.btnDatasheet.Text = "Boletim Técnico";
            this.btnDatasheet.UseVisualStyleBackColor = false;
            this.btnDatasheet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVideoAplicacao
            // 
            this.btnVideoAplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnVideoAplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVideoAplicacao.FlatAppearance.BorderSize = 0;
            this.btnVideoAplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoAplicacao.ForeColor = System.Drawing.Color.Silver;
            this.btnVideoAplicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideoAplicacao.Location = new System.Drawing.Point(227, 189);
            this.btnVideoAplicacao.Name = "btnVideoAplicacao";
            this.btnVideoAplicacao.Size = new System.Drawing.Size(410, 25);
            this.btnVideoAplicacao.TabIndex = 44;
            this.btnVideoAplicacao.Text = "Video Aplicação";
            this.btnVideoAplicacao.UseVisualStyleBackColor = false;
            this.btnVideoAplicacao.Click += new System.EventHandler(this.btnVideoAplicacao_Click);
            // 
            // btnInserirNaOS
            // 
            this.btnInserirNaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnInserirNaOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirNaOS.Enabled = false;
            this.btnInserirNaOS.FlatAppearance.BorderSize = 0;
            this.btnInserirNaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNaOS.ForeColor = System.Drawing.Color.Silver;
            this.btnInserirNaOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirNaOS.Location = new System.Drawing.Point(403, 189);
            this.btnInserirNaOS.Name = "btnInserirNaOS";
            this.btnInserirNaOS.Size = new System.Drawing.Size(216, 33);
            this.btnInserirNaOS.TabIndex = 52;
            this.btnInserirNaOS.Text = "Incluir na OS";
            this.btnInserirNaOS.UseVisualStyleBackColor = false;
            this.btnInserirNaOS.Visible = false;
            this.btnInserirNaOS.Click += new System.EventHandler(this.btnInserirNaOS_Click);
            // 
            // pnPesagemCatalise
            // 
            this.pnPesagemCatalise.Controls.Add(this.btnCancelar);
            this.pnPesagemCatalise.Controls.Add(this.label2);
            this.pnPesagemCatalise.Controls.Add(this.lstCatalises);
            this.pnPesagemCatalise.Controls.Add(this.btnInserirNaOS);
            this.pnPesagemCatalise.Controls.Add(this.txtQuantidade);
            this.pnPesagemCatalise.Controls.Add(this.label3);
            this.pnPesagemCatalise.Controls.Add(this.lstAditivosCatalise);
            this.pnPesagemCatalise.Controls.Add(this.label5);
            this.pnPesagemCatalise.Controls.Add(this.label6);
            this.pnPesagemCatalise.Controls.Add(this.lblValorCatalise);
            this.pnPesagemCatalise.Controls.Add(this.lblTituloValorCatalise);
            this.pnPesagemCatalise.Location = new System.Drawing.Point(23, 220);
            this.pnPesagemCatalise.Name = "pnPesagemCatalise";
            this.pnPesagemCatalise.Size = new System.Drawing.Size(619, 318);
            this.pnPesagemCatalise.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(403, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(216, 33);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(581, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "ML";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnVideoAplicacao
            // 
            this.pnVideoAplicacao.Controls.Add(this.VideoPlayer);
            this.pnVideoAplicacao.Location = new System.Drawing.Point(23, 220);
            this.pnVideoAplicacao.Name = "pnVideoAplicacao";
            this.pnVideoAplicacao.Size = new System.Drawing.Size(619, 318);
            this.pnVideoAplicacao.TabIndex = 54;
            this.pnVideoAplicacao.Visible = false;
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(0, 0);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(619, 318);
            this.VideoPlayer.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFechar.BackgroundImage = global::ARES_ADM.Properties.Resources.Close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Location = new System.Drawing.Point(1546, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(42, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(149, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "ARES ADM - Catalises";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp);
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnCabecalho.Controls.Add(this.lblTituloForm);
            this.pnCabecalho.Controls.Add(this.pnFavIcon);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(1581, 35);
            this.pnCabecalho.TabIndex = 32;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            this.pnCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseUp);
            // 
            // pnFavIcon
            // 
            this.pnFavIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnFavIcon.BackgroundImage = global::ARES_ADM.Properties.Resources.FavIcon;
            this.pnFavIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnFavIcon.Location = new System.Drawing.Point(10, 4);
            this.pnFavIcon.Name = "pnFavIcon";
            this.pnFavIcon.Size = new System.Drawing.Size(25, 25);
            this.pnFavIcon.TabIndex = 2;
            // 
            // pnImagem
            // 
            this.pnImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnImagem.BackgroundImage")));
            this.pnImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnImagem.Controls.Add(this.picImagemCatalise);
            this.pnImagem.Controls.Add(this.picLogoFabricante);
            this.pnImagem.Location = new System.Drawing.Point(0, 30);
            this.pnImagem.Name = "pnImagem";
            this.pnImagem.Size = new System.Drawing.Size(207, 172);
            this.pnImagem.TabIndex = 45;
            // 
            // picImagemCatalise
            // 
            this.picImagemCatalise.BackColor = System.Drawing.Color.Transparent;
            this.picImagemCatalise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picImagemCatalise.BackgroundImage")));
            this.picImagemCatalise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImagemCatalise.Location = new System.Drawing.Point(57, 54);
            this.picImagemCatalise.Name = "picImagemCatalise";
            this.picImagemCatalise.Size = new System.Drawing.Size(100, 103);
            this.picImagemCatalise.TabIndex = 33;
            this.picImagemCatalise.TabStop = false;
            // 
            // picLogoFabricante
            // 
            this.picLogoFabricante.BackColor = System.Drawing.Color.Transparent;
            this.picLogoFabricante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogoFabricante.Location = new System.Drawing.Point(52, 22);
            this.picLogoFabricante.Name = "picLogoFabricante";
            this.picLogoFabricante.Size = new System.Drawing.Size(111, 26);
            this.picLogoFabricante.TabIndex = 44;
            this.picLogoFabricante.TabStop = false;
            // 
            // frmCatalises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1581, 747);
            this.Controls.Add(this.btnVideoAplicacao);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pnInfoTec);
            this.Controls.Add(this.btnInfotec);
            this.Controls.Add(this.btnDatasheet);
            this.Controls.Add(this.cboCatalise);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboFabricante);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.pnImagem);
            this.Controls.Add(this.pnPesagemCatalise);
            this.Controls.Add(this.pnVideoAplicacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARES ADM - Catalises";
            this.pnInfoTec.ResumeLayout(false);
            this.pnInfoTec.PerformLayout();
            this.pnPesagemCatalise.ResumeLayout(false);
            this.pnPesagemCatalise.PerformLayout();
            this.pnVideoAplicacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemCatalise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFabricante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblValorCatalise;
        public System.Windows.Forms.Button btnDatasheet;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.TextBox txtSecagem_IRmedias;
        public System.Windows.Forms.TextBox txtSecagem_IRCurtas;
        public System.Windows.Forms.TextBox txtSecagem_Total;
        public System.Windows.Forms.TextBox txtSecagem_Manuseio;
        public System.Windows.Forms.TextBox txtSecagem_Toque;
        public System.Windows.Forms.TextBox txtSecagem_LivrePo;
        public System.Windows.Forms.Label lblTituloCabine;
        public System.Windows.Forms.TextBox txtIntervaloPassadas;
        public System.Windows.Forms.TextBox txtNumeroPassadas;
        public System.Windows.Forms.TextBox txtSecagem_Cabine;
        public System.Windows.Forms.Button btnVideoAplicacao;
        public System.Windows.Forms.Button btnInserirNaOS;
        public System.Windows.Forms.Button btnInfotec;
        public System.Windows.Forms.Panel pnInfoTec;
        public System.Windows.Forms.Panel pnPesagemCatalise;
        public System.Windows.Forms.Panel pnVideoAplicacao;
        private System.Windows.Forms.Label label2;
        public AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        public System.Windows.Forms.Panel btnFechar;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.ComboBox cboFabricante;
        public System.Windows.Forms.ComboBox cboCategoria;
        public System.Windows.Forms.ComboBox cboCatalise;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel pnImagem;
        public System.Windows.Forms.PictureBox picImagemCatalise;
        public System.Windows.Forms.PictureBox picLogoFabricante;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ListView lstCatalises;
        public System.Windows.Forms.ListView lstAditivosCatalise;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblTituloValorCatalise;
        public System.Windows.Forms.Label lblTituloSecagemAr;
        public System.Windows.Forms.Label lblTituloLivrePo;
        public System.Windows.Forms.Label lblTituloToque;
        public System.Windows.Forms.Label lblTituloManuseio;
        public System.Windows.Forms.Label lblTituloCuraTotal;
        public System.Windows.Forms.Label lblTituloSecagemIR;
        public System.Windows.Forms.Label lblTituloSecagemCabine;
        public System.Windows.Forms.Label lblTituloOndasCurtas;
        public System.Windows.Forms.Label lblTituloOndasMedias;
        public System.Windows.Forms.Label lblTituloAplicacao;
        public System.Windows.Forms.Label lblTituloPassadas;
        public System.Windows.Forms.Label lblTituloIntervalo;
    }
}