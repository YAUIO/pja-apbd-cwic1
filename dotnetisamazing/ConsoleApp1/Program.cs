// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("I hate microsoft");
Console.WriteLine("Please give me arch laptop i'm tired");
Console.WriteLine("S3RL - R4V3 BOY");


static int getAvg(int[] arr)
{
    int avg = 0;
    for (int i = 0; i < arr.Length; i++) {
        avg += arr[i];
    }
    return avg/arr.Length;
}

Console.WriteLine(getAvg(new int[]{1,2,3,4}));