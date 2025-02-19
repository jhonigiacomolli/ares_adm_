﻿using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace ARES_ADM.Classes
{
    class Classe_Funcionario
    {
        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();

        public string id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Sexo { get; private set; }
        public string Funcao { get; private set; }
        public string Salario { get; private set; }
        public string Comissao { get; private set; }
        public string CargaHoraria { get; private set; }
        public string ValorHora { get; private set; }


        public void Listar_Funcionarios(ListView LST, string SQL)
        {
            try
            {
                LST.Items.Clear();

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {

                        ListViewItem Item = new ListViewItem(DR["id"].ToString());
                        Item.SubItems.Add(DR["Nome"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Endereco"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Telefone"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Email"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Sexo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Funcao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Salario"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Comissao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["CargaHoraria"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["ValorHora"].ToString().TrimEnd().ToUpper());

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Pesquisa_Funcionario(ListView LST, string Criterio, string Pesquisa)
        {
            try
            {
                string ComandoSQL = string.Empty;

                if (Criterio.Equals("Nome")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Nome like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Endereço")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Endereco like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Sexo")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Sexo like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Função")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Funcao like '" + Pesquisa + "%'"; }

                Listar_Funcionarios(LST, ComandoSQL);
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Funcionario(string ID)
        {
            try
            {
                string SQL = "SELECT * FROM Funcionarios WHERE id='" + ID + "'";

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {

                        id = DR["id"].ToString().TrimEnd();
                        Nome = DR["Nome"].ToString().TrimEnd().ToUpper();
                        Endereco = DR["Endereco"].ToString().TrimEnd().ToUpper();
                        Telefone = DR["Telefone"].ToString().TrimEnd().ToUpper();
                        Email = DR["Email"].ToString().TrimEnd().ToUpper();
                        Sexo = DR["Sexo"].ToString().TrimEnd().ToUpper();
                        Funcao = DR["Funcao"].ToString().TrimEnd().ToUpper();
                        Salario = DR["Salario"].ToString().TrimEnd().ToUpper();
                        Comissao = DR["Comissao"].ToString().TrimEnd().ToUpper();
                        CargaHoraria = DR["CargaHoraria"].ToString().TrimEnd().ToUpper();
                        ValorHora = DR["ValorHora"].ToString().TrimEnd().ToUpper();
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

    }
}
