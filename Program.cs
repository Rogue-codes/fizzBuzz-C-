// fizzbuzz challenge
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i}-FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i}-Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i}-Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}


// do while loop

int heroHealth = 10;
int monsterHealth = 10;
string winner = "";

Random random = new Random();

do{
    int hit = random.Next(1,11);
    monsterHealth -= hit;
    Console.WriteLine($"Monster was damaged and lost {hit} health and now has {monsterHealth} health.");
    if(monsterHealth <= 0) continue;

    hit = random.Next(1,11);
    heroHealth -= hit;
    Console.WriteLine($"Hero was damaged and lost {hit} health and now has {heroHealth} health.");

}while(heroHealth > 0 && monsterHealth > 0);

if(heroHealth > monsterHealth){
    winner = "Hero";
}else winner = "Monster";

Console.WriteLine($"The winner is {winner}");




// do while loop
int validNum = 0;
string? enteredText;
bool validEntry = false;

Console.WriteLine("Enter a value between 5 and 10");
do
{
    enteredText = Console.ReadLine();
    validEntry = int.TryParse(enteredText, out validNum);
    if (validEntry)
    {
        if (validNum >= 5 && validNum <= 10) continue;
        else Console.WriteLine($"You entered {validNum}. Please enter a number between 5 and 10.");

    }
    else
    {
        Console.WriteLine("Please enter a valid number between 5 and 10");
    }

} while (validNum < 5 || validNum > 10);

Console.WriteLine($"Your input value ({validNum}) has been accepted.");

string ADMIN = "Administrator";
string MANAGER = "Manager";
string USER = "User";
string? enteredRole;

Console.WriteLine("Enter your role name Administrator, Manager, or User");

do
{
    enteredRole = Console.ReadLine();
    if (enteredRole != null)
    {
        if (enteredRole.ToLower().Trim() == ADMIN.ToLower() || enteredRole.ToLower().Trim() == MANAGER.ToLower() || enteredRole.ToLower().Trim() == USER.ToLower()) continue;
        else Console.WriteLine($"The role name that you entered, {enteredRole} is not valid. Enter your role name (Administrator, Manager, or User)");
    }
    else Console.WriteLine("Enter a valid text");
} while (enteredRole?.ToLower().Trim() != ADMIN.ToLower() && enteredRole?.ToLower().Trim() != MANAGER.ToLower() && enteredRole?.ToLower().Trim() != USER.ToLower());
Console.WriteLine($"Your input value {enteredRole} has been accepted.");


