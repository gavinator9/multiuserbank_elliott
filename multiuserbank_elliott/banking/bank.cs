using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class bank
    {


        private decimal _balancejohn=1250;
        private decimal _balancepaul=2500;
        private decimal _balanceringo=1000;
        private decimal _balancegeorge=3000;
        private decimal _bankbalance= 10000;
        private decimal _balanceindex = 0;


        public decimal balanceindex
        {
            get { return _balanceindex; }
            set { _balanceindex = value; }
        }


        public decimal bankbalance
        {
            get { return _bankbalance; }
            set { _bankbalance = value; }
        }

        public decimal balancejohn
        {
            get { return _balancejohn; }
            set { _balancejohn = value; }
        }

        public decimal balancepaul
        {
            get { return _balancepaul; }
            set { _balancepaul = value; }
        }

        public decimal balanceringo
        {
            get { return _balanceringo; }
            set { _balanceringo = value; }
        }

        public decimal balancegeorge
        {
            get { return _balancegeorge; }
            set { _balancegeorge = value; }
        }

        public bank(decimal balance)
        {
            _bankbalance= balance;
        }

        public string deposit(decimal input, char account)
        {
            string output = "";
            if (account == '1')
            {
                _balancejohn += input;
                _balanceindex = _balancejohn;
                _bankbalance += input;
                output = "Your new higher balance is: " + _balancejohn.ToString("C");

            }
            if (account == '2')
            {
                _balancepaul += input;
                _balanceindex = _balancepaul;
                _bankbalance += input;
                output = "Your new higher balance is: " + _balancepaul.ToString("C");
            }
            if (account == '3')
            {
                _balancegeorge += input;
                _balanceindex = _balancegeorge;
                _bankbalance+= input;
                output = "Your new higher balance is: " + _balancegeorge.ToString("C");
            }
            if (account== '4')
            {
                _balanceringo += input;
                _balanceindex = _balanceringo;
                _bankbalance += input;
                output = "Your new higher balance is: " + _balanceringo.ToString("C");
            }
            return output;
        
        
        }

        public string withdraw(decimal input, char account)
        {
            string output="da bank is empty";

            if (_bankbalance>0)
            {
                if (account == '1')
                {
                    if (input > _balancejohn)
                    {
                        _bankbalance -= _balancejohn;
                    }
                    else
                    {
                        _bankbalance -= input;
                    }
                    _balancejohn -= input;
                    _balanceindex = _balancejohn;


                    if (_balancejohn < 0)
                    {
                        _balancejohn = 0;
                        _balanceindex = _balancejohn;
                    }
                    output = "Your new withdrawn balance is: " + _balancejohn.ToString("C");

                }

                if (account == '2')
                {
                    if (input > _balancepaul)
                    {
                        _bankbalance -= _balancepaul;
                    }
                    else
                    {
                        _bankbalance -= input;
                    }
                    _balancepaul -= input;
                    _balanceindex = _balancepaul;

                    if (_balancepaul < 0)
                    {
                        _balancepaul = 0;
                        _balanceindex = _balancepaul;
                    }
                    output = "Your new withdrawn balance is: " + _balancepaul.ToString("C");

                }

                if (account == '3')
                {
                    if (input > _balancegeorge)
                    {
                        _bankbalance -= _balancegeorge;
                    }
                    else
                    {
                        _bankbalance -= input;
                    }
                    _balancegeorge -= input;
                    _balanceindex = _balancegeorge;

                    if (_balancegeorge < 0)
                    {
                        _balancegeorge = 0;
                        _balanceindex = _balancegeorge;
                    }
                    output = "Your new withdrawn balance is: " + _balancegeorge.ToString("C");

                }

                if (account == '4')
                {
                    if (input > _balanceringo)
                    {
                        _bankbalance -= _balanceringo;
                    }
                    else
                    {
                        _bankbalance -= input;
                    }
                    _balanceringo -= input;
                    _balanceindex = _balanceringo;

                    if (_balanceringo < 0)
                    {
                        _balanceringo = 0;
                        _balanceindex = _balanceringo;
                    }
                    output = "Your new withdrawn balance is: " + _balanceringo.ToString("C");

                }
            }

            if (_bankbalance<0)
            {
                _bankbalance = 0;
            }

            return output;
        }




    }
}
