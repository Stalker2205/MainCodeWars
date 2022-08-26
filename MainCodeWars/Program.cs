//Complete the function that takes two integers (a, b, where a < b) 
//and return an array of all integers between the input parameters, including them.

static int[] Between(int a, int b)
{
    int kol = 0;
    for (int i = a;i<= b;i++)
    {
        kol++;
    }
        int[] rez = new int[kol];
    for (int i = 0; a <= b; a++, i++)
    {
        rez[i] = a;
    }
    return rez;
}