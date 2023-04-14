namespace SampleMvcApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"<h1>Name: {Name}</h1><p>{Email}</p><p>{Salary:C}";
        }
    }
}
