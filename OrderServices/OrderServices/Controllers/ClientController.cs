using System.Threading.Tasks;
using System.Web.Http;
using OrderServices.Data;
using OrderServices.Models;

namespace OrderServices.Controllers
{
    public class ClientController : ApiController
    {
	    private readonly IClientRepository _repository;
	    public ClientController(IClientRepository repository)
	    {
		    _repository = repository;
	    }

		[HttpPost]
	    public async Task<ClientShipmentCreationResponse> CreateClientShipment(
		    ClientShipmentCreationRequest clientShipmentCreationRequest)
	    {
		    return await _repository.CreateClientShipment(clientShipmentCreationRequest);
	    }

	    public async Task<ClientShipmentStatusUpdateResponse> ClientShipmentStatusUpdate(
		    ClientShipmentStatusUpdateRequest clientShipmentStatusUpdateRequest)
	    {
			return await _repository.ClientShipmentStatusUpdate(clientShipmentStatusUpdateRequest);
		}
	    public async Task<ClientQuoteResponse> ClientQuoteRequest(
		    ClientQuoteRequest clientQuoteRequest)
	    {
			return await _repository.ClientQuoteRequest(clientQuoteRequest);
		}
	    public async Task<ClientShipmentCancellationResponse> ClientShipmentCancellation(
		    ClientShipmentCancellationRequest clientShipmentCancellationRequest)
	    {
			return await _repository.ClientShipmentCancellation(clientShipmentCancellationRequest);
		}
	}
}
