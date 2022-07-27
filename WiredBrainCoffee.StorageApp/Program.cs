using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repository;

var employeeRepository = new GenericRepository<Employee>();

AddEmployees(employeeRepository);
employeeRepository.Save();
GetEmployeeById(employeeRepository);

var organizationRepository = new GenericRepository<Organization>();

AddOrganizations(organizationRepository);
employeeRepository.Save();

Console.ReadLine();

void GetEmployeeById(GenericRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine($"Employee with id 2: {employee.FirstName}");
}

static void AddEmployees(GenericRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Bianca" });
    employeeRepository.Add(new Employee { FirstName = "Anna" });
    employeeRepository.Add(new Employee { FirstName = "Ruth" });
}

static void AddOrganizations(GenericRepository<Organization> organizationRepository)
{
    organizationRepository.Add(new Organization { Name = "Pluralsight" });
    organizationRepository.Add(new Organization { Name = "Alura" });
}