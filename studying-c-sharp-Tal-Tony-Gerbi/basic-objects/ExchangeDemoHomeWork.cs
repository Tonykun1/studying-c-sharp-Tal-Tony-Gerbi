using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Tal_Tony_Gerbi.basic_objects
{
    public class ExchangeDemoHomeWork
    {
        //TODO - 
        //Do demo method for 3 stocks ( =מנייה)
        //Show start day price, close day price, percent change (=אחוזי שינוי)

        //work on the details of the date: 05/21/2024	
        //those are the details: 
        //https://www.nasdaq.com/market-activity/stocks/aapl/historical
        //https://www.nasdaq.com/market-activity/stocks/tsla/historical
        //https://www.nasdaq.com/market-activity/stocks/coke/historical
        //On each  stock:
        //Do start day (according to the real time above) 
        //Show details
        //Set the price of the stock that was the higher on this day
        //Show details
        //Try to get the percent change and get rejected
        //close the day
        //Show details
        //get the percent change
        public void Demo()
        {
            Stock apple = new Stock("Apple Inc.", "AAPL", "Technology", "NAS");
            Stock tsla = new Stock("Tesla, Inc.", "TSLA", "Automotive", "NSA");
            Stock coke = new Stock("Coca-Cola Company", "COKE", "Beverages", "NSY");

            apple.startDay(191.51);
            tsla.startDay(176.40);
            coke.startDay(983.71);
            Console.WriteLine("start details:");
            apple.Display();
            tsla.Display();
            coke.Display();

            apple.setPrice(193.00);
            tsla.setPrice(178.25);
            coke.setPrice(997.02);

            Console.WriteLine();
            Console.WriteLine("Updated details With  CurrentPrice:");
            apple.Display();
            tsla.Display();
            coke.Display();

            Console.WriteLine("Attempt to get percentage change:");
            Console.WriteLine(apple.PrintPercentage());
            Console.WriteLine(tsla.PrintPercentage());
            Console.WriteLine(coke.PrintPercentage());


            apple.finishDay(189.99);
            tsla.finishDay(375.0);
            coke.finishDay(988.40);
            Console.WriteLine();
            Console.WriteLine("Final details with closing prices:");
            apple.Display();
            tsla.Display();
            coke.Display();
            Console.WriteLine("Percentage change after closing the day:");
            Console.WriteLine(apple.PrintPercentage());
            Console.WriteLine(tsla.PrintPercentage());
            Console.WriteLine(coke.PrintPercentage());
        }


    }


    public class Stock
    {
        //create properties : 
        //Official Name, price, sign (=סמליל) ,starting price , closing price, industry(=תעשייה), exchange (=בורסה)
        // is day active 
        //create methods (פעולות ) 
        //start day - setting the current price and the starting price and day is active
        //finish day - setting the current price and the closing price
        //set price - setting the price
        //Print changes percentage (if the day is still  active it's not return nothing) 
        //Display Price - printing the Sign with the current price. 

        public string Name;
        public string Sign;
        public double CurrentPrice;
        public double startPrice;
        public double endPrice;
        public string industry;
        public bool day;
        public double TimeDay;
        public string exchange;

        public Stock(string name, string sign, string industry, string exchange)
        {
            this.Name = name;
            this.Sign = sign;
            this.industry = industry;
            this.exchange = exchange;
             this.day = true;
        }
        public void startDay(double Price)
        {
            this.startPrice = Price;
            this.CurrentPrice = Price;
            this.day = true;
        }
        public void finishDay(double Price)
        {
            this.endPrice = Price;
            this.CurrentPrice = Price;
            this.day = false;
        }
        public void setPrice(double Price)
        {
            this.CurrentPrice = Price;
        }
        public string PrintPercentage()
        {
            double percentage = (( this.CurrentPrice-this.startPrice) / this.startPrice) * 100;
            if (this.day)
                return $"Don't have change on percentage cuz the day not end";
            else
                return $"the Percentage is {percentage:F}%";
        }
        public void Display()
        {
            Console.WriteLine($"the name of stock is {this.Name}");
            Console.WriteLine($"the Sign of stock is {this.Sign}");
            Console.WriteLine($"the price of stock is {this.CurrentPrice}");
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"The Sign: {this.Sign}, Current Price: {this.CurrentPrice}");
        }
    }
}
