using System;
using System.Collections.Generic;

namespace TPpresentacionWeb.Models;

public class Grupo
{
    private Dictionary<int, Integrante> integrantes = new Dictionary<int, Integrante>();

    public Grupo()
    {
        cargarDatosManuales();
    }

    public void cargarDatosManuales()
    {
        List<string> fam1 = new List<string>();
        fam1.Add("Papa: Damian");
        fam1.Add("Mama: Laura");
        fam1.Add("Hermano: Emiliano");

        List<string> int1 = new List<string>();
        int1.Add("Futbol");
        int1.Add("Cissab");
        int1.Add("Play");
        int1.Add("Independiente");

        Integrante i1 = new Integrante(49700741,"Agustin Slonimsky",new DateTime(2009, 8, 23),"/img/Agus.jpg",fam1,int1);

        List<string> fam2 = new List<string>();
        fam2.Add("Papa: Gustavo");
        fam2.Add("Mama: Natalia");
        fam2.Add("Hermana: Valentina");
        fam2.Add("Hermana: Lucila");

        List<string> int2 = new List<string>();
        int2.Add("Futbol");
        int2.Add("Macabi");
        int2.Add("River");

        Integrante i2 = new Integrante(49551586,"Tomas Cheskis",new DateTime(2009, 10, 8),"/img/Toto.jpg",fam2,int2);

        integrantes.Add(i1.dni, i1);
        integrantes.Add(i2.dni, i2);
    }

    public Dictionary<int, Integrante> devolverIntegrantes()
    {
        return integrantes;
    }

    public Integrante getIntegrante(int dni)
    {
        if (integrantes.ContainsKey(dni))
        {
            return integrantes[dni];
        }

        return null;
    }
}