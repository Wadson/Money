/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     12/12/2024 17:16:02                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('contasreceber') and o.name = 'fk_contasre_reference_formapgt')
alter table contasreceber
   drop constraint fk_contasre_reference_formapgt
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('contasreceber') and o.name = 'fk_contasre_reference_parcelas')
alter table contasreceber
   drop constraint fk_contasre_reference_parcelas
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('contas_a_pagar') and o.name = 'fk_contas_a_reference_categori')
alter table contas_a_pagar
   drop constraint fk_contas_a_reference_categori
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('contas_a_pagar') and o.name = 'fk_contas_a_reference_forneced')
alter table contas_a_pagar
   drop constraint fk_contas_a_reference_forneced
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('contas_a_pagar') and o.name = 'fk_contas_a_reference_subcateg')
alter table contas_a_pagar
   drop constraint fk_contas_a_reference_subcateg
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('contas_a_pagar') and o.name = 'fk_contas_a_reference_formapgt')
alter table contas_a_pagar
   drop constraint fk_contas_a_reference_formapgt
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('itensvenda') and o.name = 'fk_itensven_reference_produto')
alter table itensvenda
   drop constraint fk_itensven_reference_produto
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('registropagamento') and o.name = 'fk_registro_reference_formapgt')
alter table registropagamento
   drop constraint fk_registro_reference_formapgt
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('registropagamento') and o.name = 'fk_registro_reference_contasre')
alter table registropagamento
   drop constraint fk_registro_reference_contasre
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('subcategoria') and o.name = 'fk_subcateg_reference_categori')
alter table subcategoria
   drop constraint fk_subcateg_reference_categori
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('venda') and o.name = 'fk_venda_reference_cliente')
alter table venda
   drop constraint fk_venda_reference_cliente
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('venda') and o.name = 'fk_venda_reference_itensven')
alter table venda
   drop constraint fk_venda_reference_itensven
go

if exists (select 1
            from  sysobjects
           where  id = object_id('categoria')
            and   type = 'U')
   drop table categoria
go

if exists (select 1
            from  sysobjects
           where  id = object_id('cliente')
            and   type = 'U')
   drop table cliente
go

if exists (select 1
            from  sysobjects
           where  id = object_id('contasreceber')
            and   type = 'U')
   drop table contasreceber
go

if exists (select 1
            from  sysobjects
           where  id = object_id('contas_a_pagar')
            and   type = 'U')
   drop table contas_a_pagar
go

if exists (select 1
            from  sysobjects
           where  id = object_id('formapgto')
            and   type = 'U')
   drop table formapgto
go

if exists (select 1
            from  sysobjects
           where  id = object_id('fornecedor')
            and   type = 'U')
   drop table fornecedor
go

if exists (select 1
            from  sysobjects
           where  id = object_id('itensvenda')
            and   type = 'U')
   drop table itensvenda
go

if exists (select 1
            from  sysobjects
           where  id = object_id('parcelas')
            and   type = 'U')
   drop table parcelas
go

if exists (select 1
            from  sysobjects
           where  id = object_id('produto')
            and   type = 'U')
   drop table produto
go

if exists (select 1
            from  sysobjects
           where  id = object_id('registropagamento')
            and   type = 'U')
   drop table registropagamento
go

if exists (select 1
            from  sysobjects
           where  id = object_id('subcategoria')
            and   type = 'U')
   drop table subcategoria
go

if exists (select 1
            from  sysobjects
           where  id = object_id('usuario')
            and   type = 'U')
   drop table usuario
go

if exists (select 1
            from  sysobjects
           where  id = object_id('venda')
            and   type = 'U')
   drop table venda
go

