USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_ObterImagens]
GO

CREATE PROCEDURE [dbo].[pr_ObterImagens]

AS
BEGIN
	
	SELECT TOP 1 *  FROM tblImagens;

END
GO


