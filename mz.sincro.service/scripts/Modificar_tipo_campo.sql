BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.sy_SentenciasReplicacion
	DROP CONSTRAINT FK_sy_SentenciasReplicacion_sy_TiposSentencias
GO
COMMIT
BEGIN TRANSACTION
ALTER TABLE dbo.sy_SentenciasReplicacion
	DROP CONSTRAINT DF_sy_SentenciasReplicacion_FechaCreacion
GO
ALTER TABLE dbo.sy_SentenciasReplicacion
	DROP CONSTRAINT DF_sy_SentenciasReplicacion_RowId
GO
CREATE TABLE dbo.Tmp_sy_SentenciasReplicacion
	(
	IdSentenciaReplicacion bigint NOT NULL IDENTITY (1, 1),
	IdTabla varchar(300) NOT NULL,
	IdTipoSentencia varchar(20) NOT NULL,
	Sentencia text NOT NULL,
	SentenciaRowId varchar(8000) NULL,
	NombreArchivo varchar(250) NULL,
	FechaCreacion datetime NOT NULL,
	IdConexionCreacion bigint NOT NULL,
	UltimaModificacion timestamp NULL,
	IdConexionUltimaModificacion bigint NULL,
	RowId uniqueidentifier NULL ROWGUIDCOL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_sy_SentenciasReplicacion ADD CONSTRAINT
	DF_sy_SentenciasReplicacion_FechaCreacion DEFAULT (getdate()) FOR FechaCreacion
GO
ALTER TABLE dbo.Tmp_sy_SentenciasReplicacion ADD CONSTRAINT
	DF_sy_SentenciasReplicacion_RowId DEFAULT (newid()) FOR RowId
GO
SET IDENTITY_INSERT dbo.Tmp_sy_SentenciasReplicacion ON
GO
IF EXISTS(SELECT * FROM dbo.sy_SentenciasReplicacion)
	 EXEC('INSERT INTO dbo.Tmp_sy_SentenciasReplicacion (IdSentenciaReplicacion, IdTabla, IdTipoSentencia, Sentencia, SentenciaRowId, NombreArchivo, FechaCreacion, IdConexionCreacion, IdConexionUltimaModificacion, RowId)
		SELECT IdSentenciaReplicacion, IdTabla, IdTipoSentencia, Sentencia, CONVERT(varchar(8000), SentenciaRowId), NombreArchivo, FechaCreacion, IdConexionCreacion, IdConexionUltimaModificacion, RowId FROM dbo.sy_SentenciasReplicacion TABLOCKX')
GO
SET IDENTITY_INSERT dbo.Tmp_sy_SentenciasReplicacion OFF
GO
DROP TABLE dbo.sy_SentenciasReplicacion
GO
EXECUTE sp_rename N'dbo.Tmp_sy_SentenciasReplicacion', N'sy_SentenciasReplicacion', 'OBJECT'
GO
ALTER TABLE dbo.sy_SentenciasReplicacion ADD CONSTRAINT
	PK_sy_SentenciasReplicacion PRIMARY KEY CLUSTERED 
	(
	IdSentenciaReplicacion
	) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX IX_sy_SentenciasReplicacion ON dbo.sy_SentenciasReplicacion
	(
	IdTabla,
	IdTipoSentencia,
	IdSentenciaReplicacion
	) ON [PRIMARY]
GO
ALTER TABLE dbo.sy_SentenciasReplicacion WITH NOCHECK ADD CONSTRAINT
	FK_sy_SentenciasReplicacion_sy_TiposSentencias FOREIGN KEY
	(
	IdTipoSentencia
	) REFERENCES dbo.sy_TiposSentencias
	(
	IdTipoSentencia
	)
GO
COMMIT
