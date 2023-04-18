Console.Write("Введите предложение: ");
string some = Console.ReadLine();
int size = 1;
foreach (var el in some)
{
    if (Convert.ToString(el) == " ") size++;
}

string[] array = new string[size];
int count = 0;
string res = "";
for (int i= 0; i<some.Length; i++)
{
    if (Convert.ToString(some[i]) == " ")
    {
        array[count] = res;
        res = "";
        count++;
    }
    else res+= some[i];
    if (i==some.Length-1) array[count]=res;
}
int k = 0;
for (int i= 0; i<array.Length; i++)
{
    if (array[i].Length<=3)k++;
}
string[] resalt = new string[k];
int j = 0;
for (int i= 0; i<array.Length; i++)
{
    if (array[i].Length<=3)
    {
        resalt[j]=array[i];
        j++;
    }
}
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", resalt)}]");