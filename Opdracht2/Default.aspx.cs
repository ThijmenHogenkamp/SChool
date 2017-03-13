﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMaakKaart_Click(object sender, EventArgs e)
    {
        // Het aanmaken van de variablen (=Declareren)
        string Naam, Geslacht, Hobby, Opleiding;
        // Het vullen van de variabele Naam (=Initialiseren)
        // met de inhoud (Text) van de Textbox
        Naam = txtNaam.Text;
        Geslacht = rbGeslacht.SelectedValue;
        Opleiding = cbOpleiding.SelectedValue;
        Hobby = "Hobby: ";
        if (chkHobby.SelectedValue == "1")
        {
            Hobby += "Gamen ";
        }
        if (chkHobby.SelectedValue == "2")
        {
            Hobby += "Programmeren";
        }
        Response.Write("Naam: " + Naam + "<br />");
        Response.Write(Hobby + "<br />");
        Response.Write("Opleiding: " + Opleiding + "<br />");
        Response.Write("Geslacht: " + Geslacht + "<br />");
    }

           protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Form;


        if (rbForm.SelectedValue == "1")
        {
            Panel1.Visible = true;
        }

        if (rbForm.SelectedValue == "2")
        {
            Panel1.Visible = false;
        }
    }
}