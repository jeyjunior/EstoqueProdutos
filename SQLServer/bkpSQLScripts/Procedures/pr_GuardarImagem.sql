USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 16/07/2023 15:14:09 ******/
DROP PROCEDURE [dbo].[pr_GuardarImagem]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 16/07/2023 15:14:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_GuardarImagem]
	@Nome VARCHAR(30),
	@Formato VARCHAR(5),
	@Imagem VARBINARY(MAX),
	@UltimoID int OUTPUT

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
	
	-- Verificar se já existe uma imagem com o mesmo nome
	SELECT TOP 1 @Resultado = NOME FROM tblImagens WHERE NOME = @Nome
	
	IF (@Resultado is null)
		BEGIN 
			INSERT INTO tblImagens (NOME, FORMATO, IMAGEM)
			VALUES (@Nome, @Formato, @Imagem)

			-- Retorna o último ID adicionado à tabela
			SET @UltimoID = SCOPE_IDENTITY();
		END
END
GO


