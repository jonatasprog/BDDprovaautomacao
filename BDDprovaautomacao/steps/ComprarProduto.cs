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

        [Given(@"Usuário clica na imagem do produto")]
        public void GivenUsuarioClicaNaImagemDoProduto()
        {
            EscolheProdutoTask elemento = new EscolheProdutoTask(navegador);
            elemento.clicarImagem();
        }

        [Given(@"O usuário é redirecionado para a página de descricao do produto")]
        public void GivenOUsuarioERedirecionadoParaAPaginaDeDescricaoDoProduto()
        {
            PaginaDescricaoVerificationPoint tituloDescricaoDoProduto = new PaginaDescricaoVerificationPoint(navegador);
            tituloDescricaoDoProduto.getTitulo();
        }

        [When(@"Usuário clica no botão de adicionar o produto no carrinho")]
        public void WhenUsuarioClicaNoBotaoDeAdicionarOProdutoNoCarrinho()
        {
            AdicionaNoCarrinhoTask buttonAddToCart = new AdicionaNoCarrinhoTask(navegador);
            buttonAddToCart.clicarBotao();
        }

        [When(@"Usuário é redirecionado para a janela de confirmação do produto")]
        public void WhenUsuarioERedirecionadoParaAJanelaDeConfirmacaoDoProduto()
        {
            PaginaConfirmacaoVerificationPoint tituloProccedToCheckout = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloProccedToCheckout.getTitulo();
        }

        [Then(@"O produto é apresentado na janela de confirmação do produto")]
        public void ThenOProdutoEApresentadoNaJanelaDeConfirmacaoDoProduto()
        {
            PaginaConfirmacaoVerificationPoint tituloDoProduto = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloDoProduto.getTitulo2();
        }

        [Given(@"Usuário está na janela de confirmação do produto")]
        public void GivenUsuarioEstaNaJanelaDeConfirmacaoDoProduto()
        {
            PaginaConfirmacaoVerificationPoint tituloProccedToCheckout = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloProccedToCheckout.getTitulo();
        }

        [Given(@"Usuário confere o seu produto")]
        public void GivenUsuarioConfereOSeuProduto()
        {
            ConfirmacaoDoProdutoVerificationPoint linkTextDoProduto = new ConfirmacaoDoProdutoVerificationPoint(navegador);
            linkTextDoProduto.getTitulo();
        }

        [When(@"Usuário clica no botão de proceder para o checkout")]
        public void WhenUsuarioClicaNoBotaoDeProcederParaOCheckout()
        {
            ProcedeParaCheckoutTask buttonProceedToCheckout = new ProcedeParaCheckoutTask(navegador);
            buttonProceedToCheckout.clicarBotao();
        }

        [When(@"O usuário é redirecionado para a página do carrinho")]
        public void WhenOUsuarioERedirecionadoParaAPaginaDoCarrinho()
        {         

        }

        [Then(@"Usuário clica no botão procede para checkout")]
        public void ThenUsuarioClicaNoBotaoProcedeParaCheckout()
        {
            ProcedeParaCadastroTask buttonProceedToCheckout2 = new ProcedeParaCadastroTask(navegador);
            buttonProceedToCheckout2.clicarBotao();
        }




        [Given(@"Usuário está na primeira página de Sign In")]
        public void GivenUsuarioEstaNaPrimeiraPaginaDeSignIn()
        {
            
        }

        [Given(@"Usuário digita seu email no campo de email para cadastro")]
        public void GivenUsuarioDigitaSeuEmailNoCampoDeEmailParaCadastro()
        {
            SignInPageTask campoCadastraEmail = new SignInPageTask(navegador);
            campoCadastraEmail.cadastrarEmail();
        }

        [Given(@"Usuário clica no botão de criar conta")]
        public void GivenUsuarioClicaNoBotaoDeCriarConta()
        {
            SignInPageTask submitCreateButton = new SignInPageTask(navegador);
            submitCreateButton.clicarBotao();
        }

        [When(@"Usuario finalmente está na página de Sign In de cadastro dos seus demais dados")]
        public void WhenUsuarioFinalmenteEstaNaPaginaDeSignInDeCadastroDosSeusDemaisDados()
        {
            
        }

        [Then(@"Usuário preenche o formulário e clica no botão para registrar")]
        public void ThenUsuarioPreencheOFormularioEClicaNoBotaoParaRegistrar()
        {
            SignInPageTask elementosDeCadastro = new SignInPageTask(navegador);
            elementosDeCadastro.preencherFormulario();
        }                  

        [Given(@"Usuário valida seus dados e prossegue")]
        public void GivenUsuarioValidaSeusDadosEProssegue()
        { 
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