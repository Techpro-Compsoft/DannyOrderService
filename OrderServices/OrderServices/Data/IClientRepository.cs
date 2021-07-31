using System.Threading.Tasks;
using OrderServices.Models;

namespace OrderServices.Data
{
	public interface IClientRepository
	{
		Task<ClientShipmentCreationResponse> CreateClientShipment(
			ClientShipmentCreationRequest clientShipmentCreationRequest);

		Task<ClientShipmentCancellationResponse> ClientShipmentCancellation(
			ClientShipmentCancellationRequest clientShipmentCancellationRequest);

		Task<ClientQuoteResponse> ClientQuoteRequest(
			ClientQuoteRequest clientQuoteRequest);

		Task<ClientShipmentStatusUpdateResponse> ClientShipmentStatusUpdate(
			ClientShipmentStatusUpdateRequest clientShipmentStatusUpdateRequest);
	}
}