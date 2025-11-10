// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var w = CountWaysV2(4);
Console.WriteLine($"success for 4: {w == 5}");

w = CountWaysV2(5);
Console.WriteLine($"success for 5: {w == 8}");

int CountWays(int n)
{
    // TODO: Validate n 

    // base case 
    if (n == 1) return 1;
    if (n == 2) return 2;

    return CountWays(n - 1) + CountWays(n - 2);
}

int CountWaysV2(int n)
{
    // TODO: Validate n 

    // base case 
    if (n == 1) return 1;
    if (n == 2) return 2;

    int previous1 = 1;  // of n = 1
    int previous2 = 2;  // of n = 2
    int result = 0;

    // start of n = 2
    for (int i = 3; i <= n; i++)
    {
        result = previous2 + previous1;
        previous1 = previous2;
        previous2 = result;
    }

    return result;
}
