SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


ALTER       PROCEDURE Pr_tsh_Personas_Insert
	@IdPersona varchar(20),
	@Nombre varchar(50),
	@Comentarios varchar(100),
	@Telefonos varchar(100),
	@Email varchar(100),
	@InstantMesseger varchar(100),
	@Observaciones varchar(1000),
	@Activo bit,
	@FechaCreacion datetime OUTPUT,
	@IdConexionCreacion bigint,
	@IdReservado bigint,
	@IdTratamiento bigint,
	@IdEmpresa bigint,
	@IdSucursal bigint

AS

DECLARE @MaxPersona Varchar(20);
DECLARE @NewRowID uniqueidentifier;
DECLARE @Sentencia Varchar(8000);

SELECT 
	@MaxPersona = Max([IdPersona])
FROM 
	[tsh_Personas]
WHERE 
	[IdSucursal] = @IdSucursal and
	[IdEmpresa] = @IdEmpresa;
Set @IdPersona = dbo.IdCompuesto(@IdEmpresa,@IdSucursal,@MaxPersona);
select @NewRowId = Newid();


INSERT INTO [tsh_Personas] (
	[IdPersona],
	[Nombre],
	[Comentarios],
	[Telefonos],
	[Email],
	[InstantMesseger],
	[Observaciones],
	[Activo],
	[FechaCreacion],
	[IdConexionCreacion],
	[IdReservado],
	[IdTratamiento],
	[IdEmpresa],
	[IdSucursal],
	[RowId]
) VALUES (
	@IdPersona,
	@Nombre,
	@Comentarios,
	@Telefonos,
	@Email,
	@InstantMesseger,
	@Observaciones,
	@Activo,
	@FechaCreacion,
	@IdConexionCreacion,
	@IdReservado,
	@IdTratamiento,
	@IdEmpresa,
	@IdSucursal,
	@NewRowId
);


Set @Sentencia = 
'INSERT INTO TSH_PERSONAS ([IdPersona],[Nombre],[Comentarios],[Telefonos],[Email],[InstantMesseger],[Observaciones],[Activo],[IdConexionCreacion],[IdReservado],[IdTratamiento],[IdEmpresa],[IdSucursal],[RowId] ) VALUES ('''+CAST(@IdPersona as Varchar(200)) + ''', '''+CAST(@Nombre as Varchar(200)) + ''', '''+CAST(@Comentarios as Varchar(200)) + ''', '''+CAST(@Telefonos as Varchar(200)) + ''', '''+CAST(@Email as Varchar(200)) + ''', '''+CAST(@InstantMesseger as Varchar(200)) + ''', '''+CAST(@Observaciones as Varchar(200)) + ''', '''+CAST(@Activo as Varchar(200)) + ''', '+CAST(@IdConexionCreacion as Varchar(200)) + ', '+CAST(@IdReservado as Varchar(200)) + ', '+CAST(@IdTratamiento as Varchar(200)) + ', '+CAST(@IdEmpresa as Varchar(200)) + ', '+CAST(@IdSucursal as Varchar(200)) + ', '''+CAST(@NewRowId as Varchar(200)) +''' ) ';

INSERT INTO sy_SentenciasReplicacion (
	[IdTabla], 
	[IdTipoSentencia], 
	[Sentencia], 
	[FechaCreacion], 
	[IdConexionCreacion],
	[SentenciaRowId]
) VALUES (
	'TSA_PERSONAS',
	'INSERT',
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

