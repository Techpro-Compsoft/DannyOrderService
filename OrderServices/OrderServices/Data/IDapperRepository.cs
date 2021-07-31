using System.Data;
using Dapper;

namespace OrderServices.Data
{
	public interface IDapperRepository
	{
		T Execute<T>(string query, DynamicParameters parameters, CommandType commandType = CommandType.StoredProcedure);
	}
}