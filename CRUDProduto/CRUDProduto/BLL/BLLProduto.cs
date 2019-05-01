using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDProduto.Modelo;
using CRUDProduto.DAL;

namespace CRUDProduto.BLL
{
    public class BLLProduto
    {
        public class BLLAgencia
        {
            public void Excluir(model modelo)
            {
                if (modelo.ID == 0)
                {
                    throw new Exception("Selecione uma produto");

                }
                DALProduto objExcluir = new DALProduto();
                objExcluir.Excluir(modelo);
            }


            public void Alterar(model modelo)
            {
                if (modelo.ID == 0)
                {
                    throw new Exception("Informe o Codigo!!.");
                }
                if (modelo.Nome == "")
                {
                    throw new Exception("Informe o Nome");
                }
                if (modelo.Marca == "")
                {
                    throw new Exception("Informe a Marca");
                }
                if (modelo.Preco == 0)
                {
                    throw new Exception("Informe o Preço");
                }
                if (modelo.Quantidade == 0)
                {
                    throw new Exception("Informe a Quantidade");
                }
                DALProduto objAlterar = new DALProduto();
                objAlterar.Alterar(modelo);

            }
            public void Inserir(model modelo)
            {
              
                if (modelo.Nome == "")
                {
                    throw new Exception("Informe o Nome");
                }
                if (modelo.Marca == "")
                {
                    throw new Exception("Informe a Marca");
                }
                if (modelo.Preco == 0)
                {
                    throw new Exception("Informe o Preço");
                }
                if (modelo.Quantidade == 0)
                {
                    throw new Exception("Informe a Quantidade");
                }

                DALProduto objIncluir = new DALProduto();
                objIncluir.Incluir(modelo);

            }
        }
    }
}
