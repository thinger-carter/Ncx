using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcxSample.Service.User
{
	public class UserService:IUserServcie
	{
		public string GuidStr { get; set; }

		public UserService()
		{
			this.GuidStr = Guid.NewGuid().ToString();
		}
	}
}
