using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Interface
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		T Get(int id);
		IEnumerable<T> Find(Dictionary<string, object> parameters);
		void Create(T item);
		void Update(T item);
		void Delete(int id);
	}
}
