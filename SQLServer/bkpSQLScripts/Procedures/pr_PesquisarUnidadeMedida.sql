USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterUnidadeMedida]    Script Date: 17/07/2023 19:43:32 ******/
DROP PROCEDURE [dbo].[pr_ObterUnidadeMedida]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterUnidadeMedida]    Script Date: 17/07/2023 19:43:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_PesquisarUnidadeMedida]

AS
BEGIN
	
	SELECT * FROM tblUnidadeMedida;

END
GO


