﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Base_de_dados;
using Newtonsoft.Json;

namespace Library.Classes
{
    public class User
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente obrigatório")]           
            [StringLength(6, MinimumLength = 6, ErrorMessage = "O código do cliente deve ter 6 dígitos")]
            public string Id { get; set; }

            // infos pessoais
            [Required(ErrorMessage = "Campo nome obrigatório")]
            [StringLength(50, ErrorMessage = "Campo nome deve ter no máximo 50 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Campo CPF obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Campo CPF só aceita números")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "Campo CPF deve ter 11 caracteres")]
            public string CPF { get; set; }

            //endereço
            [Required(ErrorMessage = "Campo obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Campo CEP deve ter somente valores numericos")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Campo CEP deve ter 8 números")]
            public string CEP { get; set; }

            [Required(ErrorMessage = "Campo Logradouro obrigatorio")]
            [StringLength(100, ErrorMessage = "Campo logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }


            [Required(ErrorMessage = "Campo bairro obrigatório")]
            [StringLength(50, ErrorMessage = "Campo bairro deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Campo cidade obrigatório")]
            [StringLength(50, ErrorMessage = "Campo cidade deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Campo telefone obrigatório")]
            [StringLength(9, MinimumLength = 9, ErrorMessage = "Campo telefone deve ter 9 digitos")]
            public string Telefone { get; set; }

            public bool IsValid { get; set; }

            //public Unit(bool validate)
            //{
            //    if (validate == false)
            //    {
            //        throw new Exception("Validação não concluida");
            //    }
            //}
            public void ValidaComplemento()
            { 
                bool isvalid = Cls_Uteis.Valida(this.CPF);
                if (isvalid == false)
                {
                    throw new Exception("CPF inválido");
                }
                
            }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
                
            }

            #region CRUD DO FICHARIO DB

            public void IncluirDB(string conexao)
            {
                string clienteJson = SerializerUnit(this);
                var connection = new FicharyDB(conexao);
                if (connection.Status == true)
                {
                    connection.IncluirDB(this.Id, clienteJson);
                    if (connection.Status == false)
                    {
                        throw new Exception(connection.Message);
                    }
                }
                else
                {
                    throw new Exception(connection.Message);
                }
            }

            public Unit BuscarFicharioDB(string id, string conexao)
            {
                var connection = new FicharyDB(conexao);
                if (connection.Status == true)
                {
                    var clienteJson = connection.BuscarDB(id);
                    return User.DesSerializerUnit(clienteJson);
                }
                else
                {
                    throw new Exception(connection.Message);
                }
            }
            public void AlterarFicharioDB(string conexao)
            {
                var connection = new FicharyDB(conexao);
                var clienteJson = User.SerializerUnit(this);
                if (connection.Status == true)
                {
                    connection.AlterarDB(this.Id, clienteJson);
                    if (connection.Status == true)
                    {
                        throw new Exception(connection.Message);
                    }
                }
                else
                {
                    throw new Exception(connection.Message);
                }
            }

            public void ExcluirDB(string conexao)
            {

                var connection = new FicharyDB(conexao);
                if (connection.Status == true)
                {
                    connection.ApagarDB(this.Id);
                    if (connection.Status == true)
                    {

                    }
                }
                else
                {
                    throw new Exception(connection.Message);
                }
            }

            public List<List<string>> BuscarFicharioDBTodosDB(string conexao)
            {
                FicharyDB F = new FicharyDB(conexao);
                if (F.Status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();
                    if (F.Status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            User.Unit C = User.DesSerializerUnit(List[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.Message);
                    }
                }
                else
                {
                    throw new Exception(F.Message);
                }
            }
            #endregion
        }

        public class List
        {
            public string ID { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public DateTime DataNascimento { get; set; }
            public bool CursoSuperior { get; set; }
        }

        public static Unit DesSerializerUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializerUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

    }
}
