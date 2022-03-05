programa
{
	
	funcao inicio()
	{
		inteiro contador, limite, resultado, numero
		
		contador = 0
		
		escreva("Escolha o número da tabuada desejada: ")
		leia(numero)

		escreva("\n" + "Escolha o número de vezes que deseja calcular: ")
		leia(limite)
		
		faca{

			resultado = numero * contador
			escreva(numero + " x " + contador + " = " + resultado + "\n")
			contador++ //adiciona 1 ao contador, mesma coisa que contador = contador + 1
			
		}enquanto (contador <= limite)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 185; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */