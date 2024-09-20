int n = int.Parse(Console.ReadLine());
string word = "";
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int length = input.Length ;
    int number = int.Parse(input);
    int mainD = number % 10;
    int offSet = (mainD - 2) * 3;
    if (mainD == 8 || mainD == 9) offSet++;
    int index = (offSet + length - 1) + 97;
    if (number == 0) index = 32;

   word += ((char)index).ToString();
    
}
Console.WriteLine(word);