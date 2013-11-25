using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Extra.cs
/// 
/// Holds Information for a single extra service
/// </summary>
public class Extra
{
    public const bool PER_DAY = true;

    private string  name;   // Name of the extra service
    private decimal price;  // Price per person
    private bool    perDay; // Is the charge per day?

	private Extra()
	{
	}

    public Extra ( string name, decimal price, bool perDay )
    {
        this.name = name;
        this.price = price;
        this.perDay = perDay;
    }

    public Extra ( string name, decimal price )
        : this(name, price, false)
    {
    }

    public string getName () { return this.name; }
    public decimal getPrice () { return this.price; }
    public bool isPerDay () { return this.perDay; }
}