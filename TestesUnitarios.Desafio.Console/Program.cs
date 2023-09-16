using TestesUnitarios.Desafio.Console.Services;


var lista = new List<int> { 5, -1, -8, 9 };
//var resultadoEsperado = new List<int> { 5, 9 };

ValidacoesLista v = new ValidacoesLista();
v.RemoverNumerosNegativos(lista);

//lista.ForEach(i => Console.Write("{0}\t", i));