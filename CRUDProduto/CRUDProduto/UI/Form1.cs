using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDProduto.Modelo;
using CRUDProduto.DAL;
using CRUDProduto.BLL;

namespace CRUDProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            model objDados = new model();
            
            objDados.Nome = tbNome.Text;
            objDados.Marca = tbMarca.Text;
            objDados.Preco = Convert.ToDouble(tbPreco.Text);
            objDados.Quantidade = Convert.ToInt16(tbQntd.Text);

            //USANDO REGRAS DE NEGOCIOS NO BOTÃO INSERIR
            //Erro ao usar o metodo Inserir da BLLPRODUTO

             BLLProduto objInserir = new BLLProduto();
             objInserir.Inserir(objDados);



        }
    }
}
