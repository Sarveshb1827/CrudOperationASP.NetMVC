using System;
using System.Collections.Generic;

namespace CoreDICrud.Models;

public partial class TblState
{
    public int StateId { get; set; }

    public string? State { get; set; }

    public int? CountryId { get; set; }

    public virtual TblCountry? Country { get; set; }

    public virtual ICollection<TblCity> TblCities { get; set; } = new List<TblCity>();
}
