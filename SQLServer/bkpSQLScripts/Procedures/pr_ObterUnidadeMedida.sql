USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_ObterUnidadeMedida]
GO

CREATE PROCEDURE [dbo].[pr_ObterUnidadeMedida]

AS
BEGIN
	
	SELECT * FROM tblUnidadeMedida;

END
GO


