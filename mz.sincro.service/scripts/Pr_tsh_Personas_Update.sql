SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



ALTER   PROCEDURE Pr_tsh_Personas_Update
	@IdPersona varchar(20),
	@Nombre varchar(50),
	@Comentarios varchar(100),
	@Telefonos varchar(100),
	@Email varchar(100),
	@InstantMesseger varchar(100),
	@Observaciones varchar(1000),
	@Activo bit,
	@UltimaModificacion timestamp OUTPUT,
	@IdConexionUltimaModificacion bigint,
	@IdReservado bigint,
	@IdTratamiento bigint,
	@IdEmpresa bigint,
	@IdSucursal bigint,
	@OldIdPersona varchar (20)
as
DECLARE @Sentencia Varchar(8000);
DECLARE @NewRowID uniqueidentifier;

select @NewRowId = Newid();

UPDATE [tsh_Personas]
SET
	[IdPersona] = @IdPersona,
	[Nombre] = @Nombre,
	[Comentarios] = @Comentarios,
	[Telefonos] = @Telefonos,
	[Email] = @Email,
	[InstantMesseger] = @InstantMesseger,
	[Observaciones] = @Observaciones,
	[Activo] = @Activo,
	[IdConexionUltimaModificacion] = @IdConexionUltimaModificacion,
	[IdReservado] = @IdReservado,
	[IdTratamiento] = @IdTratamiento,
	[IdEmpresa] = @IdEmpresa,
	[IdSucursal] = @IdSucursal
WHERE
	[IdPersona] = @OldIdPersona
	AND [UltimaModificacion] = @UltimaModificacion
	
SELECT
	@UltimaModificacion = [UltimaModificacion],
	@NewRowId = [RowId]

FROM	[tsh_Personas]
WHERE
	[IdPersona] = @IdPersona

Set @Sentencia = 
'UPDATE [tsh_Personas]
SET [IdPersona] = '''+CAST(@IdPersona as Varchar(200)) + ''', [Nombre] = '''+CAST(@Nombre as Varchar(200)) + ''', [Comentarios] =  '''+CAST(@Comentarios as Varchar(200)) + ''', [Telefonos] = '''+CAST(@Telefonos as Varchar(200)) + ''', [Email] = '''+CAST(@Email as Varchar(200)) + ''', [InstantMesseger] = '''+CAST(@InstantMesseger as Varchar(200)) + ''', [Observaciones] = '''+CAST(@Observaciones as Varchar(200)) + ''', [Activo] = '''+CAST(@Activo as Varchar(200)) + ''', [IdConexionUltimaModificacion] = '+CAST(@IdConexionUltimaModificacion as Varchar(200)) + ', [IdReservado] = '+CAST(@IdReservado as Varchar(200)) + ', [IdTratamiento] = '+CAST(@IdTratamiento as Varchar(200)) + ', [IdEmpresa] = '+CAST(@IdEmpresa as Varchar(200)) + ', [IdSucursal] = '+CAST(@IdSucursal as Varchar(200)) + ' WHERE [RowId] = '''+CAST(@NewRowId as Varchar(200)) +'''';


INSERT INTO sy_SentenciasReplicacion (
	[IdTabla], 
	[IdTipoSentencia], 
	[Sentencia], 
	[FechaCreacion], 
	[IdConexionCreacion],
	[SentenciaRowId]
) VALUES (
	'TSH_PERSONAS',
	'UPDATE',
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

