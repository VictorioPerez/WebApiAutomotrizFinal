﻿using AutomotrizBackend.Datos;
using AutomotrizBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Servicios.Interfaces
{
    public interface IServicio
    {
        List<FormaEntrega> GetFormaEntrega();
        List<Marcas> GetMarcas();
        List<Modelos> GetModelos();
        List<Colores> GetColores();
        List<Vehiculo> GetVehiculos();
        List<TipoCliente> GetTipoCliente();
        List<Cliente> GetClientes();
        List<Vendedor> GetVendedores();
        List<FormasPago> GetFormaPago();
        List<Autopartes> GetAutopartes();
        List<Autopartes> GetAutopartesFiltros(List<Parametro> criterios);
        List<Vehiculo> GetVehiculosFiltros(List<Parametro> criterios);
        bool CrearCliente(Cliente c);
        bool PostFacturacionVehiculo(Facturas f);
        bool CrearVehiculo(Vehiculo v);
        bool CrearAutoparte(Autopartes a);
    }
}
