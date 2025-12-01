namespace ControlPoint4
{
    public partial class Form1 : Form
    {
        List<string> flights = new List<string>();
        List<List<string>> clas = new List<List<string>>();
        List<List<List<string>>> passangers = new List<List<List<string>>>();  
        public Form1()
        {
            InitializeComponent();
            ControlPoint4.Ticket.Loadticket();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes. Clear();
            foreach (TicketNode node in Ticket.tickets)
            {
                if (!flights.Contains(node.FlightNumber)) {

                    flights.Add(node.FlightNumber);
                    clas.Add(new List<string>());
                    passangers.Add(new List<List<string>>());
                    
                    treeView1.Nodes.Add( node.FlightNumber );
                    treeView1.Nodes[flights.IndexOf(node.FlightNumber )  ].Nodes.Add( "Дата отправления: "+ node.DepartureTime );
                    treeView1.Nodes[flights.IndexOf(node.FlightNumber)].Nodes.Add("Пассажиры");
                }

                int a = flights.IndexOf(node.FlightNumber);
                if (!clas[a].Contains(node.TicketClass))
                {
                    clas[a ].Add(node.TicketClass);
                    passangers[a].Add(new List<string>());

                    treeView1.Nodes[a].Nodes[1].Nodes .Add(new TreeNode()
                    {
                        Text = node.TicketClass,
                        Name = node.TicketClass
                    });
                }
                int b = clas[a].IndexOf(node.TicketClass);
                treeView1.Nodes[a].Nodes[1].Nodes[b].Nodes.Add(node.PassengerName);  
            }
        }
    }
}
