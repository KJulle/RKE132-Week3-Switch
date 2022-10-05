
Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kontrollitakse kas kasutaja sisestatud arv on paaris või paaritu

int result = userNum % 2;

if (result != 0)
{
    Console.WriteLine("This number is odd.");
}
else
{
    Console.WriteLine("This number is even.");
}