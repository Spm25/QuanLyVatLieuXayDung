using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVatLieuXayDung
{
	internal class AccountManager
	{
		private static AccountManager instance;
		public Account CurrentAccount { get; set; }

		private AccountManager() { }

		public static AccountManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new AccountManager();
				}
				return instance;
			}
		}
	}
}
