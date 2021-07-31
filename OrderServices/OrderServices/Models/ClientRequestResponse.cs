using System;
using Newtonsoft.Json;

namespace OrderServices.Models
{
    public abstract class BaseRequest{}
    public abstract class BaseResponse{}
    public class ClientShipmentCreationRequest : BaseRequest
    {
        [JsonProperty("Customer")]
        public Customer Customer { get; set; }

        [JsonProperty("Pickup")]
        public Pickup Pickup { get; set; }

        [JsonProperty("Delivery")]
        public Delivery Delivery { get; set; }

        [JsonProperty("OrderInfo")]
        public OrderInfo OrderInfo { get; set; }

        [JsonProperty("Package")]
        public Package[] Package { get; set; }
    }
    public class ClientShipmentCreationResponse : BaseResponse
    {
        [JsonProperty("LoadNumber")]
        public long LoadNumber { get; set; }

        [JsonProperty("PackageTrackingNo")]
        public string PackageTrackingNo { get; set; }

        [JsonProperty("SortTo")]
        public string SortTo { get; set; }

        [JsonProperty("PriceBreakup")]
        public PriceBreakup PriceBreakup { get; set; }

        [JsonProperty("TotalPackages")]
        public int TotalPackages { get; set; }

        [JsonProperty("TotalWeight")]
        public decimal TotalWeight { get; set; }

        [JsonProperty("TotalDimensionalWeight")]
        public decimal TotalDimensionalWeight { get; set; }

        [JsonProperty("WeightType")]
        public long WeightType { get; set; }

        [JsonProperty("Distance")]
        public decimal Distance { get; set; }

        [JsonProperty("DistanceType")]
        public string DistanceType { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("TrackingURL")]
        public Uri TrackingUrl { get; set; }

