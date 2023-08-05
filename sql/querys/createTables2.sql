CREATE TABLE Formato (
   PK_Formato INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(40),
   Descricao VARCHAR(100) NULL
);

CREATE TABLE Imagem (
   PK_Imagem INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(30) null,
   Formato VARCHAR(5) null,
   ImgBinary VARBINARY(MAX)
);


CREATE TABLE Categoria (
   PK_Categoria INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(50),
   Descricao VARCHAR(100) NULL
);

CREATE TABLE Marca (
   PK_Marca INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(40),
   Descricao VARCHAR(100) NULL
);

CREATE TABLE Embalagem (
   PK_Embalagem INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(40),
   Descricao VARCHAR(100) NULL
);


CREATE TABLE UnidadeMedida (
   PK_UnidadeMedida INT IDENTITY(1, 1) PRIMARY KEY,
   Sigla VARCHAR(5),
   Extenso VARCHAR(20)
);


CREATE TABLE Produto (
   PK_Produto INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(45),
   Volume DECIMAL(10, 2) NULL,
   Descricao VARCHAR(100) NULL,

   DataFabricacao DateTime NULL,
   DataValidade DateTime NULL,

   Altura DECIMAL(10, 2) NULL,
   Largura DECIMAL(10, 2) NULL,
   Comprimento DECIMAL(10, 2) NULL,

   FK_Formato INT,
   FK_Imagem INT,
   FK_Categoria INT,
   FK_Marca INT,
   FK_Embalagem INT,
   FK_UnidadeMedida INT,

   FOREIGN KEY (FK_Formato) REFERENCES Formato (PK_Formato),
   FOREIGN KEY (FK_Imagem) REFERENCES Imagem (PK_Imagem),
   FOREIGN KEY (FK_Categoria) REFERENCES Categoria (PK_Categoria),
   FOREIGN KEY (FK_Marca) REFERENCES Marca (PK_Marca),
   FOREIGN KEY (FK_Embalagem) REFERENCES Embalagem (PK_Embalagem),
   FOREIGN KEY (FK_UnidadeMedida) REFERENCES UnidadeMedida (PK_UnidadeMedida)
);