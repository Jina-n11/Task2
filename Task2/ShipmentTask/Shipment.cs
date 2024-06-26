using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.ShipmentTask
{
    public class Shipments
    { 
    
        public List<Shipment> shipments = new List<Shipment>();

        public void AddShipments()
        {
            for (int i = 0; i < 10; i++)
            {
                this.shipments.Add(new Shipment(Content: $" Shipment no. {i}", Quantity: i + 1 * 3, ShipmentSequence: i));
            }

        }

        public void DisplayLoadingShipments()
        {
            foreach (Shipment shipment in this.shipments)
            {
                Console.WriteLine($"orderID: {shipment.orderID} , content:{shipment.content} ,quantity: {shipment.quantity} ,Shipment Sequence: {shipment.shipmentSequence}");
            }
        }

        public void DisplayUnloadingShipments(int shipmentSequence =0)
        {
            // base case
            if (shipmentSequence > this.shipments.Count -1 )
                return;

            // recurive case
            DisplayUnloadingShipments(shipmentSequence + 1);
            var shipment = this.shipments[shipmentSequence];
            Console.WriteLine($"orderID: {shipment.orderID} ,content:{shipment.content} ,quantity: {shipment.quantity} ,Shipment Sequence: {shipment.shipmentSequence}");
        }

    }


        public class Shipment
    {
        public string? orderID { get; set; } = null;
        public string? content { get; set; }
        public int quantity { get; set; }
        public int shipmentSequence { get; set; }

        public Shipment(string? OrderID = null , string? Content = null, int Quantity = 0 , int ShipmentSequence =0) 
        {
            orderID = OrderID != null? OrderID : Guid.NewGuid().ToString();
            content = Content;
            quantity = Quantity;
            shipmentSequence = ShipmentSequence;
        }

    

    }
}
