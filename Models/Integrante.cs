public class Integrante
{
    public int dni;
    public string nombre;
    public DateTime fechaNacimiento;
    public string foto;
    public List<string> familiares;
    public List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }

    public int getDni()
    {
        return dni;
    }
}