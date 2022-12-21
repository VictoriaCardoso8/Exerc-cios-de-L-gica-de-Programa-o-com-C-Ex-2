﻿//No mercado financeiro utiliza-se uma estratégia chamada Percentage of Volume (POV) para executar operações durante o dia, seja de compra ou venda, respeitando um determinado volume.

//Por exemplo, ao configurar uma POV para fazer 10% do mercado na compra de PETR4, é esperado que, quando tivermos 100 execuções totais no mercado, a estratégia seja responsável por 10 quantidades desse total de 100 executadas.

//Para que tal fato aconteça, a estratégia deve considerar a sua execução para calcular quantas ações devem enviar. Ou seja, quando o mercado tiver executado 90 ordens, a estratégia precisa calcular 10, pois 90 + 10 = 100, e 10/100 = 10%.

//Implemente a função que retorna a quantidade que a estratégia deve enviar ao mercado, dada a porcentagem e o total negociado.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2___logica_de_prog
{
    public class Program
    { 
    public static int funcaoRetornaQuantitadePOV(decimal porc, int valor)
    {
        return (int)((valor / (1 - porc)) - valor);
    }


    static void Main()
    {
        int Quantidade = funcaoRetornaQuantitadePOV(0.2m ,70);
            Console.WriteLine(Quantidade);
    }
    }
}

