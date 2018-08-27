USE [FlightReservation]
GO

/****** Object:  Table [dbo].[Flight]    Script Date: 23/08/2018 15:29:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Flight](
	[Flight_id] [nvarchar](100) NOT NULL,
	[Departure] [nvarchar](50) NOT NULL,
	[Destination] [nvarchar](50) NOT NULL,
	[Distance] [numeric](18, 0) NULL,
	[FuelConsumption] [numeric](18, 0) NULL,
	[Number_of_Adult] [numeric](18, 0) NULL,
	[Number_of_Children] [numeric](18, 0) NULL,
	[Time] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Flight_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


