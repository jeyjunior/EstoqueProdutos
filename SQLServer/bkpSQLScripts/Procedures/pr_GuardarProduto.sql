USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_GuardarProduto]
GO

CREATE PROCEDURE [dbo].[pr_GuardarProduto]
	@Nome VARCHAR(45),
	@Preco DECIMAL (10,2),
	@FK_tblCategoria_ID INT,
	@FK_tblFornecedor_ID INT,
	@FK_tblTipoEmbalagem_ID INT,
	@Volume DECIMAL (10,2),
	@FK_tblUnidadeMedida_ID INT,
	@FK_Imagem_ID INT null,
	@Descricao VARCHAR (100) null,
	@Erro VARCHAR(100) OUTPUT

AS
BEGIN
	BEGIN TRY
		IF (@FK_Imagem_ID IS NULL)
		BEGIN
			SELECT TOP 1 @FK_Imagem_ID = PK_ID FROM tblImagens;
		END

		INSERT INTO tblProduto
		VALUES(
			@Nome, 
			@Preco, 
			@FK_tblCategoria_ID, 
			@FK_tblFornecedor_ID, 
			@FK_tblTipoEmbalagem_ID, 
			@Volume, 
			@FK_tblUnidadeMedida_ID, 
			@FK_Imagem_ID, 
			@Descricao
		);
		
		SET @Erro = '';

	END TRY
	BEGIN CATCH
		SET @Erro = ERROR_MESSAGE(); -- Armazena a mensagem de erro na variável @Erro
	END CATCH
END
GO
