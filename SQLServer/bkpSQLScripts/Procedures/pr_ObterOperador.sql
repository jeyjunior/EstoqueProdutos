USE [EstoqueProdutos]
GO

--DROP PROCEDURE [dbo].[pr_ObterOperador]
--GO

CREATE PROCEDURE [dbo].[pr_ObterOperador]
	@TipoOperador INT
AS
BEGIN
	
	IF(@TipoOperador = 1)
		BEGIN
			SELECT *  FROM tblOperador;
		END

	ELSE IF(@TipoOperador = 2)
		BEGIN
			SELECT * FROM tblOperadorEspecial;
		END

END
GO


