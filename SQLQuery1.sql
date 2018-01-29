create database SystemLoja

use SystemLoja

create table Usuario
(
cod_usuario int identity primary key,
nome varchar(30) not null,
senha varchar(8) not null,
nível varchar (1) not null,
Nomeusuario varchar(50) not null,
)

create table Produto
(
cod_usuario int identity primary key,
referencia varchar(8) not null,
descricao varchar(40) not null,
Marca varchar(20) not null,
codbarra varchar(13) not null,
cor varchar(15) not null,
precocusto money,
precovenda money,
unidade varchar(2) not null,
)

create table clientepf
(
cod_usuario int identity primary key,
nomecliente varchar(30) not null,
rg varchar(9) not null,
cpf varchar(11) not null,
endereço varchar(20),
bairro varchar(10),
cidade varchar(15),
complemento varchar(20),
numero varchar(5),
cep varchar(8),
uf varchar(2),
telefone varchar(9),
celular varchar(9),
contato varchar (15),
email varchar(20),
datanascimento date,
observacoes varchar(100),
)

create table clientepj
(
cod_usuario int identity primary key,
nomecliente varchar(30) not null,
ie varchar(14) not null,
cnpj varchar(14) not null,
endereço varchar(20),
bairro varchar(10),
cidade varchar(15),
complemento varchar(20),
numero varchar(5),
cep varchar(8),
uf varchar(2),
telefone varchar(9),
celular varchar(9),
contato varchar (15),
email varchar(20),
observacoes varchar(100),
)

alter table clientepf alter column telefone varchar(11)
alter table clientepf alter column celular varchar (11)
alter table clientepj alter column telefone varchar(11)
alter table clientepj alter column celular varchar (11)

insert into Usuario values ('Admin', 'admin','1','Esse usuario é padrão do sistema')

select * from Usuario

insert into Produto values ('11111111','Calça Jeans tamanho 40','Polo wear','7891234561434','Azul padrão','40,00','69,90','UN')

select * from Produto

alter table clientepf alter column email varchar(30) 

insert into clientepf values ('Guilherme','353571763','32448387826','Rua Eloy Chaves','Centro','Araçariguama','Casa 03','75','18147000','SP','1142041242','11963996533','Guilherme','gui_montagnani@hotmail.com','15/04/91','Cadastro Padrao')

select * from clientepf

