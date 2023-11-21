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
FROM OPENROWSET(BULK 'C:\Users\jeyjr\Pictures\Screenshots\standard.png', SINGLE_BLOB) AS Imagem;


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
    ('Nestlé', 'Alimentos da marca Nestlé.'),
    ('Unilever', 'Produtos de limpeza e higiene da marca Unilever.'),
    ('Procter & Gamble', 'Produtos de higiene e limpeza da marca Procter & Gamble.'),
    ('Coca-Cola', 'Bebidas da marca Coca-Cola.'),
    ('Pepsi', 'Bebidas da marca Pepsi.'),
    ('Colgate', 'Produtos de higiene bucal da marca Colgate.'),
    ('Dettol', 'Produtos de limpeza da marca Dettol.'),
    ('Johnson & Johnson', 'Produtos de cuidados pessoais da marca Johnson & Johnson.'),
    ('Kellogg''s', 'Cereais e alimentos da marca Kellogg''s.'),
    ('Heinz', 'Alimentos da marca Heinz.'),
    ('Lysol', 'Produtos de limpeza da marca Lysol.'),
    ('Windex', 'Produtos de limpeza da marca Windex.'),
    ('Kleenex', 'Produtos de papel da marca Kleenex.'),
    ('Quaker Oats', 'Alimentos da marca Quaker Oats.'),
    ('Tide', 'Detergente da marca Tide.'),
    ('Doritos', 'Salgadinhos da marca Doritos.'),
    ('Kraft', 'Alimentos da marca Kraft.'),
    ('Glade', 'Produtos de aromatização da marca Glade.'),
    ('Pampers', 'Produtos de cuidados infantis da marca Pampers.'),
    ('Oreo', 'Biscoitos da marca Oreo.'),
    ('Ajax', 'Produtos de limpeza da marca Ajax.'),
    ('Ritz', 'Biscoitos da marca Ritz.'),
    ('Clorox', 'Produtos de limpeza da marca Clorox.'),
    ('Swiffer', 'Produtos de limpeza da marca Swiffer.'),
    ('Lysol', 'Produtos de limpeza da marca Lysol.'),
    ('Febreze', 'Produtos de aromatização da marca Febreze.'),
    ('Arm & Hammer', 'Produtos de limpeza da marca Arm & Hammer.'),
    ('Scott', 'Produtos de papel da marca Scott.'),
    ('Kleenex', 'Produtos de papel da marca Kleenex.'),
    ('Folgers', 'Café da marca Folgers.'),
    ('Clorox', 'Produtos de limpeza da marca Clorox.'),
    ('Ziploc', 'Produtos de armazenamento da marca Ziploc.'),
    ('Huggies', 'Fraldas da marca Huggies.'),
    ('Glad', 'Produtos de armazenamento da marca Glad.'),
    ('Nivea', 'Produtos de cuidados com a pele da marca Nivea.'),
    ('L''Oréal', 'Produtos de beleza da marca L''Oréal.'),
    ('Pledge', 'Produtos de limpeza da marca Pledge.'),
    ('Air Wick', 'Produtos de aromatização da marca Air Wick.'),
    ('Raid', 'Produtos de controle de insetos da marca Raid.');


