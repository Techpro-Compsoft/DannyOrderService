using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace OrderServices.Data
{
	public class DapperRepository : IDapperRepository
	{
		private readonly IConfiguration _configuration;
		public DapperRepository(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		
		public T Execute<T>(string query, DynamicParameters parameters, CommandType commandType = CommandType.StoredProcedure)
		{
			T result;
			using IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("default"));
			if (dbConnection.State == ConnectionState.Closed)
				dbConnection.Open();
			using var transaction = dbConnection.BeginTransaction();
			try
			{
				dbConnection.Query<T>(query, parameters, commandType: commandType, transaction: transaction);
				result = parameters.Get<T>("retVal"); //get output parameter value
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