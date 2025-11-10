//Fazendo listas string e int
List<int> ListaDeInteiros = new List<int>();
List<string> ListaDeString = new List<string>();
ListaDeString.Add("ES");
ListaDeString.Add("BH");
ListaDeString.Add("RJ");
ListaDeString.Add("SP");

foreach (string ListaDeExemplo in ListaDeString)
{
    Console.WriteLine($"A sigla do estado é: {ListaDeExemplo}");
}




// int[] ArrayTeste = new int[4];
// ArrayTeste[0] = 9;
// ArrayTeste[1] = 5;
// ArrayTeste[2] = 6;
// ArrayTeste[3] = 7;
// for (int i = 0; i < ArrayTeste.Length; i++)
// {
//     Console.WriteLine($"nº {i} = {ArrayTeste[i]}");

// }
// foreach ( int ContadorArray in ArrayTeste)
// {
//     Console.WriteLine($"{ContadorArray}");
// }
// int[] ArrayTesteDobro = new int[ArrayTeste.Length * 2];
// Array.Copy(ArrayTeste, ArrayTesteDobro, ArrayTeste.Length);


// Console.WriteLine("====================================");
// foreach (int ContadorArray in ArrayTesteDobro)
// {
//     Console.WriteLine($"{ContadorArray}");
// }