using BDDprovaautomacao.tasks;
using BDDprovaautomacao.utils;
using BDDprovaautomacao.verificationpoints;
using BDDprovaautomacao.verificationPoints;
using OpenQA.Selenium;
using System;
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
            Report.Start("BDDprovaautomacao", true);
            Report.AddTestCase("BDDprovaautomacao", DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_FFF"));
            navegador = TestBase.CreateChrome();
            HomePageVerificationPoint homePage = new HomePageVerificationPoint(navegador);
            homePage.GetHomePageVP();
        }

        [Given(@"Usuário clica na imagem do produto")]
        public void GivenUsuarioClicaNaImagemDoProduto()
        {
            HomePageTask elemento = new HomePageTask(navegador);
            elemento.ClicarImagem();
        }

        [Given(@"O usuário é redirecionado para a página de descricao do produto")]
        public void GivenOUsuarioERedirecionadoParaAPaginaDeDescricaoDoProduto()
        {
            DescriptionPageVerificationPoint tituloDescricaoDoProduto = new DescriptionPageVerificationPoint(navegador);
            tituloDescricaoDoProduto.GetTituloVP();
        }

        [When(@"Usuário clica no botão de adicionar o produto no carrinho")]
        public void WhenUsuarioClicaNoBotaoDeAdicionarOProdutoNoCarrinho()
        {
            AddToCartTask buttonAddToCart = new AddToCartTask(navegador);
            buttonAddToCart.ClicarBotao();
        }

        [When(@"Usuário é redirecionado para a janela de confirmação do produto")]
        public void WhenUsuarioERedirecionadoParaAJanelaDeConfirmacaoDoProduto()
        {
            ConfirmationPageVerificationPoint tituloProccedToCheckout = new ConfirmationPageVerificationPoint(navegador);
            tituloProccedToCheckout.GetTituloVP();
        }

        [Then(@"O produto é apresentado na janela de confirmação do produto")]
        public void ThenOProdutoEApresentadoNaJanelaDeConfirmacaoDoProduto()
        {
            ConfirmationPageVerificationPoint tituloDoProduto = new ConfirmationPageVerificationPoint(navegador);
            tituloDoProduto.GetTituloVP2();
        }

        [Given(@"Usuário está na janela de confirmação do produto")]
        public void GivenUsuarioEstaNaJanelaDeConfirmacaoDoProduto()
        {
            //WhenUsuarioERedirecionadoParaAJanelaDeConfirmacaoDoProduto();
        }

        [Given(@"Usuário confere o seu produto")]
        public void GivenUsuarioConfereOSeuProduto()
        {
            ProductConfirmationVerificationPoint linkTextDoProduto = new ProductConfirmationVerificationPoint(navegador);
            linkTextDoProduto.GetTitulo();
        }

        [When(@"Usuário clica no botão de proceder para o checkout")]
        public void WhenUsuarioClicaNoBotaoDeProcederParaOCheckout()
        {
            ProcedeParaCheckoutTask buttonProceedToCheckout = new ProcedeParaCheckoutTask(navegador);
            buttonProceedToCheckout.ClicarBotao();
        }

        [When(@"O usuário é redirecionado para a página do carrinho")]
        public void WhenOUsuarioERedirecionadoParaAPaginaDoCarrinho()
        {

        }

        [Then(@"Usuário clica no botão procede para checkout")]
        public void ThenUsuarioClicaNoBotaoProcedeParaCheckout()
        {
            ProceedToRegisterTask buttonProceedToCheckout2 = new ProceedToRegisterTask(navegador);
            buttonProceedToCheckout2.ClicarBotao();
        }
        
        [Given(@"Usuário está na primeira página de Sign In")]
        public void GivenUsuarioEstaNaPrimeiraPaginaDeSignIn()
        {

        }

        [Given(@"Usuário digita seu email no campo de email para cadastro")]
        public void GivenUsuarioDigitaSeuEmailNoCampoDeEmailParaCadastro()
        {
            SignInPageTask campoCadastraEmail = new SignInPageTask(navegador);
            campoCadastraEmail.CadastrarEmail();
        }

        [Given(@"Usuário clica no botão de criar conta")]
        public void GivenUsuarioClicaNoBotaoDeCriarConta()
        {
            SignInPageTask submitCreateButton = new SignInPageTask(navegador);
            submitCreateButton.ClicarBotao();
        }

        [When(@"Usuário finalmente está na página de Sign In de cadastro dos seus demais dados")]
        public void WhenUsuarioFinalmenteEstaNaPaginaDeSignInDeCadastroDosSeusDemaisDados()
        {

        }

        [Then(@"Usuário preenche o formulário e clica no botão para submeter seu registro")]
        public void ThenUsuarioPreencheOFormularioEClicaNoBotaoParaSubmeterSeuRegistro()
        {
            SignInPageTask elementosDeCadastro = new SignInPageTask(navegador);
            elementosDeCadastro.PreencherFormulario();
        }       
        
        [Given(@"Usuário está na sessão de confirmação do seus dados")]
        public void GivenUsuarioEstaNaSessaoDeConfirmacaoDoSeusDados()
        {
            AddressPageVerificationPoint validarDados = new AddressPageVerificationPoint(navegador);
            validarDados.GetAdress();
        }

        [Given(@"Usuário confere seus dados e clica no botão de proceder para checkout")]
        public void GivenUsuarioConfereSeusDadosEClicaNoBotaoDeProcederParaCheckout()
        {
            AddressPageTask prosseguir = new AddressPageTask(navegador);
            prosseguir.ClicarBotao();
        }

        [Given(@"Usuário é redirecionado para a sessão de frete e forma de envio")]
        public void GivenUsuarioERedirecionadoParaASessaoDeFreteEFormaDeEnvio()
        {

        }

        [Given(@"Usuário clica marcando a caixinha concordando com termos de serviço e envio")]
        public void GivenUsuarioClicaMarcandoACaixinhaConcordandoComTermosDeServicoEEnvio()
        {
            ShippingPageTask aceitarTermos = new ShippingPageTask(navegador);
            aceitarTermos.MarcarCheckBox();
        }

        [Given(@"Usuário clica no botão procede para checkout dessa sessão")]
        public void GivenUsuarioClicaNoBotaoProcedeParaCheckoutDessaSessao()
        {
            ShippingPageTask buttonProceedToCheckout = new ShippingPageTask(navegador);
            buttonProceedToCheckout.ClicarBotao();
        }

        [Given(@"Usuário confere o total do seu produto")]
        public void GivenUsuarioConfereOTotalDoSeuProduto()
        {
            PaymentVerificationPoint total = new PaymentVerificationPoint(navegador);
            total.GetTotal();
        }

        [When(@"Usuário seleciona um método de pagamento clicando no botao de crédito ou débito")]
        public void WhenUsuarioSelecionaUmMetodoDePagamentoClicandoNoBotaoDeCreditoOuDebito()
        {
            PaymentTask metodoDePagamento = new PaymentTask(navegador);
            metodoDePagamento.ClicarBotao();
        }

        [When(@"Usuário confere um resumo da sua compra")]
        public void WhenUsuarioConfereUmResumoDaSuaCompra()
        {
            PaymentVerificationPoint totalAmount = new PaymentVerificationPoint(navegador);
            totalAmount.GetTotalAmount();
        }
        
        [Then(@"Usuário clica no botao de confirmação do pedido")]
        public void ThenUsuarioClicaNoBotaoDeConfirmacaoDoPedido()
        {
            PaymentTask confirmarMinhaCompra = new PaymentTask(navegador);
            confirmarMinhaCompra.ClicarBotaoConfirmandoPagamento();
            TestBase.FecharBrownser(navegador);
        }      

    }
}