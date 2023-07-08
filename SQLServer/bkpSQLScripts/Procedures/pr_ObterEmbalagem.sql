USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_ObterEmbalagem]
GO

CREATE PROCEDURE [dbo].[pr_ObterEmbalagem]

AS
BEGIN
	
	SELECT * FROM tblTipoEmbalagem;

END
GO


