USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterEmbalagem]    Script Date: 17/07/2023 19:39:37 ******/
DROP PROCEDURE [dbo].[pr_ObterEmbalagem]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterEmbalagem]    Script Date: 17/07/2023 19:39:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_PesquisarEmbalagem]

AS
BEGIN
	
	SELECT * FROM tblTipoEmbalagem;

END
GO


