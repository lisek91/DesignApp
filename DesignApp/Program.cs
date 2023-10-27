using DesignApp;

Employee employee1 = new Employee("Adam", "Suś", 29);
Employee employee2 = new Employee("Mariusz", "Sywak", 25);
Employee employee3 = new Employee("Krzysztof", "Danielik", 27);

employee1.Addscore(3);
employee1.Addscore(7);
employee1.Addscore(4);
employee1.Addscore(6);
employee1.Addscore(2);

employee2.Addscore(2);
employee2.Addscore(8);
employee2.Addscore(6);
employee2.Addscore(1);
employee2.Addscore(5);

employee3.Addscore(9);
employee3.Addscore(6);
employee3.Addscore(3);
employee3.Addscore(7);
employee3.Addscore(8);


List<Employee> Employees = new List<Employee>()
{

employee1, employee2, employee3

};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var employee in Employees) 
{

    if (employee.Result > maxResult) 
    {

        employeeWithMaxResult = employee;
            
    }

}

Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + "w wieku" + " " + employeeWithMaxResult.Age + " " + "lat");
Console.WriteLine("otrzymał wynik" + " " + employeeWithMaxResult.Result + " ");


