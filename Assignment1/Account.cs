using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    class Account
    {
        int id;
        string accountType;
        double balance;

        public int Id {  get { return id; } set {  id = value; } }
        public string AccountType { get {  return accountType; } set {  accountType = value; } }    
        public double Balance { get { return balance;} set { balance = value; } }   

        public bool WithDraw(double amount)
        {
            if (amount < Balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetDetails()
        {
            return $"Account Id: {id}\nAccount Type: {accountType}\nBalance: {balance}";



        }
    }
}
