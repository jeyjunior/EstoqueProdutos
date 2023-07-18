USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterImagens]    Script Date: 17/07/2023 19:43:58 ******/
DROP PROCEDURE [dbo].[pr_ObterImagens]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterImagens]    Script Date: 17/07/2023 19:43:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_PesquisarImagens]
	@TipoPesquisa INT
AS
BEGIN
	
	IF(@TipoPesquisa = 1)
		BEGIN
			SELECT * FROM tblImagens WHERE PK_ID = 100;
		END

	ELSE IF(@TipoPesquisa = 2)
		BEGIN
			SELECT * FROM tblImagens;
		END

END
GO


