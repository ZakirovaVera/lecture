int[] array = { 12, 56, 5, 98, 10, 63, 7, 98, 102 };

int n = array.Length;
int find = 98;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index +1;
    index++;
}