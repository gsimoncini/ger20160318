SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



ALTER  PROCEDURE Pr_tsh_Personas_Delete
	@IdPersona varchar(20), 
	@UltimaModificacion timestamp
	
AS
DECLARE @Sentencia Varchar(8000);
DECLARE @NewRowID uniqueidentifier;

DELETE FROM [tsh_Personas]
WHERE
	[IdPersona] = @IdPersona
	AND [UltimaModificacion] = @UltimaModificacion

SELECT
	@NewRowId = [RowId]
FROM	[tsh_Personas]
WHERE
	[IdPersona] = @IdPersona

Set @Sentencia = 
'DELETE FROM [tsh_Personas] WHERE [RowId] = '''+CAST(@NewRowId as Varchar(200)) + '''';


INSERT INTO sy_SentenciasReplicacion (
	[IdTabla], 
	[IdTipoSentencia], 
	[Sentencia], 
	[FechaCreacion], 
	[IdConexionCreacion],
	[SentenciaRowId]
) VALUES (
	'TSH_PERSONAS',
	'DELETE',
	@Sentencia, 
	GetDate(), 
	1,
	@NewRowId
)

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

