USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterCategoria]    Script Date: 17/07/2023 19:39:15 ******/
DROP PROCEDURE [dbo].[pr_ObterCategoria]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterCategoria]    Script Date: 17/07/2023 19:39:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_PesquisarCategoria]

AS
BEGIN
	
	SELECT * FROM tblCategoria;

END
GO


