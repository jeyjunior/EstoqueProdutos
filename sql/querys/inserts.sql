

INSERT INTO Fornecedor (Nome, CNPJ, Endereco, Bairro, UF)
VALUES
   ('Distribuidora Brasil Verde', '12345678000123', 'Av. Paulista, 123', 'Bela Vista', 'SP'),
   ('Supermercado Tropical', '98765432000110', 'Rua das Flores, 456', 'Centro', 'RJ'),
   ('Hortifruti Sabor Natural', '87654321000199', 'Rua do Mercado, 789', 'Vila Nova', 'MG'),
   ('Atacadão dos Grãos', '54321678000187', 'Av. das Indústrias, 321', 'Distrito Industrial', 'RS'),
   ('Mercado do Interior', '23876541000122', 'Rua do Mercado, 987', 'Bairro Novo', 'PR'),
   ('Distribuidora Flor do Cerrado', '65432789000154', 'Av. dos Ipês, 741', 'Jardim das Flores', 'GO'),
   ('Supermercado Estrela do Norte', '34218534000111', 'Av. da Liberdade, 852', 'Vila Esperança', 'BA'),
   ('Sacolão Frutas Frescas', '71456123000112', 'Rua das Mangueiras, 951', 'Centro', 'PE'),
   ('Distribuidora Hortaliças do Vale', '18329742000115', 'Av. das Palmeiras, 654', 'Vale Encantado', 'SC'),
   ('Mercado do Campo', '92731643000120', 'Rua das Oliveiras, 159', 'Campo Grande', 'MS');

INSERT INTO Categoria (Nome)
VALUES
   ('Nenhum'),
   ('Limpeza'),
   ('Alimentos'),
   ('Eletrônicos'),
   ('Moda'),
   ('Cosméticos'),
   ('Móveis'),
   ('Automotivo'),
   ('Brinquedos'),
   ('Esportes'),
   ('Livros');

INSERT INTO TipoEmbalagem (Nome)
VALUES
('Nenhum'),
   ('Caixa'),
   ('Garrafa'),
   ('Lata'),
   ('Pote'),
   ('Saco'),
   ('Tubo'),
   ('Envelope'),
   ('Bisnaga'),
   ('Spray'),
   ('Bandeja');

INSERT INTO UnidadeMedida (Sigla, Extenso)
VALUES
('n','Nenhum'),
   ('kg', 'Quilograma'),
   ('g', 'Grama'),
   ('L', 'Litro'),
   ('ml', 'Mililitro'),
   ('m', 'Metro'),
   ('cm', 'Centímetro'),
   ('mm', 'Milímetro'),
   ('un', 'Unidade'),
   ('dz', 'Dúzia'),
   ('pç', 'Peça');

INSERT INTO Operadores(Sigla, Extenso)
VALUES
   ('n', 'Nenhum'),
   ('=', 'Igual'),
   ('<', 'Menor que'),
   ('>', 'Maior que'),
   ('<>', 'Diferente de'),
   ('>=', 'Maior ou igual que'),
   ('<=', 'Menor ou igual que')
   
INSERT INTO OperadoresEspeciais (Sigla, Extenso)
VALUES
   ('n', 'Nenhum'),
   ('IS NULL', 'É nulo'),
   ('IS NOT NULL', 'Não é nulo'),
   ('BETWEEN', 'Entre '),
   ('NOT BETWEEN', 'Fora do intervalo'),
   ('IN', 'Está em uma lista'),
   ('NOT IN', 'Não está em uma lista'),
   ('LIKE', 'Corresponde a um padrão'),
   ('NOT LIKE', 'Não corresponde a um padrão');


INSERT INTO Imagens (Imagem) 
SELECT BulkColumn
FROM OPENROWSET(BULK 'C:\...\standard.png', SINGLE_BLOB) AS Imagem;


UPDATE Imagens
SET Nome = 'STANDARD'
WHERE PK_ID = 100 



INSERT INTO Produto
VALUES
	('Nome produto', 10.55, 5.66, 'Descrição do Produto', 104, 102, 107, 103, 100)
