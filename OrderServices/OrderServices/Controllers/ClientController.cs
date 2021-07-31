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
		[Route("CreateClientShipment")]
	    public async Task<ClientShipmentCreationResponse> CreateClientShipment(
		    ClientShipmentCreationRequest clientShipmentCreationRequest)
	    {
		    return await _repository.CreateClientShipment(clientShipmentCreationRequest);
	    }


	    [HttpPost]
	    [Route("ClientShipmentStatusUpdate")]
		public async Task<ClientShipmentStatusUpdateResponse> ClientShipmentStatusUpdate(
		    ClientShipmentStatusUpdateRequest clientShipmentStatusUpdateRequest)
	    {
			return await _repository.ClientShipmentStatusUpdate(clientShipmentStatusUpdateRequest);
		}

		[HttpPost]
		[Route("ClientQuoteRequest")]
		public async Task<ClientQuoteResponse> ClientQuoteRequest(
		    ClientQuoteRequest clientQuoteRequest)
	    {
			return await _repository.ClientQuoteRequest(clientQuoteRequest);
		}

		[HttpPost]
		[Route("ClientShipmentCancellation")]
		public async Task<ClientShipmentCancellationResponse> ClientShipmentCancellation(
		    ClientShipmentCancellationRequest clientShipmentCancellationRequest)
	    {
			return await _repository.ClientShipmentCancellation(clientShipmentCancellationRequest);
		}
	}
}
