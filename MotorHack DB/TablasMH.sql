use MHDB

create table usuarios
(
id_usuario int identity(1,1) not null,
usuario char(25) unique not null,
contrasena char(50) not null,
correo char(20) null,
tipo_usuario int not null,
id_cliente int null,
estado int not null
)


create table clientes
(
id_cliente int identity not null,
nombre_completo char(50) not null,
rfc char(20) not null,
estado int not null
)

create table catalogo
(
id_catalogo int identity not null,
categoria char(50) not null,
descripcion text null,
)

create table productos
(
id_producto int identity not null,
nombre char(40) not null,
precio_venta numeric(6,2) not null,
precio_compra numeric(6,2) not null,
id_catalogo int not null,
existencia int not null,
estado int not null
)

create table entradas
(
id_entrada int identity not null,
id_producto int not null,
id_almacen int not null,
cantidad int not null,
fecha date not null
)


create table almacen
(
id_almacen int identity not null,
nombre char(30) not null,
ubicacion char(70) not null
)

create table ventas
(
id_ventas int identity not null,
fecha_venta date not null,
id_usuario int not null,
sub_total numeric(8,2) not null,
iva numeric(5,2) not null,
total numeric(8,2) not null,
estado int not null
)

create table detalle_venta
(
id_detalle int identity not null,
id_venta int not null,
cantidad int not null,
id_producto int not null,
precio_venta numeric(7,2),
total numeric(8,2),
)