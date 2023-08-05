INSERT INTO Formato (Nome, Descricao)
VALUES 
    ('Sólido', 'Produtos com forma física sólida.'),
    ('Líquido', 'Produtos em estado líquido.'),
    ('Gasoso', 'Produtos em estado gasoso.'),
    ('Pó', 'Produtos em forma de pó fino.'),
    ('Gel', 'Produtos com textura de gel.'),
    ('Creme', 'Produtos com consistência de creme.'),
    ('Aerossol', 'Produtos em formato de aerossol.'),
    ('Granulado', 'Produtos em forma de grânulos.'),
    ('Pastilha', 'Produtos em formato de pastilha.'),
    ('Espuma', 'Produtos com consistência de espuma.');



INSERT INTO Imagem (Nome, Formato, ImgBinary) 
SELECT 'STANDARD', 'PNG', BulkColumn
FROM OPENROWSET(BULK 'C:\Users\jeyjr\OneDrive\Imagens\Capturas de tela\std.png', SINGLE_BLOB) AS Imagem;


INSERT INTO Categoria (Nome, Descricao)
VALUES
    ('Eletrônicos', 'Produtos eletrônicos e gadgets.'),
    ('Vestuário', 'Roupas e acessórios de moda.'),
    ('Alimentos', 'Produtos alimentícios e bebidas.'),
    ('Cuidados Pessoais', 'Produtos de cuidados pessoais e beleza.'),
    ('Casa e Decoração', 'Produtos para decoração e itens para casa.'),
    ('Esportes e Lazer', 'Artigos esportivos e produtos para lazer.'),
    ('Automotivo', 'Peças e acessórios para automóveis.'),
    ('Livros e Educação', 'Livros, materiais educacionais e papelaria.'),
    ('Brinquedos', 'Brinquedos e jogos para todas as idades.'),
    ('Saúde e Bem-Estar', 'Produtos relacionados à saúde e bem-estar.'),
    ('Limpeza', 'Produtos de limpeza e saneamento.'),
    ('Higiene', 'Produtos de higiene pessoal.'),
    ('Bebidas Alcoólicas', 'Bebidas que contêm álcool.'),
    ('Bebidas Não Alcoólicas', 'Bebidas não alcoólicas, como sucos e refrigerantes.'),
    ('Alimentos Perecíveis', 'Alimentos que têm prazo de validade curto.'),
    ('Alimentos Não Perecíveis', 'Alimentos de longa durabilidade.'),
    ('Alimentos Estragáveis', 'Alimentos que podem estragar rapidamente após abertos.'),
    ('Outros', 'Outras categorias não especificadas.');

INSERT INTO Marca (Nome, Descricao)
VALUES
    ('Dell', 'Produtos eletrônicos da marca Dell.'),
    ('Apple', 'Produtos eletrônicos da marca Apple.'),
    ('Samsung', 'Produtos eletrônicos da marca Samsung.'),
    ('Ypê', 'Produtos de limpeza da marca Ypê.'),
    ('Veja', 'Produtos de limpeza da marca Veja.'),
    ('Omo', 'Produtos de limpeza da marca Omo.'),
    ('Ambev', 'Bebidas alcoólicas da empresa Ambev.'),
    ('Diageo', 'Bebidas alcoólicas da empresa Diageo.'),
    ('Pernod Ricard', 'Bebidas alcoólicas da empresa Pernod Ricard.');


INSERT INTO Embalagem (Nome, Descricao)
VALUES
    ('Caixa', 'Embalagem em forma de caixa.'),
    ('Garrafa', 'Embalagem em forma de garrafa.'),
    ('Lata', 'Embalagem em forma de lata.'),
    ('Saco', 'Embalagem em forma de saco.'),
    ('Frasco', 'Embalagem em forma de frasco.'),
    ('Envelope', 'Embalagem em forma de envelope.'),
    ('Pote', 'Embalagem em forma de pote.'),
    ('Tubo', 'Embalagem em forma de tubo.'),
    ('Bandeja', 'Embalagem em forma de bandeja.'),
    ('Ampola', 'Embalagem em forma de ampola.'),
    ('Blister', 'Embalagem em formato blister.'),
    ('Pacote', 'Embalagem em formato de pacote.');


INSERT INTO UnidadeMedida (Sigla, Extenso)
VALUES
    ('g', 'Grama'),
    ('kg', 'Quilograma'),
    ('mg', 'Miligrama'),
    ('ml', 'Mililitro'),
    ('L', 'Litro'),
    ('cm', 'Centímetro'),
    ('m', 'Metro'),
    ('mm', 'Milímetro'),
    ('un', 'Unidade'),
    ('cx', 'Caixa'),
    ('pç', 'Peça'),
    ('dz', 'Dúzia');

