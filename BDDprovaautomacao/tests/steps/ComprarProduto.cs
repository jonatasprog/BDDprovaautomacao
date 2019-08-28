using BDDprovaautomacao.tasks;
using BDDprovaautomacao.utils;
using BDDprovaautomacao.verificationpoints;
using FrameworkCsharp.Utils;
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
            navegador = TestBase.CreateChrome();
        }

        [Given(@"Usuário clica na imagem do produto")]
        public void GivenUsuarioClicaNaImagemDoProduto()
        {
            EscolheProdutoTask elemento = new EscolheProdutoTask(navegador);
            elemento.ClicarImagem();
        }

        [Given(@"O usuário é redirecionado para a página de descricao do produto")]
        public void GivenOUsuarioERedirecionadoParaAPaginaDeDescricaoDoProduto()
        {
            PaginaDescricaoVerificationPoint tituloDescricaoDoProduto = new PaginaDescricaoVerificationPoint(navegador);
            tituloDescricaoDoProduto.GetTitulo();
        }

        [When(@"Usuário clica no botão de adicionar o produto no carrinho")]
        public void WhenUsuarioClicaNoBotaoDeAdicionarOProdutoNoCarrinho()
        {
            AdicionaNoCarrinhoTask buttonAddToCart = new AdicionaNoCarrinhoTask(navegador);
            buttonAddToCart.ClicarBotao();
        }

        [When(@"Usuário é redirecionado para a janela de confirmação do produto")]
        public void WhenUsuarioERedirecionadoParaAJanelaDeConfirmacaoDoProduto()
        {
            PaginaConfirmacaoVerificationPoint tituloProccedToCheckout = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloProccedToCheckout.GetTitulo();
        }

        [Then(@"O produto é apresentado na janela de confirmação do produto")]
        public void ThenOProdutoEApresentadoNaJanelaDeConfirmacaoDoProduto()
        {
            PaginaConfirmacaoVerificationPoint tituloDoProduto = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloDoProduto.GetTitulo2();
        }

        [Given(@"Usuário está na janela de confirmação do produto")]
        public void GivenUsuarioEstaNaJanelaDeConfirmacaoDoProduto()
        {
            PaginaConfirmacaoVerificationPoint tituloProccedToCheckout = new PaginaConfirmacaoVerificationPoint(navegador);
            tituloProccedToCheckout.GetTitulo();
        }

        [Given(@"Usuário confere o seu produto")]
        public void GivenUsuarioConfereOSeuProduto()
        {
            ConfirmacaoDoProdutoVerificationPoint linkTextDoProduto = new ConfirmacaoDoProdutoVerificationPoint(navegador);
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
            ProcedeParaCadastroTask buttonProceedToCheckout2 = new ProcedeParaCadastroTask(navegador);
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
            PaginaAdressVerificationPoint validarDados = new PaginaAdressVerificationPoint(navegador);
            validarDados.GetAdress();
        }

        [Given(@"Usuário confere seus dados e clica no botão de proceder para checkout")]
        public void GivenUsuarioConfereSeusDadosEClicaNoBotaoDeProcederParaCheckout()
        {
            PaginaAdressTask prosseguir = new PaginaAdressTask(navegador);
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
        }        
    }
}