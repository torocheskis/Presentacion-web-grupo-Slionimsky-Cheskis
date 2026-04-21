public class Integrante
{
    public int dni;
    public string nombre;
    public DateTime fechaNacimiento;
    public string foto;
    list<string> Familiares;
    list<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, list<string> Familiares, list<string> intereses)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.Familiares = Familiares;
        this.interese = intereses;
    }

    public int getDni():
    {
        return dni;
    }
}