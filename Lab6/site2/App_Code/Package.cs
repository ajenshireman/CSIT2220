using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Package.cs
/// 
/// Holds information for a single adventure package
/// </summary>
public class Package
{
    private string      name;           // Pakage name
    private string      description;    // Packae description
    private decimal     price;          // Base cost pre person
    private List<Extra> extras;         // List of extra services

	private Package()
	{
	}

    public Package ( string name, string description, decimal price, Extra[] extras )
    {
        this.name = name;
        this.description = description;
        this.price = price;
        for ( int i = 0; i < extras.Length; i++ )
        {
            this.extras.Add(extras[i]);
        }
    }
}