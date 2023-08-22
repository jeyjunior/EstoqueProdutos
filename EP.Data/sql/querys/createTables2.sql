CREATE TABLE Formato (
   PK_Formato INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(40),
   Descricao VARCHAR(100) NULL
);

CREATE TABLE Imagem (
   PK_Imagem INT IDENTITY(1, 1) PRIMARY KEY,
   Nome VARCHAR(30),
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
   Nome VARCHAR(45) NOT NULL,
   Volume DECIMAL(10, 2) NULL,
   Descricao VARCHAR(100) NULL,

   DataFabricacao DateTime NULL,
   DataValidade DateTime NULL,

   Altura DECIMAL(10, 2) NULL,
   Largura DECIMAL(10, 2) NULL,
   Comprimento DECIMAL(10, 2) NULL,

   FK_Formato INT NULL,
   FK_Imagem INT NULL,
   FK_Categoria INT NULL,
   FK_Marca INT NULL,
   FK_Embalagem INT NULL,
   FK_UnidadeMedida INT NULL,

   FOREIGN KEY (FK_Formato) REFERENCES Formato (PK_Formato),
   FOREIGN KEY (FK_Imagem) REFERENCES Imagem (PK_Imagem),
   FOREIGN KEY (FK_Categoria) REFERENCES Categoria (PK_Categoria),
   FOREIGN KEY (FK_Marca) REFERENCES Marca (PK_Marca),
   FOREIGN KEY (FK_Embalagem) REFERENCES Embalagem (PK_Embalagem),
   FOREIGN KEY (FK_UnidadeMedida) REFERENCES UnidadeMedida (PK_UnidadeMedida)
);

CREATE TABLE Setor (
    PK_Setor INT PRIMARY KEY IDENTITY(1, 1),
    NomeSetor VARCHAR(255) NOT NULL,
    Descricao VARCHAR(1000) NULL
);

CREATE TABLE Cargo (
    PK_Cargo INT PRIMARY KEY IDENTITY(1, 1),
    NomeCargo VARCHAR(255) NOT NULL,
    FK_Setor INT FOREIGN KEY REFERENCES Setor(PK_Setor),
    Descricao VARCHAR(1000) NULL
);

CREATE TABLE Usuario (
    PK_Usuario INT PRIMARY KEY IDENTITY(1, 1),
    ID_Usuario VARCHAR(20) NOT NULL,
    NomeCompleto VARCHAR(255) NOT NULL,
    Usuario VARCHAR(100) NOT NULL,
    FK_Setor INT FOREIGN KEY REFERENCES Setor(PK_Setor),
    Email VARCHAR(255) NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    DataCadastro DATETIME NOT NULL,
    FK_Cargo INT FOREIGN KEY REFERENCES Cargo(PK_Cargo),
    Ativo BIT NOT NULL
);

