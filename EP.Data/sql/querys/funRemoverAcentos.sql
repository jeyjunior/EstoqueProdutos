CREATE FUNCTION RemoveAcentos(@texto NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @resultado NVARCHAR(MAX);
    
    SET @resultado = @texto;
    
    -- Substitui caracteres acentuados por equivalentes não acentuados
    SET @resultado = REPLACE(@resultado, N'á', 'a');
    SET @resultado = REPLACE(@resultado, N'é', 'e');
    SET @resultado = REPLACE(@resultado, N'í', 'i');
    SET @resultado = REPLACE(@resultado, N'ó', 'o');
    SET @resultado = REPLACE(@resultado, N'ú', 'u');
    SET @resultado = REPLACE(@resultado, N'â', 'a');
    SET @resultado = REPLACE(@resultado, N'ê', 'e');
    SET @resultado = REPLACE(@resultado, N'î', 'i');
    SET @resultado = REPLACE(@resultado, N'ô', 'o');
    SET @resultado = REPLACE(@resultado, N'û', 'u');
    -- Adicione mais substituições conforme necessário
    
    RETURN @resultado;
END;
