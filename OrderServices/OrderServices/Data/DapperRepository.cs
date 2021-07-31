using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Newtonsoft.Json;

namespace OrderServices.Data
{
	public class DapperRepository : IDapperRepository
	{
		public T Execute<T>(string query, DynamicParameters parameters, CommandType commandType = CommandType.StoredProcedure)
		{
			T result;
			using IDbConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString );
			if (dbConnection.State == ConnectionState.Closed)
				dbConnection.Open();
			using var transaction = dbConnection.BeginTransaction();
			try
			{
				dbConnection.Query(query, parameters, commandType: commandType, transaction: transaction);
				var results = parameters.Get<string>("jsonOutput"); //get output parameter value
				result = JsonConvert.DeserializeObject<T>(results);
				transaction.Commit();
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				throw;
			}

			return result;
		}
	}
}