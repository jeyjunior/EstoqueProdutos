-- Criar o banco de dados EstoqueProdutos
--CREATE DATABASE Estoque;

-- Usar o banco de dados recém-criado
USE Estoque;

-- Agora você pode criar suas tabelas dentro do banco de dados EstoqueProdutos

-- Criação das tabelas (as tabelas que você já listou)
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
   FK_Formato INT NOT NULL,
   FK_Imagem INT NOT NULL,
   FK_Categoria INT NOT NULL,
   FK_Marca INT NOT NULL,
   FK_Embalagem INT NOT NULL,
   FK_UnidadeMedida INT NOT NULL,
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
    FK_Setor INT FOREIGN KEY REFERENCES Setor(PK_Setor) NOT NULL,
    Descricao VARCHAR(1000) NULL
);

CREATE TABLE Usuario (
    PK_Usuario INT PRIMARY KEY IDENTITY(1, 1),
    NomeCompleto VARCHAR(255) NOT NULL,
    NomeAbreviado VARCHAR(100) NOT NULL,
    FK_Setor INT FOREIGN KEY REFERENCES Setor(PK_Setor) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    DataCadastro DATETIME NOT NULL,
    FK_Cargo INT FOREIGN KEY REFERENCES Cargo(PK_Cargo) NOT NULL,
    FK_Imagem INT FOREIGN KEY REFERENCES Imagem(PK_Imagem) NOT NULL,
    Ativo BIT NOT NULL
);


CREATE TABLE StatusProduto (
    PK_StatusProduto INT PRIMARY KEY IDENTITY(1, 1),
    Definicao VARCHAR(50) NOT NULL,
    Descricao VARCHAR(100)
);

CREATE TABLE Fornecedor (
    PK_Fornecedor INT PRIMARY KEY IDENTITY(1, 1),
    RazaoSocial VARCHAR(255) NOT NULL,
    NomeFantasia VARCHAR(255),
    CNPJ VARCHAR(14) NOT NULL, -- CNPJ do fornecedor
    Email VARCHAR(100),
    Telefone VARCHAR(20),
    Endereco VARCHAR(255),
    Cidade VARCHAR(100),
    Estado VARCHAR(2),
    CEP VARCHAR(8),
    Observacoes TEXT
);

CREATE TABLE LancamentoProduto (
    PK_LancamentoProduto INT PRIMARY KEY IDENTITY(1, 1),
    DataTransacao DATETIME NOT NULL,
    DataValidade DATETIME NOT NULL,
    DataFabricacao DATETIME NOT NULL,
	Quantidade INT NOT NULL,
	PrecoUnitario DECIMAL(10,2) NOT NULL,
	NumeroNF VARCHAR(100) NOT NULL,
	NumeroLote VARCHAR(100) NOT NULL,
	AdicionadoNoEstoque BIT NOT NULL,
	Observacoes VARCHAR(255),
	FK_Fornecedor INT FOREIGN KEY REFERENCES Fornecedor(PK_Fornecedor) NOT NULL,
	FK_Produto INT FOREIGN KEY REFERENCES Produto(PK_Produto) NOT NULL,
	FK_UsuarioCompra INT FOREIGN KEY REFERENCES Usuario(PK_Usuario) NOT NULL,
	FK_UsuarioRegistro INT FOREIGN KEY REFERENCES Usuario(PK_Usuario) NOT NULL,
	FK_Status INT FOREIGN KEY REFERENCES StatusProduto(PK_StatusProduto) NOT NULL,
);

 
CREATE TABLE Estoque (
    PK_Estoque INT PRIMARY KEY IDENTITY(1, 1),
	FK_Produto INT FOREIGN KEY REFERENCES Produto(PK_Produto) NOT NULL,
	QuantidadeEmEstoque INT NOT NULL,
	Ativo BIT NOT NULL,
	Observacoes VARCHAR(255),
	FK_UsuarioResponsavel INT FOREIGN KEY REFERENCES Usuario(PK_Usuario) NOT NULL
);

