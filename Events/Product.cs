﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockControl stockControlEvent;
        public string ProductName { get; set; }
        public int Stock 
        { 
            get 
            { 
                return _stock;
            } 
            set 
            {
                _stock = value;
                if (value<=15 && stockControlEvent!=null)
                {
                    stockControlEvent();
                }
            }
        }
        public void Sell(int amount) 
        {
        Stock-=amount;
            Console.WriteLine("{1} Stock amount: {0}",Stock,ProductName);
        }
    }
}
