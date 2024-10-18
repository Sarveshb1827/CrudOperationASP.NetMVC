using System;
using System.Collections.Generic;

namespace CoreDICrud.Models;

public partial class TblCity
{
    public int CityId { get; set; }

    public string? City { get; set; }

    public int? StateId { get; set; }

    public virtual TblState? State { get; set; }

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
