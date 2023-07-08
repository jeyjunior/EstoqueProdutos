USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 08/07/2023 17:07:35 ******/
DROP PROCEDURE [dbo].[pr_GuardarImagem]
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

	DECLARE 
		@Resultado VARCHAR(30)

	SELECT TOP 1 @Resultado = NOME FROM tblImagens WHERE NOME = @Nome
	--SELECT TOP 1 @PK_ID_Existente = PK_ID FROM tblImagens
	
	IF (@PK_ID is null)
		BEGIN
			IF (@Resultado is null)
			BEGIN 
				INSERT INTO tblImagens (NOME, FORMATO, IMAGEM)
				VALUES (@Nome, @Formato, @Imagem)
			END
		END
END
GO


