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
    private static Package dcaw = new Package("Devil’s Courthouse Adventure Weekend", "An action packed three days weekend spent camping, rock climbing, and rappelling at Devil’s Courthouse, North Carolina. This getaway for novices and expert alike. Climbing instructor is available to beginners at an optional low price. Camping equipment rental is also available.", 350m, new Extra[]{new Extra("Climbing Instruction", 100m), new Extra("Equipment Rental", 40m, Extra.PER_DAY)});

    // Scuba Bahama
    private static Package sb = new Package("Scuba Bahama", " week-long cruise to Bahama with three day with three days of scuba diving. Those with prior experience may dive right in, while beginners should choose to take the optional, but very affordable lesson.", 1000m, new Extra[]{new Extra("SCUBA Instruction", 100m)});

    // Sky Dive Colorado
    private static Package sdc = new Package("Sky Dive Colorado", "Four thrilling days with expert sky diving instructors in Colorado Springs. For lodging, you may choose either the Wilderness Lodge or Luxury Inn.", 400m, new Extra[] { new Extra("Wilderness Lodge", 65m, Extra.PER_DAY), new Extra("Luxury Inn", 120, Extra.PER_DAY) });

    // Baron Cliff
    private static Package bc = new Package("Baron Cliff", "Eight days spent hiking and exploring caves in the Barron Cliff Wilderness , in Tennessee. Camping equipment rental is available.", 700m, new Extra[] { new Extra("Equipment Rental", 40m, Extra.PER_DAY) });

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}