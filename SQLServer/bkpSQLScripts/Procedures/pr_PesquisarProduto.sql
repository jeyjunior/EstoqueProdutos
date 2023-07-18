USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_PesquisarProduto]    Script Date: 17/07/2023 20:26:34 ******/
DROP PROCEDURE [dbo].[pr_PesquisarProduto]
GO

/****** Object:  StoredProcedure [dbo].[pr_PesquisarProduto]    Script Date: 17/07/2023 20:26:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[pr_PesquisarProduto]
    @CustomFilter VARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @SqlQuery NVARCHAR(MAX);

    SET @SqlQuery = N'
        SELECT 
            p.PK_ID, p.NOME, p.PRECO_UNITARIO, p.VOLUME, p.DESCRICAO, p.FK_Imagem_ID,
            c.Categoria, 
            f.Nome As Fornecedor,  
            e.Embalagem,  
            u.Sigla 
        FROM tblProduto AS p
        INNER JOIN tblCategoria AS c ON p.FK_tblCategoria_ID = c.PK_ID
        INNER JOIN tblFornecedor AS f ON p.FK_tblFornecedor_ID = f.PK_ID
        INNER JOIN tblTipoEmbalagem AS e ON p.FK_tblTipoEmbalagem_ID = e.PK_ID
        INNER JOIN tblUnidadeMedida AS u ON p.FK_tblUnidadeMedida_ID = u.PK_ID
        WHERE p.NOME LIKE ' + @CustomFilter;

    EXEC sp_executesql @SqlQuery;
END

--CREATE PROCEDURE [dbo].[pr_PesquisarProduto]
--	@CustomFilter VARCHAR(500) = null
--AS
--BEGIN
--    SET NOCOUNT ON;

--	SET @CustomFilter = IsNull(@CustomFilter, '')

--    SELECT 
--        p.PK_ID, p.NOME, p.PRECO_UNITARIO, p.VOLUME, p.DESCRICAO, p.FK_Imagem_ID,
--        c.Categoria, 
--        f.Nome As Fornecedor,  
--        e.Embalagem,  
--        u.Sigla 
--    FROM tblProduto AS p
--    INNER JOIN tblCategoria AS c ON p.FK_tblCategoria_ID = c.PK_ID
--    INNER JOIN tblFornecedor AS f ON p.FK_tblFornecedor_ID = f.PK_ID
--    INNER JOIN tblTipoEmbalagem AS e ON p.FK_tblTipoEmbalagem_ID = e.PK_ID
--    INNER JOIN tblUnidadeMedida AS u ON p.FK_tblUnidadeMedida_ID = u.PK_ID
--    WHERE p.NOME LIKE @CustomFilter

--END
--GO


