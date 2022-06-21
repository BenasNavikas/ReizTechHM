using ReizTechHM;

Branch branch = new Branch();
Person person1 = new Person() { name = "Name1", surname = "Surname1" };
Person person2 = new Person() { name = "Name2", surname = "Surname2" };
Person person3 = new Person() { name = "Name3", surname = "Surname3" };
Person person4 = new Person() { name = "Name4", surname = "Surname4" };
Person person5 = new Person() { name = "Name5", surname = "Surname5" };
Person person6 = new Person() { name = "Name6", surname = "Surname6" };
Person person7 = new Person() { name = "Name7", surname = "Surname7" };
Person person8 = new Person() { name = "Name8", surname = "Surname8" };
Person person9 = new Person() { name = "Name9", surname = "Surname9" };
Person person10 = new Person() { name = "Name10", surname = "Surname10" };
Person person11 = new Person() { name = "Name11", surname = "Surname11" };
Person person12 = new Person() { name = "Name12", surname = "Surname12" };

branch.Branches = new List<Branch> { person1 };
person1.Branches = new List<Branch> { person2, person3 };
person2.Branches = new List<Branch> { person4 };
person3.Branches = new List<Branch> { person5, person6, person7 };
person5.Branches = new List<Branch> { person8 };
person6.Branches = new List<Branch> { person9, person10 };
person9.Branches = new List<Branch> { person11 };
person7.Branches = new List<Branch> { person12 };
int depth = Branch.FindDepth(branch, 0);
Console.WriteLine("Branch depth: {0}", depth);


try
{
    Console.Write("Enter hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Enter minutes : ");
    int minutes = int.Parse(Console.ReadLine());
    if (hours > 12 || hours < 1 || minutes > 60 || minutes < 0)
    {
        Console.WriteLine("Wrong data range. Hours must be {1; 12}, minutes must be {0; 60}!!");
    }
    Calculations calculations = new Calculations();
    double angle = calculations.FindAngle(hours, minutes);
    Console.Write("Angle between {0} and {1} is {2} degrees.", hours, minutes, angle);
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}
