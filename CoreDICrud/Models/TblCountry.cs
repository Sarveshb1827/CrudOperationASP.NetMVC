using System;
using System.Collections.Generic;

namespace CoreDICrud.Models;

public partial class TblCountry
{
    public int CountryId { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<TblState> TblStates { get; set; } = new List<TblState>();
}
