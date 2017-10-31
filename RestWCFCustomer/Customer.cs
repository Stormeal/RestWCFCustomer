using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestWCFCustomer
{
    public class Customer
    {
        private int _id;
        private string _firstName;
        private string _latName;
        private int _year;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LatName
        {
            get { return _latName; }
            set { _latName = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Customer(int id, string firstName, string latName, int year)
        {
            _id = id;
            _firstName = firstName;
            _latName = latName;
            _year = year;
        }

        public Customer()
        {
            
        }
    }
}