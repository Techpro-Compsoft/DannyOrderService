USE [OrdersDb]
GO
/****** Object:  StoredProcedure [dbo].[sp_ClientQuoteRequest]    Script Date: 08/01/2021 03:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ClientQuoteRequest]  
    @jsonData nvarchar(max)	null,
	@jsonOutput nvarchar(max) out
AS
BEGIN
 SET @jsonOutput = '{
						"Details": {
						"TotalPackages": 4,
						"CubedWeightFactor": 166.50,
						"TotalDimensionalWeight": 1240.0,
						"TotalWeight": 1100.0,
						"WeightType": "0",
						"ServiceTypeID": 1,
						"ServiceType": "DIRECT",
						"EstimatedDeliveryBy": "8/5/2020 11:00:00 AM",
						"DimWeightDescription": "",
						"IsMaxInsExceed": false,
						"MaxInsValue": 1000.0000,
						"CutOffExceed": 0,
						"StatusCode": 200,
						"StatusDescription": "Success"
				},
		"PriceBreakup": 
		{
			"BaseCharge": 12.95,
			"WeightCharge": 1.50,
			"PackageCharge": 7.00,
			"VehicleCharge": 10.00,
			"FuelCharge": 1.17,
			"Other": 10.00,
			"OtherDescription": "Inside delivery $10",
			"SubTotal": 42.62,
			"Tax1Amount": 0.0,
			"Tax1Name": "GST",
			"Tax1Rate": 5,
			"Tax2Amount": 0.0,
			"Tax2Name": "PST",
			"Tax2Rate": 8,
			"TotalAmount": 42.62
		},

		"TemperatureControl" :9999,
	    "ChainOfCustody" :8888,
	    "DangerousGoods" :7777,
	    "InsideDelivery" : 6666		
		}
		'

RETURN 1 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ClientShipmentCancellation]    Script Date: 08/01/2021 03:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ClientShipmentCancellation]  
    @jsonData nvarchar(max)	null,
	@jsonOutput nvarchar(max) out
AS
BEGIN
 SET @jsonOutput = '{
"LoadNumber": 7152503,
"StatusCode": 7,
"StatusDescription": "Failure",
"Message": "Shipment already in progress. Please call 9058909999 for more help"
}'
RETURN 1 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ClientShipmentStatusUpdate]    Script Date: 08/01/2021 03:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ClientShipmentStatusUpdate]  
    @jsonData nvarchar(max)	null,
	@jsonOutput nvarchar(max) out
AS
BEGIN
 SET @jsonOutput = '{
	"LoadNumber": 7152503,
	"StatusCode": 6,
	"StatusDescription": "Finalized",
	"SubStatus": null,
	"LoadCreationDate": "7/20/2020 1:40:00 PM",
	"DeliveredBy": "144",
	"TemperatureControl" :9999,
	"ChainOfCustody" :8888,
	"DangerousGoods" :7777,
	"InsideDelivery" : 6666,
	"Scans": [{
			"ScanType": "ArrivedAtPickup",
			"ScanDate": "7/20/2020 1:40:00 PM",
			"ScanLocation": "Brampton",
			"Contact": ""
		},
		{
			"ScanType": "Picked Up",
			"ScanDate": "7/20/2020 1:40:00 PM",
			"ScanLocation": "Brampton",
			"Contact": "John"
		},
		{
			"ScanType": "Warehouse Inbound",
			"ScanDate": "7/20/2020 1:40:00 PM",
			"ScanLocation": "Mississauga",
			"Contact": ""
		},
		{
			"ScanType": "Warehouse Outbound",
			"ScanDate": "7/20/2020 1:40:00 PM",
			"ScanLocation": "Mississauga",
			"Contact": "Steve"
		},
		{
			"ScanType": "Arrived at Delivery",
			"ScanDate": "7/20/2020 1:40:00 PM",
			"ScanLocation": "Toronto",
			"Contact": ""
		},
		{
			"ScanType": "Delivered",
			"ScanDate": "7/20/2020 1:40:00 PM",
			"ScanLocation": "Toronto",
			"Contact": "POD"
		}

	]
}'
RETURN 1 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateClientShipment]    Script Date: 08/01/2021 03:26:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateClientShipment]  
    @jsonData nvarchar(max)	null,
	@jsonOutput nvarchar(max) out
AS
BEGIN
--DECLARE @jsonOutput nvarchar(max) 
 SET @jsonOutput = '{
"LoadNumber": 7175873,
"PackageTrackingNo": "7175873.001; 7175873.002; 7175873.003; 7175873.004; ",
"SortTo": "A & B - A & B OFFICE-1",
"TemperatureControl" :9999,
"ChainOfCustody" :8888,
"DangerousGoods" :7777,
"InsideDelivery" : 6666,
"PriceBreakup": {
"BaseCharge": 12.95,
"WeightCharge": 1.50,
"PackageCharge": 7.00,
"VehicleCharge": 10.00,
"FuelCharge": 1.17,
"Other": 10.00,
"OtherDescription": "Inside delivery $10",
"SubTotal": 42.62,
"Tax1Amount": 0.0,
"Tax1Name": "GST",
"Tax1Rate": 5,
"Tax2Amount": 0.0,
"Tax2Name": "PST",
"Tax2Rate": 8,
"TotalAmount": 42.62
},
"TotalPackages": "4",
"TotalWeight": "100",
"TotalDimensionalWeight": "144",
"WeightType": 1,
"Distance": "123",
"DistanceType": "1",
"Message": "Thanks for your business",
"TrackingURL": "https://trackit.ab.com/track/load=7175873",
"StatusDescription": "Success",
"StatusCode": 200
}'
RETURN 1 
END
GO
