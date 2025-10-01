using common;
namespace assign4
{
    //part 1
    public class person
    {
        public string name;
        public int age;
        public Permissions permissions;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            /*Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            person p = new person();
            p.name = name;
            p.age = age;
            Console.WriteLine($"your name is {p.name} and your age is {p.age}");
            p.permissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"you can {p.permissions}");
            */

            /* part 2*/
            //1
            /* for(int i = 0; i < 7; i++)
             {
                 weekdays day = (weekdays)i;
                 Console.WriteLine(day);
             }*/

            //2
            /*object[] people = new object[3];
            people[0] = new person { name = "mohamed", age = 20 };
            people[1] = new person { name = "ahmed", age = 25 };
            people[2] = new person { name = "ali", age = 35 };
            foreach(var p in people)
            {
                person per = (person)p;
                Console.WriteLine($"name: {per.name}, age: {per.age}");
            }*/

            //3
            /*Console.WriteLine("enter the season");
            string input = Console.ReadLine();
            season s = (season)Enum.Parse(typeof(season), input);
            if(s== season.spring)
            {
                Console.WriteLine("it is from march to may");
            }
            else if (s == season.summer)
            {
                Console.WriteLine("it is from june to august");
            }
            else if(s== season.autumn)
            {
                Console.WriteLine("it is from septemper to november");
            }
            else
            {
                Console.WriteLine("it is from december to february");
            }*/

            //4
            /*Permissions userPermissions = new Permissions();
            userPermissions |= Permissions.Read;
            userPermissions |= Permissions.Write;
            Console.WriteLine($"User Permissions: {userPermissions}");
            userPermissions &= ~Permissions.Write;
            Console.WriteLine($"User Permissions after removing Write: {userPermissions}");
            */
            //5
            /*Console.WriteLine("enter color:");
            string color = Console.ReadLine();
            Colors col = (Colors)Enum.Parse(typeof(Colors), color);
            if(col == Colors.red || col==Colors.green|| col==Colors.blue)
            {
                Console.WriteLine("it is primary color");
            }
            else Console.WriteLine("it is not primary color");
            */

            //6
            /*Console.WriteLine("enter first point");
            Point p1 = new Point();
            Console.Write("x:");
            p1.x = int.Parse(Console.ReadLine());
            Console.Write("y:");
            p1.y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second point");
            Point p2 = new Point();
            Console.Write("x:");
            p2.x = int.Parse(Console.ReadLine());
            Console.Write("y:");
            p2.y = int.Parse(Console.ReadLine());
            int dis =(int) Math.Sqrt(Math.Pow(p1.x-p2.x,2) + Math.Pow(p1.y - p2.y,2));
            Console.WriteLine($"the distance is {dis}");
            */


            //7
            /*person perso1 = new person();
            person perso2 = new person();
            person perso3 = new person();

            Console.WriteLine("enter first person");
            Console.Write("name:");
            perso1.name = Console.ReadLine();
            Console.Write("age:");
            perso1.age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second person");
            Console.Write("name:");
            perso2.name = Console.ReadLine();
            Console.Write("age:");
            perso2.age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third person");
            Console.Write("name:");
            perso3.name = Console.ReadLine();
            Console.Write("age:");
            perso3.age = int.Parse(Console.ReadLine());
            if(perso1.age > perso2.age && perso1.age > perso3.age)
            {
                Console.WriteLine($"the oldest is {perso1.name} and his age is {perso1.age}");
            }
            else if(perso2.age > perso1.age && perso2.age > perso3.age)
            {
                Console.WriteLine($"the oldest is {perso2.name} and his age is {perso2.age}");
            }
            else
            {
                Console.WriteLine($"the oldest is {perso3.name} and his age is {perso3.age}");
            }*/
        }
    }
}
