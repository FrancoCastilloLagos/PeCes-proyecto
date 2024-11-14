using System.Collections.Generic;

public static class TicketEntityCollection
{
    private static List<TicketEntity> _listadoTickets = new List<TicketEntity>();

    public static List<TicketEntity> ListadoTickets
    {
        get { return _listadoTickets; }
        set { _listadoTickets = value; }
    }
}