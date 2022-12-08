int [] array = {1, 3, 4, 1, 5, 6, 6, 1};
int len = array.Length;
int j, i;

for (i=0; i<len; i++)
{
    for (j = i+1; j<len; j++)
    {
        if (array[j] ==  array[i])
        {
            Console.WriteLine ($"Element = {array[i]}, index = {i}, index = {j}");
        }
    }
}
