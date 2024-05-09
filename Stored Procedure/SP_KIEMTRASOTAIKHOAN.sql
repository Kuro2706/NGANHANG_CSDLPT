USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_KIEMTRASOTAIKHOAN]    Script Date: 09/05/2024 23:00:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_KIEMTRASOTAIKHOAN]
	@SOTK nvarchar(9)
AS
BEGIN
	IF EXISTS (SELECT TK.SOTK FROM TaiKhoan TK WHERE TK.SOTK = @SOTK)
		RETURN 1
	RETURN 0
END

GO
