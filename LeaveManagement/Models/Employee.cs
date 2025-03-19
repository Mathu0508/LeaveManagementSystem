using System;
using System.Collections.Generic;

namespace LeaveManagement.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int? LeaveBalance { get; set; }

    public virtual ICollection<Leave> Leaves { get; set; } = new List<Leave>();
}
