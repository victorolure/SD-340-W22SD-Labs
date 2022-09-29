using System.Text;

string wordConcatenate(string wordArg, int numArg)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < numArg; i++)
    {
        sb.Append(wordArg);
    }
    return sb.ToString();
}

string testString = "My name is Victor";
stringDelegate newDel = new stringDelegate(wordConcatenate);

newDel = (string wordArg, int numArg) =>
{
    return wordArg.Substring(0, wordArg.Length - numArg);
};

Console.WriteLine(newDel(testString, 5));

delegate string stringDelegate(string wordArg, int numArg);