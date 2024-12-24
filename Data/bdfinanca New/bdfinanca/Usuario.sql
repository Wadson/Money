CREATE TABLE [dbo].[Usuario]
(
	[ID_Usuario] INT NOT NULL PRIMARY KEY, 
    [Nome_Usuario] NCHAR(10) NULL, 
    [DT_Nascimento_Usuario] NCHAR(10) NULL, 
    [Email_Usuario] NCHAR(10) NULL, 
    [NivelAcesso_Usuario] NCHAR(10) NULL, 
    [Senha_Usuario] NCHAR(10) NULL, 
    [Login_Usuario] NCHAR(10) NULL
)
