﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupal_PROG3
{
    public partial class Ejercicio2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string ciudad;
            //nombre = Request.QueryString["Nom"];

            nombre = Request["txtNombre"];
            apellido = Request["txtApellido"];
            ciudad = Request["ddlCiudades"];
            lblNombreForm.Text = nombre;
            lblApellidoForm.Text = apellido;
            lblZonamostrar.Text = ciudad;
        }
    }
}