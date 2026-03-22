using System;

public class Prestamo
{
    public string Id { get; set; }
    public Libro Libro { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime? FechaDevolucion { get; set; }
    public EstadoPrestamo Estado { get; set; }

    public Prestamo()
    {
        Estado = EstadoPrestamo.Activo;
        FechaDevolucion = null;
    }

    public Prestamo(string id, Libro libro, Usuario usuario, DateTime fechaPrestamo, DateTime fechaLimite)
    {
        Id = id;
        Libro = libro;
        Usuario = usuario;
        FechaPrestamo = fechaPrestamo;
        FechaLimite = fechaLimite;
        Estado = EstadoPrestamo.Activo;
        FechaDevolucion = null;
    }

    public bool EstaVencido()
    {
        return DateTime.Now > FechaLimite && Estado == EstadoPrestamo.Activo;
    }

    public int DiasTranscurridos()
    {
        return (DateTime.Now - FechaPrestamo).Days;
    }

    public string ResumenCorto()
    {
        return $"Préstamo {Id} - {Libro.Titulo} a {Usuario.Nombre}";
    }

    public string DetalleCompleto()
    {
        return $"ID: {Id} | Libro: {Libro.Titulo} | Usuario: {Usuario.Nombre} | Estado: {Estado}";
    }

    public override string ToString()
    {
        return DetalleCompleto();
    }
}