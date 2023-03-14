string str1 = "pepega";
string str2 = "pepega";
string str3 = "pe pega";
string str4 = "Hello and Hi";

//Method 1
bool method1 = Compare(str1, str2);
bool method11 = Compare(str1, str3);

//Method 2
int method2 = Analyze(str3);

//Method 3
string method3 = Sort(str1);

//Method 4
char[] chars = Duplicate(str4);

static bool Compare(string str1, string str2) => str1==str2 ? true : false;
static int Analyze(string str)
{
    //int result1 = str.Length;
    //return result1;
    int result = 0;
    char[] charArray = str.ToCharArray();
    foreach (var ch in charArray)
    {
        result++;
    }
    return result;
}
static string Sort(string str)
{
    string result = "";
    char[] charArray = str.ToCharArray();
    Array.Sort(charArray);
    foreach (var ch in charArray)
    {
        result += ch;
    }

    return result;
}
static char[] Duplicate(string str)
{
    char[] charArray = str.ToCharArray();
    string resultString = "";
    for (int i = 0; i < charArray.Length-2; i++)
    {
        for (int j = i+1; j < charArray.Length; j++)
        {
            if (charArray[j] == charArray[i])
            {
                if (!resultString.Contains(charArray[j]) && charArray[j]!=' ')
                {
                    resultString += charArray[j];
                }
            }
        }
    }
    return resultString.ToCharArray();
}