/*==============================================================*/
/* Table: categoria                                             */
/*==============================================================*/
create table categoria (
   id_categoria         int                  not null,
   nome_categoria       varchar(1)           null,
   constraint pk_categoria primary key (id_categoria)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('categoria') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'categoria' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Categoria', 
   'schema', @currentuser, 'table', 'categoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('categoria')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_categoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'categoria', 'column', 'id_categoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Categoria',
   'schema', @currentuser, 'table', 'categoria', 'column', 'id_categoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('categoria')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nome_categoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'categoria', 'column', 'nome_categoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nome_Categoria',
   'schema', @currentuser, 'table', 'categoria', 'column', 'nome_categoria'
go

/*==============================================================*/
/* Table: cliente                                               */
/*==============================================================*/
create table cliente (
   id_cliente           int                  not null,
   nome_cliente         varchar(1)           null,
   dtcadastro_cliente   varchar(1)           null,
   fone_cliente         varchar(1)           null,
   endereco_cliente     varchar(1)           null,
   bairro_cliente       varchar(1)           null,
   cidade_cliente       varchar(1)           null,
   estado_cliente       varchar(1)           null,
   constraint pk_cliente primary key (id_cliente)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('cliente') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'cliente' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Cliente', 
   'schema', @currentuser, 'table', 'cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'id_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'id_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nome_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'nome_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nome_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'nome_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dtcadastro_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'dtcadastro_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DTCadastro_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'dtcadastro_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'fone_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'fone_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Fone_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'fone_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'endereco_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'endereco_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Endereco_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'endereco_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'bairro_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'bairro_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Bairro_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'bairro_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'cidade_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'cidade_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Cidade_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'cidade_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('cliente')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'estado_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'cliente', 'column', 'estado_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Estado_Cliente',
   'schema', @currentuser, 'table', 'cliente', 'column', 'estado_cliente'
go

/*==============================================================*/
/* Table: contasreceber                                         */
/*==============================================================*/
create table contasreceber (
   id_contasreceber     int                  not null,
   id_parcela           int                  null,
   valor_parcela        decimal              null,
   id_formapgto         int                  null,
   constraint pk_contasreceber primary key (id_contasreceber)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('contasreceber') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'contasreceber' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ContasReceber', 
   'schema', @currentuser, 'table', 'contasreceber'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contasreceber')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_contasreceber')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'id_contasreceber'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ContasReceber',
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'id_contasreceber'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contasreceber')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'id_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Parcela',
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'id_parcela'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contasreceber')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'valor_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'valor_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Valor_Parcela',
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'valor_parcela'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contasreceber')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_formapgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'id_formapgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_FormaPgto',
   'schema', @currentuser, 'table', 'contasreceber', 'column', 'id_formapgto'
go

/*==============================================================*/
/* Table: contas_a_pagar                                        */
/*==============================================================*/
create table contas_a_pagar (
   id_contasapagar      int                  not null,
   dt_cadastro          datetime             null,
   id_fornecedor        int                  null,
   id_categoria         int                  null,
   id_subcategoria      int                  null,
   id_formapgto         int                  null,
   descricao_conta      varchar(1)           null,
   constraint pk_contas_a_pagar primary key (id_contasapagar)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('contas_a_pagar') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'contas_a_pagar' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Contas_A_Pagar', 
   'schema', @currentuser, 'table', 'contas_a_pagar'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_contasapagar')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_contasapagar'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ContasAPagar',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_contasapagar'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dt_cadastro')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'dt_cadastro'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DT_Cadastro',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'dt_cadastro'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_fornecedor')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_fornecedor'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Fornecedor',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_fornecedor'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_categoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_categoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Categoria',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_categoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_subcategoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_subcategoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_SubCategoria',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_subcategoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_formapgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_formapgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_FormaPgto',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'id_formapgto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('contas_a_pagar')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'descricao_conta')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'descricao_conta'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Descricao_Conta',
   'schema', @currentuser, 'table', 'contas_a_pagar', 'column', 'descricao_conta'
go

/*==============================================================*/
/* Table: formapgto                                             */
/*==============================================================*/
create table formapgto (
   id_formapgto         int                  not null,
   formapgto            varchar(1)           null,
   constraint pk_formapgto primary key (id_formapgto)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('formapgto') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'formapgto' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'FormaPgto', 
   'schema', @currentuser, 'table', 'formapgto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('formapgto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_formapgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'formapgto', 'column', 'id_formapgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_FormaPgto',
   'schema', @currentuser, 'table', 'formapgto', 'column', 'id_formapgto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('formapgto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'formapgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'formapgto', 'column', 'formapgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'FormaPgto',
   'schema', @currentuser, 'table', 'formapgto', 'column', 'formapgto'
go

/*==============================================================*/
/* Table: fornecedor                                            */
/*==============================================================*/
create table fornecedor (
   id_fornecedor        int                  not null,
   nome_fornecedor      varchar>             null,
   endere_fornecedor    varchar(1)           null,
   constraint pk_fornecedor primary key (id_fornecedor)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('fornecedor') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'fornecedor' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Fornecedor', 
   'schema', @currentuser, 'table', 'fornecedor'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('fornecedor')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_fornecedor')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'fornecedor', 'column', 'id_fornecedor'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Fornecedor',
   'schema', @currentuser, 'table', 'fornecedor', 'column', 'id_fornecedor'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('fornecedor')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nome_fornecedor')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'fornecedor', 'column', 'nome_fornecedor'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nome_Fornecedor',
   'schema', @currentuser, 'table', 'fornecedor', 'column', 'nome_fornecedor'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('fornecedor')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'endere_fornecedor')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'fornecedor', 'column', 'endere_fornecedor'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Endere_Fornecedor',
   'schema', @currentuser, 'table', 'fornecedor', 'column', 'endere_fornecedor'
go

/*==============================================================*/
/* Table: itensvenda                                            */
/*==============================================================*/
create table itensvenda (
   id_itensvenda        int                  not null,
   id_produto           int                  null,
   qtd_produto          image                null,
   valor_produto        decimal              null,
   constraint pk_itensvenda primary key (id_itensvenda)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('itensvenda') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'itensvenda' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'ItensVenda', 
   'schema', @currentuser, 'table', 'itensvenda'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('itensvenda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_itensvenda')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'id_itensvenda'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ItensVenda',
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'id_itensvenda'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('itensvenda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'id_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Produto',
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'id_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('itensvenda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'qtd_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'qtd_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'QTD_Produto',
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'qtd_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('itensvenda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'valor_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'valor_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Valor_Produto',
   'schema', @currentuser, 'table', 'itensvenda', 'column', 'valor_produto'
go

/*==============================================================*/
/* Table: parcelas                                              */
/*==============================================================*/
create table parcelas (
   id_parcela           int                  not null,
   valor_parcela        decimal              null,
   num_parcela          int                  null,
   dt_vcto_parcela      date                 null,
   status_parcela       char                 null,
   constraint pk_parcelas primary key (id_parcela)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('parcelas') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'parcelas' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Parcelas', 
   'schema', @currentuser, 'table', 'parcelas'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('parcelas')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'parcelas', 'column', 'id_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Parcela',
   'schema', @currentuser, 'table', 'parcelas', 'column', 'id_parcela'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('parcelas')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'valor_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'parcelas', 'column', 'valor_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Valor_Parcela',
   'schema', @currentuser, 'table', 'parcelas', 'column', 'valor_parcela'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('parcelas')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'num_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'parcelas', 'column', 'num_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Num_Parcela',
   'schema', @currentuser, 'table', 'parcelas', 'column', 'num_parcela'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('parcelas')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dt_vcto_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'parcelas', 'column', 'dt_vcto_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DT_Vcto_Parcela',
   'schema', @currentuser, 'table', 'parcelas', 'column', 'dt_vcto_parcela'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('parcelas')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'status_parcela')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'parcelas', 'column', 'status_parcela'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Status_Parcela',
   'schema', @currentuser, 'table', 'parcelas', 'column', 'status_parcela'
go

/*==============================================================*/
/* Table: produto                                               */
/*==============================================================*/
create table produto (
   id_produto           int                  not null,
   nome_produto         varchar(1)           null,
   descricao_produto    varchar(1)           null,
   marca_produto        varchar(1)           null,
   precocusto_produto   double precision     null,
   lucro_produto        real                 null,
   precovenda_produto   double precision     null,
   constraint pk_produto primary key (id_produto)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('produto') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'produto' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Produto', 
   'schema', @currentuser, 'table', 'produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'id_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'id_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nome_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'nome_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nome_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'nome_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'descricao_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'descricao_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Descricao_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'descricao_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'marca_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'marca_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Marca_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'marca_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'precocusto_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'precocusto_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PrecoCusto_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'precocusto_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'lucro_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'lucro_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Lucro_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'lucro_produto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('produto')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'precovenda_produto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'produto', 'column', 'precovenda_produto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'PrecoVenda_Produto',
   'schema', @currentuser, 'table', 'produto', 'column', 'precovenda_produto'
go

/*==============================================================*/
/* Table: registropagamento                                     */
/*==============================================================*/
create table registropagamento (
   id_pagamento         int                  not null,
   id_contasreceber     int                  null,
   id_formapgto         int                  null,
   valor_pgto           decimal              null,
   dt_pgto              datetime             null,
   constraint pk_registropagamento primary key (id_pagamento)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('registropagamento') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'registropagamento' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'RegistroPagamento', 
   'schema', @currentuser, 'table', 'registropagamento'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('registropagamento')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_pagamento')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'id_pagamento'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Pagamento',
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'id_pagamento'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('registropagamento')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_contasreceber')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'id_contasreceber'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ContasReceber',
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'id_contasreceber'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('registropagamento')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_formapgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'id_formapgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_FormaPgto',
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'id_formapgto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('registropagamento')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'valor_pgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'valor_pgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Valor_Pgto',
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'valor_pgto'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('registropagamento')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dt_pgto')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'dt_pgto'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DT_Pgto',
   'schema', @currentuser, 'table', 'registropagamento', 'column', 'dt_pgto'
go

/*==============================================================*/
/* Table: subcategoria                                          */
/*==============================================================*/
create table subcategoria (
   id_subcategoria      int                  not null,
   nome_subcategoria    varchar(1)           null,
   id_categoria         int                  null,
   constraint pk_subcategoria primary key (id_subcategoria)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('subcategoria') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'subcategoria' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'SubCategoria', 
   'schema', @currentuser, 'table', 'subcategoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('subcategoria')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_subcategoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'subcategoria', 'column', 'id_subcategoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_SubCategoria',
   'schema', @currentuser, 'table', 'subcategoria', 'column', 'id_subcategoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('subcategoria')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nome_subcategoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'subcategoria', 'column', 'nome_subcategoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nome_SubCategoria',
   'schema', @currentuser, 'table', 'subcategoria', 'column', 'nome_subcategoria'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('subcategoria')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_categoria')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'subcategoria', 'column', 'id_categoria'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Categoria',
   'schema', @currentuser, 'table', 'subcategoria', 'column', 'id_categoria'
go

/*==============================================================*/
/* Table: usuario                                               */
/*==============================================================*/
create table usuario (
   id_usuario           numeric              not null,
   nome_usuario         varchar(1)           null,
   senha_usuario        varchar(1)           null,
   nivelacesso_usuario  varchar(1)           null,
   user_usuario         varchar(1)           null,
   email_usuario        varchar(1)           null,
   dt_nascimento        datetime             null,
   constraint pk_usuario primary key (id_usuario)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('usuario') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'usuario' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Usuario', 
   'schema', @currentuser, 'table', 'usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_usuario')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'id_usuario'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Usuario',
   'schema', @currentuser, 'table', 'usuario', 'column', 'id_usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nome_usuario')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'nome_usuario'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Nome_Usuario',
   'schema', @currentuser, 'table', 'usuario', 'column', 'nome_usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'senha_usuario')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'senha_usuario'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Senha_Usuario',
   'schema', @currentuser, 'table', 'usuario', 'column', 'senha_usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'nivelacesso_usuario')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'nivelacesso_usuario'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NivelAcesso_Usuario',
   'schema', @currentuser, 'table', 'usuario', 'column', 'nivelacesso_usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'user_usuario')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'user_usuario'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'User_Usuario',
   'schema', @currentuser, 'table', 'usuario', 'column', 'user_usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'email_usuario')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'email_usuario'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Email_Usuario',
   'schema', @currentuser, 'table', 'usuario', 'column', 'email_usuario'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('usuario')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dt_nascimento')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'usuario', 'column', 'dt_nascimento'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DT_Nascimento',
   'schema', @currentuser, 'table', 'usuario', 'column', 'dt_nascimento'
go

/*==============================================================*/
/* Table: venda                                                 */
/*==============================================================*/
create table venda (
   id_venda             int                  not null,
   dt_venda             datetime             null,
   id_cliente           int                  null,
   id_itensvenda        int                  null,
   status_venda         char(1)              null,
   constraint pk_venda primary key (id_venda)
)
go

if exists (select 1 from  sys.extended_properties
           where major_id = object_id('venda') and minor_id = 0)
begin 
   declare @currentuser sysname 
select @currentuser = user_name() 
execute sp_dropextendedproperty 'MS_Description',  
   'schema', @currentuser, 'table', 'venda' 
 
end 


select @currentuser = user_name() 
execute sp_addextendedproperty 'MS_Description',  
   'Venda', 
   'schema', @currentuser, 'table', 'venda'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('venda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_venda')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'venda', 'column', 'id_venda'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Venda',
   'schema', @currentuser, 'table', 'venda', 'column', 'id_venda'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('venda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'dt_venda')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'venda', 'column', 'dt_venda'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'DT_Venda',
   'schema', @currentuser, 'table', 'venda', 'column', 'dt_venda'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('venda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_cliente')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'venda', 'column', 'id_cliente'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_Cliente',
   'schema', @currentuser, 'table', 'venda', 'column', 'id_cliente'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('venda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'id_itensvenda')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'venda', 'column', 'id_itensvenda'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ID_ItensVenda',
   'schema', @currentuser, 'table', 'venda', 'column', 'id_itensvenda'
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('venda')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'status_venda')
)
begin
   declare @currentuser sysname
select @currentuser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'schema', @currentuser, 'table', 'venda', 'column', 'status_venda'

end


select @currentuser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Status_Venda',
   'schema', @currentuser, 'table', 'venda', 'column', 'status_venda'
go

alter table contasreceber
   add constraint fk_contasre_reference_formapgt foreign key (id_formapgto)
      references formapgto (id_formapgto)
go

alter table contasreceber
   add constraint fk_contasre_reference_parcelas foreign key (id_parcela)
      references parcelas (id_parcela)
go

alter table contas_a_pagar
   add constraint fk_contas_a_reference_categori foreign key (id_categoria)
      references categoria (id_categoria)
go

alter table contas_a_pagar
   add constraint fk_contas_a_reference_forneced foreign key (id_fornecedor)
      references fornecedor (id_fornecedor)
go

alter table contas_a_pagar
   add constraint fk_contas_a_reference_subcateg foreign key (id_subcategoria)
      references subcategoria (id_subcategoria)
go

alter table contas_a_pagar
   add constraint fk_contas_a_reference_formapgt foreign key (id_formapgto)
      references formapgto (id_formapgto)
go

alter table itensvenda
   add constraint fk_itensven_reference_produto foreign key (id_produto)
      references produto (id_produto)
go

alter table registropagamento
   add constraint fk_registro_reference_formapgt foreign key (id_formapgto)
      references formapgto (id_formapgto)
go

alter table registropagamento
   add constraint fk_registro_reference_contasre foreign key (id_contasreceber)
      references contasreceber (id_contasreceber)
go

alter table subcategoria
   add constraint fk_subcateg_reference_categori foreign key (id_categoria)
      references categoria (id_categoria)
go

alter table venda
   add constraint fk_venda_reference_cliente foreign key (id_cliente)
      references cliente (id_cliente)
go

alter table venda
   add constraint fk_venda_reference_itensven foreign key (id_itensvenda)
      references itensvenda (id_itensvenda)
go

