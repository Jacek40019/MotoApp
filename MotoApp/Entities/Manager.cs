namespace MotoApp.Entities
{
    public class Manager : Employee
    {

        public string? FirstName { get; set; }

        public override string ToString() => base.ToString() + "(Manager)";

    }
}
