using System;

namespace Acelera2025.Class
{
    internal class Endereco
    {
        private string cidade;
        private string uf;
        private string cep;
        private string bairro;
        private string nomeRua;
        private string num;

        public Endereco(string cidade, string uf, string cep, string bairro, string nomeRua, string num)
        {
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.bairro = bairro;
            this.nomeRua = nomeRua;
            this.num = num;
        }

        public string GetCidade()
        {
            return cidade;
        }

        public string GetUf()
        {
            return uf;
        }

        public string GetCep()
        {
            return cep;
        }

        public string GetBairro()
        {
            return bairro;
        }

        public string GetNomeRua()
        {
            return nomeRua;
        }

        public string GetNum()
        {
            return num;
        }
    }
}
