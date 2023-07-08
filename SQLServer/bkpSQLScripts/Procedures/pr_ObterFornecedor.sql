USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_ObterFornecedor]
GO

CREATE PROCEDURE [dbo].[pr_ObterFornecedor]

AS
BEGIN
	
	SELECT * FROM tblFornecedor;

END
GO


