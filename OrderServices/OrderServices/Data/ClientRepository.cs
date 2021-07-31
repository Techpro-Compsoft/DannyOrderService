using System.Data;
using System.Threading.Tasks;
using Dapper;
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
			@params.Add("retVal", DbType.String, direction: ParameterDirection.Output);
			var result = await Task.FromResult(_repository.Execute<ClientShipmentCreationResponse>("[dbo].[sp_CreateClientShipment]"
				, @params));
			return result;
			
		}

		public async Task<ClientShipmentStatusUpdateResponse> ClientShipmentStatusUpdate(
			ClientShipmentStatusUpdateRequest clientShipmentStatusUpdateRequest)
		{
			var @params = new DynamicParameters();
			@params.Add("LoadNumber", DbType.String, direction: ParameterDirection.Input);
			@params.Add("ReferenceNumber", DbType.String, direction: ParameterDirection.Input);
			@params.Add("ClientId", DbType.Int32, direction: ParameterDirection.Input);
			@params.Add("AccessKey", DbType.String, direction: ParameterDirection.Input);
			@params.Add("retVal", DbType.String, direction: ParameterDirection.Output);
			var result = await Task.FromResult(_repository.Execute<ClientShipmentStatusUpdateResponse>("[dbo].[sp_ClientShipmentStatusUpdate]"
				, @params));
			return result;
		}
		public async Task<ClientQuoteResponse> ClientQuoteRequest(
			ClientQuoteRequest clientQuoteRequest)
		{
			var @params = new DynamicParameters();
			@params.Add("retVal", DbType.String, direction: ParameterDirection.Output);
			var result = await Task.FromResult(_repository.Execute<ClientQuoteResponse>("[dbo].[sp_ClientQuoteRequest]"
				, @params));
			return result;
		}
		public async Task<ClientShipmentCancellationResponse> ClientShipmentCancellation(
			ClientShipmentCancellationRequest clientShipmentCancellationRequest)
		{
			var @params = new DynamicParameters();
			@params.Add("LoadNumber", DbType.String, direction: ParameterDirection.Input);
			@params.Add("ReferenceNumber", DbType.String, direction: ParameterDirection.Input);
			@params.Add("ClientId", DbType.Int32, direction: ParameterDirection.Input);
			@params.Add("AccessKey", DbType.String, direction: ParameterDirection.Input);
			@params.Add("retVal", DbType.String, direction: ParameterDirection.Output);
			var result = await Task.FromResult(_repository.Execute<ClientShipmentCancellationResponse>("[dbo].[sp_ClientShipmentCancellation]"
				, @params));
			return result;
		}
	}
}