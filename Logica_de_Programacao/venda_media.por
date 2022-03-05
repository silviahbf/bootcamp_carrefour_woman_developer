programa
{
	
	funcao inicio()
	{
		real vendajan, vendafev, vendamar, vendaabr, media
		cadeia vendedor

		escreva("Nome do vendedor: ")
		leia(vendedor)
		
		escreva("Entre com o valor das vendas de janeiro: ")
		leia(vendajan)
		escreva("Entre com o valor das vendas de fevereiro: ")
		leia(vendafev)
		escreva("Entre com o valor das vendas de março: ")
		leia(vendamar)
		escreva("Entre com o valor das vendas de abril: ")
		leia(vendaabr)

		media = (vendajan+vendafev+vendamar+vendaabr)/4

		escreva("Vendedor: " + vendedor + "   Venda média: " + media)

		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 578; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */