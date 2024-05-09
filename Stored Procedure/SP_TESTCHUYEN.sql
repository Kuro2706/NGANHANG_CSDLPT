USE [NGANHANG]
GO

/****** Object:  StoredProcedure [dbo].[SP_TESTCHUYEN]    Script Date: 09/05/2024 23:01:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_TESTCHUYEN]
	@MANV nvarchar(10),
	@MACN nvarchar(10),
	@MANVMOI nvarchar(10) OUTPUT
AS
DECLARE @LGNAME nvarchar(50)
DECLARE @USERNAME nvarchar(50)
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN
	BEGIN DISTRIBUTED TRAN
		DECLARE @HO nvarchar(40)
		DECLARE @TEN nvarchar(10)
		DECLARE @CMND nvarchar(10)
		DECLARE @DIACHI nvarchar(100)
		DECLARE @PHAI nvarchar(3)
		DECLARE @SODT nvarchar(15)

		-- Lưu lại thông tin nhân viên cần chuyển chi nhánh để kiểm tra
		SELECT @HO = HO, @TEN = TEN, @CMND = CMND, @DIACHI = DIACHI, @PHAI = PHAI, @SODT = SODT FROM NhanVien WHERE MANV = @MANV
		
		-- Kiểm tra bên site cần chuyển tới đã có nhân viên đó hay chưa, nếu có rồi thì chuyển đổi trạng thái, chưa thì thêm vào
		IF EXISTS(SELECT MANV FROM LINK1.NGANHANG.DBO.NhanVien 
			WHERE HO = @HO AND TEN = @TEN AND CMND = @CMND AND DIACHI = @DIACHI AND PHAI = @PHAI AND SODT = @SODT)
		BEGIN 
			UPDATE LINK1.NGANHANG.DBO.NhanVien 
			SET TrangThaiXoa = 0
			WHERE MANV = (SELECT MANV FROM LINK1.NGANHANG.DBO.NhanVien WHERE HO = @HO AND TEN = @TEN AND CMND = @CMND AND DIACHI = @DIACHI AND PHAI = @PHAI AND SODT = @SODT)
        END

		ELSE
		-- Nếu chưa tồn tại thì thêm mới hoàn toàn vào chi nhánh mới
		BEGIN
			INSERT INTO LINK1.NGANHANG.DBO.NhanVien (MANV, HO, TEN, CMND, DIACHI, PHAI, SODT, MACN, TrangThaiXoa)
			VALUES ((SELECT MAX(MANV) FROM LINK0.NGANHANG.dbo.NhanVien) + 1, @HO, @TEN, @CMND, @DIACHI, @PHAI, @SODT, @MACN, 0)
		END

		--Đổi trạng thái đối với tài khoản cũ ở site hiện tại
		UPDATE DBO.NhanVien
		SET TrangThaiXoa = 1
		WHERE MANV = @MANV
	COMMIT TRAN;
		
		--sp_droplogin và sp_dropuser không thể thực thi trong một giao tác do người dùng định nghĩa
		--Kiểm tra xem Nhân viên đã có login chưa. Có thì xóa
		IF EXISTS (SELECT SUSER_NAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS nvarchar))
		BEGIN
			SET @LGNAME = CAST((SELECT SUSER_NAME(sid) FROM sys.sysusers WHERE name = CAST(@MANV AS nvarchar)) AS nvarchar(50))
			SET @USERNAME = CAST(@MANV AS nvarchar(50))
			EXEC SP_DROPUSER @USERNAME;
			EXEC SP_DROPLOGIN @LGNAME;
        END
END

GO