INSERT INTO Embalagem (Nome, Descricao)
VALUES
    ('Caixa de Papelão', 'Embalagem em forma de caixa de papelão resistente.'),
    ('Garrafa de Vidro', 'Embalagem em forma de garrafa de vidro para líquidos.'),
    ('Lata de Alumínio', 'Embalagem em forma de lata de alumínio para alimentos.'),
    ('Saco Plástico', 'Embalagem em forma de saco plástico para produtos a granel.'),
    ('Frasco de Plástico', 'Embalagem em forma de frasco de plástico com tampa rosqueável.'),
    ('Envelope de Papel', 'Embalagem em forma de envelope de papel para documentos.'),
    ('Pote de Vidro', 'Embalagem em forma de pote de vidro para conservas.'),
    ('Tubo de Metal', 'Embalagem em forma de tubo de metal para pastas e cremes.'),
    ('Bandeja de Isopor', 'Embalagem em forma de bandeja de isopor para carnes resfriadas.'),
    ('Ampola de Vidro', 'Embalagem em forma de ampola de vidro para medicamentos.'),
    ('Blister de Plástico', 'Embalagem em formato blister de plástico para produtos pequenos.'),
    ('Pacote de Papel', 'Embalagem em formato de pacote de papel para produtos a granel.'),
    ('Garrafa PET', 'Embalagem em forma de garrafa PET para líquidos.');



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

INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Arroz Integral', 1000.00, 'Arroz integral de alta qualidade.', '2023-09-23', '2024-09-23', 5.0, 10.0, 15.0, 1, 1, 3, 12, 1, 6),
    ('Feijão Preto', 500.00, 'Feijão preto de primeira linha.', '2023-09-24', '2024-09-24', 5.0, 10.0, 15.0, 1, 1, 3, 12, 1, 6),
    ('Azeite de Oliva Extra Virgem', 500.00, 'Azeite de oliva extra virgem de alta qualidade.', '2023-09-25', '2024-09-25', 5.0, 10.0, 15.0, 1, 1, 3, 12, 1, 6),
    ('Leite em Pó', 400.00, 'Leite em pó instantâneo para preparo de bebidas.', '2023-09-26', '2024-09-26', NULL, NULL, NULL, 1, 1, 3, 12, 4, 7),
    ('Chocolate ao Leite', 200.00, 'Chocolate ao leite suíço.', '2023-09-27', '2024-09-27', 10.0, 5.0, 15.0, 1, 1, 3, 12, 1, 9),
    ('Macarrão Espaguete', 500.00, 'Macarrão espaguete de trigo durum.', '2023-09-28', '2024-09-28', NULL, NULL, NULL, 1, 1, 3, 12, 1, 6),
    ('Molho de Tomate', 300.00, 'Molho de tomate pronto para massas.', '2023-09-29', '2024-09-29', NULL, NULL, NULL, 1, 1, 3, 12, 4, 6),
    ('Café em Grãos', 500.00, 'Café em grãos torrados de alta qualidade.', '2023-09-30', '2024-09-30', NULL, NULL, NULL, 1, 1, 3, 12, 4, 6),
    ('Salmão Fresco', 300.00, 'Salmão fresco de cultivo.', '2023-10-01', '2024-10-01', NULL, NULL, NULL, 2, 1, 3, 12, 2, 8),
    ('Iogurte Natural', 200.00, 'Iogurte natural sem açúcar.', '2023-10-02', '2024-10-02', NULL, NULL, NULL, 1, 1, 3, 12, 4, 5);

-- Categoria: Limpeza
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Detergente Líquido', 500.00, 'Detergente líquido para lavar louças.', '2023-09-23', '2024-09-23', 5.0, 10.0, 15.0, 2, 1, 11, 13, 1, 6),
    ('Desinfetante', 1000.00, 'Desinfetante para limpeza geral.', '2023-09-24', '2024-09-24', 5.0, 10.0, 15.0, 2, 1, 11, 14, 1, 6),
    ('Esponja de Limpeza', NULL, 'Esponja de limpeza multiuso.', NULL, NULL, NULL, NULL, NULL, 5, 1, 11, 13, 11, 10),
    ('Vassoura de Nylon', NULL, 'Vassoura de nylon para limpeza.', NULL, NULL, NULL, NULL, NULL, 5, 1, 11, 13, 11, 10);

