USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_ObterImagens]    Script Date: 16/07/2023 14:45:35 ******/
DROP PROCEDURE [dbo].[pr_ObterImagens]
GO

CREATE PROCEDURE [dbo].[pr_ObterImagens]
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


