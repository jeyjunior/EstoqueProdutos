USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 08/07/2023 16:52:12 ******/
DROP PROCEDURE [dbo].[pr_GuardarImagem]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 08/07/2023 16:52:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_GuardarImagem]
	@PK_ID int = null,
	@Nome VARCHAR(30) null,
	@Formato VARCHAR(5) null,
	@Imagem VARBINARY(MAX) null

AS
BEGIN
	IF LEN(@Nome) > 30
	BEGIN
        RAISERROR ('A descrição deve ter no máximo 30 caracteres.', 16, 1)
        RETURN
    END

	IF LEN(@Formato) > 5
	BEGIN
        RAISERROR ('O formato deve ter no máximo 5 caracteres.', 16, 1)
        RETURN
    END

	--DECLARE 
	--	@PK_ID_Existente int
	--	@NomeExistente VARCHAR(30), 
	--	@FormatoExistente VARCHAR(5)

	--SELECT TOP 1 @NomeExistente = NOME, @FormatoExistente = FORMATO FROM tblImagens
	--SELECT TOP 1 @PK_ID_Existente = PK_ID FROM tblImagens

	--IF (@Nome != @NomeExistente OR @Formato != @FormatoExistente)
	IF (@PK_ID is null)
		BEGIN
			INSERT INTO tblImagens (NOME, FORMATO, IMAGEM)
			VALUES (@Nome, @Formato, @Imagem)
		END
	
		
END
GO