-- Categoria: Eletrônicos
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Smartphone', NULL, 'Smartphone de última geração.', '2023-09-25', NULL, NULL, NULL, NULL, 1, 1, 1, 1, 1, 6),
    ('Tablet', NULL, 'Tablet com alta performance.', '2023-09-26', NULL, NULL, NULL, NULL, 1, 1, 1, 2, 1, 6),
    ('Notebook', NULL, 'Notebook poderoso para trabalho e entretenimento.', '2023-09-27', NULL, NULL, NULL, NULL, 1, 1, 1, 3, 1, 6),
    ('Smart TV', NULL, 'Smart TV de 55 polegadas com resolução 4K.', '2023-09-28', NULL, NULL, NULL, NULL, 1, 1, 1, 4, 1, 6);

-- Categoria: Decoração
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Almofada Decorativa', NULL, 'Almofada decorativa para sofá.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Vaso de Cerâmica', NULL, 'Vaso de cerâmica para decoração.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Quadro Decorativo', NULL, 'Quadro decorativo para paredes.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Cortinas', NULL, 'Cortinas para janelas e portas.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10);

-- Categoria: Higiene Pessoal
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Shampoo', 500.00, 'Shampoo para cabelos saudáveis.', '2023-09-29', '2024-09-29', NULL, NULL, NULL, 2, 1, 12, 16, 3, 6),
    ('Condicionador', 500.00, 'Condicionador para cabelos macios.', '2023-09-30', '2024-09-30', NULL, NULL, NULL, 2, 1, 12, 16, 3, 6),
    ('Sabonete Líquido', 250.00, 'Sabonete líquido suave para a pele.', '2023-10-01', '2024-10-01', NULL, NULL, NULL, 1, 1, 12, 17, 4, 6),
    ('Creme Dental', NULL, 'Creme dental com flúor para uma higiene bucal completa.', NULL, NULL, NULL, NULL, NULL, 1, 1, 12, 18, 1, 6);


	-- Categoria: Alimentos
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Macarrão Penne', 500.00, 'Macarrão penne de trigo durum.', '2023-10-03', '2024-10-03', NULL, NULL, NULL, 1, 1, 3, 12, 1, 6),
    ('Ketchup', 300.00, 'Molho de ketchup para lanches e batatas fritas.', '2023-10-04', '2024-10-04', NULL, NULL, NULL, 1, 1, 3, 19, 1, 6),
    ('Mostarda', 250.00, 'Mostarda amarela para acompanhar alimentos.', '2023-10-05', '2024-10-05', NULL, NULL, NULL, 1, 1, 3, 19, 1, 6),
    ('Óleo de Coco', 500.00, 'Óleo de coco extra virgem para culinária.', '2023-10-06', '2024-10-06', NULL, NULL, NULL, 1, 1, 3, 12, 1, 6),
    ('Sopa de Tomate', 350.00, 'Sopa de tomate enlatada.', '2023-10-07', '2024-10-07', NULL, NULL, NULL, 1, 1, 3, 12, 3, 6),
    ('Molho de Soja', 250.00, 'Molho de soja para temperar alimentos.', '2023-10-08', '2024-10-08', NULL, NULL, NULL, 1, 1, 3, 12, 4, 6),
    ('Pimenta em Grãos', NULL, 'Pimenta em grãos para dar sabor aos pratos.', NULL, NULL, NULL, NULL, NULL, 1, 1, 3, 12, 1, 6),
    ('Biscoitos de Chocolate', 200.00, 'Biscoitos recheados com chocolate.', '2023-10-09', '2024-10-09', NULL, NULL, NULL, 1, 1, 3, 12, 1, 9),
    ('Barras de Cereal', NULL, 'Barras de cereal para um lanche saudável.', NULL, NULL, NULL, NULL, NULL, 5, 1, 3, 20, 11, 10),
    ('Água Mineral', 1000.00, 'Água mineral natural engarrafada.', '2023-10-10', '2024-10-10', NULL, NULL, NULL, 2, 1, 3, 12, 1, 6);

