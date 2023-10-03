CREATE TABLE ConfigColunasProduto (
	PK_ConfigColunasProduto INT IDENTITY(1, 1) PRIMARY KEY,
	FK_Usuario INT NOT NULL,
	Nome bit NOT NULL,
	Volume bit NOT NULL,
	Descricao bit NOT NULL,
	Altura bit NOT NULL,
	Largura bit NOT NULL,
	Comprimento bit NOT NULL,
	Formato bit NOT NULL,
	Imagem bit NOT NULL,
	Categoria bit NOT NULL,
	Marca bit NOT NULL,
	Embalagem bit NOT NULL,
	UnidadeMedida bit NOT NULL,

	FOREIGN KEY (FK_Usuario) REFERENCES Usuario (PK_Usuario),
);



