using System.Runtime.Serialization;

Console.WriteLine("Type what you want to do:");
string userAnswer  = Console.ReadLine();
if (userAnswer == "start" ||  userAnswer == "Start")
{
    Console.WriteLine("Mining job started!");
    string fiveM_File = "C:\\Users\\austi\\Downloads\\fiveMbudget.txt";
    if (File.Exists(fiveM_File))
    {
        Console.WriteLine(("File has been found, you will need to delete old inputs."));
    }
    else
    {
        File.Create(fiveM_File).Close();
    }
    int timesPaid = 0;
    int totalPayout = 0;
    Console.WriteLine("Do you want to input mining turn in ?");
    string userTurnIn = Console.ReadLine();
    while (userTurnIn == "y" ||  userTurnIn == "Y")
    {
        Console.WriteLine("Input payout:");
        string payout = Console.ReadLine();
        timesPaid++;
        int pay = int.Parse(payout);
        int payAdded =+ pay;
        using (StreamWriter writer = new StreamWriter(fiveM_File, true))
        {
            if (pay < 999)
            {
                writer.WriteLine($"Pay {timesPaid}, Amount earned: ${pay: 0.00}");
            }
            else
            {
                writer.WriteLine($"Pay {timesPaid}, Amount earned: ${pay: 0,000}");
            }
            
        }
    }
}