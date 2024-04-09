CREATE VIEW [dbo].[v_DanhSachPhanManh]
AS
SELECT TENCN = PUBS.description, TENSERVER = SUBS.subscriber_server
FROM sysmergepublications PUBS, sysmergesubscriptions SUBS
WHERE PUBS.pubid = SUBS.pubid AND publisher <> subscriber_server
AND PUBS.description NOT IN (N'THÔNG TIN KHÁCH HÀNG')
GO