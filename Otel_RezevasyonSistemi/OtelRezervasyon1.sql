USE [OtelRezervasyon]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 16.01.2024 17:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Tc] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DogumTarihi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda]    Script Date: 16.01.2024 17:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OdaAdi] [nvarchar](50) NOT NULL,
	[Durumu] [nvarchar](50) NOT NULL,
	[OdaTuru] [nvarchar](50) NOT NULL,
	[OdaUcreti] [int] NOT NULL,
 CONSTRAINT [PK_Oda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervasyon]    Script Date: 16.01.2024 17:23:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervasyon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Tc] [int] NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Adres] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DogumTarihi] [nvarchar](50) NOT NULL,
	[OdaAdi] [nvarchar](50) NOT NULL,
	[OdaTuru] [nvarchar](50) NOT NULL,
	[Durumu] [nvarchar](50) NOT NULL,
	[OdaUcreti] [int] NOT NULL,
	[Gun] [int] NOT NULL,
	[Tutar] [int] NOT NULL,
	[GirisTarihi] [nvarchar](50) NOT NULL,
	[CikisTarihi] [nvarchar](50) NOT NULL,
	[KisiSayisi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Rezervasyon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
