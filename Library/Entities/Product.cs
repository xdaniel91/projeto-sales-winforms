﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Library.BaseDados;
using Newtonsoft.Json;
using Npgsql;

namespace WindowsFormsApp1
{
    public class Product
    {
        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [StringLength(20, ErrorMessage = "O nome do produto deve ter no máximo 20 caracteres")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "Campo preço obrigatório")]
        public double Preco { get; private set; }

        [Required(ErrorMessage = "Campo Quantidade obrigatório")]
        public int QuantidadeDisponivel { get; private set; }

        public Product(string nome, double preco, int quantidadeDisponivel)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeDisponivel = quantidadeDisponivel;
            ValidaClasse();
        }
        private Product()
        {
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

        protected internal void RemoveQtdeDisponivel(int qtde)
        {
            if (qtde > QuantidadeDisponivel || qtde <= 0)
            {
                throw new Exception("Valor inválido");
            }
            QuantidadeDisponivel -= qtde;
        }

        public object[] InformacoesTratadasParaBancoDeDados()
        {
            object[] array = new object[] { this.Nome, this.Preco.ToString().Replace(',', '.'), this.QuantidadeDisponivel};
            return array;
        }
    }
 
}
