USE [bdmoney]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] NOT NULL,
	[nome_categoria] [nvarchar](50) NULL,
 CONSTRAINT [pk_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] NOT NULL,
	[nome_cliente] [nvarchar](50) NULL,
	[dtcadastro_cliente] [date] NULL,
	[fone_cliente] [nvarchar](50) NULL,
	[endereco_cliente] [nvarchar](50) NULL,
	[bairro_cliente] [nvarchar](50) NULL,
	[cidade_cliente] [nvarchar](50) NULL,
	[estado_cliente] [nvarchar](50) NULL,
 CONSTRAINT [pk_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contas_a_pagar]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contas_a_pagar](
	[id_contasapagar] [int] NOT NULL,
	[dt_cadastro] [datetime] NULL,
	[id_fornecedor] [int] NULL,
	[id_categoria] [int] NULL,
	[id_subcategoria] [int] NULL,
	[id_formapgto] [int] NULL,
	[descricao_conta] [nvarchar](50) NULL,
 CONSTRAINT [pk_contas_a_pagar] PRIMARY KEY CLUSTERED 
(
	[id_contasapagar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contasreceber]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contasreceber](
	[id_contasreceber] [int] NOT NULL,
	[id_parcela] [int] NULL,
	[valor_parcela] [decimal](18, 0) NULL,
	[status_conta] [bit] NOT NULL,
 CONSTRAINT [pk_contasreceber] PRIMARY KEY CLUSTERED 
(
	[id_contasreceber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formapgto]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formapgto](
	[id_formapgto] [int] NOT NULL,
	[formapgto] [nvarchar](50) NULL,
 CONSTRAINT [pk_formapgto] PRIMARY KEY CLUSTERED 
(
	[id_formapgto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fornecedor]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fornecedor](
	[id_fornecedor] [int] NOT NULL,
	[nome_fornecedor] [nvarchar](50) NULL,
	[endere_fornecedor] [nvarchar](50) NULL,
 CONSTRAINT [pk_fornecedor] PRIMARY KEY CLUSTERED 
(
	[id_fornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[itensvenda]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itensvenda](
	[id_itensvenda] [int] NOT NULL,
	[id_produto] [int] NULL,
	[qtd_produto] [int] NULL,
	[valor_produto] [decimal](18, 0) NULL,
	[id_venda] [int] NULL,
	[num_parcela] [int] NULL,
 CONSTRAINT [pk_itensvenda] PRIMARY KEY CLUSTERED 
(
	[id_itensvenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parcelas]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcelas](
	[id_parcela] [int] NOT NULL,
	[valor_parcela] [decimal](18, 0) NULL,
	[num_parcela] [int] NULL,
	[dt_vcto_parcela] [date] NULL,
	[id_venda] [int] NULL,
 CONSTRAINT [PK_parcelas] PRIMARY KEY CLUSTERED 
(
	[id_parcela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[id_produto] [int] NOT NULL,
	[nome_produto] [nvarchar](50) NULL,
	[precocusto_produto] [decimal](18, 0) NULL,
	[descricao_produto] [nvarchar](50) NULL,
	[lucro_produto] [decimal](18, 0) NULL,
	[precovenda_produto] [decimal](18, 0) NULL,
	[marca_produto] [nvarchar](50) NULL,
 CONSTRAINT [pk_produto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registropagamento]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registropagamento](
	[id_pagamento] [int] NOT NULL,
	[id_contasreceber] [int] NULL,
	[id_formapgto] [int] NULL,
	[valor_pgto] [decimal](18, 0) NULL,
	[dt_pgto] [datetime] NULL,
 CONSTRAINT [pk_registropagamento] PRIMARY KEY CLUSTERED 
(
	[id_pagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subcategoria]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subcategoria](
	[id_subcategoria] [int] NOT NULL,
	[nome_subcategoria] [nvarchar](50) NULL,
	[id_categoria] [int] NULL,
 CONSTRAINT [pk_subcategoria] PRIMARY KEY CLUSTERED 
(
	[id_subcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] NOT NULL,
	[nome] [nvarchar](50) NULL,
	[senha] [nvarchar](50) NULL,
	[nivelacesso] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[dt_nascimento] [datetime] NULL,
 CONSTRAINT [pk_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venda]    Script Date: 31/12/2024 20:18:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venda](
	[id_venda] [int] NOT NULL,
	[dt_venda] [datetime] NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [pk_venda] PRIMARY KEY CLUSTERED 
(
	[id_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[contas_a_pagar]  WITH CHECK ADD  CONSTRAINT [fk_contas_a_reference_categori] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[contas_a_pagar] CHECK CONSTRAINT [fk_contas_a_reference_categori]
GO
ALTER TABLE [dbo].[contas_a_pagar]  WITH CHECK ADD  CONSTRAINT [fk_contas_a_reference_formapgt] FOREIGN KEY([id_formapgto])
REFERENCES [dbo].[formapgto] ([id_formapgto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[contas_a_pagar] CHECK CONSTRAINT [fk_contas_a_reference_formapgt]
GO
ALTER TABLE [dbo].[contas_a_pagar]  WITH CHECK ADD  CONSTRAINT [fk_contas_a_reference_forneced] FOREIGN KEY([id_fornecedor])
REFERENCES [dbo].[fornecedor] ([id_fornecedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[contas_a_pagar] CHECK CONSTRAINT [fk_contas_a_reference_forneced]
GO
ALTER TABLE [dbo].[contas_a_pagar]  WITH CHECK ADD  CONSTRAINT [fk_contas_a_reference_subcateg] FOREIGN KEY([id_subcategoria])
REFERENCES [dbo].[subcategoria] ([id_subcategoria])
GO
ALTER TABLE [dbo].[contas_a_pagar] CHECK CONSTRAINT [fk_contas_a_reference_subcateg]
GO
ALTER TABLE [dbo].[contasreceber]  WITH CHECK ADD  CONSTRAINT [FK_contasreceber_parcelas_contasreceber] FOREIGN KEY([id_parcela])
REFERENCES [dbo].[parcelas] ([id_parcela])
GO
ALTER TABLE [dbo].[contasreceber] CHECK CONSTRAINT [FK_contasreceber_parcelas_contasreceber]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [fk_itensven_reference_produto] FOREIGN KEY([id_venda])
REFERENCES [dbo].[venda] ([id_venda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [fk_itensven_reference_produto]
GO
ALTER TABLE [dbo].[itensvenda]  WITH CHECK ADD  CONSTRAINT [FK_itensvenda_produto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[produto] ([id_produto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[itensvenda] CHECK CONSTRAINT [FK_itensvenda_produto]
GO
ALTER TABLE [dbo].[parcelas]  WITH CHECK ADD  CONSTRAINT [fk_itensven_reference_venda] FOREIGN KEY([id_venda])
REFERENCES [dbo].[venda] ([id_venda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[parcelas] CHECK CONSTRAINT [fk_itensven_reference_venda]
GO
ALTER TABLE [dbo].[registropagamento]  WITH CHECK ADD  CONSTRAINT [fk_registro_reference_contasre] FOREIGN KEY([id_contasreceber])
REFERENCES [dbo].[contasreceber] ([id_contasreceber])
GO
ALTER TABLE [dbo].[registropagamento] CHECK CONSTRAINT [fk_registro_reference_contasre]
GO
ALTER TABLE [dbo].[registropagamento]  WITH CHECK ADD  CONSTRAINT [fk_registro_reference_formapgt] FOREIGN KEY([id_formapgto])
REFERENCES [dbo].[formapgto] ([id_formapgto])
GO
ALTER TABLE [dbo].[registropagamento] CHECK CONSTRAINT [fk_registro_reference_formapgt]
GO
ALTER TABLE [dbo].[subcategoria]  WITH CHECK ADD  CONSTRAINT [fk_subcateg_reference_categori] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[subcategoria] CHECK CONSTRAINT [fk_subcateg_reference_categori]
GO
ALTER TABLE [dbo].[venda]  WITH CHECK ADD  CONSTRAINT [fk_venda_reference_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[venda] CHECK CONSTRAINT [fk_venda_reference_cliente]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'categoria', @level2type=N'COLUMN',@level2name=N'id_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome_Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'categoria', @level2type=N'COLUMN',@level2name=N'nome_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'nome_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DTCadastro_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'dtcadastro_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fone_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'fone_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Endereco_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'endereco_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bairro_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'bairro_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cidade_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'cidade_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente', @level2type=N'COLUMN',@level2name=N'estado_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_ContasAPagar' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'id_contasapagar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DT_Cadastro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'dt_cadastro'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Fornecedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'id_fornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'id_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_SubCategoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'id_subcategoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_FormaPgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'id_formapgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descricao_Conta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar', @level2type=N'COLUMN',@level2name=N'descricao_conta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contas_A_Pagar' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contas_a_pagar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_ContasReceber' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contasreceber', @level2type=N'COLUMN',@level2name=N'id_contasreceber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Parcela' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contasreceber', @level2type=N'COLUMN',@level2name=N'id_parcela'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valor_Parcela' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contasreceber', @level2type=N'COLUMN',@level2name=N'valor_parcela'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ContasReceber' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contasreceber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_FormaPgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'formapgto', @level2type=N'COLUMN',@level2name=N'id_formapgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FormaPgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'formapgto', @level2type=N'COLUMN',@level2name=N'formapgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FormaPgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'formapgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id_fornecedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'fornecedor', @level2type=N'COLUMN',@level2name=N'id_fornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome_Fornecedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'fornecedor', @level2type=N'COLUMN',@level2name=N'nome_fornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Endere_Fornecedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'fornecedor', @level2type=N'COLUMN',@level2name=N'endere_fornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fornecedor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'fornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_ItensVenda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'itensvenda', @level2type=N'COLUMN',@level2name=N'id_itensvenda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'itensvenda', @level2type=N'COLUMN',@level2name=N'id_produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'QTD_Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'itensvenda', @level2type=N'COLUMN',@level2name=N'qtd_produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valor_Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'itensvenda', @level2type=N'COLUMN',@level2name=N'valor_produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ItensVenda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'itensvenda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produto', @level2type=N'COLUMN',@level2name=N'id_produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome_Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produto', @level2type=N'COLUMN',@level2name=N'nome_produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PrecoCusto_Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produto', @level2type=N'COLUMN',@level2name=N'precocusto_produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Produto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Pagamento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'registropagamento', @level2type=N'COLUMN',@level2name=N'id_pagamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_ContasReceber' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'registropagamento', @level2type=N'COLUMN',@level2name=N'id_contasreceber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_FormaPgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'registropagamento', @level2type=N'COLUMN',@level2name=N'id_formapgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Valor_Pgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'registropagamento', @level2type=N'COLUMN',@level2name=N'valor_pgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DT_Pgto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'registropagamento', @level2type=N'COLUMN',@level2name=N'dt_pgto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'RegistroPagamento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'registropagamento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_SubCategoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'subcategoria', @level2type=N'COLUMN',@level2name=N'id_subcategoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome_SubCategoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'subcategoria', @level2type=N'COLUMN',@level2name=N'nome_subcategoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Categoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'subcategoria', @level2type=N'COLUMN',@level2name=N'id_categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SubCategoria' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'subcategoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'id_usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nome_Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'nome'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Senha_Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'senha'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'NivelAcesso_Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'nivelacesso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User_Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email_Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DT_Nascimento' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario', @level2type=N'COLUMN',@level2name=N'dt_nascimento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Venda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'venda', @level2type=N'COLUMN',@level2name=N'id_venda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'DT_Venda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'venda', @level2type=N'COLUMN',@level2name=N'dt_venda'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID_Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'venda', @level2type=N'COLUMN',@level2name=N'id_cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Venda' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'venda'
GO
