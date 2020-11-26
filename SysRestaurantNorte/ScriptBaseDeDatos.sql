CREATE DATABASE restaurante
go
USE [restaurante]
GO
/****** Object: Table [dbo].[Carta] ******/
/*CREATE TABLE [dbo].[Carta](
	[idCarta] [int] IDENTITY(1,1) NOT NULL,
	[nombreCarta] [nvarchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Platillo] PRIMARY KEY CLUSTERED 
(
	[idCarta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
insert into Carta values(1,'Carta Principal','Carta Principal del restaurante')
GO*/
/****** Object: Table [dbo].[platillo] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Platillo](
	[idPlatillo] [int] IDENTITY(1,1) NOT NULL,
	--[idCarta][int]NULL,
	[nombrePlatillo] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[estPlatillo] [bit] NOT NULL,
 --CONSTRAINT [FK_IdCarta] FOREIGN KEY (idCarta) REFERENCES Carta(idCarta),
 CONSTRAINT [PK_Platillo] PRIMARY KEY CLUSTERED 
(
	[idPlatillo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  StoredProcedure [dbo].[spBuscarPlatilloNumero]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spBuscarPlatilloNumero] 
  @idPlatillo int
  as
  Begin 
  Select * from Platillo
  where idPlatillo= @idPlatillo
  end
GO
/****** Object:  StoredProcedure [dbo].[spBuscarPlatilloNombre]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spBuscarPlatilloNombre] 
  @nombrePlatillo int
  as
  Begin Select * from Platillo
  where nombrePlatillo = @nombrePlatillo
  end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitaPlatillo] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spDeshabilitaPlatillo] 
(@idPlatillo int
)
as
begin 
	update  Platillo set 
	estPlatillo = 0
	where idPlatillo = @idPlatillo
end
GO

/****** Object:  StoredProcedure [dbo].[spEditaPlatillo] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditaPlatillo] 
(@idPlatillo int,
@nombrePlatillo varchar(50),
@descripcion varchar(50),
@estPlatillo bit
)
as
begin 
	update  Platillo set 
	nombrePlatillo = @nombrePlatillo,
	descripcion = @descripcion,
	estPlatillo = @estPlatillo
	where idPlatillo = @idPlatillo
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertaPlatillo]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaPlatillo] 
(
@nombrePlatillo varchar(50),
@descripcion varchar(50),
@estPlatillo bit
)
as
begin 
	insert into Platillo(nombrePlatillo,descripcion,estPlatillo) values
	(@nombrePlatillo,@descripcion, @estPlatillo)
end
GO



/****** Object:  StoredProcedure [dbo].[spListaPlatillos]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].spListaPlatillos
AS
	SELECT * from Platillo where estPlatillo='1'
GO

/************************************************************************************************************************/

/****** Object: Table [dbo].[Mesa] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa](
	[idMesa] [int] IDENTITY(1,1) NOT NULL,
	[cantAsientos][int] NULL,
	[descripcion] [nvarchar](50) NULL,
	[estMesa] [bit] NOT NULL,
 CONSTRAINT [PK_Mesa] PRIMARY KEY CLUSTERED 
(
	[idMesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  StoredProcedure [dbo].[spListaMesas]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].spListaMesas
AS
	SELECT * from Mesa
GO
/****** Object:  StoredProcedure [dbo].[spInsertaMesa]******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertaMesa] 
(
@cantAsientos int,
@descripcion varchar(50),
@estMesa bit
)
as
begin 
	insert into Mesa values (@cantAsientos,@descripcion,@estMesa)
end
GO



/****** Object:  StoredProcedure [dbo].[spEditaMesa] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  PROCEDURE [dbo].[spEditaMesa] 
(@idMesa int,
@cantAsientos int,
@descripcion varchar(50),
@estMesa bit
)
as
begin 
	update  Mesa set 
	cantAsientos = @cantAsientos,
	descripcion = @descripcion,
	estMesa = @estMesa
	where idMesa = @idMesa
end
GO

/****** Object:  StoredProcedure [dbo].[spDeshabilitaMesa] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc spEliminaMesa
@idMesa int
as
delete Mesa where idMesa=@idMesa
go

create table cliente (
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dniCliente] [int] NOT NULL primary key ,
	[nombre][nvarchar](50) NOT NULL,
	[razonSocial] [nvarchar](50) NULL,
	[correo][nvarchar](50) unique NULL,
	[celular][nvarchar] (50) NOT NULL,
	[direccion][nvarchar] (50) NULL,
	[fecRegCliente] [date] NOT NULL,
)
ALTER TABLE cliente add unique (dniCliente);
GO

create proc spMostrarCliente
as
select *from cliente 
go

--Procedimiento almacenado Insertar, agregar
create proc spInsertarCliente
@dniCliente int,
@nombre varchar(50) ,
@razonSocial varchar(50) ,
@correo varchar(50) ,
@celular varchar (50) ,
@direccion varchar (50),
@fecRegCliente date
as
insert into cliente values (@dniCliente,@nombre,@razonSocial,@correo,@celular,@direccion,@fecRegCliente)
go


--Procedimiento almacenado Editar Modiicar
create proc spEditarCliente
@dniCliente int,
@nombre varchar(50) ,
@razonSocial varchar(50) ,
@correo varchar(50) ,
@celular varchar (50) ,
@direccion varchar (50),
@fecRegCliente date
as
update cliente set nombre =@nombre,razonSocial=@razonSocial,correo=@correo,celular=@celular,direccion=@direccion,fecRegCliente=@fecRegCliente 
where dniCliente=@dniCliente
go


--Procedimiento almacenado Elimicar
create proc spEliminarCliente
@dniCliente int
as
delete cliente where dniCliente=@dniCliente
go


/*PEDIDO*/
create table Pedido (
	[idPedido] [int] primary key IDENTITY(1,1) NOT NULL,
	[idMesa] [int] NULL  ,
	[dniCliente] [int] NOT NULL,
	[descripcion] varchar(50) NULL,
	CONSTRAINT [FK_dniCliente] FOREIGN KEY (dniCliente) REFERENCES cliente(dniCliente),
	CONSTRAINT [FK_idMesa] FOREIGN KEY (idMesa) REFERENCES Mesa(idMesa)
)
GO

