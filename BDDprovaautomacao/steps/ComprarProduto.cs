using BDDprovaautomacao.tasks;
using BDDprovaautomacao.utils;
using BDDprovaautomacao.verificationpoints;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BDDprovaautomacao
{
    [Binding]
    public class StepDefinitions
    {
        private static IWebDriver navegador;
                

        [Given(@"Usuário está na Home Page")]
        public void GivenUsuarioEstaNaHomePage()
        {
            navegador = TestBase.createChrome();
        }

        [When(@"Usuário escolhe um produto")]        
        public void WhenUsuarioEscolheUmProduto()
        {            
            
        }
        
        [Then(@"É redirecionado para a página de descrição do produto")]
        public void ERedirecionadoParaAPaginaDeDescricaoDoProduto()
        {
            EscolheProdutoTask elemento = new EscolheProdutoTask(navegador);
            elemento.clicarImagem();
        }

        [Given(@"Usuário está na página de descrição de seu produto")]
        public void GivenUsuarioEstaNaPaginaDeDescricaoDeSeuProduto()
        {
            PaginaDescricaoVerificationPoint tituloDescricaoDoProduto = new PaginaDescricaoVerificationPoint(navegador);
            tituloDescricaoDoProduto.getTitulo();

        }

        [When(@"Usuário adiciona seu produto no carrinho")]        
        public void WhenUsuarioAdicionaSeuProdutoNoCarrinho()
        {
           
        }

        [Then(@"O usuário vai para a página de confirmação de seu item no carrinho")]
        public void ThenOUsuarioVaiParaAPaginaDeConfirmacaoDeSeuItemNoCarrinho()
        {
            AdicionaNoCarrinhoTask buttonAddToCart = new AdicionaNoCarrinhoTask(navegador);
            buttonAddToCart.clicarBotao();
        }

        [Given(@"Usuário está na pagina de confirmação")]
        public void GivenUsuarioEstaNaPaginaDeConfirmacao()
        {
            PaginaConfirmacaoVerificationPoint tituloProccedToCheckout = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloProccedToCheckout.getTitulo();
        }

        [Given(@"Procede para o checkout")]
        public void GivenProcedeParaOCheckout()
        {
            ProcedeParaCheckoutTask buttonProceedToCheckout = new ProcedeParaCheckoutTask(navegador);
            buttonProceedToCheckout.clicarBotao();
        }

        [When(@"O usuário confirma o produto")]
        public void WhenOUsuarioConfirmaOProduto()
        {
            ConfirmacaoDoProdutoVerificationPoint linkTextDoProduto = new ConfirmacaoDoProdutoVerificationPoint(navegador);
            linkTextDoProduto.getTitulo();
        }

        [Then(@"O usuário finaliza a primeira etapa da compra")]
        public void ThenOUsuarioFinalizaAPrimeiraEtapaDaCompra()
        {
            ProcedeParaCadastroTask buttonProceedToCheckout2 = new ProcedeParaCadastroTask(navegador);
            buttonProceedToCheckout2.clicarBotao();
        }

        [Given(@"Usuario cadastra seu email")]
        public void GivenUsuarioCadastraSeuEmail()
        {
            SignInPageTask campoCadastraEmail = new SignInPageTask(navegador);
            campoCadastraEmail.cadastrarEmail();
        }

        [Given(@"Usuario confirma seu email")]
        public void GivenUsuarioConfirmaSeuEmail()
        {
            SignInPageTask submitCreateButton = new SignInPageTask(navegador);
            submitCreateButton.clicarBotao();
        }

        [Then(@"Usuário preenche e envia formulário de cadastro")]
        public void ThenUsuarioPreencheEEnviaFormularioDeCadastro()
        {
            SignInPageTask elementosDeCadastro = new SignInPageTask(navegador);
            elementosDeCadastro.preencherFormulario();
        }

        [Given(@"Usuário valida seus dados e prossegue")]
        public void GivenUsuarioValidaSeusDadosEProssegue() { 
           PaginaAdressVerificationPoint validarDados = new PaginaAdressVerificationPoint(navegador);
           validarDados.getAdress();
           PaginaAdressTask prosseguir = new PaginaAdressTask(navegador);
           prosseguir.clicarBotao();
        }

        [Given(@"Usuário aceita os termos de serviço e prossegue")]
        public void GivenUsuarioAceitaOsTermosDeServicoEProssegue()
        {
            ShippingPageTask aceitarTermos = new ShippingPageTask(navegador);
            aceitarTermos.marcarCheckBox();
            ShippingPageTask buttonProceedToCheckout = new ShippingPageTask(navegador);
            buttonProceedToCheckout.clicarBotao();
        }

        [Given(@"Usuário valida o total do valor de seu produto")]
        public void GivenUsuarioValidaOTotalDoValorDeSeuProduto()
        {
            PaymentVerificationPoint total = new PaymentVerificationPoint(navegador);
            total.getTotal();
        }

        [When(@"Usuário seleciona um método de pagamento e prossegue")]
        public void WhenUsuarioSelecionaUmMetodoDePagamentoEProssegue()
        {
            PaymentTask metodoDePagamento = new PaymentTask(navegador);
            metodoDePagamento.clicarBotao();
        }

        [Then(@"Usuário confere a finalização da sua compra")]
        public void ThenUsuarioCo()
        {
            PaymentVerificationPoint totalAmount = new PaymentVerificationPoint(navegador);
            totalAmount.getTotalAmount();
            PaymentTask confirmarMinhaCompra = new PaymentTask(navegador);
            confirmarMinhaCompra.clicarBotaoConfirmandoPagamento();
        }
    }    
}