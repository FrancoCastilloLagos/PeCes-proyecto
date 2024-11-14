using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public static class TicketController
    {
        public static string Create(Ticket ticket)
        {
            ticket.Id = Guid.NewGuid().ToString().Substring(0, 8);
            ClienteEntity clienteEntity;

            if (ticket.Cliente is Empresa empresa)
            {
                clienteEntity = new EmpresaEntity
                {
                    Id = empresa.Id,
                    Nombre = empresa.Nombre,
                    Rut = empresa.Rut,
                    Telefono = empresa.Telefono,
                    Email = empresa.Email,
                    RazonSocial = empresa.RazonSocial
                };
            }
            else if (ticket.Cliente is PersonaNatural personaNatural)
            {
                clienteEntity = new PersonaNaturalEntity
                {
                    Id = personaNatural.Id,
                    Nombre = personaNatural.Nombre,
                    Rut = personaNatural.Rut,
                    Telefono = personaNatural.Telefono,
                    Email = personaNatural.Email
                };
            }
            else
            {
                return "Error: Tipo de cliente no reconocido.";
            }

            var ticketEntity = new TicketEntity
            {
                Id = ticket.Id,
                Cliente = clienteEntity,
                Producto = ticket.Producto,
                Descripción = ticket.Descripción,
                Estado = ticket.Estado 
            };

            TicketEntityCollection.ListadoTickets.Add(ticketEntity);

            return "Ticket creado con éxito.";
        }

        public static Ticket Read(string ticketId)
        {
            var ticketEntity = TicketEntityCollection.ListadoTickets.FirstOrDefault(t => t.Id == ticketId);
            if (ticketEntity != null)
            {
                return new Ticket
                {
                    Id = ticketEntity.Id,
                    Cliente = ConvertirCliente(ticketEntity.Cliente),
                    Producto = ticketEntity.Producto,
                    Descripción = ticketEntity.Descripción,
                    Estado = ticketEntity.Estado
                };
            }
            return null; 
        }

        public static string Update(Ticket ticket)
        {
            var ticketEntity = TicketEntityCollection.ListadoTickets.FirstOrDefault(t => t.Id == ticket.Id);
            if (ticketEntity != null)
            {
                ticketEntity.Producto = ticket.Producto;
                ticketEntity.Descripción = ticket.Descripción;
                ticketEntity.Estado = ticket.Estado; 

                if (ticketEntity.Cliente is PersonaNaturalEntity personaNaturalEntity)
                {
                    personaNaturalEntity.Telefono = ticket.Cliente.Telefono;
                    personaNaturalEntity.Email = ticket.Cliente.Email;
                }
                else if (ticketEntity.Cliente is EmpresaEntity empresaEntity)
                {
                    empresaEntity.Telefono = ticket.Cliente.Telefono;
                    empresaEntity.Email = ticket.Cliente.Email;
                }

                return "Ticket actualizado con éxito.";
            }

            return "Error: Ticket no encontrado.";
        }

        public static List<Ticket> ReadAll()
        {
            return TicketEntityCollection.ListadoTickets.Select(ticketEntity => new Ticket
            {
                Id = ticketEntity.Id,
                Cliente = ConvertirCliente(ticketEntity.Cliente),
                Producto = ticketEntity.Producto,
                Descripción = ticketEntity.Descripción,
                Estado = ticketEntity.Estado
            }).ToList();
        }

        private static Cliente ConvertirCliente(ClienteEntity clienteEntity)
        {
            if (clienteEntity is PersonaNaturalEntity personaNatural)
            {
                return new PersonaNatural
                {
                    Id = personaNatural.Id,
                    Nombre = personaNatural.Nombre,
                    Rut = personaNatural.Rut,
                    Telefono = personaNatural.Telefono,
                    Email = personaNatural.Email
                };
            }
            else if (clienteEntity is EmpresaEntity empresa)
            {
                return new Empresa
                {
                    Id = empresa.Id,
                    Nombre = empresa.Nombre,
                    Rut = empresa.Rut,
                    Telefono = empresa.Telefono,
                    Email = empresa.Email,
                    RazonSocial = empresa.RazonSocial
                };
            }
            return null;
        }
    }
}






