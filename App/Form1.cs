using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCep
{
    public partial class BuscaCepApp : Form
    {
        public BuscaCepApp()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CepService cepService = new CepService();
            string enderecoFormatado="";

            var endereco = cepService.buscarEndereco(txt_cep.Text);
            if(!string.IsNullOrEmpty(endereco.cep))
                enderecoFormatado = $"Rua: {endereco.logradouro},\r\nBairro: {endereco.bairro},\r\nEstado: {endereco.uf},\r\nCep: {endereco.cep}";

            txt_resultado.Text = enderecoFormatado;
            txt_cep.Clear();
        }
    }
}
