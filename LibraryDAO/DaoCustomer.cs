﻿using Library.BaseDados;
using Library.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDAO
{
    class Progam
    {
        static void Main() { }
    }
    public  class DaoCustomer : DaoBase, IDaoEntities
    {
        static Database postgre = new Database();
       
        public void Insert(dynamic customer)
        {
            try
            {
                var data = customer.BirthDate.ToString("yyyy/MM/dd").Replace('/', '-');
                postgre.connection = new NpgsqlConnection(postgre.connectString);
                postgre.connection.Open();
                postgre.sql = $@"select * from clientes_insert('{customer.Nome}', '{data}', '{customer.Cpf}', '{customer.Email}');";
                postgre.sqlCommand = new NpgsqlCommand(postgre.sql, postgre.connection);
                bool result = (bool)postgre.sqlCommand.ExecuteScalar();
                postgre.connection.Close();
                if (!result) throw new Exception("Não foi possível inserir o cliente! by: DaoCustomer");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AtualizarGrid(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = postgre.dt;
        }
        public void Select()
        {
            postgre.connection = new NpgsqlConnection(postgre.connectString);
            postgre.connection.Open();
            postgre.sql = @"select * from clientes_select()";
            postgre.sqlCommand = new NpgsqlCommand(postgre.sql, postgre.connection);
            postgre.dt = new DataTable();
            postgre.dt.Load(postgre.sqlCommand.ExecuteReader());
            postgre.connection.Close();
        }

        public void Delete(uint id)
        {
            try
            {
                Database postgre = new Database();
                postgre.connection = new NpgsqlConnection(postgre.connectString);
                postgre.connection.Open();
                postgre.sql = $@"select * from clientes_delete({id})";
                postgre.sqlCommand = new NpgsqlCommand(postgre.sql, postgre.connection);
                bool result = (bool)postgre.sqlCommand.ExecuteScalar();
                postgre.connection.Close();
                if (!result) throw new Exception("Não foi possível inserir o cliente! by: DaoCustomer");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(object[] infos, uint id)
        {
            try
            {
                var nome = infos[0] as string;
                var email = infos[1] as string;
                var data = infos[2] as string;
                var cpf = infos[3] as string;

                postgre.connection = new NpgsqlConnection(postgre.connectString);
                postgre.connection.Open();
                postgre.sql = $@"select * from clientes_update({id}, '{nome}', '{data}', '{cpf}', '{email}');";
                postgre.sqlCommand = new NpgsqlCommand(postgre.sql, postgre.connection);
                bool result = (bool)postgre.sqlCommand.ExecuteScalar();
                postgre.connection.Close();
                if (!result) throw new Exception("Não foi possível inserir o cliente! by: DaoCustomer");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
