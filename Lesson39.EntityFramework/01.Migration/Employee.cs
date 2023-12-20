using System;
using System.Collections.Generic;

namespace _01.Migration;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
