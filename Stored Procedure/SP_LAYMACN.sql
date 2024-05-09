USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_LAYMACN]    Script Date: 09/05/2024 23:00:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_LAYMACN] --lay ma chi nhanh tu ten chi nhanh
@TENCN nvarchar(100)
AS
BEGIN
	SELECT CN.MACN FROM LINK0.NGANHANG.dbo.ChiNhanh CN WHERE CN.TENCN = @TENCN
END

GO

