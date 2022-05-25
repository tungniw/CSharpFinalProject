// Loops

// TYPES OF LOOPS: FOR, FOREACH, WHILE, DO-WHILE

// WHILE

int total = 1;

// while (total != 8) //While Loops condition must be able to evaluate to TRUE or FALSE.
// {
//     Console.WriteLine("just keep swimming...");
//     Console.ReadKey();
//     total += 1;
// }

bool isRunning = true;

total = 1;

while (isRunning)
{
    Console.WriteLine("just keep swimming...");

    if (total == 4)
    {
        isRunning = false;
    }

    total++;
}

// DO WHILE - will always execute at least once. WHILE loop doesn't have to execute at least once.

int iterator = 0;

do
{
    Console.WriteLine("Hello World.");
    iterator++;
}
while (iterator < 0);


//  FOR LOOP

total = 10;

for (int i = 0; i < total; i++)
{
    Console.WriteLine("Another One - DJ Khaled.");
}


string[] students = {"Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };

for (int i = 0; i < students.Length; i ++)
{
    Console.WriteLine($"Welcome to EFA, {students[i]}");
}

List<string> roster = new List<string>() { "Harry", "Lloyd", "Thelma", "Louise", "Pippin", "Merry" };

for (int i = 0; i < roster.Count(); i ++)
{
    Console.WriteLine($"Welcome to EFA, {roster[i]}");
}


// FOREACH LOOP

foreach (string name in roster) 
{
    foreach (char x in name)
    {
        Console.Write(char.ToUpper(x));
    }
        Console.Write("\n");
}
