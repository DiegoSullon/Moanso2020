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
create table cliente (
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dniCliente] [nvarchar](50) NOT NULL primary key ,
	[nombre][nvarchar](50) NOT NULL,
	--[razonSocial] [nvarchar](50) NULL,
	[correo][nvarchar](50) unique NULL,
	--[celular][nvarchar] (50) NOT NULL,
	--[direccion][nvarchar] (50) NULL,
	--[fecRegCliente] [date] NOT NULL,
)
ALTER TABLE cliente add unique (dniCliente);
GO

create proc spMostrarCliente
as 
select * from cliente 
go

--Procedimiento almacenado Insertar, agregar
create proc spInsertarCliente
@dniCliente varchar(50) ,
@nombre varchar(50) ,
--@razonSocial varchar(50) ,
@correo varchar(50) 
--@celular varchar (50) ,
--@direccion varchar (50),
--@fecRegCliente date
as
insert into cliente values (@dniCliente,@nombre,@correo)
go

create  PROCEDURE [dbo].[spBuscarCliente] 
  @id int
  as
  Begin 
  Select * from cliente
  where id= @id
  end
GO

--Procedimiento almacenado Editar Modiicar
create proc spEditarCliente
@dniCliente varchar(50) ,
@nombre varchar(50) ,
@correo varchar(50) 
as
update cliente set nombre =@nombre,correo=@correo
where dniCliente=@dniCliente
go


--Procedimiento almacenado Elimicar
create proc spEliminarCliente
@dniCliente varchar(50) 
as
delete cliente where dniCliente=@dniCliente
go


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


/*PEDIDO*/
create table Pedido (
	[idPedido] [int] primary key IDENTITY(1,1) NOT NULL,
	[idMesa] [int] NULL  ,
	[dniCliente] nvarchar(50) ,
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
@dniCliente int
as
insert into Pedido values (@idMesa,@dniCliente)
go

create proc spEditarPedido
@idMesa int ,
@idPedido int,
@dniCliente int
as
update Pedido set idMesa =@idMesa, dniCliente=@dniCliente
where idPedido=@idPedido
go

create proc spEliminarPedido
@idPedido int
as
delete Pedido where idPedido=@idPedido
go

create table Detalle(
	[idPedido] [int]  NOT NULL,
	[idPlatillo] [int]  NOT NULL,
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
@idPedido int
as
delete Detalle where idPedido=@idPedido
go




/*select Platillo.nombrePlatillo,Platillo.descripcion,
.cantidad from Pedido inner join Detalle on Pedido.idPedido=Detalle.idPedido inner join Platillo on Detalle.idPlatillo = Platillo.idPlatillo 
go*/

create proc spMostrarDetallePlatillos
@idPedido int 
as
select Platillo.idPlatillo,Platillo.nombrePlatillo,Platillo.descripcion,Platillo.estPlatillo from Pedido inner join Detalle on Pedido.idPedido=Detalle.idPedido inner join Platillo on Detalle.idPlatillo = Platillo.idPlatillo 
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
insert into Platillo(nombrePlatillo,descripcion,estPlatillo) 
values 
	('Arroz Con Pollo','Riquisimo Arroz Con Pollo',1),
	('Lomo Saltado','Acompaņado de Papas Fritas',1)
go


select * from Platillo
go
insert into cliente(dniCliente,nombre,correo) values (72918470,'Jose','josema@gmail.com')
go
select * from Cliente
go
insert into Mesa(cantAsientos,descripcion,estMesa) values(4,'Mesa Cuadrada',1)
go
select * from mesa
go
insert into Pedido(idMesa,dniCliente) 
values
	(1,'72918470'),
	(1,'72918470')
go
select * from Pedido
go
/* PEDIDO 1*/
insert into Detalle(idPedido,idPlatillo) 
values
	(1,2),
	(1,1)
go
/*Pedido 2*/
insert into Detalle(idPedido,idPlatillo) 
values 
	(2,1)
go
select * from Detalle
go



/******************************************************************************************************************************/
create table Rol(
	idRol[int] IDENTITY(1,1)NOT NULL primary key,
	descripcion[nvarchar](50) NOT NULL,
)
go

insert into Rol values('Cajero'),('Mesero'),('Gerente'),('Cocina')
go
/******************************************************************************************************************************/

create table Empleado(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [nvarchar](50) NOT NULL primary key ,
	[nombre][nvarchar](50) NOT NULL,
	[correo][nvarchar](50) unique NULL,
	[idRol][int]  NULL,
	CONSTRAINT [idRol_Empleado] FOREIGN KEY (idRol) REFERENCES Rol(idRol)
)
ALTER TABLE Empleado add unique (dni);
GO

create proc spMostrarEmpleado
as 
select * from Empleado 
go

--Procedimiento almacenado Insertar, agregar
create proc spInsertaEmpleado
@dni varchar(50) ,
@nombre varchar(50) ,
@correo varchar(50) ,
@idRol int
as
insert into Empleado values (@dni,@nombre,@correo,@idRol)
go

create  PROCEDURE [dbo].[spBuscarEmpleado] 
  @id int
  as
  Begin 
  Select * from Empleado
  where id= @id
  end
GO

--Procedimiento almacenado Editar Modiicar
create proc spEditarEmpleado
@id int,
@nombre varchar(50) ,
@correo varchar(50) ,
@idRol int 
as
update Empleado set nombre =@nombre,correo=@correo,idRol=@idRol
where id=@id
go


--Procedimiento almacenado Elimicar
create proc spEliminarEmpleado
@id int
as
delete Empleado where id=@id
go
