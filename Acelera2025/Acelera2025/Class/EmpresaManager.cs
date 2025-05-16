using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acelera2025.Class
{
    internal class EmpresaManager
    {
        public static EmpresaManager Instance { get; private set; }

        private ArrayList empresaDB = new ArrayList();
        public Empresa minhaEmpresa;

        public EmpresaManager()
        {
            Instance = this;
        }

        public ArrayList GetEmpresaDB()
        {
            return empresaDB;
        }

        public void AddEmpresa(Empresa empresa)
        {
            empresa.SetIndex(empresaDB.Count);
            empresaDB.Add(empresa);
        }

        public void InativarEmpresa(Empresa empresa)
        {
            empresa.SetActivity(true); // true = inativa
        }

        public Empresa BuscarPorEmailSenha(string email, string senha)
        {
            foreach (Empresa e in empresaDB)
            {
                if (e.GetEmail() == email && e.GetSenha() == senha && !e.IsInactive())
                {
                    return e;
                }
            }
            return null;
        }

        public Empresa BuscarPorCNPJ(string cnpj)
        {
            foreach (Empresa e in empresaDB)
            {
                if (e.GetCNPJ() == cnpj)
                {
                    return e;
                }
            }
            return null;
        }
    }
}