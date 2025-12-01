using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ControlPoint4
{
    public static class Ticket
    {
        public static int activeTicket;
        public static List<TicketNode> tickets;

        public static bool isGood = false;

        public static event EventHandler ticketChanged;
        public static void Createticket()
        {
            tickets = new List<TicketNode>();
            //tickets.Add (new TicketNode() { title = "test", answers = new List<string>(), variable = new List<string>(), description = "test", type = ["radio"] }) ;
            activeTicket = 0;
            Saveticket();
        }

        public static void Loadticket()
        {
            tickets = new();
            isGood = false;
            if (!File.Exists("tickets.json")) { return; }

            FileStream stream = new FileStream(path: "tickets.json", FileMode.Open);
            List<TicketNode> ticket = JsonSerializer.Deserialize<List<TicketNode >>(stream);
            stream.Close();

            if (ticket == null) return;
            bool isBad = false;
            ticket .ForEach(ticket =>
            {
                if (string.IsNullOrEmpty(ticket.PassengerName ) || 
                string.IsNullOrEmpty(ticket.FlightNumber ) ||
                string.IsNullOrEmpty(ticket.PassengerName )) isBad = true;

            });
            if (isBad) { Createticket(); return; }
            ;

            isGood = true;
            //activeTicket = ticket.currentTicket;
            tickets = ticket ;

        }
        public static void Saveticket()
        {
            MasterTicketNode node = new MasterTicketNode();
            //node.currentTicket = activeTicket;
            node.Tickets = tickets;

            //ticketChanged.Invoke(node, new ticketChangedEventArgs());   
            string json = JsonSerializer.Serialize(node);
            File.WriteAllText("ticket.json", json);
        }

    }
    public class ticketChangedEventArgs : EventArgs
    {

    }
    public class MasterTicketNode
    {
        //public int currentTicket { get; set; }
        public List<TicketNode> Tickets { get; set; }
    }
    public class TicketNode
    {
        public string PassengerName { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureTime { get; set; }
        public string TicketClass { get; set; }
    }
}
