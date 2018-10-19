using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Restaurante;
using DTO_Restaurante;
namespace UI_Restaurante
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            btnAlterarFunc.Enabled = false;
            btnAlterarProd.Enabled = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Prod_DTO obj = new Prod_DTO();
                obj.nome = txtNomeProd.Text;
                obj.tipo = txtTipo.Text;
                obj.estoque = txtEstoque.Text;
                obj.preco = txtPreço.Text;
                obj.unid_medida = txtUniMed.Text;
                string retorno;
                retorno = Prod_BLL.CadProd(obj);
                if (retorno == "sucesso")
                {
                    this.Hide();
                    Home Tela = new Home();
                    Tela.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show(retorno, "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            /*catch (Exception ex)//MOSTRA A EXCEÇÃO NO BANCO, PORÉM COM SOFTWARE PRONTO NÃO É BOM MOSTRAR PARA O USUÁRIO!!
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {
            try
            {
                CADASTRO_DTO obj = new CADASTRO_DTO();
                obj.nome = txtNomeFun.Text;
                obj.CPF = mTxtCPF.Text;
                obj.RG = txtRgFunc.Text;
                obj.banco = cbbBancoFunc.Text;
                obj.agencia = txtAgenciaFunc.Text;
                obj.conta = txtContaFunc.Text;
                obj.endereco = txtEndereco.Text;
                obj.cidade = txtCidade.Text;
                obj.bairro = txtBairro.Text;
                obj.estado = CbEstado.Text;
                obj.numero = txtNumero.Text;
                obj.telefone = mTxtTelefone.Text;
                string retorno;//a string de retorno servirá para trazer o retorno que irá vir da classe bll ou dal
                retorno = CADASTRO_BLL.Val_Cad_Func(obj);

                if (retorno == "Sucesso!")
                {
                    MessageBox.Show(retorno, "Funcionário cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNomeFun.Clear();
                    txtRgFunc.Clear();
                    cbbBancoFunc.Text = "";
                    txtAgenciaFunc.Clear();
                    txtContaFunc.Clear();
                    txtEndereco.Clear();
                    txtCidade.Clear();
                    txtBairro.Clear();
                    CbEstado.Text = "";
                    txtNumero.Clear();
                    mTxtTelefone.Clear();
                    mTxtCPF.Clear();
                }
                else
                {
                    MessageBox.Show(retorno, "Funcionário não foi cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            /*catch (Exception ex)//MOSTRA A EXCEÇÃO NO BANCO, PORÉM COM SOFTWARE PRONTO NÃO É BOM MOSTRAR PARA O USUÁRIO!!
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtEndFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string CPF;
                CPF = mTxtCPF.Text;
                Buscar_BLL bll = new Buscar_BLL();
                CADASTRO_DTO obj = new CADASTRO_DTO();

                obj = bll.Val_Busca((CPF));
                txtNomeFun.Text = obj.nome;
                txtRgFunc.Text = obj.RG;
                cbbBancoFunc.Text = obj.banco;
                txtAgenciaFunc.Text = obj.agencia;
                txtContaFunc.Text = obj.conta;
                txtEndereco.Text = obj.endereco;
                txtCidade.Text = obj.cidade;
                txtBairro.Text = obj.bairro;
                CbEstado.Text = obj.estado;
                txtNumero.Text = obj.numero;
                mTxtTelefone.Text = obj.telefone;
                btnAlterarFunc.Enabled = true;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*try
            {
                CADASTRO_DTO obj = new CADASTRO_DTO();
                obj.CPF = mTxtCPF.Text;
                string retorna;
                retorna = Buscar_BLL.Val_Busca(obj);
                if (retorna == "Funcionário encontrado!")
                {
                    MessageBox.Show(retorna, "Funcionário encontrado!" + obj, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    


                }
                else
                {
                    MessageBox.Show(retorna, "Funcionário não foi encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }*/
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFun.Clear();
            txtRgFunc.Clear();
            cbbBancoFunc.Text = "";
            txtAgenciaFunc.Clear();
            txtContaFunc.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            CbEstado.Text = "";
            txtNumero.Clear();
            mTxtTelefone.Clear();
            mTxtCPF.Clear();
            btnAlterarFunc.Enabled = false;
        }

        private void btnAlterarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                CADASTRO_DTO obj = new CADASTRO_DTO();
                obj.nome = txtNomeFun.Text;
                obj.CPF = mTxtCPF.Text;
                obj.RG = txtRgFunc.Text;
                obj.banco = cbbBancoFunc.Text;
                obj.agencia = txtAgenciaFunc.Text;
                obj.conta = txtContaFunc.Text;
                obj.endereco = txtEndereco.Text;
                obj.cidade = txtCidade.Text;
                obj.bairro = txtBairro.Text;
                obj.estado = CbEstado.Text;
                obj.numero = txtNumero.Text;
                obj.telefone = mTxtTelefone.Text;
                string retorno;//a string de retorno servirá para trazer o retorno que irá vir da classe bll ou dal
                retorno = CADASTRO_BLL.Alterar(obj);
                if (retorno == "Sucesso!")
                {
                    MessageBox.Show(retorno, "Cadastro Alterado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNomeFun.Clear();
                    txtRgFunc.Clear();
                    cbbBancoFunc.Text = "";
                    txtAgenciaFunc.Clear();
                    txtContaFunc.Clear();
                    txtEndereco.Clear();
                    txtCidade.Clear();
                    txtBairro.Clear();
                    CbEstado.Text = "";
                    txtNumero.Clear();
                    mTxtTelefone.Clear();
                    mTxtCPF.Clear();
                }
                else
                {
                    MessageBox.Show(retorno, "Cadastro não foi alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void btnBuscarProd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Nome;
                Nome = txtNomeProd.Text;
                Buscar_BLL bll = new Buscar_BLL();
                Prod_DTO produto = new Prod_DTO();

                produto = bll.Validar_Busca_Produto((Nome));
                txtNomeProd.Text = produto.nome;
                txtPreço.Text = produto.preco;
                txtTipo.Text = produto.tipo;
                txtUniMed.Text = produto.unid_medida;
                txtEstoque.Text = produto.estoque;
                btnAlterarProd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            try
            {
                Prod_DTO obj = new Prod_DTO();
                obj.nome = txtNomeProd.Text;
                obj.preco = txtPreço.Text;
                obj.tipo = txtTipo.Text;
                obj.unid_medida = txtUniMed.Text;
                obj.estoque = txtEstoque.Text;
                string retorno;//a string de retorno servirá para trazer o retorno que irá vir da classe bll ou dal
                retorno = Prod_BLL.Alterar_prod(obj);
                if (retorno == "Sucesso!")
                {
                    MessageBox.Show(retorno, "Produto Alterado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  
                    txtNomeProd.Clear();
                    txtPreço.Clear();
                    txtTipo.Clear();
                    txtUniMed.Clear();
                    txtEstoque.Clear();
                }
                else
                {
                    MessageBox.Show(retorno, "O produto não foi alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
