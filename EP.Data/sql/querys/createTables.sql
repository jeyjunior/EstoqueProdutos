CREATE TABLE Fornecedor (
   PK_Fornecedor INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(50),
   CNPJ VARCHAR(14),
   Endereco VARCHAR(100),
   Bairro VARCHAR(50),
   UF VARCHAR(2)
);

CREATE TABLE Categoria (
   PK_Categoria INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(50)
);

CREATE TABLE TipoEmbalagem (
   PK_TipoEmbalagem INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(40)
);

CREATE TABLE UnidadeMedida (
   PK_UnidadeMedida INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(5),
   Extenso VARCHAR(20)
);

CREATE TABLE Operadores (
   PK_Operadores INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(5),
   Extenso VARCHAR(20)
);

CREATE TABLE OperadoresEspeciais (
   PK_OperadoresEspeciais INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(20),
   Extenso VARCHAR(50)
);

CREATE TABLE Imagem (
   PK_Imagem INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(30) null,
   Formato VARCHAR(5) null,
   Imagem VARBINARY(MAX)
);

CREATE TABLE Produto (
   PK_Produto INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(45),
   Volume DECIMAL(10, 2),
   Preco DECIMAL(10, 2),
   Descricao VARCHAR(100),
   FK_Categoria INT,
   FK_Fornecedor INT,
   FK_TipoEmbalagem INT,
   FK_UnidadeMedida INT,
   FK_Imagem INT,
   FOREIGN KEY (FK_Categoria) REFERENCES Categoria (PK_Categoria),
   FOREIGN KEY (FK_Fornecedor) REFERENCES Fornecedor (PK_Fornecedor),
   FOREIGN KEY (FK_TipoEmbalagem) REFERENCES TipoEmbalagem (PK_TipoEmbalagem),
   FOREIGN KEY (FK_UnidadeMedida) REFERENCES UnidadeMedida (PK_UnidadeMedida),
   FOREIGN KEY (FK_Imagem) REFERENCES Imagem (PK_Imagem)
);

CREATE TABLE Estoque (
   PK_Estoque INT IDENTITY(100, 1) PRIMARY KEY,
   FK_Produto INT,
   Quantidade INT,
   Preco DECIMAL(10,2)

   FOREIGN KEY (FK_Produto) REFERENCES Produto (PK_Produto),
);