        [JsonProperty("StatusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("StatusCode")]
        public long StatusCode { get; set; }
    }
    public class ClientShipmentStatusUpdateRequest : BaseRequest
    {
	    [JsonProperty("LoadNumber")]
	    public string LoadNumber { get; set; }

	    [JsonProperty("ReferenceNumber")]
	    public string ReferenceNumber { get; set; }

	    [JsonProperty("ClientId")]
	    public long ClientId { get; set; }

	    [JsonProperty("Accesskey")]
	    public string Accesskey { get; set; }
    }
    public class ClientShipmentStatusUpdateResponse : BaseResponse
    {
	    [JsonProperty("LoadNumber")]
	    public string LoadNumber { get; set; }

	    [JsonProperty("StatusCode")]
	    public long StatusCode { get; set; }

	    [JsonProperty("StatusDescription")]
	    public string StatusDescription { get; set; }

	    [JsonProperty("SubStatus")]
	    public object SubStatus { get; set; }

	    [JsonProperty("LoadCreationDate")]
	    public string LoadCreationDate { get; set; }

	    [JsonProperty("DeliveredBy")]
	    public string DeliveredBy { get; set; }

	    [JsonProperty("Scans")]
	    public Scan[] Scans { get; set; }
    }
    public class ClientQuoteRequest : BaseRequest
    {
	    [JsonProperty("Customer")]
	    public Customer Customer { get; set; }

	    [JsonProperty("Pickup")]
	    public Pickup Pickup { get; set; }

	    [JsonProperty("Delivery")]
	    public Delivery Delivery { get; set; }

	    [JsonProperty("OrderInfo")]
	    public OrderInfo OrderInfo { get; set; }

	    [JsonProperty("Package")]
	    public Package[] Package { get; set; }
    }
    public class ClientQuoteResponse : BaseResponse
    {
	    [JsonProperty("Details")]
	    public Details Details { get; set; }

	    [JsonProperty("PriceBreakup")]
	    public PriceBreakup PriceBreakup { get; set; }
    }
    public class ClientShipmentCancellationRequest : BaseRequest
    {
	    [JsonProperty("LoadNumber")]
	    public long LoadNumber { get; set; }

	    [JsonProperty("ReferenceNumber")]
	    public string ReferenceNumber { get; set; }

	    [JsonProperty("ClientId")]
	    public long ClientId { get; set; }

	    [JsonProperty("Accesskey")]
	    public string Accesskey { get; set; }
    }

    public class ClientShipmentCancellationResponse : BaseResponse
    {
        [JsonProperty("LoadNumber")]
	    public long LoadNumber { get; set; }

	    [JsonProperty("StatusCode")]
	    public long StatusCode { get; set; }

	    [JsonProperty("StatusDescription")]
	    public string StatusDescription { get; set; }

	    [JsonProperty("Message")]
	    public string Message { get; set; }
    }

    public class Details
    {
	    [JsonProperty("TotalPackages")]
	    public long TotalPackages { get; set; }

	    [JsonProperty("CubedWeightFactor")]
	    public double CubedWeightFactor { get; set; }

	    [JsonProperty("TotalDimensionalWeight")]
	    public double TotalDimensionalWeight { get; set; }

	    [JsonProperty("TotalWeight")]
	    public double TotalWeight { get; set; }

	    [JsonProperty("WeightType")]
	    public string WeightType { get; set; }

	    [JsonProperty("ServiceTypeID")]
	    public long ServiceTypeId { get; set; }

	    [JsonProperty("ServiceType")]
	    public string ServiceType { get; set; }

	    [JsonProperty("EstimatedDeliveryBy")]
	    public string EstimatedDeliveryBy { get; set; }

	    [JsonProperty("DimWeightDescription")]
	    public string DimWeightDescription { get; set; }

	    [JsonProperty("IsMaxInsExceed")]
	    public bool IsMaxInsExceed { get; set; }

	    [JsonProperty("MaxInsValue")]
	    public double MaxInsValue { get; set; }

	    [JsonProperty("CutOffExceed")]
	    public long CutOffExceed { get; set; }

	    [JsonProperty("StatusCode")]
	    public long StatusCode { get; set; }

	    [JsonProperty("StatusDescription")]
	    public string StatusDescription { get; set; }
    }

    public partial class Customer
    {
        [JsonProperty("ClientId")]
        public long ClientId { get; set; }

        [JsonProperty("Accesskey")]
        public string Accesskey { get; set; }
    }
    
    public class Scan
    {
	    [JsonProperty("ScanType")]
	    public string ScanType { get; set; }

	    [JsonProperty("ScanDate")]
	    public string ScanDate { get; set; }

	    [JsonProperty("ScanLocation")]
	    public string ScanLocation { get; set; }

	    [JsonProperty("Contact")]
	    public string Contact { get; set; }
    }

    public class PriceBreakup
    {
        [JsonProperty("BaseCharge")]
        public double BaseCharge { get; set; }

        [JsonProperty("WeightCharge")]
        public double WeightCharge { get; set; }

        [JsonProperty("PackageCharge")]
        public double PackageCharge { get; set; }

        [JsonProperty("VehicleCharge")]
        public double VehicleCharge { get; set; }

        [JsonProperty("FuelCharge")]
        public double FuelCharge { get; set; }

        [JsonProperty("Other")]
        public double Other { get; set; }

        [JsonProperty("OtherDescription")]
        public string OtherDescription { get; set; }

        [JsonProperty("SubTotal")]
        public double SubTotal { get; set; }

        [JsonProperty("Tax1Amount")]
        public double Tax1Amount { get; set; }

        [JsonProperty("Tax1Name")]
        public string Tax1Name { get; set; }

        [JsonProperty("Tax1Rate")]
        public long Tax1Rate { get; set; }

        [JsonProperty("Tax2Amount")]
        public double Tax2Amount { get; set; }

        [JsonProperty("Tax2Name")]
        public string Tax2Name { get; set; }

        [JsonProperty("Tax2Rate")]
        public long Tax2Rate { get; set; }

        [JsonProperty("TotalAmount")]
        public double TotalAmount { get; set; }
    }

    public class Delivery
    {
        [JsonProperty("DeliveryCompanyName")]
        public string DeliveryCompanyName { get; set; }

        [JsonProperty("DeliveryStreet1")]
        public string DeliveryStreet1 { get; set; }

        [JsonProperty("DeliveryStreet2")]
        public string DeliveryStreet2 { get; set; }

        [JsonProperty("DeliveryCity")]
        public string DeliveryCity { get; set; }

        [JsonProperty("DeliveryProvince")]
        public string DeliveryProvince { get; set; }

        [JsonProperty("DeliveryPostalCode")]
        public string DeliveryPostalCode { get; set; }

        [JsonProperty("DeliveryCountry")]
        public string DeliveryCountry { get; set; }

        [JsonProperty("DeliveryContact")]
        public string DeliveryContact { get; set; }

        [JsonProperty("DeliveryPhone")]
        public string DeliveryPhone { get; set; }

        [JsonProperty("DeliveryFax")]
        public string DeliveryFax { get; set; }

        [JsonProperty("DeliveryEmail")]
        public string DeliveryEmail { get; set; }

        [JsonProperty("DeliveryInstruction")]
        public string DeliveryInstruction { get; set; }

        [JsonProperty("DeliveryCode")]
        public string DeliveryCode { get; set; }

        [JsonProperty("DeliveryOpen")]
        public string DeliveryOpen { get; set; }

        [JsonProperty("DeliveryClose")]
        public string DeliveryClose { get; set; }

        [JsonProperty("DeliveryWindowStart")]
        public string DeliveryWindowStart { get; set; }

        [JsonProperty("DeliveryWindowEnd")]
        public string DeliveryWindowEnd { get; set; }

        [JsonProperty("DeliveryAppointmentRequired")]
        public int DeliveryAppointmentRequired { get; set; }

        [JsonProperty("DeliveryNameRequired")]
        public int DeliveryNameRequired { get; set; }

        [JsonProperty("DeliverySignatureRequired")]
        public int DeliverySignatureRequired { get; set; }

        [JsonProperty("DeliveryImageRequired")]
        public int DeliveryImageRequired { get; set; }

        [JsonProperty("DeliveryAddressSave")]
        public int DeliveryAddressSave { get; set; }
    }

    public class OrderInfo
    {
        [JsonProperty("PickupDate")]
        public string PickupDate { get; set; }

        [JsonProperty("ReadyTime")]
        public string ReadyTime { get; set; }

        [JsonProperty("VehicleTypeId")]
        public long VehicleTypeId { get; set; }

        [JsonProperty("ServiceTypeID")]
        public long ServiceTypeId { get; set; }

        [JsonProperty("Caller")]
        public string Caller { get; set; }

        [JsonProperty("Reference")]
        public string Reference { get; set; }

        [JsonProperty("Waybill")]
        public string Waybill { get; set; }

        [JsonProperty("TotalWeight")]
        public long TotalWeight { get; set; }

        [JsonProperty("InsuranceRequired")]
        public int InsuranceRequired { get; set; }

        [JsonProperty("COD")]
        public long Cod { get; set; }

        [JsonProperty("DeclaredValue")]
        public object DeclaredValue { get; set; }

        [JsonProperty("Department")]
        public string Department { get; set; }

        [JsonProperty("OperatorName")]
        public string OperatorName { get; set; }

        [JsonProperty("OperatorPhone")]
        public string OperatorPhone { get; set; }

        [JsonProperty("OperatorEmail")]
        public string OperatorEmail { get; set; }

        [JsonProperty("CurrencyType")]
        public long CurrencyType { get; set; }
    }

    public class Package
    {
        [JsonProperty("PackageId")]
        public long PackageId { get; set; }

        [JsonProperty("PackageQty")]
        public long PackageQty { get; set; }

        [JsonProperty("PackageLen")]
        public long PackageLen { get; set; }

        [JsonProperty("PackageWidth")]
        public long PackageWidth { get; set; }

        [JsonProperty("PackageHeight")]
        public long PackageHeight { get; set; }

        [JsonProperty("PackageWeight")]
        public long PackageWeight { get; set; }

        [JsonProperty("DimensionsType")]
        public long DimensionsType { get; set; }

        [JsonProperty("WeightType")]
        public long WeightType { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class Pickup
    {
        [JsonProperty("PickupCompanyName")]
        public string PickupCompanyName { get; set; }

        [JsonProperty("PickupStreet1")]
        public string PickupStreet1 { get; set; }

        [JsonProperty("PickupStreet2")]
        public string PickupStreet2 { get; set; }

        [JsonProperty("PickupCity")]
        public string PickupCity { get; set; }

        [JsonProperty("PickupProvince")]
        public string PickupProvince { get; set; }

        [JsonProperty("PickupPostalCode")]
        public string PickupPostalCode { get; set; }

        [JsonProperty("PickupCountry")]
        public string PickupCountry { get; set; }

        [JsonProperty("PickupContact")]
        public string PickupContact { get; set; }

        [JsonProperty("PickupPhone")]
        public string PickupPhone { get; set; }

        [JsonProperty("PickupFax")]
        public string PickupFax { get; set; }

        [JsonProperty("PickupEmail")]
        public string PickupEmail { get; set; }

        [JsonProperty("PickupInstructions")]
        public string PickupInstructions { get; set; }

        [JsonProperty("PickupCode")]
        public string PickupCode { get; set; }

        [JsonProperty("PickupOpen")]
        public string PickupOpen { get; set; }

        [JsonProperty("PickupClose")]
        public string PickupClose { get; set; }

        [JsonProperty("PickupWindowStart")]
        public string PickupWindowStart { get; set; }

        [JsonProperty("PickupWindowEnd")]
        public string PickupWindowEnd { get; set; }

        [JsonProperty("PickupAppointmentRequired")]
        public int PickupAppointmentRequired { get; set; }

        [JsonProperty("PickupNameRequired")]
        public int PickupNameRequired { get; set; }

        [JsonProperty("PickupSignatureRequired")]
        public int PickupSignatureRequired { get; set; }

        [JsonProperty("PickupAddressSave")]
        public int PickupAddressSave { get; set; }
    }
}