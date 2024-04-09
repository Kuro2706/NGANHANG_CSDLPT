CREATE PROCEDURE [dbo].[SP_CHUYENCHINHANH]
	@MANV nchar(10),
	@MACN nchar(10)
AS
DECLARE @LGNAME varchar(50)
DECLARE @USERNAME varchar(50)
SET XACT_ABORT ON;
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
BEGIN
	BEGIN DISTRIBUTED TRAN
		DECLARE @HONV nvarchar(40), @TENNV nvarchar(10), @DIACHINV nvarchar(100), @SDTNV nvarchar(15)
		-- Lưu lại thông tin nhân viên cần chuyển chi nhánh để kiểm tra
		SELECT @HONV = HO, @TENNV = TEN, @DIACHINV = DIACHI, @SDTNV = SODT FROM NHANVIEN WHERE MANV = @MANV
		-- Kiểm tra bên site cần chuyển tới đã có nhân viên đó hay chưa, nếu có rồi thì chuyển đổi trạng thái, chưa thì thêm vào
		
		IF EXISTS(SELECT MANV FROM LINK1.NGANHANG.DBO.NhanVien 
			WHERE HO = @HONV AND TEN = @TENNV AND DIACHI = @DIACHINV AND SODT = @SDTNV)

		BEGIN 
			UPDATE LINK1.NGANHANG.DBO.NhanVien 
			SET TrangThaiXoa = 0
			WHERE MANV = (SELECT MANV FROM LINK1.NGANHANG.DBO.NhanVien WHERE HO = @HONV AND TEN = @TENNV AND DIACHI = @DIACHINV AND SODT = @SDTNV)
        END

		ELSE
		
		-- Nếu chưa tồn tại thì thêm mới hoàn toàn vào chi nhánh mới với MANV là MANV lớn nhất +1
		BEGIN
			INSERT INTO LINK1.NGANHANG.DBO.NhanVien (MANV, HO, TEN, DIACHI, SODT, MACN, TrangThaiXoa)
			VALUES ((SELECT MAX(MANV) FROM LINK0.NGANHANG.DBO.NhanVien) + 1, @HONV,@TENNV,@DIACHINV,@SDTNV,@MACN,0)
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