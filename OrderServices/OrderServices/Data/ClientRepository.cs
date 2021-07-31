using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Newtonsoft.Json;
using OrderServices.Models;

namespace OrderServices.Data
{
	public class ClientRepository : IClientRepository
	{
		private readonly IDapperRepository _repository;
		public ClientRepository(IDapperRepository repository)
		{
			_repository = repository;
		}

		public async Task<ClientShipmentCreationResponse> CreateClientShipment(
			ClientShipmentCreationRequest clientShipmentCreationRequest)
		{
			var @params = new DynamicParameters();
			var data = JsonConvert.SerializeObject(clientShipmentCreationRequest);
			@params.Add("jsonData", data, DbType.String, direction: ParameterDirection.Input);
			@params.Add("@jsonOutput",null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
			var result = await Task.FromResult(_repository.Execute<ClientShipmentCreationResponse>("[dbo].[sp_CreateClientShipment]"
				, @params));
			return result;
			
		}

		public async Task<ClientShipmentStatusUpdateResponse> ClientShipmentStatusUpdate(
			ClientShipmentStatusUpdateRequest clientShipmentStatusUpdateRequest)
		{
			var @params = new DynamicParameters();
			var data = JsonConvert.SerializeObject(clientShipmentStatusUpdateRequest);
			@params.Add("jsonData", data, DbType.String, direction: ParameterDirection.Input);
			@params.Add("@jsonOutput", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
			var result = await Task.FromResult(_repository.Execute<ClientShipmentStatusUpdateResponse>("[dbo].[sp_ClientShipmentStatusUpdate]"
				, @params));
			return result;
		}

		public async Task<ClientQuoteResponse> ClientQuoteRequest(
			ClientQuoteRequest clientQuoteRequest)
		{
			var @params = new DynamicParameters();
			var data = JsonConvert.SerializeObject(clientQuoteRequest);
			@params.Add("jsonData", data, DbType.String, direction: ParameterDirection.Input);
			@params.Add("@jsonOutput", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
			var result = await Task.FromResult(_repository.Execute<ClientQuoteResponse>("[dbo].[sp_ClientQuoteRequest]"
				, @params));
			return result;
		}

		public async Task<ClientShipmentCancellationResponse> ClientShipmentCancellation(
			ClientShipmentCancellationRequest clientShipmentCancellationRequest)
		{
			var @params = new DynamicParameters();
			var data = JsonConvert.SerializeObject(clientShipmentCancellationRequest);
			@params.Add("jsonData", data, DbType.String, direction: ParameterDirection.Input);
			@params.Add("@jsonOutput", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
			var result = await Task.FromResult(_repository.Execute<ClientShipmentCancellationResponse>("[dbo].[sp_ClientShipmentCancellation]"
				, @params));
			return result;
		}
	}
}