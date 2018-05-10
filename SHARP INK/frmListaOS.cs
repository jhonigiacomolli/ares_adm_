﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHARP_INK.Classes;

namespace SHARP_INK
{
    public partial class frmListaOS : Form
    {
        bool mouseDown;
        Point lastLocation;
        public int ItemSelecionado;

        public frmListaOS()
        {
            InitializeComponent();
            pnMenuOS.Height = 0;

            new Classe_Tema().TEMA_frmListaOS(this);
            new Classe_Listviews().Criar_LST_Veiculos(lstVeiculos);
            new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos");
        }

        private void pnCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }   
        }

        private void pnCabecalho_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lblTituloForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void lblTituloForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void lblTituloForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            if (pnMenuOS.Height == 0) 
            {
                pnMenuOS.Height = 92;
            }
            else
            {
                pnMenuOS.Height = 0;
            }
        }

        private void frmListaOS_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void pnCabecalho_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void lstVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;
            ItemSelecionado =int.Parse(lstVeiculos.FocusedItem.Text);
        }

        private void lstVeiculos_MouseDown(object sender, MouseEventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;

            frmCadastroOS cadastro = new frmCadastroOS(this);
            cadastro.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string id = lstVeiculos.FocusedItem.Text.TrimEnd();
            string Proprietario = lstVeiculos.FocusedItem.SubItems[1].Text.TrimEnd();
            string Veiculo = lstVeiculos.FocusedItem.SubItems[2].Text.TrimEnd();
            string Placa = lstVeiculos.FocusedItem.SubItems[3].Text.TrimEnd();
            string Cor = lstVeiculos.FocusedItem.SubItems[4].Text.TrimEnd();
            string Tamanho = lstVeiculos.FocusedItem.SubItems[5].Text.TrimEnd();

            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão de item", "Deseja realmente excluir a OS Nº " + id + "\n" + "Proprietario: " + Proprietario + "\nVeiculo: " + Veiculo + "\nPlaca: " + Placa);
            messagebox.ShowDialog();


        }
    }
}
