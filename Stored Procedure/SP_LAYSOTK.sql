USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_LAYSOTK]    Script Date: 27/06/2024 15:16:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [dbo].[SP_LAYSOTK]
AS
BEGIN
	SELECT SOTK  FROM LINK0.NGANHANG.DBO.TAIKHOAN
END
GO
