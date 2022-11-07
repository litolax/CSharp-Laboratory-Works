using System.Text.RegularExpressions;

namespace EigthLaboratory
{
    class Test
    {
        public int FirstInt;
        public int SecondInt;
        public int ThirdInt;
        public string FirstString;
        public string SecondString;
        public string ThirdString;

        public virtual void Testing()
        {
            FirstInt = 1;
            SecondInt = 2;
            ThirdInt = 3;
            FirstString = "1";
            SecondString = "2";
            ThirdString = "3";
               
        }
    }

    class Test2 : Test
    {
        public int FourthInt;
        public string FourthString;

        public override void Testing()
        {
            base.Testing();
            FourthInt = 4;
            FirstInt = 5;
            
            Console.WriteLine(FirstInt);
        }
    }

    class AVTO
    {
        public int YearOfGraduate;

        public AVTO()
        {
            Console.WriteLine("Вызван конструктор без параметров");
        }
        
        public AVTO(int year)
        {
            YearOfGraduate = year;
            Console.WriteLine("Вызван конструктор с параметрами");
        }
    }
    
    class AVTO1 : AVTO
    {
        public AVTO1()
        {
            Console.WriteLine("Вызван конструктор без параметров в классе наследнике");
        }
       
        public AVTO1(int year) : base(year)
        {
            Console.WriteLine("Вызван конструктор с параметрами в классе наследнике");
        }
        public void InputData()
        {
            Console.WriteLine("Введите год выпуска автомобиля");
            YearOfGraduate = Convert.ToInt32(Console.ReadLine());
        }
        
        public void ShowData()
        {
            Console.WriteLine("Год выпуска автомобиля: " + YearOfGraduate);
        }
    }

    class Time
    {
        public int Seconds;
        public int Minutes;
        public int Hours;
    }

    class Time2 : Time
    {
        public void SetSeconds(int seconds)
        {
            if (seconds >= 0 && seconds <= 59)
            {
                Seconds = seconds;
            }
            else throw new Exception("Некорректное значение секунд");
        }
        
        public void SetMinutes(int minutes)
        {
            if (minutes >= 0 && minutes <= 59)
            {
                Minutes = minutes;
            }
            else throw new Exception("Некорректное значение минут");
        }
        
        public void SetHours(int hours)
        {
            if (hours >= 0 && hours <= 59)
            {
                Hours = hours;
            }
            else throw new Exception("Некорректное значение часов");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Test2 test2 = new Test2();
            
            test2.Testing();
            
            AVTO1 avto1 = new AVTO1();
            
            avto1.InputData();
            avto1.ShowData();

            AVTO1 avto2 = new AVTO1(2004);
            avto2.ShowData();
            
            Time2 time2 = new Time2();
            time2.SetHours(10);
            time2.SetMinutes(25);
            time2.SetSeconds(30);

            Console.ReadKey();
        }
    }
}