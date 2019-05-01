using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProduto.DAL
{
   public class dados
    {
        public static string ConexaoDB
        {
            get
            {
                //conexao com o banco de dados (problema com a barra invertida do nome do servidor sqlexpress)
                return "server=SMILEY-PC\\SQLEXPRESS;database=dbMercado;user=sa;pwd=database123";
            }
        }
    }
}
