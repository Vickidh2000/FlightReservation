/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Payment_id]
      ,[Price]
      ,[PaymentType]
  FROM [FlightReservation].[dbo].[Payment]