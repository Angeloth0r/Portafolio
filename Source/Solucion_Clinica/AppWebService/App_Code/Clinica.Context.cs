﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class EntitiesClinica : DbContext
{
    public EntitiesClinica()
        : base("name=EntitiesClinica")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<ATENCION> ATENCION { get; set; }
    public DbSet<CAJA> CAJA { get; set; }
    public DbSet<CAJERO> CAJERO { get; set; }
    public DbSet<CALENDARIO> CALENDARIO { get; set; }
    public DbSet<CENTRO_MEDICO> CENTRO_MEDICO { get; set; }
    public DbSet<ERRORES> ERRORES { get; set; }
    public DbSet<ESPECIALIDAD> ESPECIALIDAD { get; set; }
    public DbSet<FORMA_PAGO> FORMA_PAGO { get; set; }
    public DbSet<HORARIO> HORARIO { get; set; }
    public DbSet<LOG_RESERVA> LOG_RESERVA { get; set; }
    public DbSet<MEDICO> MEDICO { get; set; }
    public DbSet<PACIENTE> PACIENTE { get; set; }
    public DbSet<PERSONAL> PERSONAL { get; set; }
    public DbSet<PREVISION> PREVISION { get; set; }
    public DbSet<RECAUDACION> RECAUDACION { get; set; }
    public DbSet<RESERVA> RESERVA { get; set; }
    public DbSet<SECRETARIA> SECRETARIA { get; set; }
    public DbSet<TIPO_PAGO> TIPO_PAGO { get; set; }
    public DbSet<TIPO_RESERVA> TIPO_RESERVA { get; set; }
    public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
    public DbSet<USUARIO> USUARIO { get; set; }
}