create proc spMostrarPedidos
as
select *from Pedido 
go

create proc spInsertarPedido
@idMesa int,
@dniCliente int,
@descripcion varchar(50)
as
insert into Pedido values (@idMesa,@dniCliente,@descripcion)
go

create proc spEditarPedido
@idMesa int ,
@idPedido int,
@dniCliente int,
@descripcion varchar(50)
as
update Pedido set idMesa =@idMesa, dniCliente=@dniCliente, descripcion=@descripcion
where idPedido=@idPedido
go

create proc spEliminarPedido
@idPedido int
as
delete Pedido where idPedido=@idPedido
go

create table Detalle(
	[idDetalle] [int] primary key IDENTITY(1,1) NOT NULL,
	[idPedido] [int]  NOT NULL,
	[idPlatillo] [int]  NOT NULL,
	[cantidad][int] NOT NULL
	CONSTRAINT [idPedido] FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido),
	CONSTRAINT [idPlatillo] FOREIGN KEY (idPlatillo) REFERENCES Platillo(idPlatillo)
)
GO

create proc spInsertaDetalle
@idPedido int,
@idPlatillo int
as
insert into Detalle values (@idPedido,@idPlatillo)
go

create proc spEliminaDetalle
@idDetalle int
as
delete Detalle where idDetalle=@idDetalle
go


insert into Platillo(nombrePlatillo,descripcion,estPlatillo) 
go
values 
	('Arroz Con Pollo','Riquisimo Arroz Con Pollo',1),
	('Lomo Saltado','Acompañado de Papas Fritas',1)
go
select * from Platillo
go
insert into cliente(dniCliente,nombre,razonSocial,correo,celular,direccion,fecRegCliente) values (72918470,'Jose','XD','josema@gmail.com',960492627,'CIX','1/16/2007')
go
select * from Cliente
go
insert into Mesa(cantAsientos,descripcion,estMesa) values(4,'Mesa Cuadrada',1)
go
select * from mesa
go
insert into Pedido(idMesa,dniCliente) 
values
	(1,72918470),
	(1,72918470)
go
select * from Pedido
go
/* PEDIDO 1*/
insert into Detalle(idPedido,idPlatillo,cantidad) 
values
	(1,2,2),
	(1,1,2)
go
/*Pedido 2*/
insert into Detalle(idPedido,idPlatillo,cantidad) 
values 
	(2,1,5)
go
select * from Detalle
go


/*select Platillo.nombrePlatillo,Platillo.descripcion,Detalle.cantidad from Pedido inner join Detalle on Pedido.idPedido=Detalle.idPedido inner join Platillo on Detalle.idPlatillo = Platillo.idPlatillo 
go*/

create proc spMostrarDetallePlatillos
@idPedido int 
as
select Platillo.nombrePlatillo,Platillo.descripcion,Detalle.cantidad from Pedido inner join Detalle on Pedido.idPedido=Detalle.idPedido inner join Platillo on Detalle.idPlatillo = Platillo.idPlatillo 
where Pedido.idPedido = @idPedido
go


create table MedioDePago(
	[idMedioDePago][int] primary key IDENTITY(1,1) NOT NULL,
	[descripcion][nvarchar](50) NOT NULL,--efectivo,debito,credito
)
go
insert into MedioDePago values ('efectivo'),('debito'),('credito')
go
select * from MedioDePago
go
create table Venta(
	[idVenta] [int] primary key IDENTITY(1,1) NOT NULL,
	[idPedido] [int]  NOT NULL,
	[idMedioDePago] [int]  NOT NULL,
	[fechaVenta] [date] NOT NULL,
	CONSTRAINT [idPedidoVenta] FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido),
	CONSTRAINT [idMedioDePago] FOREIGN KEY (idMedioDePago) REFERENCES MedioDePago(idMedioDePago)
)
GO
