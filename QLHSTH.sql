USE [QLHSTH]
GO
/****** Object:  Table [dbo].[DIEM_THI]    Script Date: 30/5/2016 17:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM_THI](
	[ma_diem_thi] [nvarchar](50) NOT NULL,
	[ten_lop] [nvarchar](50) NULL,
	[ma_hoc_sinh] [nvarchar](50) NULL,
	[ho_ten] [nvarchar](50) NULL,
	[ma_mon_hoc] [nvarchar](50) NULL,
	[mon_hoc] [nvarchar](50) NULL,
	[nam_hoc] [nvarchar](50) NULL,
	[diem_hk1] [float] NULL,
	[diem_hk2] [float] NULL,
	[diem_tb] [float] NULL,
 CONSTRAINT [PK_DIEM_THI] PRIMARY KEY CLUSTERED 
(
	[ma_diem_thi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DS_MONHOC]    Script Date: 30/5/2016 17:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DS_MONHOC](
	[ma_mon_hoc] [nvarchar](50) NOT NULL,
	[mon_hoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_DS_MONHOC] PRIMARY KEY CLUSTERED 
(
	[ma_mon_hoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DS_NAMHOC]    Script Date: 30/5/2016 17:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DS_NAMHOC](
	[ma_nam_hoc] [nvarchar](50) NOT NULL,
	[nam_hoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_DS_NAMHOC] PRIMARY KEY CLUSTERED 
(
	[ma_nam_hoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSACH_LOP]    Script Date: 30/5/2016 17:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSACH_LOP](
	[ma_lop] [nvarchar](50) NOT NULL,
	[ten_lop] [nvarchar](50) NULL,
	[khoi] [nvarchar](50) NULL,
 CONSTRAINT [PK_DSACH_LOP] PRIMARY KEY CLUSTERED 
(
	[ma_lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOC_SINH]    Script Date: 30/5/2016 17:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOC_SINH](
	[ma_hoc_sinh] [nvarchar](50) NOT NULL,
	[ho_ten] [nvarchar](50) NULL,
	[ngay_sinh] [date] NULL,
	[noi_sinh] [nvarchar](50) NULL,
	[dan_toc] [nvarchar](50) NULL,
	[ton_giao] [nvarchar](50) NULL,
	[doi_tuong] [nvarchar](50) NULL,
	[dia_chi] [nvarchar](50) NULL,
	[dien_thoai] [int] NULL,
	[ten_cha] [nvarchar](50) NULL,
	[nghe_nghiep_cha] [nvarchar](50) NULL,
	[noi_lam_viec_cha] [nvarchar](50) NULL,
	[ten_me] [nvarchar](50) NULL,
	[nghe_nghiep_me] [nvarchar](50) NULL,
	[noi_lam_viec_me] [nvarchar](50) NULL,
	[gioi_tinh] [nvarchar](50) NULL,
	[ma_lop] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOC_SINH] PRIMARY KEY CLUSTERED 
(
	[ma_hoc_sinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAI_KHOAN]    Script Date: 30/5/2016 17:58:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAI_KHOAN](
	[user_id] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[phan_quyen] [int] NOT NULL,
 CONSTRAINT [PK_TAI_KHOAN] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
