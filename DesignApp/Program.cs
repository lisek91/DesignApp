int number = 45975;
string NumberAsString = number.ToString();
char[] digits = NumberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char digit in digits) 
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3') 
    {
        counter3++;
    }
    else if (digit == '4') 
    {
        counter4++;
    }
    else if (digit == '5') 
    {
        counter5++;
    }
    else if (digit == '6') 
    {
        counter6++;
    }
    else if (digit == '7') 
    {
        counter7++;
    }
    else if (digit == '8') 
    {
        counter8++;
    }
    else if (digit == '9') 
    {
        counter9++;
    }

}

List<string> dig = new List<string>();

dig.Add("0=>" + counter0);
dig.Add("1=>" + counter1);
dig.Add("2=>" + counter2);
dig.Add("3=>" + counter3);
dig.Add("4=>" + counter4);
dig.Add("5=>" + counter5);
dig.Add("6=>" + counter6);
dig.Add("7=>" + counter7);
dig.Add("8=>" + counter8);
dig.Add("9=>" + counter9);

foreach (var counter in dig)
    Console.WriteLine(counter);