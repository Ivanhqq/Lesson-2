
int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if (arg2 > result) result = arg2;
   if (arg3 > result) result = arg3;
   return result;

}

//№эл. масс.    0  1    2  3  4  5  6    7   8   
int[] array = {23, 45, 24, 8, 9, 0, 12, 456, 256};


Console.WriteLine(array[8]);




