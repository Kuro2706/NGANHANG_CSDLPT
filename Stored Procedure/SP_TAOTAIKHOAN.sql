USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 09/05/2024 23:01:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_TAOTAIKHOAN]
@LGNAME varchar(50), @PASS varchar(50),
@USERNAME varchar(50), @ROLE varchar(50)
AS
	DECLARE @RET INT
	--KIEM TRA TRANG THAI XOA CO BANG 1 HAY KO
	IF EXISTS (SELECT 1 FROM NhanVien WHERE MANV = @USERNAME AND TrangThaiXoa = 1)
    BEGIN
        RAISERROR('Nhân viên đã bị xóa và không thể tạo tài khoản.', 16, 1)
        RETURN
    END

	EXEC @RET = sp_addlogin @LGNAME, @PASS, 'NGANHANG'
	IF(@RET=1) --LGNAME BI TRUNG
	BEGIN
		RAISERROR('Login name bị trùng', 16, 2)
		RETURN
	END
	EXEC @RET = sp_grantdbaccess @LGNAME, @USERNAME
	IF(@RET=1) --USERNAME BI TRUNG
	BEGIN
		EXEC sp_droplogin @LGNAME
		RAISERROR('Nhân viên đã có login name', 16, 3)
		RETURN
	END
	EXEC sp_addrolemember @ROLE, @USERNAME
	IF @ROLE = N'NGANHANG'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
	IF @ROLE = N'CHINHANH'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
RETURN 0 --THANH CONG

GO

