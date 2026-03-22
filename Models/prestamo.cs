using System;

public class Prestamo
{
    public int Id { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }
    public EstadoPrestamo Estado { get; set; }

    public Prestamo()
    {
        Estado = EstadoPrestamo.Activo;
        FechaPrestamo = DateTime.Now;
        FechaDevolucion = null;
    }

    public Prestamo(int id, DateTime fechaPrestamo)
    {
        Id = id;
        FechaPrestamo = fechaPrestamo;
        Estado = EstadoPrestamo.Activo;
        FechaDevolucion = null;
    }

    public bool EstaVencido()
    {
        return (DateTime.Now - FechaPrestamo).Days > 7;
    }

    public int DiasTranscurridos()
    {
        return (DateTime.Now - FechaPrestamo).Days;
    }

    public string ResumenCorto()
    {
        return $"Préstamo {Id} - Estado: {Estado}";
    }

    public string DetalleCompleto()
    {
        return $"ID: {Id}, Fecha: {FechaPrestamo}, Estado: {Estado}";
    }

    public override string ToString()
    {
        return DetalleCompleto();
    }
}