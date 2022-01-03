﻿using Library.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmChooseUser : Form
    {
        public User.Unit CustomerChosen{ get; set; }

        public FrmChooseUser()
        {
            InitializeComponent();
            EscreverUsers();
        }

        public void EscreverUsers()
        {
            foreach (var item in DataBase.lista_users)
            {
                lst_cliente.Items.Add(item);
            }
        }

        void AddUser()
        {
            if (lst_cliente.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                try
                {
                    User.Unit user = DataBase.lista_users[lst_cliente.SelectedIndex]; // usuario selecionado na lst
                    if (user != null)
                    {
                        CustomerChosen = user;
                    }
                    else
                    {
                        throw new Exception("Cliente escolhido = nulo");
                    }

                    //if (user != null)
                    //{
                    //    lst_produtos.Enabled = true;
                    //    btnFinzaliar.Enabled = true;
                    //    btnQuantidade.Enabled = true;
                    //}

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void lst_cliente_DoubleClick(object sender, EventArgs e)
        {
            AddUser();
            this.Close();
        }
    }
}