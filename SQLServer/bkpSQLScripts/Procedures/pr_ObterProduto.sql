CREATE PROCEDURE pr_ObterProduto
    @NomeProduto NVARCHAR(100),
    @CustomFilter NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.PK_ID, p.NOME, p.PRECO_UNITARIO, p.VOLUME, p.DESCRICAO, p.FK_Imagem_ID,
        c.Categoria, 
        f.Nome,  
        e.Embalagem,  
        u.Sigla 
    FROM tblProduto AS p
    INNER JOIN tblCategoria AS c ON p.FK_tblCategoria_ID = c.PK_ID
    INNER JOIN tblFornecedor AS f ON p.FK_tblFornecedor_ID = f.PK_ID
    INNER JOIN tblTipoEmbalagem AS e ON p.FK_tblTipoEmbalagem_ID = e.PK_ID
    INNER JOIN tblUnidadeMedida AS u ON p.FK_tblUnidadeMedida_ID = u.PK_ID
    WHERE p.NOME LIKE '%' + @NomeProduto + '%'
    + ' ' + COALESCE(@CustomFilter, '') 
END
