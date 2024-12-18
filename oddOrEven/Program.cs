

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//Kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0) // != ei ole vordne
{
    Console.WriteLine("User number is ood.");
}
else
{
    Console.WriteLine("User number is even.");
}
