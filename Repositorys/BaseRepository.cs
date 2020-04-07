using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.DataAccess
{
	public abstract class BaseRepository
	{
		protected IDbConnection Connection { get { return new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString); } }
	}
}
