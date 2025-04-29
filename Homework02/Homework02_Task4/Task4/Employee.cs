namespace Task4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public Employee (string name)
        {  Name = name; }

        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
