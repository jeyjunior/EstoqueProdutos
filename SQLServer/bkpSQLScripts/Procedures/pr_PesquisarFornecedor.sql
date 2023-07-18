USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterFornecedor]    Script Date: 17/07/2023 19:44:27 ******/
DROP PROCEDURE [dbo].[pr_ObterFornecedor]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterFornecedor]    Script Date: 17/07/2023 19:44:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_PesquisarFornecedor]

AS
BEGIN
	
	SELECT * FROM tblFornecedor;

END
GO


