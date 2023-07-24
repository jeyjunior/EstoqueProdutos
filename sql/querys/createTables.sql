CREATE TABLE Fornecedor (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(50),
   CNPJ VARCHAR(14),
   Endereco VARCHAR(100),
   Bairro VARCHAR(50),
   UF VARCHAR(2)
);

CREATE TABLE Categoria (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(50)
);

CREATE TABLE TipoEmbalagem (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(40)
);

CREATE TABLE UnidadeMedida (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(5),
   Extenso VARCHAR(20)
);

CREATE TABLE Operadores (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(5),
   Extenso VARCHAR(20)
);

CREATE TABLE OperadoresEspeciais (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(20),
   Extenso VARCHAR(50)
);

CREATE TABLE Imagens (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(30) null,
   Formato VARCHAR(5) null,
   Imagem VARBINARY(MAX)
);

CREATE TABLE Produto (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(45),
   Volume DECIMAL(10, 2),
   Preco DECIMAL(10, 2),
   Descricao VARCHAR(100),
   FK_Categoria_ID INT,
   FK_Fornecedor_ID INT,
   FK_TipoEmbalagem_ID INT,
   FK_UnidadeMedida_ID INT,
   FK_Imagem_ID INT,
   FOREIGN KEY (FK_Categoria_ID) REFERENCES Categoria (PK_ID),
   FOREIGN KEY (FK_Fornecedor_ID) REFERENCES Fornecedor (PK_ID),
   FOREIGN KEY (FK_TipoEmbalagem_ID) REFERENCES TipoEmbalagem (PK_ID),
   FOREIGN KEY (FK_UnidadeMedida_ID) REFERENCES UnidadeMedida (PK_ID),
   FOREIGN KEY (FK_Imagem_ID) REFERENCES Imagens (PK_ID)
);

CREATE TABLE Estoque (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   FK_Produto_ID INT,
   Quantidade INT,
   Preco DECIMAL(10,2)

   FOREIGN KEY (FK_Produto_ID) REFERENCES Produto (PK_ID),
);
