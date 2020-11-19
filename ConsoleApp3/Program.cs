using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Q2
              int number1, sum1 = 0;
              Console.WriteLine("Enter number : ");
              number1 = int.Parse(Console.ReadLine());
              for(int i=0;i<=number1; i++)
              {
                  if(i % 2 ==0 && i % 3 == 0)
                  {
                      sum1 = sum1 + i;
                  }
              }
              Console.WriteLine("The sum is = " + sum1);
            //-----------------------------------------------------------------------------------------------------------

            //Q3
              for(int i=2; i<=100; i=i+2)
              {
                  Console.WriteLine(i);
              }
            //-----------------------------------------------------------------------------------------------------------
            //Q4
             for (int i = 1; i <= 100; i++)
             {
                  if (i % 2 != 0)
                  {
                      Console.WriteLine(i);
                  }
              }
            //-----------------------------------------------------------------------------------------------------------
            //Q5
             int max, number;
             max = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter 50 numbers : ");
             for(int i = 1; i<50; i++)
             {
                 number = int.Parse(Console.ReadLine());
                 if(number > max)
                 {
                     max = number;
                 }
             }
             Console.WriteLine("Max = " + max);
            //-----------------------------------------------------------------------------------------------------------
            //Q6
             int max, number = 0;
              max = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter numbers : ");
              while ( number >= 0)
              {
                  number = int.Parse(Console.ReadLine());
                  if(number > max)
                  {
                      max = number;
                  }
              }
              Console.WriteLine("Max = " + max);
            //-----------------------------------------------------------------------------------------------------------
            //Q7
              int grade = 0, sum = 0, counter = 0;
              Console.WriteLine("Enter the grades : ");
              while(grade>=0 && grade <= 100)
              {
                  grade = int.Parse(Console.ReadLine());
                  if(grade >= 0 && grade <= 100)
                  {
                      sum = sum + grade;
                      counter++;
                  }
              }
              Console.WriteLine("Grade = " + (double)sum / counter);
            //-----------------------------------------------------------------------------------------------------------
            //Q8.1
             for(int i=25; i<=50; i++)
             {
                 if(i%5 == 0 && i%7 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }
            //Q8.2
              int i = 25;
              while ( i <= 50 )
              {
                  if (i % 5 == 0 && i % 7 == 0)
                  {
                      Console.WriteLine(i);
                  }
                  i++;
              }
            //-----------------------------------------------------------------------------------------------------------
            //Q9
              int number, sum=0;
              Console.WriteLine("Enter number : ");
              number = int.Parse(Console.ReadLine());
              while (number != 0)
              {
                  sum = sum + number % 10;
                  number = number / 10;
              }
              Console.WriteLine("Sum of digits = " + sum);

            //-----------------------------------------------------------------------------------------------------------
            //Q10
              int number;
              Console.WriteLine("Enter 70 numbers : ");
              for(int i = 0;i<70; i++)
              {
                  number = int.Parse(Console.ReadLine());
                  if(number % 3 == 0)
                  {
                      Console.WriteLine(number);
                  }
              }

            //-----------------------------------------------------------------------------------------------------------
            //Q11
             int numberLicense;
             int reachTime;
             int count = 0;
             for(int i = 0; i < 40; i++)
             {
                 Console.Write("Enter the number license : ");
                 numberLicense = int.Parse(Console.ReadLine());
                 Console.Write("\nEnter the time that the car need to reach : ");
                 reachTime = int.Parse(Console.ReadLine());
                 if(reachTime > 5)
                 {
                     Console.WriteLine("Can't particpate in the race !!");
                 }
                 if(reachTime <= 4)
                 {
                     Console.WriteLine("Car with number " + numberLicense + " needs " + reachTime + " min to reach");
                     count++;
                 }
             }
             Console.WriteLine("The number of the cars that need 4 min to reach is : " + count);
            //-----------------------------------------------------------------------------------------------------------
            //Q12
            int box1 = 0, box2 = 0, box3 = 0;
            int appleWight = 1;
            while(box1<=40 && box2<=30 && box3 <= 25 && appleWight != 0)
            {
                appleWight = int.Parse(Console.ReadLine());
                if (appleWight >= 10 && appleWight <= 30)
                {
                    Console.WriteLine("This Apple in BOX 1");
                    box1++;
                }
                else
                {
                    if (appleWight >= 31 && appleWight <= 50)
                    {
                        Console.WriteLine("This Apple in BOX 2");
                        box2++;
                    }
                    else
                    {
                        if (appleWight > 50)
                        {
                            Console.WriteLine("This Apple in BOX 3");
                            box3++;
                        }
                        else
                        {
                            Console.WriteLine("Illigal apple weight");
                        }
                    }
                }
            }
            Console.WriteLine("Box 1 = {0}, Box 2 = {1}, Box 3 = {2}", box1, box2, box3);

       //-----------------------------------------------------------------------------------------------------------
        }
    }
}
