using System;


void ConvertToBynary(int i)
{
    string x = Convert.ToString(i);
    
    int[] NumBinary=new int [x.Length];
    
    for (int z = 0; i > 0; z++)
    {
        i /= 2;
        if (i % 2 == 0)
        {
            NumBinary[x.Length-z] = 0;
        } else NumBinary[x.Length-z] = 1;

        
    }
    foreach (int c in NumBinary)
    {
        Console.Write(NumBinary[c]);
        Console.Write(" ");
    }
}
    

int i = 2;
ConvertToBynary(i);
