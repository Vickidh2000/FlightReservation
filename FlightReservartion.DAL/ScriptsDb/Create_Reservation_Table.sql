USE [FlightReservation]
GO

/****** Object:  Table [dbo].[Reservation]    Script Date: 23/08/2018 15:48:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reservation](
	[Reservation_id] [int] NOT NULL,
	[Flight_id] [nvarchar](100) NOT NULL,
	[Payment_id] [int] NOT NULL,
	[Passenger_id] [int] NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Flight] FOREIGN KEY([Flight_id])
REFERENCES [dbo].[Flight] ([Flight_id])
GO

ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Flight]
GO

ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Passenger] FOREIGN KEY([Passenger_id])
REFERENCES [dbo].[Passenger] ([Passenger_id])
GO

ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Passenger]
GO

ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Payment] FOREIGN KEY([Payment_id])
REFERENCES [dbo].[Payment] ([Payment_id])
GO

ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Payment]
GO


