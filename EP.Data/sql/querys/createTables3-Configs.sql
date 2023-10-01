CREATE TABLE ConfigColunasProduto (
	PK_ConfigColunasProduto INT IDENTITY(1, 1) PRIMARY KEY,
	FK_Usuario INT NOT NULL,
	Nome bit NOT NULL,
	Volume bit NOT NULL,
	Descricao bit NOT NULL,
	DataFabricacao bit NOT NULL,
	DataValidade bit NOT NULL,
	Altura bit NOT NULL,
	Largura bit NOT NULL,
	Comprimento bit NOT NULL,
	FK_Formato bit NOT NULL,
	FK_Imagem bit NOT NULL,
	FK_Categoria bit NOT NULL,
	FK_Marca bit NOT NULL,
	FK_Embalagem bit NOT NULL,
	FK_UnidadeMedida bit NOT NULL,

	FOREIGN KEY (FK_Usuario) REFERENCES Usuario (PK_Usuario),
);


