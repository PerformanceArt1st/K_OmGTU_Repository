int chislo; char znak; int sum = 0; int k = 0; int x_count = 1;
Console.WriteLine("Введите кол-во строк: (бесполезно)");
int n = Convert.ToInt32(Console.ReadLine());
while (k < 1)
{
    var i = Console.ReadLine();
    string[] s = i.Split(' ');
    if (s.Length == 1)
    {
        chislo = Convert.ToInt32(s[0]);
        sum = -sum;
        sum += chislo;
        k++;
    }
    if (s.Length == 2)
    {
        znak = Convert.ToChar(s[0]);
        try
        {
            chislo = Convert.ToInt32(s[1]);
            switch (znak)
            {
                case '+':
                    sum += chislo;
                    break;
                case '-':
                    sum -= chislo;
                    break;
                case '*':
                    sum *= chislo;
                    x_count *= chislo;
                    break;
            }
        }
        catch (Exception)
        {                   
            chislo = Convert.ToChar(s[0]);
            switch (znak)
            {
                case '+':
                    x_count += 1;
                    break;
                case '-':
                    x_count -= 1;
                    break;
            }
        }
        Console.WriteLine(sum);
    }
}
Console.WriteLine(sum/x_count);