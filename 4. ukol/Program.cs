Console.WriteLine("Zadej text:");
string radek = Console.ReadLine();
char[] charArray = radek.ToLower().ToCharArray();

List<char> seznamZnaku = new List<char>();
List<int> pocetZnaku = new List<int>();

for (int i = 0; i < charArray.Length; i++)
{
    
    if (!seznamZnaku.Contains(charArray[i]))
    {
        seznamZnaku.Add(charArray[i]);
        pocetZnaku.Add(0);
    }
    int index = seznamZnaku.IndexOf(charArray[i]);
    pocetZnaku[index]++;
}


for (int i = 0; i<pocetZnaku.Count; i++)
{
    Console.WriteLine(seznamZnaku[i] + "-" + pocetZnaku[i]);
}




