Feature: ComprarProduto
	In order to buy a product
	As a dress store user
	I want to choose an item, sign up me and confirm my purchase
  
  Scenario: 01 Adicionar produto no carrinho
    Given Usuário está na Home Page
    And Usuário clica na imagem do produto 
	And O usuário é redirecionado para a página de descricao do produto
    When Usuário clica no botão de adicionar o produto no carrinho
    And Usuário é redirecionado para a janela de confirmação do produto
	Then O produto é apresentado na janela de confirmação do produto 

  Scenario: 02 Prosseguir para checkout
    Given Usuário está na janela de confirmação do produto
	And Usuário confere o seu produto
    When Usuário clica no botão de proceder para o checkout
    And O usuário é redirecionado para a página do carrinho
    Then Usuário clica no botão procede para checkout 

  Scenario: 03 Criar uma conta
	Given Usuário está na primeira página de Sign In
    Given Usuário digita seu email no campo de email para cadastro
    And Usuário clica no botão de criar conta 
	When Usuário finalmente está na página de Sign In de cadastro dos seus demais dados
    Then Usuário preenche o formulário e clica no botão para submeter seu registro

  Scenario: 04 Finalizar a compra do produto
	Given Usuário está na sessão de confirmação do seus dados
    And Usuário confere seus dados e clica no botão de proceder para checkout
	And Usuário é redirecionado para a sessão de frete e forma de envio
    And Usuário clica marcando a caixinha concordando com termos de serviço e envio 
    And  Usuário clica no botão procede para checkout dessa sessão
	And Usuário confere o total do seu produto
    When Usuário seleciona um método de pagamento clicando no botao de crédito ou débito
	And Usuário confere um resumo da sua compra
    Then Usuário clica no botao de confirmação do pedido