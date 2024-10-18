using System;
using System.Collections.Generic;

namespace CoreDICrud.Models;

public partial class TblUser
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public int? CityId { get; set; }

    public virtual TblCity? City { get; set; }
}
