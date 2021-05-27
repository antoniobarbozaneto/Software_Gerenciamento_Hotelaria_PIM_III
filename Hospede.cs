using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Pim_3_Semestre
{
    class Hospede
    {
        public int Id_Hospede { get; set; }
        //public string Nome { get; set; }
        private static string nome;        
        public string Dt_Nasc { get; set; }
        public string Rg { get; set; }

        //public string Cpf { get; set; }
        private static string cpf;

        //public string Passaporte { get; set; }
        private static string passaporte;
        public string Rua { get; set; }
        public string Num { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Celular_Um { get; set; }
        public string Celular_Dois { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }

        public Hospede()
        {
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Passaporte
        {
            get { return passaporte; }
            set { passaporte = value; }
        }

        public void Incluir(string Nome, string Dt_Nasc, string Rg, string Cpf, string Passaporte, string Rua, string Num, string Bairro, string Cidade, string Cep, string Telefone, string Celular_Um, string Celular_Dois, string Email, string Obs)
        {
            this.Id_Hospede++;
            this.Nome = Nome;
            this.Dt_Nasc = Dt_Nasc;
            this.Rg = Rg;
            this.Cpf = Cpf;
            this.Passaporte = Passaporte;
            this.Rua = Rua;
            this.Num = Num;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Cep = Cep;
            this.Telefone = Telefone;
            this.Celular_Um = Celular_Um;
            this.Celular_Dois = Celular_Dois;
            this.Email = Email;
            this.Obs = Obs;
        }

        public void Excluir() // Mtd Exclui Dados do Obj.
        {
            this.Id_Hospede = 0;
            this.Nome = "";
            this.Dt_Nasc = "";
            this.Rg = "";
            this.Cpf = "";
            this.Passaporte = "";
            this.Rua = "";
            this.Num = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Cep = "";
            this.Telefone = "";
            this.Celular_Um = "";
            this.Celular_Dois = "";
            this.Email = "";
            this.Obs = "";
        }

        public void Editar(string Nome, string Dt_Nasc, string Rg, string Cpf, string Passaporte, string Rua, string Num, string Bairro, string Cidade, string Cep, string Telefone, string Celular_Um, string Celular_Dois, string Email, string Obs)
        {
            this.Id_Hospede = Id_Hospede;
            this.Nome = Nome;
            this.Dt_Nasc = Dt_Nasc;
            this.Rg = Rg;
            this.Cpf = Cpf;
            this.Passaporte = Passaporte;
            this.Rua = Rua;
            this.Num = Num;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Cep = Cep;
            this.Telefone = Telefone;
            this.Celular_Um = Celular_Um;
            this.Celular_Dois = Celular_Dois;
            this.Email = Email;
            this.Obs = Obs;
        }

    }
}