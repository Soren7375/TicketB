using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Interface
{
	public interface IService<T> where T : class
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Find(Dictionary<string, object> parameters);
		T Get(int id);
	}
}
