﻿drop database RESTAURANTE;
Create database RESTAURANTE;
use RESTAURANTE;

create TABLE TB_LOGIN(
cod INT primary key  identity (1,1),
usuario Varchar(40) Not null,
senha varchar(30) not null
);

create TABLE TB_PRODUTOS(
cod_prod INT primary key  identity(1,1),
nome Varchar(40) not null,
tipo varchar(30) not null,
preco decimal(10,2) not null,
unid_medida varchar(30) not null,
estoque int not null
);
CREATE TABLE TB_FUNCIONARIOS(
cod_funcionario INT primary key  identity(1,1),
nome Varchar(40) not null,
RG varchar(30) not null,
CPF varchar(11) unique not null,
endereco varchar(30) not null,
conta VARCHAR(10) not null,
banco VARCHAR(10) not null,
agencia VARCHAR(10) not null,
telefone varchar( 11) not null,
bairro varchar(50) not null,
cidade varchar(50) not null,
estado varchar(2) not null,
numero int not null
);
insert into TB_LOGIN
(
	usuario, senha)
VALUES(	'Leonardo',
	'123456'
	);
select * from TB_FUNCIONARIOS
