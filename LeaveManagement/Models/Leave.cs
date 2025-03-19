using System;
using System.Collections.Generic;

namespace LeaveManagement.Models;

public partial class Leave
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Type { get; set; } = null!;

    public string? Status { get; set; }

    public string? Reason { get; set; }

    public virtual Employee? Employee { get; set; }
}
