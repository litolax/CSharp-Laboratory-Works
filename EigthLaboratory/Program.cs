namespace EigthLaboratory
{
    class Program
    {
        public struct Student
        {
            public string Name, Surname, SecondSurname;
            public int YearOfBirthday;
            public int Group;
            public int PhysicsMark, MathMark, InformationMark, HemistryMark;
            public int[] SortedMarks;

            public void InputData()
            {
                Console.WriteLine("Введите имя: ");
                this.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию: ");
                this.Surname = Console.ReadLine();
                Console.WriteLine("Введите отчество: ");
                this.SecondSurname = Console.ReadLine();
                Console.WriteLine("Введите год рождения: ");
                this.YearOfBirthday = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер группы: ");
                this.Group = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите отметку за семестр по химии: ");
                this.HemistryMark = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите отметку за семестр по физике: ");
                this.PhysicsMark = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите отметку за семестр по математике: ");
                this.MathMark = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите отметку за семестр по информатике: ");
                this.InformationMark = Convert.ToInt32(Console.ReadLine());
            }

            public string GetFIO()
            {
                return $"{Surname} {Name[0]}.{SecondSurname[0]}";
            }

            public double GetAverageMark()
            {
                return (MathMark + HemistryMark + PhysicsMark + InformationMark) / 4;
            }

            enum Marks
            {
                Math,
                Hemistry,
                Physics,
                Information
            }

            public int[] Sort()
            {
                this.SortedMarks = new [] { MathMark, PhysicsMark, InformationMark, HemistryMark };
                int temp;
                for (var i = 0; i < 3; i++)
                {
                    var min = i;
                    for (var j = i + 1; j < 4; j++)
                    {
                        if (SortedMarks[j] < SortedMarks[min])
                            min = j;
                    }

                    temp = SortedMarks[i];
                    SortedMarks[i] = SortedMarks[min];
                    SortedMarks[min] = temp;
                }

                return SortedMarks;
            }

            public void ShowMarks() =>
                Console.WriteLine(
                    $"Отметка {Name} по математике {MathMark}, по физике {PhysicsMark}, по информатике {InformationMark}, по химии {HemistryMark}");

            public void ShowSortedMarks()
            {
                Console.WriteLine($"Отсортированные отметки {Name}:{SortedMarks[0]}, {SortedMarks[1]}, {SortedMarks[2]}, {SortedMarks[3]}");
            }

            public void ShowInfo() =>
                Console.WriteLine(
                    $"Имя: {GetFIO()}.\nГод рождения: {YearOfBirthday}.\nНомер группы: {Group}\nСредний балл: {GetAverageMark()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько студентов вы хотите ввести? ");
            var studentsCount = int.Parse(Console.ReadLine());
            var st = new Student[studentsCount];
            for (var i = 0; i < studentsCount; i++)
            {
                st[i] = new Student();
                st[i].InputData();
            }

            Console.WriteLine("Введите интересующую вас группу: ");
            var groupIndex = int.Parse(Console.ReadLine());
            double average = 0.0;
            for (var i = 0; i < studentsCount; i++)
            {
                average += st[i].GetAverageMark();
            }

            average /= studentsCount;

            for (var i = 0; i < studentsCount; i++)
            {
                var student = st[i];
                if (student.Group != groupIndex || !(student.GetAverageMark() > average)) continue;
                student.ShowInfo();
                student.ShowMarks();
                student.Sort();
                student.ShowSortedMarks();
            }

            Console.ReadKey();
        }
    }
}