using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /* Packages and Prices */
    // Devil's Courthouse
    private static Extra dcaw1 = new Extra("Climbing Instruction", 100m);
    private static Extra dcaw2 = new Extra("Equipment Rental", 40m, Extra.PER_DAY);
    private static Package dcaw = new Package("evil’s Courthouse Adventure Weekend", "An action packed three days weekend spent camping, rock climbing, and rappelling at Devil’s Courthouse, North Carolina. This getaway for novices and expert alike. Climbing instructor is available to beginners at an optional low price. Camping equipment rental is also available.", 350m, new Extra[]{dcaw1, dcaw2});

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}