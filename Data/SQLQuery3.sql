//Mostra o local do banco de dados
SELECT name physical_name, state, database_id FROM sys.master_files

//pausa o servi�o de banco de dados
ALTER DATABASE bdmoney SET OFFLINE

//Alterar o local do banco de dados
ALTER DATABASE bdmoney MODIFY FILE (NAME = 'bdmoney', FILENAME = 'D:\Money\Data\bdmoney.mdf')
ALTER DATABASE bdmoney MODIFY FILE (NAME = 'bdmoney_log', FILENAME = 'D:\Money\Data\bdmoney_log.ldf')