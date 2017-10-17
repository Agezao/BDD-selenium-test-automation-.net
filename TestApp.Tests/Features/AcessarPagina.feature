#language: pt
#utf-8

Funcionalidade: Acessar Pagina
	Eu como usuario do Sistema em escopo
	Quero acessar o sistema
	Para realizar minha atividade qualquer

@mytag
	Cenario: Acessar a home
		Dado que eu estou na home do site
		Entao eu irei visualizar o texto "Getting started"
		E eu irei visualizar o texto "Get more libraries"
		Entao Salvar evidência "1.1.home.jpg" em "evidencias\1\"

	Cenario: Acessar a pagina de Contato
		Dado que eu estou na home do site
		Entao eu irei clicar no link "Contact"
		Entao eu irei visualizar o texto "Your contact page."
		E eu irei visualizar o texto "One Microsoft Way"
		Entao Salvar evidência "1.2.contato.jpg" em "evidencias\1\"

