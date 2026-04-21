public class Grupo
{
    private dictionary<int, Integrante> integrantes = new dictionary<int, Integrante>();

    public void cargarDatosManuales()
    {
        list<string> fam1 = new list<string>();
        fam1.Add("Damian");
        fam1.Add("Laura");
        fam1.Add("Emi");

        list<string> int1 = new list<string>();
        int1.Add("Jugar al futbol");
        int1.Add("Jugar a la play");
        int1.Add("Ver independiente");

        Integrante I1 = new Integrante(49700741, "Agustin Slonimsky", new DateTime(2009, 8, 9), ".", fam1, int1); 

        list<string> fam2 = new list<string>();
        fam2.Add("Gustavo");
        fam2.Add("Natalia");
        fam2.Add("Valentina");
        fam2.Add("Lucila");

        list<string> int2 = new list<string>();
        int2.Add("Jugar al futbol");
        int2.Add("Ir a macabi");
        int2.Add("Ver River");

        Integrante I2 = new Integrante(49551586, "Tomas Cheskis", new DateTime(2009, 10, 8), ".", fam2, int2);   
    }
    public dictionary<int, Integrante> devolverIntegrantes()
    {
        return integrantes;
    }
    public Integrante getIntegante(int dni)
    {
        Integrante N = null;
        if(integrantes.ContainsKey(dni))
        {
            N = integrantes[dni];
        }
        return N;
    }

}