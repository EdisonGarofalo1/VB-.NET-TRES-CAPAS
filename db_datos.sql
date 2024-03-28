USE [BD_prueba2024]
GO
/****** Object:  Table [dbo].[CAB_MOVIMIENTO]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAB_MOVIMIENTO](
	[CABMOV_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CABMOV_NUM_DOC] [numeric](18, 0) NULL,
	[TIPMOV_ID] [int] NOT NULL,
	[CABMOVIMIENTO] [varchar](3) NOT NULL,
	[PER_ID] [numeric](18, 0) NOT NULL,
	[CABMOV_FECHA] [date] NOT NULL,
	[CABMOV_BASE_IMPONIBLE] [numeric](9, 2) NOT NULL,
	[CABMOV_IVA] [numeric](9, 2) NOT NULL,
	[CABMOV_VALOR_FINAL] [numeric](9, 2) NOT NULL,
	[CABMOV_ESTADO] [varchar](1) NOT NULL,
	[USUARIO] [varchar](25) NOT NULL,
	[FECHA_INGRESO] [datetime] NOT NULL,
	[FECHA_MODIFIC] [datetime] NOT NULL,
 CONSTRAINT [PK_CST_ID_CAB] PRIMARY KEY CLUSTERED 
(
	[CABMOV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAB_PARAMETRICA]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAB_PARAMETRICA](
	[CABP_ID] [int] IDENTITY(1,1) NOT NULL,
	[CABP_CODIGO] [varchar](10) NOT NULL,
	[CABP_DESCRIPCION] [varchar](50) NOT NULL,
	[CABP_ESTADO] [bit] NOT NULL,
 CONSTRAINT [PK_CST_PK_CP_ID_CAB] PRIMARY KEY CLUSTERED 
(
	[CABP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[CAT_ID] [int] IDENTITY(1,1) NOT NULL,
	[CAT_DESCRIPCION] [varchar](30) NOT NULL,
	[CAT_ESTADO] [varchar](1) NOT NULL,
 CONSTRAINT [PK_CST_ID_GRUPO] PRIMARY KEY CLUSTERED 
(
	[CAT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DET_MOVIMIENTO]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DET_MOVIMIENTO](
	[DET_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[CABMOV_ID] [numeric](18, 0) NOT NULL,
	[PROD_ID] [int] NOT NULL,
	[DET_CANTIDAD] [int] NOT NULL,
	[DET_PRECIO] [nchar](10) NULL,
	[DET_BASE_IMPONIBLE] [numeric](9, 2) NOT NULL,
	[DET_IVA] [numeric](9, 2) NOT NULL,
	[DET_TOTAL] [numeric](9, 2) NOT NULL,
	[DET_ESTADO] [varchar](1) NOT NULL,
 CONSTRAINT [PK_CST_ID_DETALLE] PRIMARY KEY CLUSTERED 
(
	[DET_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DET_PARAMETRICA]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DET_PARAMETRICA](
	[DETP_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[DETP_CODIGO] [varchar](10) NOT NULL,
	[DETP_DESCRIPCION] [varchar](250) NOT NULL,
	[DETP_VALOR] [numeric](9, 2) NOT NULL,
	[CABP_ID] [int] NOT NULL,
	[DETP_ESTADO] [bit] NOT NULL,
 CONSTRAINT [PK_CST_PK_ID_PARAMETRO] PRIMARY KEY CLUSTERED 
(
	[DETP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAS](
	[PER_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PER_IDENTIFICACION] [varchar](13) NOT NULL,
	[CP_SEXO] [int] NOT NULL,
	[CP_ESTADO_CIVIL] [int] NOT NULL,
	[PER_NOMBRES] [varchar](200) NOT NULL,
	[PER_TELEFONO] [varchar](10) NOT NULL,
	[PER_DIRECCION] [varchar](250) NOT NULL,
	[PER_ESTADO] [varchar](1) NOT NULL,
 CONSTRAINT [PK_CST_ID_PERSONA] PRIMARY KEY CLUSTERED 
(
	[PER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[PRO_ID] [int] IDENTITY(1,1) NOT NULL,
	[CAT_ID] [int] NOT NULL,
	[PRO_CODIGO] [varchar](20) NOT NULL,
	[PRO_DESCRIPCION] [varchar](50) NOT NULL,
	[PRO_PRECIO] [numeric](9, 2) NOT NULL,
	[STOCK] [int] NULL,
	[PRO_LLEVA_IVA] [bit] NOT NULL,
	[PRO_ESTADO] [varchar](1) NOT NULL,
 CONSTRAINT [PK_CST_ID_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[PRO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seg_accesos]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seg_accesos](
	[acc_id] [int] IDENTITY(1,1) NOT NULL,
	[per_Id] [int] NOT NULL,
	[men_Id] [int] NOT NULL,
	[acc_estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[acc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seg_Menu]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seg_Menu](
	[men_Id] [int] IDENTITY(1,1) NOT NULL,
	[men_Id_MenuPadre] [int] NULL,
	[men_Descripcion] [varchar](255) NOT NULL,
	[men_Posicion] [int] NOT NULL,
	[men_ForAsociado] [bit] NOT NULL,
	[men_nombreFrm] [varchar](255) NULL,
	[men_estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[men_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seg_Perfil]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seg_Perfil](
	[per_Id] [int] IDENTITY(1,1) NOT NULL,
	[per_Nombre] [varchar](25) NOT NULL,
	[per_Descripcion] [varchar](255) NOT NULL,
	[per_estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[per_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seg_Usuarios]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seg_Usuarios](
	[usu_id] [int] IDENTITY(1,1) NOT NULL,
	[per_Id] [int] NOT NULL,
	[usu_cedula] [varchar](100) NOT NULL,
	[usu_nombres] [varchar](100) NOT NULL,
	[usu_apellidos] [varchar](100) NOT NULL,
	[usu_direccion] [varchar](100) NULL,
	[usu_telefono] [varchar](100) NULL,
	[usu_email] [varchar](100) NULL,
	[usu_usuario] [varchar](50) NOT NULL,
	[usu_clave] [varchar](250) NOT NULL,
	[usu_foto] [image] NULL,
	[usu_estado] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_MOVIMIENTO]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_MOVIMIENTO](
	[TIPMOV_ID] [int] IDENTITY(1,1) NOT NULL,
	[TIPMOV_DESCRIPCION] [varchar](30) NOT NULL,
	[TIPMOV_ESTADO] [varchar](1) NOT NULL,
 CONSTRAINT [PK_CST_ID_TIPO] PRIMARY KEY CLUSTERED 
(
	[TIPMOV_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CAB_MOVIMIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CNST_CAB_PERSONA] FOREIGN KEY([PER_ID])
REFERENCES [dbo].[PERSONAS] ([PER_ID])
GO
ALTER TABLE [dbo].[CAB_MOVIMIENTO] CHECK CONSTRAINT [FK_CNST_CAB_PERSONA]
GO
ALTER TABLE [dbo].[CAB_MOVIMIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CNST_CAB_TIPO] FOREIGN KEY([TIPMOV_ID])
REFERENCES [dbo].[TIPO_MOVIMIENTO] ([TIPMOV_ID])
GO
ALTER TABLE [dbo].[CAB_MOVIMIENTO] CHECK CONSTRAINT [FK_CNST_CAB_TIPO]
GO
ALTER TABLE [dbo].[DET_MOVIMIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CNST_DETALLE_CABECERA] FOREIGN KEY([CABMOV_ID])
REFERENCES [dbo].[CAB_MOVIMIENTO] ([CABMOV_ID])
GO
ALTER TABLE [dbo].[DET_MOVIMIENTO] CHECK CONSTRAINT [FK_CNST_DETALLE_CABECERA]
GO
ALTER TABLE [dbo].[DET_MOVIMIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CNST_DETALLE_PRODUCTO] FOREIGN KEY([PROD_ID])
REFERENCES [dbo].[PRODUCTOS] ([PRO_ID])
GO
ALTER TABLE [dbo].[DET_MOVIMIENTO] CHECK CONSTRAINT [FK_CNST_DETALLE_PRODUCTO]
GO
ALTER TABLE [dbo].[DET_PARAMETRICA]  WITH CHECK ADD  CONSTRAINT [FK_DET_PARAMETRICA_CAB_PARAMETRICA] FOREIGN KEY([CABP_ID])
REFERENCES [dbo].[CAB_PARAMETRICA] ([CABP_ID])
GO
ALTER TABLE [dbo].[DET_PARAMETRICA] CHECK CONSTRAINT [FK_DET_PARAMETRICA_CAB_PARAMETRICA]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_CNST_PRODUCTOS_GRUPOS] FOREIGN KEY([CAT_ID])
REFERENCES [dbo].[CATEGORIAS] ([CAT_ID])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_CNST_PRODUCTOS_GRUPOS]
GO
ALTER TABLE [dbo].[seg_accesos]  WITH CHECK ADD  CONSTRAINT [fk_seg_accesos_seg_menu] FOREIGN KEY([men_Id])
REFERENCES [dbo].[seg_Menu] ([men_Id])
GO
ALTER TABLE [dbo].[seg_accesos] CHECK CONSTRAINT [fk_seg_accesos_seg_menu]
GO
ALTER TABLE [dbo].[seg_accesos]  WITH CHECK ADD  CONSTRAINT [fk_seg_accesos_seg_perfil] FOREIGN KEY([per_Id])
REFERENCES [dbo].[seg_Perfil] ([per_Id])
GO
ALTER TABLE [dbo].[seg_accesos] CHECK CONSTRAINT [fk_seg_accesos_seg_perfil]
GO
ALTER TABLE [dbo].[seg_Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_seg_usuarios_seg_perfil] FOREIGN KEY([per_Id])
REFERENCES [dbo].[seg_Perfil] ([per_Id])
GO
ALTER TABLE [dbo].[seg_Usuarios] CHECK CONSTRAINT [fk_seg_usuarios_seg_perfil]
GO
/****** Object:  StoredProcedure [dbo].[sp_mant_accesos]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_mant_accesos]      

(  
 @periso_id int, 
 @per_id int,     
 @men_id int,         
 @estado char(1),      
 @accion int      
)      
as      
begin      
 if @accion=2      
 begin       

    --actualizar      

     update seg_accesos     
     set acc_estado=@estado      
     where      
     acc_id=@periso_id   
 end      
 else      
 begin      
    insert into seg_accesos      
    (men_id,per_id,acc_estado)      
    values      
    (@men_id,@per_id,@estado)      
 end      
end 

GO
/****** Object:  StoredProcedure [dbo].[sp_MantPerfil]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_MantPerfil]
(
 @per_id int,
 @per_Nombre varchar(25),
 @per_descripcion varchar(255),
 @per_estado char(1)
)
as
begin
  if @per_id=0
  begin
     insert into seg_Perfil (per_Nombre,per_descripcion,per_estado)
	                 values(@per_Nombre,@per_descripcion,@per_estado)
  end
  else
  begin
   update seg_Perfil
   set per_Nombre = @per_Nombre,
        per_descripcion=@per_descripcion,
		per_estado=@per_estado
  where 
    per_id=@per_id
  end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_mantusuario]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_mantusuario] 
(  
	@usu_id int,  
	@per_Id int,  
	@usu_cedula  varchar(13),  
	@usu_nombres varchar(100),  
	@usu_apellidos varchar(100),  
	@usu_direccion varchar(250),  
	@usu_telefono varchar(13),  
	@usu_email varchar(50),  
	@usu_usuario varchar(50),  
	@usu_clave varchar(50),  
	@usu_foto image,  
	@usu_estado varchar(1)  
)  

as   

begin  

  if @usu_id=0  

    begin  
				--insertar  

		insert into seg_usuarios  
		(    	per_Id ,  
					usu_cedula  ,  
					usu_nombres ,  
					usu_apellidos ,  
					usu_direccion ,  
					usu_telefono ,  
					usu_email ,  
					usu_usuario ,  
					usu_clave ,  
					usu_foto ,  
					usu_estado   
			)  
		values  
			(  
			@per_Id ,  
			@usu_cedula  ,  
			@usu_nombres ,  
			@usu_apellidos ,  
			@usu_direccion ,  
			@usu_telefono ,  
			@usu_email ,  
			@usu_usuario ,  
			@usu_clave ,  
			@usu_foto ,  
			@usu_estado   

			)  

	  end  
  else  
	  begin  

		--modificar  

		 update seg_usuarios  

				set 
				usu_cedula =@usu_cedula,  
				per_Id =@per_Id, 
				usu_nombres =@usu_nombres ,  
				usu_apellidos =@usu_apellidos ,  
				usu_direccion =@usu_direccion ,  
				usu_telefono=@usu_telefono  ,  
				usu_email =@usu_email ,  
				usu_usuario =@usu_usuario ,  
				usu_clave =@usu_clave ,  
				usu_foto =@usu_foto,  
				usu_estado =@usu_estado  
				where
					usu_id=@usu_id
	  end  
end

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_ListaUsiarios]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_sel_ListaUsiarios]
as
begin
  select top(10)usu_cedula,per_nombre,(usu_apellidos + ' '+ usu_nombres) as nombres,usu_estado
  from seg_usuarios,seg_perfil 
  where seg_usuarios.per_id=seg_perfil.per_id
end

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_ListaUsiariosxApe]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_sel_ListaUsiariosxApe]
( 
@apellido varchar(20)
)
as
begin
  select top(10)usu_cedula,per_nombre,(usu_apellidos + ' '+ usu_nombres) as nombres,usu_estado
  from seg_usuarios,seg_perfil 
  where seg_usuarios.per_id=seg_perfil.per_id and seg_Usuarios.usu_apellidos like @apellido +'%'
   
end

GO
/****** Object:  StoredProcedure [dbo].[sp_selCabFactura]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_selCabFactura]

(

 @numfac numeric(18,0)

)

as

begin



select cb.CABMOV_ID,p.PER_IDENTIFICACION,p.PER_NOMBRES,p.PER_DIRECCION,p.PER_TELEFONO,

       cb.CABMOV_FECHA,cb.CABMOV_ESTADO,cb.CABMOV_BASE_IMPONIBLE,cb.CABMOV_IVA,cb.CABMOV_VALOR_FINAL



from CAB_MOVIMIENTO cb,PERSONAS p



where

cb.PER_ID=p.PER_ID and

 CABMOV_NUM_DOC=@numfac

 end
GO
/****** Object:  StoredProcedure [dbo].[sp_selDetalleFactura]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_selDetalleFactura]

(

 @cab_id numeric(18,0)

)

as

begin



SELECT        dbo.PRODUCTOS.PRO_ID, dbo.PRODUCTOS.PRO_CODIGO, dbo.PRODUCTOS.PRO_DESCRIPCION, dbo.DET_MOVIMIENTO.PROD_ID,dbo.PRODUCTOS.PRO_LLEVA_IVA, 

                         dbo.DET_MOVIMIENTO.DET_CANTIDAD, dbo.DET_MOVIMIENTO.DET_PRECIO, dbo.DET_MOVIMIENTO.DET_BASE_IMPONIBLE, 

                         dbo.DET_MOVIMIENTO.DET_IVA, dbo.DET_MOVIMIENTO.DET_TOTAL, dbo.DET_MOVIMIENTO.DET_ESTADO

FROM            dbo.DET_MOVIMIENTO INNER JOIN

                         dbo.PRODUCTOS ON dbo.DET_MOVIMIENTO.PROD_ID = dbo.PRODUCTOS.PRO_ID



where

   dbo.DET_MOVIMIENTO.CABMOV_ID=@cab_id

   end
GO
/****** Object:  StoredProcedure [dbo].[sp_selpermisospadre]    Script Date: 28/03/2024 12:53:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_selpermisospadre]      
(
	@cod_perfil int,
	@menu_padre int
)
as
begin
select P.acc_id, M.men_Id, p.per_Id,men_Descripcion, m.men_nombreFrm, p.acc_estado  
from seg_Menu m , seg_accesos p	
where m.men_Id = p.men_Id
and p.per_Id=@cod_perfil
and M.men_Id_MenuPadre = @menu_padre
union 
select 0 as acc_id, m.men_Id, 1 as per_Id,men_Descripcion, m.men_nombreFrm, 'E' as acc_estado  
from seg_Menu m 	
where m.men_Id not in (select  men_Id from seg_accesos
						where per_Id = @cod_perfil and men_estado='A') AND M.men_Id_MenuPadre = @menu_padre

end

GO
