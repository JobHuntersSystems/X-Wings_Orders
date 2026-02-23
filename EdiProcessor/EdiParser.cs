using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using EF_CRUD;
using System.Data.Entity;



namespace EdiProcessor
{
    public class EdiParser
    {
        OrdersEntity ctx;
        int OrdersIDs = new int();

        public int ReadEDI(string filepath)
        {
            ctx = new OrdersEntity();
            string[] EDILines = null;
            if (File.Exists(filepath))
            {
                EDILines = File.ReadAllLines(filepath);
            }

            SaveEDI(EDILines);
            string fileName = Path.GetFileName(filepath);
            string destPath = Path.Combine(@"FTP\Tractats", fileName);
            File.Move(filepath, destPath);

            return OrdersIDs;
        }

        private void SaveEDI(string[] EDIList)
        {
            Order order = new Order();
            OrderInfo orderInfo = new OrderInfo();
            OrdersDetail ordersDetail = new OrdersDetail();

            if (EDIList[0].Equals("ORDERS_D_96A_UN_EAN008"))
            {
                foreach (string data in EDIList)
                {
                    string[] splitedData = data.Split('|');

                    switch (splitedData[0])
                    {
                        case "ORD": 
                            order = new Order();
                            order = ProcessORD(order, splitedData);
                            break;
                        case "DTM": 
                            order = ProcessDTM(order, splitedData);
                            break;
                        case "NADMS": 
                            orderInfo = new OrderInfo();
                            order.OrderInfoes.Add(ProcessNADMS(orderInfo, splitedData));
                            break;
                        case "NADMR": 
                            order = ProcessNADMR(order, splitedData);
                            break;
                        case "LIN":
                            ordersDetail = new OrdersDetail();
                            ordersDetail = ProcessLIN(ordersDetail, splitedData);
                            break;
                        case "QTYLIN":
                            ordersDetail = ProcessQTYLIN(ordersDetail, splitedData);
                            break;
                        case "DTMLIN":
                            ordersDetail = ProcessDTMLIN(ordersDetail, splitedData);
                            order.OrdersDetails.Add(ordersDetail);
                            break;
                        default:
                            break;
                    }
                }
                ctx.Orders.Add(order);
                ctx.SaveChanges();
                OrdersIDs = order.idOrder;
            }
        }

        #region Methods Order
        private Order ProcessORD(Order order, string[] data)
        {
            order.codeOrder = data[1];
            switch (data[2])
            {
                case "220":
                    order.IdPriority = 1;
                    break;
                case "22E":
                    order.IdPriority = 2;
                    break;
                default:
                    break;
            }

            return order;
        }

        private Order ProcessDTM(Order order, string[] data)
        {
            DateTime fecha = DateTime.ParseExact(data[1], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            order.dateOrder = fecha;
            return order;
        }

        private Order ProcessNADMR(Order order, string[] data)
        {
            switch (data[1])
            {
                case "NABOSOUTXW02":
                    order.IdFactory = 1;
                    break;
                case "ENDONORTAW01":
                    order.IdFactory = 2;
                    break;
                case "MUSTNORTTAF1":
                    order.IdFactory = 3;
                    break;
                case "MANDSOUTSD02":
                    order.IdFactory = 4;
                    break;
                default:
                    break;
            }

            return order;
        }

        #endregion

        #region Methods OrderDetails
        private OrderInfo ProcessNADMS(OrderInfo orderInfo , string[] data)
        {
            short areaOperativaId;
            switch (data[1])
            {
                case "OUTER":
                    areaOperativaId = 1;
                    break;
                case "INNER":
                    areaOperativaId = 2;
                    break;
                case "UNKNO":
                    areaOperativaId = 3;
                    break;
                default:
                    areaOperativaId = 4;
                    break;
            }

            short emisorId;
            switch (data[2])
            {
                case "37EA":
                    emisorId = 1;
                    break;
                case "40A":
                    emisorId = 2;
                    break;
                case "FOSB":
                    emisorId = 3;
                    break;
                case "SOC":
                    emisorId = 4;
                    break;
                default:
                    emisorId = 1;
                    break;
            }

            orderInfo = new OrderInfo();

            orderInfo.idAgency = emisorId;
            orderInfo.idOperationalArea = areaOperativaId;

            return orderInfo;

        }

        #endregion

        #region Methods Order
        private OrdersDetail ProcessLIN(OrdersDetail orderDetail, string[] data)
        {
            string codigoPlaneta = data[1];
            string codigoReferencia = data[2];

            var prueba = ctx.Planets.FirstOrDefault(p => p.CodePlanet == (codigoPlaneta));
            int idplaneta = prueba.idPlanet;
     
            var prueba2 = ctx.References.FirstOrDefault(p => p.codeReference == codigoReferencia);
            short idreference = prueba2.idReference;

            orderDetail.idPlanet = idplaneta;
            orderDetail.idReference = idreference;

            return orderDetail;
        }

        private OrdersDetail ProcessQTYLIN(OrdersDetail ordersDetail, string[] data)
        {

            int cantidad;
            if (data[1].Equals("21"))
            {
                cantidad = int.Parse(data[2]);
            }
            else
            {
                cantidad = int.Parse(data[2]) * (-1);
            }
            ordersDetail.Quantity = (short) cantidad;
            return ordersDetail;
        }


        private OrdersDetail ProcessDTMLIN(OrdersDetail ordersDetail, string[] data)
        {
            DateTime fecha = DateTime.ParseExact(data[1], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            ordersDetail.DeliveryDate = fecha;
            return ordersDetail;
        }

        #endregion
    }
}
