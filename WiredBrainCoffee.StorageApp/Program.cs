using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repository;

var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
AddEmployees(employeeRepository);
GetEmployeeById(employeeRepository, 3);

var organizationRepository = new ListRepository<Organization>();
AddOrganizations(organizationRepository);

Console.ReadLine();

void GetEmployeeById(IRepository<Employee> employeeRepository, int Id)
{
    var employee = employeeRepository.GetById(Id);
    Console.WriteLine($"Employee with id {Id}: {employee.FirstName}");
}

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Bianca" });
    employeeRepository.Add(new Employee { FirstName = "Anna" });
    employeeRepository.Add(new Employee { FirstName = "Ruth" });
}

static void AddOrganizations(IRepository<Organization> organizationRepository)
{
    organizationRepository.Add(new Organization { Name = "Pluralsight" });
    organizationRepository.Add(new Organization { Name = "Alura" });
}