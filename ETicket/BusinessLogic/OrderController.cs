﻿using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OrderController
    {
        private ICRUD crud = new DbOrder();
        private DbOrder dbOrder = new DbOrder();
        public int Create(Object order) => crud.Create(order);
        public object Get(int id) => crud.Get(id);
        public void Delete(int id) => crud.Delete(id);
        public void Update(Object order) => crud.Update(order);
        public List<Object> GetAll() => crud.GetAll();
        public List<Order> GetOrdersOfCustomer(string CustomerId) => dbOrder.GetOrdersOfCustomer(CustomerId);
        public List<Ticket> GetOrderTickets(int id) => dbOrder.GetOrderTickets(id);
        public void Cancel(Order order) => dbOrder.Cancel(order);
        public List<Order> GetCustomerOrdersByUsername(string Username) => dbOrder.GetCustomerOrdersByUsername(Username);

    }
}
