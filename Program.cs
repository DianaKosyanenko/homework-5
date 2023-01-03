/*int [] CreateArray(int size, int minValue, int maxValue){
     int [] array = new int [size];  
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minValue, maxValue+1);
    }

    return array;
}

void ShowArrai(int [] array){
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }

    Console.WriteLine();
}

int Test(int [] array){
    int numb1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2 == 0)
         {
            numb1++;
         }
    }
    return numb1;
}
int size = 4;
int min = 100;
int max = 1000;
int [] array = CreateArray(size, min, max);
ShowArrai(array);
Console.WriteLine($"even number is {Test(array)} ");*/


/*int [] CreateArray(int size, int minValue, int maxValue){
     int [] array = new int [size];  
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next( minValue, maxValue+1);
    }

    return array;
}

void ShowArrai(int [] array){
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i] }");
    }

    Console.WriteLine();
}

int Founder(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int num = array[i];
       if (num>10 && num<99)
       {
            count++;
       } 
    }
    return count;
}
int size = 123;
int min = 1;
int max = 100;
int [] array = CreateArray(size, min, max);
ShowArrai(array);
Console.WriteLine($"count of number {Founder(array)} ");*/

/*int [] CreateArray(int size, int minValue, int maxValue){
     int [] array = new int [size];  
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next( minValue, maxValue+1);
    }

    return array;
}

void ShowArrai(int [] array){
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i] }");
    }

    Console.WriteLine();
}

int Founder(int[] array){
    int numb1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] % 2 != 0)
         {
            numb1 += array[i];
         }
    }
    return numb1;
}
int size = 4;
int min = 100;
int max = 1000;
int [] array = CreateArray(size, min, max);
ShowArrai(array);
Console.WriteLine($"sum of not number is {Founder(array)} ");*/