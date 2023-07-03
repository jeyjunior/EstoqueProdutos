USE [EstoqueJJ]
GO

ALTER PROCEDURE [dbo].[prPesquisarProdutos]
	@TipoDePesquisa INT,
	@ID INT Null,
	@Nome VARCHAR(120) NULL,
    @ParametroComplementar VARCHAR(120) NULL
AS
BEGIN
		-- PESQUISA GENERICA DOS PRODUTOS
		IF(@TipoDePesquisa = 1)
			BEGIN
				DECLARE @QueryTipo1 NVARCHAR(MAX)
				SET @QueryTipo1 = N'
				SELECT P.ID, P.NOME, P.PRECO_UNIT, C.Categoria, F.RazaoSocial, P.ID_IMAGEM
				FROM tblProdutos P
				JOIN tblCategoriaProduto C ON P.ID_CATEGORIA = C.ID
				JOIN tblFornecedor F ON P.ID_FORNECEDOR = F.ID
				WHERE P.NOME LIKE ''%' + @Nome + '%'' AND ' + @ParametroComplementar
				EXEC sp_executesql @QueryTipo1
			END

		-- PESQUISAR UM UNICO PRODUTO PELO ID
		ELSE IF(@TipoDePesquisa = 2)
			BEGIN
				IF(@ID IS NOT NULL)
					BEGIN
						DECLARE @QueryTipo2 NVARCHAR(MAX)
						SET @QueryTipo2 = N'
						SELECT P.ID, P.NOME, P.PRECO_UNIT, C.Categoria, F.RazaoSocial, M.IMAGEM
						FROM tblProdutos P
						JOIN tblCategoriaProduto C ON P.ID_CATEGORIA = C.ID
						JOIN tblFornecedor F ON P.ID_FORNECEDOR = F.ID
						JOIN tblImagens M ON P.ID_IMAGEM = M.ID
						WHERE P.ID = ' + @ID
						EXEC sp_executesql @QueryTipo2
					END
			END
END
