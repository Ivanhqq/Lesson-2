int[] array = {23, 45, 24, 8, 256, 0, 12, 456, 256};

int n = array.Length;

Console.Clear ();
Console.WriteLine("ВВеди целое число и получишь № эл массива");
int find = Convert.ToInt32(Console.ReadLine());
//int find = 45;

int index = 0;

while (index < n)
{
      if(array[index] == find)
      {
        Console.WriteLine(index); 
        break;
      }
      index++;
    
}