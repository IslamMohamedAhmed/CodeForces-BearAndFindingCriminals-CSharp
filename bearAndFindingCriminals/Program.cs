using static System.Console;
using static System.Convert;
using static System.Math;


int n, a, crimes = 0;
int[] arr1 = new int[105];

string str1 = ReadLine();
var arr2 = str1.Split(" ");

n = ToInt32(arr2[0]);
a = ToInt32(arr2[1]);
a--;
string str2 = ReadLine();
var arr3 = str2.Split(" ");
for (int i = 0; i < n; i++)
{
    arr1[i] = ToInt32(arr3[i]);
}

if (arr1[a] == 1)
{
    crimes++;
}
if (a == 0)
{
    for(int j = a+1; j < n; j++)
    {
        if (arr1[j] == 1)
        {
            crimes++;
        }
    }
}
else if(a == n - 1){
    for(int j= 0; j < a; j++)
    {
        if (arr1[j] == 1)
        {
            crimes++;
        }
    }

}
else
{
    int k = 1;
    while (true)
    {

        if (a - k >= 0)
        {
            if (a + k <= n - 1)
            {
                if (arr1[a - k] == 1 && arr1[a + k] == 1)
                {
                    crimes += 2;
                }
            }
            else
            {
                if (arr1[a - k] == 1)
                {
                    crimes++;
                }
            }
        }
        else
        {
            if (a + k <= n - 1 && arr1[a + k] == 1)
            {
                crimes++;
            }
        }
        k++;
        if (a - k < 0 && a + k > n - 1)
        {
            break;
        }
    }
}
WriteLine(crimes);