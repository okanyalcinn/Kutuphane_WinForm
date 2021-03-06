USE [master]
GO
/****** Object:  Database [KutuphaneDB]    Script Date: 20.03.2019 09:58:22 ******/
CREATE DATABASE [KutuphaneDB]
GO
ALTER DATABASE [KutuphaneDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KutuphaneDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KutuphaneDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KutuphaneDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KutuphaneDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KutuphaneDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KutuphaneDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KutuphaneDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KutuphaneDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KutuphaneDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KutuphaneDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KutuphaneDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KutuphaneDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KutuphaneDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KutuphaneDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KutuphaneDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KutuphaneDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KutuphaneDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KutuphaneDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KutuphaneDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KutuphaneDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KutuphaneDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KutuphaneDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KutuphaneDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KutuphaneDB] SET RECOVERY FULL 
GO
ALTER DATABASE [KutuphaneDB] SET  MULTI_USER 
GO
ALTER DATABASE [KutuphaneDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KutuphaneDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KutuphaneDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KutuphaneDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KutuphaneDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [KutuphaneDB]
GO
/****** Object:  Table [dbo].[Adresler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresler](
	[adresID] [int] IDENTITY(1,1) NOT NULL,
	[cadde] [nvarchar](50) NOT NULL,
	[sokak] [nvarchar](50) NOT NULL,
	[mahalle] [nvarchar](50) NULL,
	[binaNo] [int] NULL,
	[kat] [int] NULL,
	[postakodu] [int] NULL,
	[il] [nvarchar](20) NOT NULL,
	[ilce] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Adresler] PRIMARY KEY CLUSTERED 
(
	[adresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmanetSilinen]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmanetSilinen](
	[emanetID] [int] NOT NULL,
	[uyeID] [int] NOT NULL,
	[kitapID] [int] NOT NULL,
	[emanetTarihi] [date] NOT NULL,
	[teslimTarihi] [date] NOT NULL,
	[TelismDurum] [bit] NOT NULL,
	[tarihfark] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmanetSilinen] PRIMARY KEY CLUSTERED 
(
	[emanetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmanetT]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmanetT](
	[emanetID] [int] IDENTITY(1,1) NOT NULL,
	[uyeID] [int] NOT NULL,
	[kitapID] [int] NOT NULL,
	[emanetTarihi] [date] NOT NULL,
	[teslimTarihi] [date] NOT NULL,
	[teslimDurum] [bit] NOT NULL,
	[tarihfark] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmanetT] PRIMARY KEY CLUSTERED 
(
	[emanetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[kategoriID] [int] IDENTITY(1,1) NOT NULL,
	[kategoriAd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[kategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[kitapID] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [nvarchar](30) NULL,
	[kitapAdi] [nvarchar](50) NULL,
	[yayinTarihi] [datetime] NULL,
	[sayfaSayisi] [int] NULL,
	[yayinEviID] [int] NULL,
	[kutuphaneID] [int] NULL,
	[kategoriID] [int] NULL,
	[yazarID] [int] NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KitaplarKategoriler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitaplarKategoriler](
	[kitapID] [int] NOT NULL,
	[kategoriID] [int] NOT NULL,
 CONSTRAINT [PK_KitaplarKategoriler] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC,
	[kategoriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KitaplarKutuphane]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitaplarKutuphane](
	[kitapID] [int] NOT NULL,
	[kutuphaneID] [int] NOT NULL,
 CONSTRAINT [PK_KitaplarKutuphane] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC,
	[kutuphaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KitaplarSilinen]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitaplarSilinen](
	[kitapID] [int] NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[kitapAdi] [nvarchar](50) NOT NULL,
	[yayinTarihi] [datetime] NOT NULL,
	[sayfaSayisi] [int] NOT NULL,
	[yayinEviID] [int] NOT NULL,
	[kutuphaneID] [int] NOT NULL,
	[kategoriID] [int] NOT NULL,
	[yazarID] [int] NOT NULL,
 CONSTRAINT [PK_KitaplarSilinen] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KitapYazar]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitapYazar](
	[kitapID] [int] NOT NULL,
	[yazarID] [int] NOT NULL,
 CONSTRAINT [PK_KitapYazar] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC,
	[yazarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kutuphane]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kutuphane](
	[kutuphaneID] [int] IDENTITY(1,1) NOT NULL,
	[kutuphaneAd] [nvarchar](50) NOT NULL,
	[adresID] [int] NOT NULL,
 CONSTRAINT [PK_Kutuphane] PRIMARY KEY CLUSTERED 
(
	[kutuphaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SilinenUyeler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinenUyeler](
	[uyeID] [int] NOT NULL,
	[uyeAd] [nvarchar](50) NOT NULL,
	[uyeSoyad] [nvarchar](50) NOT NULL,
	[TCno] [nvarchar](11) NOT NULL,
	[cinsiyet] [nvarchar](10) NOT NULL,
	[telefon] [nvarchar](11) NOT NULL,
	[eposta] [nvarchar](50) NOT NULL,
	[adresID] [int] NOT NULL,
 CONSTRAINT [PK_SilinenUyeler] PRIMARY KEY CLUSTERED 
(
	[uyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[uyeID] [int] IDENTITY(1,1) NOT NULL,
	[uyeAd] [nvarchar](50) NOT NULL,
	[uyeSoyad] [nvarchar](50) NOT NULL,
	[TCno] [nvarchar](11) NOT NULL,
	[cinsiyet] [nvarchar](10) NOT NULL,
	[telefon] [nvarchar](11) NOT NULL,
	[eposta] [nvarchar](50) NOT NULL,
	[adresID] [int] NOT NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[uyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yayinevleri]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yayinevleri](
	[yayinEviID] [int] IDENTITY(1,1) NOT NULL,
	[yayinEviAdi] [nvarchar](50) NOT NULL,
	[adresID] [int] NOT NULL,
 CONSTRAINT [PK_Yayinevleri] PRIMARY KEY CLUSTERED 
(
	[yayinEviID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yazarlar]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazarlar](
	[yazarID] [int] IDENTITY(1,1) NOT NULL,
	[yazarAd] [nvarchar](50) NOT NULL,
	[yazarSoyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Yazarlar] PRIMARY KEY CLUSTERED 
(
	[yazarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VM_AdreslerListele]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_AdreslerListele]
AS
SELECT        adresID, cadde + ' ' + sokak + ' ' + mahalle + ' ' + il + ' ' + ilce AS Adres
FROM            dbo.Adresler

GO
/****** Object:  View [dbo].[VM_ComboboxUyeListele]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_ComboboxUyeListele]
AS
SELECT        uyeID, uyeAd + '  ' + uyeSoyad AS Expr1
FROM            dbo.Uyeler

GO
/****** Object:  View [dbo].[VM_EmanetListe]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_EmanetListe]
AS
SELECT        dbo.Uyeler.uyeID, dbo.Uyeler.uyeAd + ' ' + dbo.Uyeler.uyeSoyad AS UyeAdSoyad, dbo.Kitaplar.kitapID, dbo.Kitaplar.kitapAdi, dbo.EmanetT.emanetTarihi, dbo.EmanetT.teslimTarihi, dbo.EmanetT.teslimDurum, 
                         dbo.EmanetT.emanetID, dbo.EmanetT.tarihfark
FROM            dbo.EmanetT INNER JOIN
                         dbo.Kitaplar ON dbo.EmanetT.kitapID = dbo.Kitaplar.kitapID INNER JOIN
                         dbo.Uyeler ON dbo.EmanetT.uyeID = dbo.Uyeler.uyeID

GO
/****** Object:  View [dbo].[VM_KitaplarListele]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_KitaplarListele]
AS
SELECT        K.kitapID, K.ISBN, K.kitapAdi, K.sayfaSayisi, K.yayinTarihi, Y.yazarAd, Y.yazarSoyad, YEV.yayinEviAdi, KTP.kutuphaneAd, KTG.kategoriAd
FROM            dbo.Kitaplar AS K INNER JOIN
                         dbo.Yazarlar AS Y ON K.yazarID = Y.yazarID INNER JOIN
                         dbo.Kategoriler AS KTG ON K.kategoriID = KTG.kategoriID INNER JOIN
                         dbo.Kutuphane AS KTP ON K.kutuphaneID = KTP.kutuphaneID INNER JOIN
                         dbo.Yayinevleri AS YEV ON K.yayinEviID = YEV.yayinEviID
WHERE        (K.yazarID IS NOT NULL)

GO
/****** Object:  View [dbo].[VM_KutuphaneListele]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_KutuphaneListele]
AS
SELECT        dbo.Kutuphane.kutuphaneID, dbo.Kutuphane.kutuphaneAd, dbo.Kutuphane.adresID, dbo.Adresler.cadde, dbo.Adresler.sokak, dbo.Adresler.il, dbo.Adresler.ilce
FROM            dbo.Adresler INNER JOIN
                         dbo.Kutuphane ON dbo.Adresler.adresID = dbo.Kutuphane.adresID

GO
/****** Object:  View [dbo].[VM_UyelerListele]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_UyelerListele]
AS
SELECT        dbo.Uyeler.uyeID, dbo.Uyeler.uyeAd, dbo.Uyeler.uyeSoyad, dbo.Uyeler.TCno, dbo.Uyeler.cinsiyet, dbo.Uyeler.telefon, dbo.Uyeler.eposta, dbo.Adresler.cadde, dbo.Adresler.sokak, dbo.Adresler.mahalle, dbo.Adresler.binaNo, 
                         dbo.Adresler.kat, dbo.Adresler.postakodu, dbo.Adresler.il, dbo.Adresler.ilce, dbo.Uyeler.adresID
FROM            dbo.Uyeler INNER JOIN
                         dbo.Adresler ON dbo.Uyeler.adresID = dbo.Adresler.adresID

GO
/****** Object:  View [dbo].[VM_YayineviListele]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VM_YayineviListele]
AS
SELECT        dbo.Yayinevleri.yayinEviID, dbo.Yayinevleri.yayinEviAdi, dbo.Yayinevleri.adresID, dbo.Adresler.cadde, dbo.Adresler.sokak, dbo.Adresler.mahalle, dbo.Adresler.binaNo, dbo.Adresler.kat, dbo.Adresler.postakodu, dbo.Adresler.il, 
                         dbo.Adresler.ilce
FROM            dbo.Adresler INNER JOIN
                         dbo.Yayinevleri ON dbo.Adresler.adresID = dbo.Yayinevleri.adresID

GO
SET IDENTITY_INSERT [dbo].[Adresler] ON 

INSERT [dbo].[Adresler] ([adresID], [cadde], [sokak], [mahalle], [binaNo], [kat], [postakodu], [il], [ilce]) VALUES (6, N'Karadeniz  ', N'Beşler', N'Cumhuriyet', 9, 6, 3265, N'İstanbul', N'Şişli')
INSERT [dbo].[Adresler] ([adresID], [cadde], [sokak], [mahalle], [binaNo], [kat], [postakodu], [il], [ilce]) VALUES (7, N'Akın Caddesi', N'Maldiv Sokak', N'Malazgirt Mahallesi', 13, 7, 34666, N'İstanbul', N'Avcılar')
INSERT [dbo].[Adresler] ([adresID], [cadde], [sokak], [mahalle], [binaNo], [kat], [postakodu], [il], [ilce]) VALUES (8, N'Fatih Caddes', N'Fatihler Sokak', N'Fatihli Mah.', 1, 9, 34002, N'İstanbul', N'Fatih')
SET IDENTITY_INSERT [dbo].[Adresler] OFF
INSERT [dbo].[EmanetSilinen] ([emanetID], [uyeID], [kitapID], [emanetTarihi], [teslimTarihi], [TelismDurum], [tarihfark]) VALUES (1179, 10, 34, CAST(N'2019-03-20' AS Date), CAST(N'2019-03-20' AS Date), 1, N'0')
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([kategoriID], [kategoriAd]) VALUES (11, N'Tarih')
INSERT [dbo].[Kategoriler] ([kategoriID], [kategoriAd]) VALUES (12, N'BilimKurgu')
INSERT [dbo].[Kategoriler] ([kategoriID], [kategoriAd]) VALUES (14, N'Roman')
INSERT [dbo].[Kategoriler] ([kategoriID], [kategoriAd]) VALUES (15, N'Çocuk')
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
SET IDENTITY_INSERT [dbo].[Kutuphane] ON 

INSERT [dbo].[Kutuphane] ([kutuphaneID], [kutuphaneAd], [adresID]) VALUES (5, N'Fatih Kütüphanesi', 8)
INSERT [dbo].[Kutuphane] ([kutuphaneID], [kutuphaneAd], [adresID]) VALUES (6, N'Edirne Kütüphanesi', 8)
SET IDENTITY_INSERT [dbo].[Kutuphane] OFF
INSERT [dbo].[SilinenUyeler] ([uyeID], [uyeAd], [uyeSoyad], [TCno], [cinsiyet], [telefon], [eposta], [adresID]) VALUES (10, N'okan', N'yalçın', N'22222222222', N'Erkek', N'5454444444', N'yalcinokann@gmail.com', 10)
SET IDENTITY_INSERT [dbo].[Yayinevleri] ON 

INSERT [dbo].[Yayinevleri] ([yayinEviID], [yayinEviAdi], [adresID]) VALUES (3, N'Pusula', 8)
INSERT [dbo].[Yayinevleri] ([yayinEviID], [yayinEviAdi], [adresID]) VALUES (4, N'Abacüs Yayınları', 8)
SET IDENTITY_INSERT [dbo].[Yayinevleri] OFF
SET IDENTITY_INSERT [dbo].[Yazarlar] ON 

INSERT [dbo].[Yazarlar] ([yazarID], [yazarAd], [yazarSoyad]) VALUES (2, N'Ali', N'Karataş')
INSERT [dbo].[Yazarlar] ([yazarID], [yazarAd], [yazarSoyad]) VALUES (6, N'Kadir', N'SATIRBAŞI')
SET IDENTITY_INSERT [dbo].[Yazarlar] OFF
ALTER TABLE [dbo].[EmanetT]  WITH CHECK ADD  CONSTRAINT [FK_EmanetT_Kitaplar] FOREIGN KEY([kitapID])
REFERENCES [dbo].[Kitaplar] ([kitapID])
GO
ALTER TABLE [dbo].[EmanetT] CHECK CONSTRAINT [FK_EmanetT_Kitaplar]
GO
ALTER TABLE [dbo].[EmanetT]  WITH CHECK ADD  CONSTRAINT [FK_EmanetT_Uyeler] FOREIGN KEY([uyeID])
REFERENCES [dbo].[Uyeler] ([uyeID])
GO
ALTER TABLE [dbo].[EmanetT] CHECK CONSTRAINT [FK_EmanetT_Uyeler]
GO
ALTER TABLE [dbo].[Kitaplar]  WITH CHECK ADD  CONSTRAINT [FK_Kitaplar_Yayinevleri] FOREIGN KEY([yayinEviID])
REFERENCES [dbo].[Yayinevleri] ([yayinEviID])
GO
ALTER TABLE [dbo].[Kitaplar] CHECK CONSTRAINT [FK_Kitaplar_Yayinevleri]
GO
ALTER TABLE [dbo].[KitaplarKategoriler]  WITH CHECK ADD  CONSTRAINT [FK_KitaplarKategoriler_Kategoriler] FOREIGN KEY([kategoriID])
REFERENCES [dbo].[Kategoriler] ([kategoriID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitaplarKategoriler] CHECK CONSTRAINT [FK_KitaplarKategoriler_Kategoriler]
GO
ALTER TABLE [dbo].[KitaplarKategoriler]  WITH CHECK ADD  CONSTRAINT [FK_KitaplarKategoriler_Kitaplar] FOREIGN KEY([kitapID])
REFERENCES [dbo].[Kitaplar] ([kitapID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitaplarKategoriler] CHECK CONSTRAINT [FK_KitaplarKategoriler_Kitaplar]
GO
ALTER TABLE [dbo].[KitaplarKutuphane]  WITH CHECK ADD  CONSTRAINT [FK_KitaplarKutuphane_Kitaplar] FOREIGN KEY([kitapID])
REFERENCES [dbo].[Kitaplar] ([kitapID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitaplarKutuphane] CHECK CONSTRAINT [FK_KitaplarKutuphane_Kitaplar]
GO
ALTER TABLE [dbo].[KitaplarKutuphane]  WITH CHECK ADD  CONSTRAINT [FK_KitaplarKutuphane_Kutuphane] FOREIGN KEY([kutuphaneID])
REFERENCES [dbo].[Kutuphane] ([kutuphaneID])
GO
ALTER TABLE [dbo].[KitaplarKutuphane] CHECK CONSTRAINT [FK_KitaplarKutuphane_Kutuphane]
GO
ALTER TABLE [dbo].[KitapYazar]  WITH CHECK ADD  CONSTRAINT [FK_KitapYazar_Kitaplar] FOREIGN KEY([kitapID])
REFERENCES [dbo].[Kitaplar] ([kitapID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitapYazar] CHECK CONSTRAINT [FK_KitapYazar_Kitaplar]
GO
ALTER TABLE [dbo].[KitapYazar]  WITH CHECK ADD  CONSTRAINT [FK_KitapYazar_Yazarlar] FOREIGN KEY([yazarID])
REFERENCES [dbo].[Yazarlar] ([yazarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KitapYazar] CHECK CONSTRAINT [FK_KitapYazar_Yazarlar]
GO
ALTER TABLE [dbo].[Kutuphane]  WITH CHECK ADD  CONSTRAINT [FK_Kutuphane_Adresler] FOREIGN KEY([adresID])
REFERENCES [dbo].[Adresler] ([adresID])
GO
ALTER TABLE [dbo].[Kutuphane] CHECK CONSTRAINT [FK_Kutuphane_Adresler]
GO
ALTER TABLE [dbo].[Yayinevleri]  WITH CHECK ADD  CONSTRAINT [FK_Yayinevleri_Adresler] FOREIGN KEY([adresID])
REFERENCES [dbo].[Adresler] ([adresID])
GO
ALTER TABLE [dbo].[Yayinevleri] CHECK CONSTRAINT [FK_Yayinevleri_Adresler]
GO
/****** Object:  StoredProcedure [dbo].[SP_EmanetDuzelt]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EmanetDuzelt]	
(
	@uyeID int, @kitapID int, @teslimDurum  bit, @emanetID int
)
AS
BEGIN
	UPDATE [dbo].[EmanetT]
   SET[teslimDurum] = @teslimDurum
      
 WHERE [uyeID] = @uyeID and [kitapID]=@kitapID and emanetID = @emanetID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmanetEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EmanetEkle]
(
	@uyeID int, @kitapID int, @emanetTarihi datetime,@teslimTarihi datetime, @teslimDurum  bit,@tarihfark nvarchar(50)
)
AS
BEGIN 
INSERT INTO [dbo].[EmanetT]
           ([uyeID]
           ,[kitapID]
           ,[emanetTarihi]
           ,[teslimTarihi]
           ,[teslimDurum]
		   ,[tarihfark]
           )
     VALUES (@uyeID,@kitapID,@emanetTarihi,@teslimTarihi,@teslimDurum,@tarihfark)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EmanetSil]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EmanetSil]	
(
	@uyeID int, @kitapID int, @teslimDurum  bit, @emanetID int
)
AS
BEGIN
	Delete [dbo].[EmanetT]
 WHERE [uyeID] = @uyeID and [kitapID]=@kitapID and emanetID = @emanetID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_EmanetTarihDuzelt]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EmanetTarihDuzelt]	
(
	@uyeID int, @kitapID int, @emanetID int, @tarihfark nvarchar(50)
)
AS
BEGIN
	UPDATE [dbo].[EmanetT]
   SET[tarihfark] = @tarihfark
      
 WHERE [uyeID] = @uyeID and [kitapID]=@kitapID and [emanetID] = @emanetID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KategoriEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[SP_KategoriEkle]
(
	@KategoriAd nvarchar (50)
)
AS
BEGIN 
INSERT INTO dbo.Kategoriler(KategoriAd) VALUES (@KategoriAd)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KategoriSil]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[SP_KategoriSil]
(
	@silinecekID int
)
AS
BEGIN
	DELETE FROM [dbo].[Kategoriler] WHERE [kategoriID] = @silinecekID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KitapAra]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KitapAra] 
	(
		@kitapAdi nvarchar(50)
	)
AS
BEGIN
SELECT        K.kitapID, K.ISBN, K.kitapAdi, K.sayfaSayisi, K.yayinTarihi, Y.yazarAd, Y.yazarSoyad, YEV.yayinEviAdi, KTP.kutuphaneAd, KTG.kategoriAd
FROM            dbo.Kitaplar AS K INNER JOIN
                         dbo.Yazarlar AS Y ON K.yazarID = Y.yazarID INNER JOIN
                         dbo.Kategoriler AS KTG ON K.kategoriID = KTG.kategoriID INNER JOIN
                         dbo.Kutuphane AS KTP ON K.kutuphaneID = KTP.kutuphaneID INNER JOIN
                         dbo.Yayinevleri AS YEV ON K.yayinEviID = YEV.yayinEviID
WHERE [kitapAdi] LIKE '%'+@kitapAdi+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KitapDuzelt]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_KitapDuzelt]	
(
	@kitapID int, @ISBN nvarchar(30), @kitapAdi nvarchar(50), @yayinTarihi datetime, @sayfaSayisi int, @yayineviID int, @KutuphaneID int, @KategoriID int, @yazarID int
)
AS
BEGIN
	UPDATE [dbo].[Kitaplar]
   SET [ISBN] = @ISBN
      ,[kitapAdi] = @kitapAdi
      ,[yayinTarihi] = @yayinTarihi
      ,[sayfaSayisi] = @sayfaSayisi
      ,[yayinEviID] = @yayineviID
      ,[kutuphaneID] = @KutuphaneID
      ,[kategoriID] = @KategoriID
      ,[yazarID] = @yazarID
 WHERE [kitapID] = @kitapID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KitapEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[SP_KitapEkle]
(
	@isbnno nvarchar(30), @kitapadi nvarchar(50), @yayinTarihi datetime, @sayfaSayisi int, @yayineviID int, @KutuphaneID int, @KategoriID int, @yazarID int
)
AS
BEGIN 
INSERT INTO [dbo].[Kitaplar]
           ([ISBN]
           ,[kitapAdi]
           ,[yayinTarihi]
           ,[sayfaSayisi]
           ,[yayinEviID]
           ,[kutuphaneID]
           ,[kategoriID]
           ,[yazarID])
     VALUES (@isbnno,@kitapadi,@yayinTarihi,@sayfaSayisi,@yayineviID,@KutuphaneID,@KategoriID,@yazarID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KitapSil]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[SP_KitapSil]
(
	@silinecekID int
)
AS
BEGIN
	DELETE FROM [dbo].[Kitaplar] WHERE [kitapID] = @silinecekID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KutuphaneDuzelt]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[SP_KutuphaneDuzelt]	
(
	@ID int, @kutuphaneAd nvarchar(50), @adresID nvarchar(50)
)
AS
BEGIN
	UPDATE [dbo].[Kutuphane]
   SET [kutuphaneAd] = @kutuphaneAd
      ,[adresID] = @adresID
 WHERE [kutuphaneID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KutuphaneEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_KutuphaneEkle]
(
	@kutuphaneAdi nvarchar (50),
	@adresID int
)
AS
BEGIN 
INSERT INTO dbo.Kutuphane(kutuphaneAd,adresID) VALUES (@kutuphaneAdi,@adresID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UyeAra]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_UyeAra] 
	(
		@uyeadi nvarchar (50)
	)
AS
BEGIN
	SELECT   dbo.Uyeler.uyeID, dbo.Uyeler.uyeAd, dbo.Uyeler.uyeSoyad, dbo.Uyeler.TCno, dbo.Uyeler.cinsiyet, dbo.Uyeler.telefon, dbo.Uyeler.eposta, dbo.Uyeler.adresID, dbo.Adresler.adresID AS Expr1, dbo.Adresler.cadde, 
                         dbo.Adresler.sokak, dbo.Adresler.mahalle, dbo.Adresler.binaNo, dbo.Adresler.kat, dbo.Adresler.postakodu, dbo.Adresler.il, dbo.Adresler.ilce
FROM            dbo.Uyeler INNER JOIN
                         dbo.Adresler ON dbo.Uyeler.adresID = dbo.Adresler.adresID
WHERE [UyeAd] LIKE '%'+@uyeadi+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UyeDuzelt]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_UyeDuzelt]	
(
	@uyeID int, @uyeadi nvarchar(50), @uyesoyadi nvarchar(50),
	@tcNo nvarchar(11), @cinsiyet nvarchar(10), @telefon nvarchar(11),
	@eposta nvarchar(50), @adresID int
)
AS
BEGIN
	UPDATE [dbo].[Uyeler]
   SET [uyeAd] = @uyeadi, [uyeSoyad] = @uyesoyadi ,[TCno] = @tcNo
      ,[cinsiyet] = @cinsiyet ,[telefon] = @telefon ,[eposta] = @eposta, [adresID] = @adresID
	  
 WHERE [UyeID] = @uyeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UyeEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_UyeEkle]
(
	@uyeadi nvarchar (50),
	 @uyesoyadi nvarchar (50),
	  @tcNo nvarchar (11),
	   @cinsiyet nvarchar (10),
	    @telefon nvarchar (11),
		 @eposta nvarchar (50),
		 @adresID int
)
AS
BEGIN 
INSERT INTO dbo.Uyeler(UyeAd,uyeSoyad,TCno,cinsiyet,telefon,eposta,adresID) VALUES (@uyeadi,@uyesoyadi,@tcNo,@cinsiyet,@telefon,@eposta,@adresID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UyeSil]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_UyeSil]
(
	@silinecekID int
)
AS
BEGIN
	DELETE FROM [dbo].[Uyeler] WHERE [uyeID] = @silinecekID
END

GO
/****** Object:  StoredProcedure [dbo].[SP_YayinEviEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_YayinEviEkle]
(
	@yayinEviAdi nvarchar (50),
	@adresID int
)
AS
BEGIN 
INSERT INTO dbo.Yayinevleri(yayinEviAdi,adresID) VALUES (@yayinEviAdi,@adresID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_YazarAra]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_YazarAra] 
	(
		@yazarAdi nvarchar(50)
	)
AS
BEGIN
SELECT * FROM Yazarlar
WHERE [yazarAd] LIKE '%'+@yazarAdi+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_YazarDuzelt]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_YazarDuzelt]	
(
	@ID int, @yazarAd nvarchar(50), @yazarSoyad nvarchar(50)
)
AS
BEGIN
	UPDATE [dbo].[Yazarlar]
   SET [yazarAd] = @yazarAd
      ,[yazarSoyad] = @yazarSoyad
 WHERE [yazarID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_YazarEkle]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_YazarEkle]
(
	@yazarAd nvarchar (50),
	@yazarSoyad nvarchar (50)
)
AS
BEGIN 
INSERT INTO dbo.Yazarlar([yazarAd],[yazarSoyad]) VALUES (@yazarAd,@yazarSoyad)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_YazarSil]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_YazarSil]
(
	@silinecekID int
)
AS
BEGIN
	DELETE FROM [dbo].[Yazarlar] WHERE [yazarID] = @silinecekID
END
GO
/****** Object:  Trigger [dbo].[trg_silinenEmanetler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_silinenEmanetler] on [dbo].[EmanetT]
after delete
as begin
insert into dbo.EmanetSilinen select * from deleted
end

GO
/****** Object:  Trigger [dbo].[trg_KitaplarKutuphane]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_KitaplarKutuphane]
ON [dbo].[Kitaplar] 
for insert
as begin

		DECLARE @KitapID INT, @KutuphaneId INT,@KategoriID INT, @yazarID INT;
	
	select @KitapID =kitapID, @KutuphaneId=KutuphaneID ,@KategoriID=KategoriID ,@yazarID=yazarID from inserted


	INSERT INTO KitaplarKutuphane (kitapID,kutuphaneID)
	VALUES(@KitapID, @KutuphaneId)

	INSERT INTO KitaplarKategoriler (kitapID,kategoriID)
	VALUES(@KitapID, @KategoriId)

	INSERT INTO KitapYazar(kitapID,yazarID)
	VALUES(@KitapID, @yazarID)

END;

GO
/****** Object:  Trigger [dbo].[trg_KitaplarSilinince]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_KitaplarSilinince] on [dbo].[Kitaplar]
after delete
as begin
insert into dbo.KitaplarSilinen select * from deleted
end
GO
/****** Object:  Trigger [dbo].[trg_SilinenUyeler]    Script Date: 20.03.2019 09:58:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_SilinenUyeler] on [dbo].[Uyeler]
after delete
as begin
insert into dbo.SilinenUyeler select * from deleted
end

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Adresler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 202
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_AdreslerListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_AdreslerListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Uyeler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_ComboboxUyeListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_ComboboxUyeListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[16] 2[24] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EmanetT"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 189
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Kitaplar"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 136
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Uyeler"
            Begin Extent = 
               Top = 6
               Left = 464
               Bottom = 136
               Right = 634
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 945
         Width = 1500
         Width = 765
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_EmanetListe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_EmanetListe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[5] 2[35] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "K"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Y"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KTG"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KTP"
            Begin Extent = 
               Top = 102
               Left = 454
               Bottom = 215
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "YEV"
            Begin Extent = 
               Top = 120
               Left = 246
               Bottom = 233
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_KitaplarListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_KitaplarListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_KitaplarListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[10] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Adresler"
            Begin Extent = 
               Top = 0
               Left = 36
               Bottom = 234
               Right = 206
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Kutuphane"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 164
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_KutuphaneListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_KutuphaneListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Uyeler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 202
               Right = 209
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Adresler"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 202
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_UyelerListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_UyelerListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Adresler"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 202
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Yayinevleri"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 118
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_YayineviListele'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VM_YayineviListele'
GO
USE [master]
GO
ALTER DATABASE [KutuphaneDB] SET  READ_WRITE 
GO