-- Categoria: Limpeza
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Amaciante de Roupas', 1000.00, 'Amaciante de roupas com fragrância suave.', '2023-10-11', '2024-10-11', NULL, NULL, NULL, 2, 1, 11, 13, 1, 6),
    ('Lustra-Móveis', NULL, 'Lustra-móveis em spray para móveis de madeira.', NULL, NULL, NULL, NULL, NULL, 6, 1, 11, 14, 1, 6),
    ('Pano de Limpeza', NULL, 'Pano de limpeza multiuso.', NULL, NULL, NULL, NULL, NULL, 5, 1, 11, 13, 11, 10),
    ('Saco de Lixo', NULL, 'Saco de lixo resistente para descarte de resíduos.', NULL, NULL, NULL, NULL, NULL, 6, 1, 11, 13, 1, 6),
    ('Máquina de Lavar Roupas', NULL, 'Máquina de lavar roupas com capacidade de 10 kg.', NULL, NULL, NULL, NULL, NULL, 1, 1, 11, 21, 1, 6),
    ('Aspirador de Pó', NULL, 'Aspirador de pó com filtro HEPA.', NULL, NULL, NULL, NULL, NULL, 1, 1, 11, 22, 1, 6),
    ('Esponja de Aço', NULL, 'Esponja de aço para remoção de sujeira difícil.', NULL, NULL, NULL, NULL, NULL, 5, 1, 11, 13, 11, 10),
    ('Limpador Multiuso', 500.00, 'Limpador multiuso para várias superfícies.', '2023-10-12', '2024-10-12', NULL, NULL, NULL, 1, 1, 11, 23, 1, 6),
    ('Pano de Chão', NULL, 'Pano de chão absorvente e resistente.', NULL, NULL, NULL, NULL, NULL, 5, 1, 11, 13, 11, 10),
    ('Detergente em Pó', 1000.00, 'Detergente em pó para lavagem de roupas.', '2023-10-13', '2024-10-13', NULL, NULL, NULL, 1, 1, 11, 13, 1, 6);

-- Categoria: Eletrônicos
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Fone de Ouvido Bluetooth', NULL, 'Fone de ouvido sem fio com cancelamento de ruído.', '2023-10-14', NULL, NULL, NULL, NULL, 1, 1, 1, 1, 1, 6),
    ('Console de Jogos', NULL, 'Console de jogos de última geração.', '2023-10-15', NULL, NULL, NULL, NULL, 1, 1, 1, 24, 1, 6),
    ('Câmera DSLR', NULL, 'Câmera DSLR de alta resolução para fotografia profissional.', '2023-10-16', NULL, NULL, NULL, NULL, 1, 1, 1, 25, 1, 6),
    ('Forno de Micro-ondas', NULL, 'Forno de micro-ondas com capacidade de 30 litros.', '2023-10-17', NULL, NULL, NULL, NULL, 1, 1, 1, 26, 1, 6),
    ('Liquidificador', NULL, 'Liquidificador potente para preparar sucos e smoothies.', '2023-10-18', NULL, NULL, NULL, NULL, 1, 1, 1, 27, 1, 6),
    ('Cafeteira Elétrica', NULL, 'Cafeteira elétrica para preparar café fresco.', '2023-10-19', NULL, NULL, NULL, NULL, 1, 1, 1, 28, 1, 6),
    ('Mouse sem Fio', NULL, 'Mouse sem fio ergonômico para computadores.', '2023-10-20', NULL, NULL, NULL, NULL, 1, 1, 1, 29, 1, 6),
    ('Teclado Mecânico', NULL, 'Teclado mecânico para jogos e digitação.', '2023-10-21', NULL, NULL, NULL, NULL, 1, 1, 1, 30, 1, 6),
    ('Câmera de Segurança', NULL, 'Câmera de segurança Wi-Fi para monitoramento residencial.', '2023-10-22', NULL, NULL, NULL, NULL, 1, 1, 1, 31, 1, 6),
    ('Smartwatch', NULL, 'Smartwatch com monitoramento de saúde.', '2023-10-23', NULL, NULL, NULL, NULL, 1, 1, 1, 32, 1, 6);

