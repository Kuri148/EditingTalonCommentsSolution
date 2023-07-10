using System.Diagnostics.Metrics;

/* This string set of .talon commands where the first action is repeated 
a series of times, before the final action is carried out. */


int iterations = default;
string commandOutput = default;
string[] countingWords = new string[11] { "", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten" };
int count = default;


Console.WriteLine("Give base command:");
string baseCommand = Console.ReadLine();
Console.WriteLine("Give number of iterations (11 or lower):");
string iterationString = Console.ReadLine();
Console.WriteLine("Give a direction:");
string direction = Console.ReadLine();
Console.WriteLine("Give final action:");
string finalAction = Console.ReadLine();

if (int.TryParse(iterationString, out int result)) iterations = result + 1;


for (int i = 0; i < iterations; i++)
    {
     commandOutput += $"{baseCommand} {countingWords[i]}:\n";
    for (int j = 0; j <= count; j++)
        {
        if (j == count) 
        {
            commandOutput += $"\tkey({finalAction})\n\n";
            count++;
            break;
        }
        commandOutput += $"\tkey({direction})\n";
        }
    }
Console.WriteLine(commandOutput);