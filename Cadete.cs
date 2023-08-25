
using System.Runtime.InteropServices;

public class Cadete{
    private int id;
    private string nombre;
    private string direccion;
    private string numTelefono;
    private List<Pedido> listaPedidos;
    // public int cosa {get;set;}

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string NumTelefono { get => numTelefono; set => numTelefono = value; }

    public Cadete(int id, string nombre, string direccion, string numTelefono)
    {
        this.id= id;
        this.nombre = nombre;
        Direccion = direccion;
        NumTelefono = numTelefono;
        listaPedidos = new List<Pedido>();
    }



}
