Mudei toda a estrutura do banco de dados, agora precisamos atualizar todo o sistema:

Vou passar o que tenho com a antiga estrutura para que seja corrigido.

Esse é o banco de dados que tenho já alterado:


CREATE TABLE [TiposReceita] (
  [TipoID] int IDENTITY (1,1) NOT NULL
, [NomeTipo] nvarchar(50) NOT NULL
);
GO
CREATE TABLE [Receitas] (
  [ReceitaID] int IDENTITY (2,1) NOT NULL
, [Descricao] nvarchar(200) NOT NULL
, [Valor] numeric(18,2) NOT NULL
, [TipoID] int NOT NULL
, [DataRecebimento] datetime NULL
, [DataCadastro] datetime NULL
);
GO
CREATE TABLE [MetodosPagamento] (
  [MetodoPgtoID] int IDENTITY (1,1) NOT NULL
, [NomeMetodoPagamento] nvarchar(50) NOT NULL
);
GO
CREATE TABLE [GastosCombustivel] (
  [GastoID] int IDENTITY (1,1) NOT NULL
, [Data] datetime NOT NULL
, [Valor] numeric(18,2) NOT NULL
, [Litros] numeric(18,2) NOT NULL
, [PrecoPorLitro] numeric(18,2) NOT NULL
, [Veiculo] nvarchar(50) NOT NULL
, [DataCriacao] datetime DEFAULT ((GETDATE())) NOT NULL
);
GO
CREATE TABLE [Categorias] (
  [CategoriaID] int IDENTITY (1,1) NOT NULL
, [NomeCategoria] nvarchar(100) NOT NULL
);
GO
CREATE TABLE [Despesas] (
  [DespesaID] int IDENTITY (2,1) NOT NULL
, [Descricao] nvarchar(200) NOT NULL
, [CategoriaID] int NULL
, [MetodoPgtoID] int NULL
, [DataDaCompra] datetime DEFAULT (((GETDATE()))) NOT NULL
, [ValorDaCompra] numeric(18,2) NULL
);
GO
CREATE TABLE [Parcelas] (
  [ParcelaID] int IDENTITY (1,1) NOT NULL
, [DespesaID] int NOT NULL
, [NumeroParcela] int NOT NULL
, [ValorParcela] numeric(18,2) NOT NULL
, [DataVencimento] datetime NOT NULL
, [DataPgto] datetime NULL
, [Pago] bit DEFAULT (((0))) NOT NULL
);
GO
ALTER TABLE [TiposReceita] ADD CONSTRAINT [PK_TiposReceita] PRIMARY KEY ([TipoID]);
GO
ALTER TABLE [Receitas] ADD CONSTRAINT [PK_Receitas] PRIMARY KEY ([ReceitaID]);
GO
ALTER TABLE [MetodosPagamento] ADD CONSTRAINT [PK_MetodosPagamento] PRIMARY KEY ([MetodoPgtoID]);
GO
ALTER TABLE [GastosCombustivel] ADD CONSTRAINT [PK_GastosCombustivel] PRIMARY KEY ([GastoID]);
GO
ALTER TABLE [Categorias] ADD CONSTRAINT [PK_Categorias] PRIMARY KEY ([CategoriaID]);
GO
ALTER TABLE [Despesas] ADD CONSTRAINT [PK__Despesas_Temp__0000000000000302] PRIMARY KEY ([DespesaID]);
GO
ALTER TABLE [Parcelas] ADD CONSTRAINT [PK__Parcelas__00000000000002CD] PRIMARY KEY ([ParcelaID]);
GO
CREATE INDEX [IX_Receitas_DataRecebimento] ON [Receitas] ([DataRecebimento] ASC);
GO
CREATE INDEX [IX_GastosCombustivel_Data] ON [GastosCombustivel] ([Data] ASC);
GO
CREATE INDEX [Despesas_DataDaCompra] ON [Despesas] ([DataDaCompra] ASC);
GO
CREATE INDEX [IX_Despesas_MetodoPgtoID] ON [Despesas] ([MetodoPgtoID] ASC);
GO
CREATE INDEX [IX_Parcelas_DataVencimento] ON [Parcelas] ([DataVencimento] ASC);
GO
ALTER TABLE [Receitas] ADD CONSTRAINT [FK_Receitas_TiposReceita] FOREIGN KEY ([TipoID]) REFERENCES [TiposReceita]([TipoID]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
ALTER TABLE [Despesas] ADD CONSTRAINT [Despesas_CategoriaID] FOREIGN KEY ([CategoriaID]) REFERENCES [Categorias]([CategoriaID]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [Despesas] ADD CONSTRAINT [Despesas_MetodoPgtoIID] FOREIGN KEY ([MetodoPgtoID]) REFERENCES [MetodosPagamento]([MetodoPgtoID]) ON DELETE CASCADE ON UPDATE CASCADE;
GO
ALTER TABLE [Parcelas] ADD CONSTRAINT [Parcelas_DespesaID] FOREIGN KEY ([DespesaID]) REFERENCES [Despesas]([DespesaID]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

As classes Model: ParcelasModel


namespace Money.MODEL
{
    internal class ParcelasModel
    {
        public int ParcelaID { get; set; }
        public int DespesaID { get; set; }
        public int NumeroParcela { get; set; }
        public decimal ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public bool? Pago { get; set; }
    }
}

DespesasModel

namespace Money.MODEL
{
    public class DespesasModel
    {
        public int DespesaID { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDaCompra { get; set; }           
        public int? CategoriaID { get; set; }
        public string NomeCategoria { get; set; } // Adicionada propriedade para o nome da categoria
        public int? MetodoPgtoID { get; set; }      
        public DateTime DataCriacao { get; set; }       
    }
}

CategoriasModel

namespace Money.MODEL
{
    internal class CategoriasModel
    {
        public int CategoriaID { get; set; }
        public string NomeCategoria { get; set; }
    }
}

MetodosPagamentoModel

namespace Money.MODEL
{
    internal class MetodosPagamentoModel
    {
        public int MetodoPgtoID { get; set; }
        public string NomeMetodoPagamento { get; set; }
    }
}

ReceitasModel

namespace Money
{
    internal class ReceitasModel
    {
        public int ReceitaID { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDaReceita { get; set; }
        public DateTime DataRecebimento { get; set; }
        public int? TipoID { get; set; } // Agora aceita valores nulos       
        public string NomeTipoReceita { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}

DespesasDal


namespace Money.DAL
{
    internal class DespesasDAL
    {
        public void Salvar(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Despesas (Descricao, ValorDaCompra, DataVencimento, NumeroParcelas, " +
                             "ValorParcela, CategoriaID, MetodoPgtoID, Pago, DataCriacao, DataPgto) " +
                             "VALUES (@Descricao, @ValorDaCompra, @DataVencimento, @NumeroParcelas, " +
                             "@ValorParcela, @CategoriaID, @MetodoPgtoID, @Pago, @DataCriacao, @DataPgto)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                    cmd.Parameters.AddWithValue("@DataVencimento", despesa.DataVencimento);                    
                    cmd.Parameters.AddWithValue("@NumeroParcelas", string.IsNullOrEmpty(despesa.NumeroParcelas) ? (object)DBNull.Value : despesa.NumeroParcelas);
                    cmd.Parameters.AddWithValue("@ValorParcela", (object)despesa.ValorParcela ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pago", despesa.Pago);
                    cmd.Parameters.AddWithValue("@DataCriacao", despesa.DataCriacao);
                    if (despesa.DataPgto.HasValue)
                        cmd.Parameters.AddWithValue("@DataPgto", despesa.DataPgto.Value);
                    else
                        cmd.Parameters.AddWithValue("@DataPgto", DBNull.Value);

                    Console.WriteLine($"DAL - Pago: {despesa.Pago}, DataPgto: {despesa.DataPgto}");
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Atualizar(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Despesas SET Descricao = @Descricao, ValorDaCompra = @ValorDaCompra, " +
                             "DataVencimento = @DataVencimento, NumeroParcelas = @NumeroParcelas, " +
                             "ValorParcela = @ValorParcela, CategoriaID = @CategoriaID, MetodoPgtoID = @MetodoPgtoID, " +
                             "Pago = @Pago, DataCriacao = @DataCriacao " + // Adicionado espaço aqui
                             "WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Descricao", despesa.Descricao);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", despesa.ValorDaCompra);
                    cmd.Parameters.AddWithValue("@DataVencimento", despesa.DataVencimento);                                      
                    cmd.Parameters.AddWithValue("@NumeroParcelas", string.IsNullOrEmpty(despesa.NumeroParcelas) ? (object)DBNull.Value : despesa.NumeroParcelas);
                    cmd.Parameters.AddWithValue("@ValorParcela", (object)despesa.ValorParcela ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoriaID", (object)despesa.CategoriaID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MetodoPgtoID", (object)despesa.MetodoPgtoID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pago", despesa.Pago);
                    cmd.Parameters.AddWithValue("@DataCriacao", despesa.DataCriacao);
                    cmd.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi atualizado. Verifique se o DespesaID existe.");
                }
            }
        }
        public void AtualizarStatus(DespesasModel despesa)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Despesas SET Pago = @Pago, DataPgto = @DataPgto WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {                  
                                    
                    cmd.Parameters.AddWithValue("@Pago", despesa.Pago);
                    cmd.Parameters.AddWithValue("@DataPgto", despesa.DataPgto);
                    cmd.Parameters.AddWithValue("@DespesaID", despesa.DespesaID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi atualizado. Verifique se o DespesaID existe.");
                }
            }
        }
        public void Excluir(int despesaId)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Despesas WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", despesaId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("Nenhum registro foi excluído. Verifique se o DespesaID existe.");
                }
            }
        }

        public List<DespesasModel> Pesquisar(string descricao = null, bool? pago = null)
        {
            var lista = new List<DespesasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = @"SELECT 
                        d.DespesaID, 
                        d.Descricao,  
                        d.ValorDaCompra,
                        d.DataVencimento,                         
                        d.NumeroParcelas, 
                        d.ValorParcela, 
                        d.CategoriaID, 
                        c.NomeCategoria AS NomeCategoria,  -- Ajustado para o nome correto
                        d.MetodoPgtoID, 
                        d.Pago, 
                        d.DataCriacao, 
                        d.DataPgto 
                      FROM Despesas d
                      LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
                var conditions = new List<string>();

                // Filtro de pagamento
                if (pago.HasValue)
                {
                    conditions.Add("d.Pago = @Pago");
                }

                // Filtro de descrição
                if (!string.IsNullOrEmpty(descricao))
                {
                    conditions.Add("d.Descricao LIKE @Descricao");
                }

                // Combinar condições, se existirem
                if (conditions.Count > 0)
                {
                    sql += " WHERE " + string.Join(" AND ", conditions);
                }

                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (pago.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@Pago", pago.Value);
                    }
                    if (!string.IsNullOrEmpty(descricao))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                ValorDaCompra = reader.GetDecimal(2),
                                DataVencimento = reader.GetDateTime(3),                                                             
                                NumeroParcelas = reader.IsDBNull(4) ? null : reader.GetValue(4).ToString(),
                                ValorParcela = reader.IsDBNull(5) ? null : (decimal?)reader.GetDecimal(5),
                                CategoriaID = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6),
                                NomeCategoria = reader.IsDBNull(7) ? null : reader.GetString(7),
                                MetodoPgtoID = reader.IsDBNull(8) ? null : (int?)reader.GetInt32(8),
                                Pago = reader.GetBoolean(9),
                                DataCriacao = reader.GetDateTime(10),
                                DataPgto = reader.IsDBNull(11) ? null : (DateTime?)reader.GetDateTime(11)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public List<DespesasModel> PesquisarRelatorios(string descricao = null)
        {
            var lista = new List<DespesasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT d.DespesaID, d.Descricao, d.DataVencimento," +
                             "d.NumeroParcelas, d.ValorParcela, d.CategoriaID, d.MetodoPgtoID, " +
                             "d.Pago, d.DataCriacao, d.DataPgto, d.ValorDaCompra, c.NomeCategoria " +
                             "FROM Despesas d LEFT JOIN Categorias c ON d.CategoriaID = c.CategoriaID";
                if (!string.IsNullOrEmpty(descricao))
                    sql += " WHERE d.Descricao LIKE @Descricao";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (!string.IsNullOrEmpty(descricao))
                        cmd.Parameters.AddWithValue("@Descricao", "%" + descricao + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new DespesasModel
                            {
                                DespesaID = reader.GetInt32(0),       // Índice 0
                                Descricao = reader.GetString(1),      // Índice 1
                                DataVencimento = (DateTime)(reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2)), // Índice 2                               
                                NumeroParcelas = reader.IsDBNull(3) ? null : reader.GetValue(4).ToString(), // Índice 4
                                ValorParcela = reader.IsDBNull(4) ? null : (decimal?)reader.GetDecimal(4), // Índice 5
                                CategoriaID = reader.IsDBNull(5) ? null : (int?)reader.GetInt32(5), // Índice 6
                                MetodoPgtoID = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6), // Índice 7
                                Pago = reader.GetBoolean(7),          // Índice 8
                                DataCriacao = reader.GetDateTime(8),  // Índice 9
                                DataPgto = reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(10), // Índice 10
                                ValorDaCompra = reader.IsDBNull(10) ? 0m : reader.GetDecimal(10), // Índice 11
                                NomeCategoria = reader.IsDBNull(11) ? null : reader.GetString(11) // Índice 12
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}

ParcelasDal

namespace Money.DAL
{
    internal class ParcelasDAL
    {
        public void Salvar(ParcelasModel parcela)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "INSERT INTO Parcelas (DespesaID, NumeroParcela, ValorParcela, DataVencimento, Status) " +
                             "VALUES (@DespesaID, @NumeroParcela, @ValorParcela, @DataVencimento, @Status)";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@DespesaID", parcela.DespesaID);
                    cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
                    cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@Status", parcela.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(ParcelasModel parcela)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "UPDATE Parcelas SET DespesaID = @DespesaID, NumeroParcela = @NumeroParcela, " +
                             "ValorParcela = @ValorParcela, DataVencimento = @DataVencimento, Status = @Status " +
                             "WHERE ParcelaID = @ParcelaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ParcelaID", parcela.ParcelaID);
                    cmd.Parameters.AddWithValue("@DespesaID", parcela.DespesaID);
                    cmd.Parameters.AddWithValue("@NumeroParcela", parcela.NumeroParcela);
                    cmd.Parameters.AddWithValue("@ValorParcela", parcela.ValorParcela);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@Status", parcela.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int parcelaID)
        {
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "DELETE FROM Parcelas WHERE ParcelaID = @ParcelaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ParcelaID", parcelaID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ParcelasModel> Pesquisar(int? despesaID = null)
        {
            var lista = new List<ParcelasModel>();
            using (var conn = Conexao.Conex())
            {
                conn.Open();
                string sql = "SELECT * FROM Parcelas";
                if (despesaID.HasValue)
                    sql += " WHERE DespesaID = @DespesaID";
                using (var cmd = new SqlCeCommand(sql, conn))
                {
                    if (despesaID.HasValue)
                        cmd.Parameters.AddWithValue("@DespesaID", despesaID.Value);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ParcelasModel
                            {
                                ParcelaID = reader.GetInt32(0),
                                DespesaID = reader.GetInt32(1),
                                NumeroParcela = reader.GetInt32(2),
                                ValorParcela = reader.GetDecimal(3),
                                DataVencimento = reader.GetDateTime(4),
                                Status = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
