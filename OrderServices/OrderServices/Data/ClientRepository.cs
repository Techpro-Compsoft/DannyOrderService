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
			ClientShipmentCreationRequest request)
		{
			return await Execute<ClientShipmentCreationResponse, ClientShipmentCreationRequest>(request);
		}

		public async Task<ClientShipmentStatusUpdateResponse> ClientShipmentStatusUpdate(
			ClientShipmentStatusUpdateRequest request)
		{
			return await Execute<ClientShipmentStatusUpdateResponse, ClientShipmentStatusUpdateRequest>(request);
		}

		public async Task<ClientQuoteResponse> ClientQuoteRequest(
			ClientQuoteRequest request)
		{
			return await Execute<ClientQuoteResponse, ClientQuoteRequest>(request);
		}

		public async Task<ClientShipmentCancellationResponse> ClientShipmentCancellation(
			ClientShipmentCancellationRequest request)
		{
			return await Execute<ClientShipmentCancellationResponse, ClientShipmentCancellationRequest>(request);
		}

		async Task<T> Execute<T,U>(
			U request) where T : BaseResponse where U : BaseRequest
		{
			var @params = new DynamicParameters();
			var data = JsonConvert.SerializeObject(request);
			@params.Add("jsonData", data, DbType.String, direction: ParameterDirection.Input);
			@params.Add("@jsonOutput", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
			var result = await Task.FromResult(_repository.Execute<T>("[dbo].[sp_ClientShipmentCancellation]"
				, @params));
			return result;
		}
	}
}