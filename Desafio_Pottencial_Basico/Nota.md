Desafio

Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.
Entrada

A entrada consiste em um número inteiro ( n );
Saída

A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

Exemplo 1

Entrada 	Saída
234 	15

Explicação: 

Produto de dígitos = 2 * 3 * 4 = 24

Soma dos dígitos = 2 + 3 + 4 = 9

Resultado = 24 - 9 = 15

Exemplo 2:

Entrada 	Saída
4421 	21

Explicação: 

Produto de dígitos = 4 * 4 * 2 * 1 = 32

Soma dos dígitos = 4 + 4 + 2 + 1 = 11

Resultado = 32 - 11 = 21

Restrições:

    1 <= n <= 10^5


## Desafio 2 


Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.
Entrada

A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.
Saída

Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

Exemplo de Entrada 	Exemplo de Saída

4
56234523485723854755454545478690 78690
5434554 543
1243 1243
54 64545454545454545454545454545454554
	

encaixa
nao encaixa
encaixa
nao encaixa