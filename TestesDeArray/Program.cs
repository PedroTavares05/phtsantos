int[] ArrayTeste = new int[4];
ArrayTeste[0] = 9;
ArrayTeste[1] = 5;
ArrayTeste[2] = 6;
ArrayTeste[3] = 7;
for (int i = 0; i < ArrayTeste.Length; i++)
{
    Console.WriteLine($"nº {i} = {ArrayTeste[i]}");

}

foreach ( int ContadorArray in ArrayTeste)
{
    Console.WriteLine($"{ContadorArray}");
}