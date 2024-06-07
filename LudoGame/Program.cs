
Random r = new Random();

string[] chars = new string[4] { "Æ", "Ø", "©", "¥" };
string[,] tabuleiro = new string[14, 14];



int num = 0;
int num2 = 0;
int num3 = 0;
for (int i = 0; i < tabuleiro.GetLength(0); i++)
{
    for (int j = 0; j < tabuleiro.GetLength(1); j++)
    {
        if (i < 1 || i == tabuleiro.GetLength(0) - 1 || j < 1 || j == tabuleiro.GetLength(1) -1)
        {
            num++;
            tabuleiro[i, j] = $"{num.ToString("00")}";
        }
        else if( i > 5 && i < 8 && j > 5 && j < 8)
        {
            //tabuleiro[i,j] = $"{chars[r.Next(chars.Length)]}{chars[r.Next(chars.Length)]}" ;
            tabuleiro[i, j] = $"00";
        }
        else if (i == j)
        {
            num2++;
            tabuleiro[i, j] = $"{num2.ToString("00")}";
        }
        else if (i + j == tabuleiro.GetLength(0) - 1)
        {
            num3++;
            tabuleiro[i, j] = $"{num3.ToString("00")}";
        }
        else
        {
            tabuleiro[i, j] = "  ";
        }
    }
}

for (int i = 0; i < tabuleiro.GetLength(0); i++)
{
    for (int j = 0; j < tabuleiro.GetLength(1); j++)
    {
        Console.Write($" {tabuleiro[i, j]} ");
    }
    Console.WriteLine("\n");
}
//caracter dec  oct     hex
//Æ     	146	0222	0x92
//Ø	        157	0235	0x9d
//©	        184	0270	0xb8
//¥	        190	0276	0xbe