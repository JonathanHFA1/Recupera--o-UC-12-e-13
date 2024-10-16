CREATE  DATABASE venda;

use venda;

CREATE table tblclientes(
cpf_cnpj varchar(20) primary key,
nome varchar(30),
endereco varchar(50),
rg_ie varchar(15),
tipo char,
valor float,
valor_imposto float,
total float
);

insert into tblclientes values('123.456.789.00' , 'Pedro da Silva', 'Rua Vergueiro 1234','4.567.890','f',2500.00,250.00,2750.00);
insert into tblclientes values('456.123.789-00' , 'Joao Silva', 'Av. Parati 23','3.127.290','f',3000.00,300.00,3000.00);
insert into tblclientes values('789.456.321-00' , 'Maria da Silva', 'Rua Leonor 45','5.577.900','j',3500.00,350.00,3750.00);

insert into tblclientes values('123.000.789.00' , 'Fabricio da Silva', 'Rua Vergueiro 1234','4.567.890','j',2500.00,250.00,2750.00);
insert into tblclientes values('456.999.789-00' , 'Carlos Silva', 'Av. Parati 23','3.127.290','j',3000.00,300.00,3000.00);
insert into tblclientes values('789.888.321-00' , 'Leonora da Silva', 'Rua Leonor 45','5.577.900','f',3500.00,350.00,3750.00);

select * from tblclientes