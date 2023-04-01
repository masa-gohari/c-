Console.Write("Enter First Number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write("Enter Second Number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write("Select:\n 1. +\n 2. -\n 3. / \n 4. % \nYour Answer is:");
int menu = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int temp;
if(firstNumber < secondNumber)
{
    temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}

switch (menu)
{
    case 1:
        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
        break;
    case 2:
        Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
        break;
    case 3:
        Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);
        break;
    case 4:
        Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, firstNumber % secondNumber);
        break;
}