-- Categoria: Decoração
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Tapete Felpudo', NULL, 'Tapete felpudo para sala.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Cadeira de Escritório', NULL, 'Cadeira de escritório ergonômica.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 33, 1, 6),
    ('Luminária de Mesa', NULL, 'Luminária de mesa com ajuste de intensidade.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 34, 1, 6),
    ('Almofada de Pelúcia', NULL, 'Almofada de pelúcia para decoração.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Relógio de Parede', NULL, 'Relógio de parede decorativo.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 35, 1, 6),
    ('Mesa de Centro', NULL, 'Mesa de centro moderna para sala de estar.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 36, 1, 6),
    ('Quadro Abstrato', NULL, 'Quadro abstrato para decoração.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Porta-Retrato', NULL, 'Porta-retrato elegante para fotos.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 37, 1, 6),
    ('Manta de Sofá', NULL, 'Manta de sofá para noites aconchegantes.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10),
    ('Cortina de Blackout', NULL, 'Cortina de blackout para bloquear a luz.', NULL, NULL, NULL, NULL, NULL, 1, 1, 5, 15, 11, 10);

-- Categoria: Higiene Pessoal
INSERT INTO Produto (Nome, Volume, Descricao, DataFabricacao, DataValidade, Altura, Largura, Comprimento, FK_Formato, FK_Imagem, FK_Categoria, FK_Marca, FK_Embalagem, FK_UnidadeMedida)
VALUES
    ('Sabonete em Barra', 100.00, 'Sabonete em barra com fragrância suave.', '2023-10-24', '2024-10-24', NULL, NULL, NULL, 1, 1, 12, 13, 4, 6),
    ('Creme Hidratante', 200.00, 'Creme hidratante para pele seca.', '2023-10-25', '2024-10-25', NULL, NULL, NULL, 1, 1, 12, 12, 1, 6),
    ('Papel Higiênico', NULL, 'Rolo de papel higiênico de alta qualidade.', NULL, NULL, NULL, NULL, NULL, 5, 1, 12, 5, 11, 10),
    ('Desodorante', NULL, 'Desodorante roll-on para proteção duradoura.', NULL, NULL, NULL, NULL, NULL, 6, 1, 12, 5, 11, 10),
    ('Escova de Dentes', NULL, 'Escova de dentes macia para higiene bucal.', NULL, NULL, NULL, NULL, NULL, 1, 1, 12, 5, 1, 6),
    ('Lâmina de Barbear', NULL, 'Lâmina de barbear descartável de alta qualidade.', NULL, NULL, NULL, NULL, NULL, 6, 1, 12, 2, 1, 6),
    ('Shampoo Anticaspa', 500.00, 'Shampoo anticaspa para couro cabeludo saudável.', '2023-10-26', '2024-10-26', NULL, NULL, NULL, 2, 1, 12, 3, 3, 6),
    ('Creme para Barbear', NULL, 'Creme para barbear para um barbear suave.', NULL, NULL, NULL, NULL, NULL, 1, 1, 12, 8, 1, 6),
    ('Enxaguante Bucal', 250.00, 'Enxaguante bucal para hálito fresco.', '2023-10-27', '2024-10-27', NULL, NULL, NULL, 1, 1, 12, 6, 3, 6),
    ('Algodão', NULL, 'Bolas de algodão para cuidados de beleza.', NULL, NULL, NULL, NULL, NULL, 5, 1, 12, 2, 11, 10);


	

-- Inserir Setores
INSERT INTO Setor (NomeSetor, Descricao)
VALUES
    ('Recursos Humanos', 'Setor responsável pelo gerenciamento de pessoal.'),
    ('Financeiro', 'Setor responsável pelo gerenciamento financeiro da empresa.'),
    ('Marketing', 'Setor responsável por estratégias de marketing e publicidade.'),
    ('Tecnologia da Informação', 'Setor responsável pela infraestrutura de TI e desenvolvimento de software.'),
    ('Vendas', 'Setor responsável pela venda de produtos e serviços.'),
    ('Logística', 'Setor responsável pelo gerenciamento de estoque e distribuição.'),
    ('Produção', 'Setor responsável pela fabricação de produtos.'),
    ('Qualidade', 'Setor responsável pelo controle de qualidade dos produtos.'),
    ('Atendimento ao Cliente', 'Setor responsável pelo suporte e atendimento aos clientes.'),
    ('Administração', 'Setor de administração geral da empresa.');

-- Inserir Cargos
-- Recursos Humanos
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Gerente de RH', 1, 'Gerente do departamento de Recursos Humanos.'),
    ('Analista de RH', 1, 'Analista de Recursos Humanos responsável por recrutamento e seleção.'),
    ('Assistente de RH', 1, 'Assistente do departamento de Recursos Humanos.');

-- Financeiro
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor Financeiro', 2, 'Diretor do departamento financeiro.'),
    ('Contador', 2, 'Contador responsável pela contabilidade da empresa.'),
    ('Analista Financeiro', 2, 'Analista financeiro responsável pelo controle de despesas.');

-- Marketing
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de Marketing', 3, 'Diretor do departamento de Marketing.'),
    ('Especialista em SEO', 3, 'Especialista em otimização de mecanismos de busca.'),
    ('Gerente de Conteúdo', 3, 'Gerente de conteúdo de marketing online.');

-- Tecnologia da Informação
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de TI', 4, 'Diretor do departamento de Tecnologia da Informação.'),
    ('Desenvolvedor de Software', 4, 'Desenvolvedor de software responsável por programação.'),
    ('Administrador de Rede', 4, 'Administrador de rede de computadores.');

-- Vendas
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de Vendas', 5, 'Diretor do departamento de Vendas.'),
    ('Representante de Vendas', 5, 'Representante de vendas para clientes corporativos.'),
    ('Vendedor de Varejo', 5, 'Vendedor responsável pelo atendimento a clientes em lojas físicas.');

-- Logística
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de Logística', 6, 'Diretor do departamento de Logística.'),
    ('Coordenador de Estoque', 6, 'Coordenador de estoque e distribuição de produtos.'),
    ('Motorista de Entrega', 6, 'Motorista responsável pela entrega de produtos.');

-- Produção
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de Produção', 7, 'Diretor do departamento de Produção.'),
    ('Supervisor de Linha de Produção', 7, 'Supervisor da linha de produção de produtos.'),
    ('Operador de Máquina', 7, 'Operador de máquinas na linha de produção.');

-- Qualidade
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de Controle de Qualidade', 8, 'Diretor do departamento de Controle de Qualidade.'),
    ('Técnico de Controle de Qualidade', 8, 'Técnico responsável pelo controle de qualidade dos produtos.'),
    ('Auditor de Qualidade', 8, 'Auditor de qualidade para inspeção de produtos.');

-- Atendimento ao Cliente
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('Diretor de Atendimento ao Cliente', 9, 'Diretor do departamento de Atendimento ao Cliente.'),
    ('Especialista em Suporte Técnico', 9, 'Especialista em suporte técnico para clientes.'),
    ('Atendente de SAC', 9, 'Atendente de Serviço de Atendimento ao Cliente.');

-- Administração
INSERT INTO Cargo (NomeCargo, FK_Setor, Descricao)
VALUES
    ('CEO', 10, 'CEO da empresa.'),
    ('COO', 10, 'COO da empresa, responsável pelas operações.'),
    ('CFO', 10, 'CFO da empresa, responsável pelas finanças.');



	-- Insert para status de produto "Compra"
INSERT INTO StatusProduto (Definicao, Descricao)
VALUES ('Compra', 'Produto adquirido por meio de compra.');

-- Insert para status de produto "Devolução"
INSERT INTO StatusProduto (Definicao, Descricao)
VALUES ('Devolução', 'Produto devolvido ao estoque.');

-- Insert para status de produto "Doação"



-- Outros inserts para status de produto podem ser adicionados conforme necessário.


-- Usuario
INSERT INTO Usuario (NomeCompleto, NomeAbreviado, FK_Setor, Email, Senha, DataCadastro, FK_Cargo, FK_Imagem, Ativo)
VALUES ('Admin', 'Adm', 1, 'adm@teste.com', '123456', '01/01/2020', 1, 1, 1);



-- Inserir Fornecedores
INSERT INTO Fornecedor (RazaoSocial, NomeFantasia, CNPJ, Email, Telefone, Endereco, Cidade, Estado, CEP, Observacoes)
VALUES
    ('Companhia Alimentícia S.A.', 'AlimentaMais', '12345678000100', 'contato@alimentamais.com', '(11) 1234-5678', 'Rua dos Alimentos, 123', 'São Paulo', 'SP', '12345678', 'Fornecedor de alimentos.'),
    ('Produtos de Limpeza Ltda.', 'LimpaTudo', '98765432000100', 'contato@limpatudo.com', '(21) 9876-5432', 'Avenida da Limpeza, 456', 'Rio de Janeiro', 'RJ', '98765432', 'Fornecedor de produtos de limpeza.'),
    ('Eletrônicos Express EIRELI', 'EletroRápido', '11122233344455', 'contato@eletrorapido.com', '(31) 1111-2222', 'Rua dos Gadgets, 789', 'Belo Horizonte', 'MG', '11122333', 'Fornecedor de eletrônicos.'),
    ('Higiene Pessoal Master Ltda.', 'HigieneTop', '55544433322211', 'contato@higienetop.com', '(41) 5555-4444', 'Avenida da Higiene, 101', 'Curitiba', 'PR', '55544333', 'Fornecedor de produtos de higiene pessoal.'),
    ('Distribuidora de Alimentos Premium S.A.', 'SaborSupremo', '77766655544433', 'contato@saborsupremo.com', '(51) 7777-6666', 'Rua das Delícias, 202', 'Porto Alegre', 'RS', '77766555', 'Fornecedor de alimentos.'),
    ('Tecnologia de Ponta EIRELI', 'TechInova', '99988877766655', 'contato@techinova.com', '(61) 9999-8888', 'Avenida da Tecnologia, 303', 'Brasília', 'DF', '99988777', 'Fornecedor de eletrônicos.'),
    ('Soluções de Limpeza Ltda.', 'LimpaFácil', '22233344455566', 'contato@limpafacil.com', '(71) 2222-3333', 'Rua da Solução, 404', 'Salvador', 'BA', '22233444', 'Fornecedor de produtos de limpeza.'),
    ('Distribuidora de Alimentos Gourmet S.A.', 'GourmetEats', '66677788899900', 'contato@gourmets.com', '(81) 6666-7777', 'Avenida dos Sabores, 505', 'Recife', 'PE', '66677888', 'Fornecedor de alimentos.'),
    ('Higiene Pessoal Essencial EIRELI', 'EssencialClean', '44455566677788', 'contato@essencialclean.com', '(91) 4444-5555', 'Rua da Essência, 606', 'Belém', 'PA', '44455666', 'Fornecedor de produtos de higiene pessoal.'),
    ('Eletrônicos Premium Ltda.', 'PremiumTech', '88899900011122', 'contato@premiumtech.com', '(99) 8888-9999', 'Avenida Premium, 707', 'Manaus', 'AM', '88899000', 'Fornecedor de eletrônicos.');
