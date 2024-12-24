-- Script Date: 08/12/2024 18:00  - ErikEJ.SqlCeScripting version 3.5.2.95
-- Database information:
-- Locale Identifier: 1046
-- Encryption Mode: Platform Default
-- Case Sensitive: False
-- Database: C:\Money\Data\Vs 4.0\bdfinanca.sdf
-- ServerVersion: 4.0.8876.1
-- DatabaseSize: 192 KB
-- SpaceAvailable: 3,999 GB
-- Created: 04/12/2024 22:32

-- User Table information:
-- Number of tables: 14
-- categoria: 0 row(s)
-- cliente: 1 row(s)
-- contas: 0 row(s)
-- formapgto: 0 row(s)
-- fornecedor: 0 row(s)
-- itens_pedido: 0 row(s)
-- parcelas: 0 row(s)
-- pedidos: 0 row(s)
-- produto: 0 row(s)
-- receitas: 0 row(s)
-- registros_pagamentos: 0 row(s)
-- subcategoria: 0 row(s)
-- usuario: 1 row(s)
-- vendas: 0 row(s)

CREATE TABLE [vendas] (
  [ID_Venda] int IDENTITY (1,1) NOT NULL
, [Data_Venda] datetime NOT NULL
, [ID_Cliente] int NOT NULL
, [ID_Produto] int NOT NULL
, [Qtd_Vendida] int NOT NULL
);
GO
CREATE TABLE [usuario] (
  [idusuario] int NOT NULL
, [usuario] nvarchar(100) NULL
, [senha] nvarchar(100) NULL
, [nivelacesso] nvarchar(100) NULL
, [nome] nvarchar(60) NULL
, [dtnascimento] datetime NULL
);
GO
CREATE TABLE [subcategoria] (
  [idsubcategoria] int NOT NULL
, [idcategoria] int NOT NULL
, [subcategoria] nvarchar(100) NOT NULL
);
GO
CREATE TABLE [registros_pagamentos] (
  [ID_Pagamento] int IDENTITY (1,1) NOT NULL
, [ID_Pedido] int NOT NULL
, [Metodo_Pagamento] nvarchar(50) NOT NULL
, [Valor_Pagamento] real NOT NULL
, [Data_Pagamento] datetime NOT NULL
);
GO
CREATE TABLE [produto] (
  [ID_Produto] int IDENTITY (1,1) NOT NULL
, [Nome_Produto] nchar(100) NOT NULL
, [Descricao] nchar(100) NOT NULL
, [Preco] real NOT NULL
, [Categoria] nchar(100) NOT NULL
);
GO
CREATE TABLE [pedidos] (
  [ID_Pedido] int IDENTITY (1,1) NOT NULL
, [Data_Pedido] datetime NOT NULL
, [ID_Cliente] int NOT NULL
, [Status_Pedido] nchar(20) NOT NULL
);
GO
CREATE TABLE [itens_pedido] (
  [ID_Item] int IDENTITY (1,1) NOT NULL
, [ID_Pedido] int NOT NULL
, [ID_Produto] int NOT NULL
, [Quantidade] int NOT NULL
);
GO
CREATE TABLE [fornecedor] (
  [idfornecedor] int NOT NULL
, [fornecedor] nvarchar(150) NULL
, [dtcadastro] datetime NULL
);
GO
CREATE TABLE [formapgto] (
  [idformapgto] int NOT NULL
, [formapgto] nvarchar(25) NOT NULL
);
GO
CREATE TABLE [cliente] (
  [idCliente] int NOT NULL
, [nomeCliente] nvarchar(40) NULL
, [dtcadastro] datetime NULL
, [telefoneCliente] nvarchar(11) NULL
, [enderecoCliente] nvarchar(40) NULL
, [bairroCliente] nvarchar(40) NULL
, [cidadeCliente] nvarchar(40) NULL
, [estadoCliente] nvarchar(40) NULL
);
GO
CREATE TABLE [receitas] (
  [idreceitas] int IDENTITY (1,1) NOT NULL
, [datacadastro] datetime NOT NULL
, [idCliente] int NOT NULL
, [valor] money NOT NULL
, [descricao] nvarchar(100) NULL
, [dtVencimento] datetime NULL
);
GO
CREATE TABLE [categoria] (
  [idcategoria] int NOT NULL
, [categoria] nvarchar(100) NOT NULL
);
GO
CREATE TABLE [contas] (
  [idconta] int NOT NULL
, [datacadastro] datetime NOT NULL
, [idfornecedor] int NOT NULL
, [descricao] nvarchar(100) NULL
, [idcategoria] int NOT NULL
, [idsubcategoria] int NOT NULL
, [idformapgto] int NOT NULL
);
GO
CREATE TABLE [parcelas] (
  [idparcela] int NOT NULL
, [idconta] int NOT NULL
, [num_parcela] nvarchar(1000) NULL
, [valor_parc] real NULL
, [datavenc] datetime NULL
, [datapgto] datetime NULL
, [pago] bit NULL
, [valorpago] real NULL
, [formapgto] nvarchar(50) NULL
);
GO
ALTER TABLE [vendas] ADD CONSTRAINT [PK_vendas] PRIMARY KEY ([ID_Venda]);
GO
ALTER TABLE [usuario] ADD CONSTRAINT [PK_usuario] PRIMARY KEY ([idusuario]);
GO
ALTER TABLE [subcategoria] ADD CONSTRAINT [PK_subcategoria] PRIMARY KEY ([idsubcategoria]);
GO
ALTER TABLE [registros_pagamentos] ADD CONSTRAINT [PK_registros_pagamentos] PRIMARY KEY ([ID_Pagamento]);
GO
ALTER TABLE [produto] ADD CONSTRAINT [PK_produto] PRIMARY KEY ([ID_Produto]);
GO
ALTER TABLE [pedidos] ADD CONSTRAINT [PK_pedidos] PRIMARY KEY ([ID_Pedido]);
GO
ALTER TABLE [itens_pedido] ADD CONSTRAINT [PK_itens_pedido] PRIMARY KEY ([ID_Item]);
GO
ALTER TABLE [fornecedor] ADD CONSTRAINT [PK_fornecedor] PRIMARY KEY ([idfornecedor]);
GO
ALTER TABLE [formapgto] ADD CONSTRAINT [PK_formapgto] PRIMARY KEY ([idformapgto]);
GO
ALTER TABLE [cliente] ADD CONSTRAINT [PK_cliente] PRIMARY KEY ([idCliente]);
GO
ALTER TABLE [receitas] ADD CONSTRAINT [PK_receitas] PRIMARY KEY ([idreceitas]);
GO
ALTER TABLE [categoria] ADD CONSTRAINT [PK_categoria] PRIMARY KEY ([idcategoria]);
GO
ALTER TABLE [contas] ADD CONSTRAINT [PK_contas] PRIMARY KEY ([idconta]);
GO
ALTER TABLE [parcelas] ADD CONSTRAINT [PK_parcelas] PRIMARY KEY ([idparcela]);
GO
GO
SET IDENTITY_INSERT [vendas] OFF;
GO
INSERT INTO [usuario] ([idusuario],[usuario],[senha],[nivelacesso],[nome],[dtnascimento]) VALUES (
1,N'ADMIN',N'123456',N'Administrador',N'ADMIN',{ts '2010-01-01 00:00:00.000'});
GO
GO
GO
SET IDENTITY_INSERT [registros_pagamentos] OFF;
GO
GO
SET IDENTITY_INSERT [produto] OFF;
GO
GO
SET IDENTITY_INSERT [pedidos] OFF;
GO
GO
SET IDENTITY_INSERT [itens_pedido] OFF;
GO
GO
GO
INSERT INTO [cliente] ([idCliente],[nomeCliente],[dtcadastro],[telefoneCliente],[enderecoCliente],[bairroCliente],[cidadeCliente],[estadoCliente]) VALUES (
1,N'Marinalva Brandão de Sá',{ts '2024-12-08 00:00:00.000'},N'94992555628',N'RUA RIO ITACAIUNAS',N'NOVO HORIZONTE',N'XINGUARA',N'PARÁ');
GO
GO
SET IDENTITY_INSERT [receitas] OFF;
GO
GO
GO
GO
ALTER TABLE [receitas] ADD CONSTRAINT [FK_IdCliente] FOREIGN KEY ([idCliente]) REFERENCES [cliente]([idCliente]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [contas] ADD CONSTRAINT [FK_IdCategoria] FOREIGN KEY ([idcategoria]) REFERENCES [categoria]([idcategoria]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [contas] ADD CONSTRAINT [FK_IdFormaPgto] FOREIGN KEY ([idformapgto]) REFERENCES [formapgto]([idformapgto]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [contas] ADD CONSTRAINT [FK_IdFornecedor] FOREIGN KEY ([idfornecedor]) REFERENCES [fornecedor]([idfornecedor]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [contas] ADD CONSTRAINT [FK_IdSubCategoria] FOREIGN KEY ([idsubcategoria]) REFERENCES [subcategoria]([idsubcategoria]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [parcelas] ADD CONSTRAINT [FK_IdConta] FOREIGN KEY ([idconta]) REFERENCES [contas]([idconta]) ON DELETE CASCADE ON UPDATE CASCADE;
GO

