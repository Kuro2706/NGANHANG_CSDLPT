USE [NGANHANG]
GO

/****** Object:  View [dbo].[v_DSPM1]    Script Date: 09/05/2024 22:57:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_DSPM1]
AS
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server


GO

