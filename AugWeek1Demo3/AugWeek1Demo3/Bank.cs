using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugWeek1Demo3
{
	public delegate void BankBalanceChanged(double newValue);
    public delegate void Message(string word1, string word2);
	class Bank
	{
		private double _balance;
		public event BankBalanceChanged BalanceChanged;
        public event Message SendMessage;
		public double BankBalance
		{
			get
			{
				return _balance;
			}
			set
			{
				_balance = value;
				BalanceChanged(value);
                SendMessage("hhh","2hh");
			}	
		}
	}
}
