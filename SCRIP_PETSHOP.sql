create database wcc

use wcc
create table Animal(
Id int primary key identity,
Descrição varchar(50)
)

create table TipoAnimal(
Id int primary key identity,

foreign key (IdTipoAnimal) references TipoAnimal (Id)
)

create table Cliente(
Id int primary key identity,
Nome varchar(100) not null,
Email varchar(100) not null,
DataNascimento smalldatetime null,
Telefone varchar(20) not null,
DocIdentificador char(50) not null 
)

create table Endereco(
Id int primary key identity,
Logradouro varchar(100) not null,
Numero  varchar(10) not null,
Complemento varchar(50) not null,
Bairro varchar(100) not null,
Cidade varchar(200) not null,
Estado  varchar(100) not null,
DocIdentificador varchar(50) not null,
)

Create table ClienteAnimal(
IdCliente int not null,
IdAnimal int not null,
FOREIGN KEY (IdCliente) REFERENCES Cliente(Id),
FOREIGN KEY (IdAnimal) REFERENCES Animal(Id)
)


