USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 10/07/2023 19:48:52 ******/
DROP PROCEDURE [dbo].[pr_GuardarImagem]
GO
CREATE PROCEDURE [dbo].[pr_GuardarImagem]
	@PK_ID int = null,
	@Nome VARCHAR(30) = null,
	@Formato VARCHAR(5) = null,
	@Imagem VARBINARY(MAX) = null,
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
	
	IF (@PK_ID is null)
	BEGIN
		IF (@Resultado is null)
		BEGIN 
			INSERT INTO tblImagens (NOME, FORMATO, IMAGEM)
			VALUES (@Nome, @Formato, @Imagem)

			-- Retorna o último ID adicionado à tabela
			SET @UltimoID = SCOPE_IDENTITY();
		END
	END
END
GO
