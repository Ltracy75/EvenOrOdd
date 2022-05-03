Console.Write("Enter an integer: ");
var answer = Console.ReadLine();
var theNbr = Convert.ToInt32(answer);

while (theNbr != 0)

    {
    if (theNbr % 2 == 0)
        //Modoulous used to confirm divisible by 2, if 0 that's even
        {
        Console.WriteLine($"The number {theNbr} is even.");
        }
    else
        {
        Console.WriteLine($"The number {theNbr} is Odd.");
        }
    Console.Write("Enter an integer: ");
    answer = Console.ReadLine();
    theNbr = Convert.ToInt32(answer);
    //these statments have to be in a while loop, so it can continue to ask the user if they want to be asked to do it again
    }



Console.WriteLine("Done ...");