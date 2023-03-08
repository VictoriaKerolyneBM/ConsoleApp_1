using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    public class Endereco
    {
        private int Id;
        private int Cep;
        private string Logradouro;
        private int Numero;
        private string Bairro;
        private string Cidade;

     public Endereco(int id,int cep, string logradouro,int numero,string bairro, string cidade) 
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        public int getId()
        {
            return Id;
        }

        public int getCep()
        {
            return Cep;
        }

        public string getLogradouro()
        {
            return Logradouro;
        }
        public int getNumero()
        {
            return Numero;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public void setId(int id)
        {
           Id=id;
        }

        public void setCep(int cep)
        {
            Cep=cep;
        }

        public void setLogradouro(string logradouro)
        {
             Logradouro = logradouro;
        }
        public void setNumero(int numero)
        {
            Numero = numero ;
        }

        public void setBairro(string bairro)
        {
             Bairro=bairro;
        }

        public void setCidade(string cidade)
        {
             Cidade=cidade;
        }
    }
}
