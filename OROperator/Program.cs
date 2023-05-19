//Math >= 90 OR Chemistry >= 90

//int math, chemistry;

//Console.WriteLine("Enter your Math result:");
//math = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Enter your Chemistry result:");
//chemistry = Int32.Parse(Console.ReadLine());

//if(math >= 90 || chemistry >= 90)
//{
//    Console.WriteLine("Congratulations! You got accepted.");
//}
//else
//{
//    Console.WriteLine("Your application cannot be approved.");
//}


//Math && Chem || Chem && Bio || Chem && Bio

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90 || math >= 90 && biology >= 90 || chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}