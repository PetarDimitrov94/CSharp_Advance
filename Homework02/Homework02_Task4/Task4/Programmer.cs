namespace Task4
{
    public class Programmer : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public Programmer (string name, double hourlyRate, double hoursWorded) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorded;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }

    }
}
