
bool flag;
double first_number = 0;
double second_number = 0;
double answer = 0;
char? action = null;
char? action2 = null;

do
{
    do
    {
        try
        {
            Console.Write("Enter first number: ");
            first_number = Convert.ToDouble(Console.ReadLine());
            flag = true;
        }
        catch
        {
            flag = false;
            Console.WriteLine("Error!");
        }
    }
    while (flag != true);
    do
    {
        try
        {
            Console.WriteLine("Select an action : ");
            action = Convert.ToChar(Console.ReadLine());
            if (action == '*' || action == '+' || action == '/' || action == '-')
            {
                flag = false;
            }
        }
        catch
        {
            flag = true;
            Console.WriteLine("Error!");
        }
    }
    while (flag != false);

    do
    {
        try
        {
            Console.Write("Enter second number: ");
            second_number = Convert.ToDouble(Console.ReadLine());
            flag = true;
        }
        catch
        {
            flag = false;
            Console.WriteLine("Error!");
        }
    }
    while (flag != true);



    switch (action)
    {
        case '*':
            answer = first_number * second_number;
            Console.WriteLine("Ответ: " + answer);
            break;
        case '+':
            answer = first_number + second_number;
            Console.WriteLine("Ответ: " + answer);
            break;
        case '/':
            answer = first_number / second_number;
            Console.WriteLine("Ответ: " + answer);
            break;
        case '-':
            answer = first_number - second_number;
            Console.WriteLine("Ответ: " + answer);
            break;
    }
    do
    {
        try
        {
            Console.WriteLine("start again? Y/N : ");
            action2 = Convert.ToChar(Console.ReadLine());
                flag = true;
            
        }
        catch
        {
            flag = false;
            Console.WriteLine("Error!");
        }
    }
    while (flag != true);
}
while (action2 == 'Y');

