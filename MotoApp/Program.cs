using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;
using MotoApp.Repository;
using System.Runtime.CompilerServices;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded;

void EmployeeRepositoryOnItemAdded(object? sender, Employee e)
{
    Console.WriteLine($"Employee added => {e.FirstName} from {sender?.GetType().Name}");    
}

AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);

static void EmployeeAdded(Employee item)
{
    Console.WriteLine($"{item.FirstName} added");
}

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee {FirstName = "Adam"},
        new Employee {FirstName = "Piotr"},
        new Employee {FirstName = "Zuzanna"}
    };

    employeeRepository.AddBatch(employees);
    //AddBatch(employeeRepository, employees);
}



//{
//{
//    employeeRepository.Add(new Employee { FirstName = "Adam" });
//    employeeRepository.Add(new Employee { FirstName = "Marek" });
//    employeeRepository.Add(new Employee { FirstName = "Zuzia" });
//    employeeRepository.Save();
//}




static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}