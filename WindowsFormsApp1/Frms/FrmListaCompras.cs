﻿using Library.BaseDados;
using Npgsql;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Frms
{
    public partial class FrmListaCompras : UserControl
    {
       // Order OrderSelect;
       // Database postgre = new Database();
        LibraryDAO.DaoCustomer daoCustomer = new LibraryDAO.DaoCustomer();
        public FrmListaCompras()
        {
            InitializeComponent();
        }

        private new void DoubleClick(object sender, EventArgs e)
        {
        }

        private void FrmListaCompras_Load(object sender, EventArgs e)
        {
            AtualizarGridEmBackground();
        }

      /* void MySelect()
        {
            try
            {
                postgre.connection = new NpgsqlConnection(postgre.connectString);
                postgre.connection.Open();
                postgre.sql = @"select cl_nome as Cliente, oi_quantidade as Quantidade, pd_nome as Produto, oi_valortotal as Total, to_char(oi_datahora, 'DD/MM/YYYY') as Data from clientes		
                            join compra_item on oi_clienteId = clientes.cl_id
                            join produtos on produtos.pd_id = compra_item.oi_produtoId";
                postgre.sqlCommand = new NpgsqlCommand(postgre.sql, postgre.connection);
                postgre.dt = new DataTable();
                postgre.dt.Load(postgre.sqlCommand.ExecuteReader());
                postgre.connection.Close();
                dgv_clientexitem.DataSource = null; /* reset datagrid view 
                dgv_clientexitem.DataSource = postgre.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } */

        void AtualizarGridEmBackground()
        {
            BackgroundWorker myBW = new BackgroundWorker();
            myBW.DoWork += (obj, args) => daoCustomer.SelectItemsxClientes();
            myBW.RunWorkerCompleted += (obj, args) => daoCustomer.AtualizarGrid(dgv_clientexitem);
            myBW.RunWorkerAsync();

        }

        private void btnPesquisarID_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarData_Click(object sender, EventArgs e)
        {

        }
    }
}