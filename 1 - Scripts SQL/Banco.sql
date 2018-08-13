---criar data Base
create DataBase LojaJogos_01
go
use LojaJogos_01
go

---TABELA 1
Create table tb_TipoProduto
(	Cd_TipoProduto int identity (1,1) Primary key,
	ds_TipoProduto varchar (20) not null, 
	Ativo bit not null default(1)
);
go

insert into Tb_TipoProduto 
values	('Jogo',1),
		('Console',1),
		('Controle',1),
		('HeadSet',1);
go
select * from Tb_TipoProduto
go

---TABELA 2
create table tb_FaixaEtaria
(cd_FaixaEtaria int identity(1,1) primary key,
ds_FaixaEtaria varchar(20) not null, 
Ativo bit not null default(1));
go

Insert into tb_FaixaEtaria (ds_FaixaEtaria, Ativo)
 values ('Livre', 1), 
		('10 anos', 1),
		('12 anos', 1), 
		('14 anos', 1), 
		('16 anos',1),
		('18 anos',1);
go

Select cd_FaixaEtaria, ds_FaixaEtaria from tb_FaixaEtaria where Ativo = 1;
go

---TABELA 3
create table tb_Plataforma 
(cd_Plataforma int identity(1,1)
 primary key, ds_Plataforma varchar(20) not null, 
 Ativo bit not null default(1)
 );
go

Insert into tb_Plataforma (ds_Plataforma, Ativo) 
values	('Xbox 360', 1),
		('Xbox One', 1), 
		('PS3', 1), 
		('PS4', 1), 
		('PSP',1),
		('Nintendo WII',1), 
		('Nintendo WIIU',1), 
		('Nintendo DS',1);
go

Select cd_Plataforma, ds_Plataforma from tb_Plataforma where Ativo = 1;
go

---TABELA 4
create table tb_Fabricante 
(cd_Fabricante int identity(1,1)
 primary key, ds_Fabricante varchar(20) not null, 
 Ativo bit not null default(1)
 );
go

Insert into tb_Fabricante (ds_Fabricante, Ativo) 
values	('Sony', 1), 
		('Microsoft', 1), 
		('Nintendo', 1), 
		('Ubisoft', 1), 
		('RockStar',1), 
		('Razer',1), 
		('Multilaser',1);
go

Select cd_Fabricante, ds_Fabricante from tb_Fabricante where Ativo = 1;
go

---TABELA 5
create table tb_Fornecedor
(cd_Fornecedor int identity(1,1) primary key, 
 Cnpj varchar(14) not null, 
  NomeFantasia varchar (100) not null, 
  RazaoSocial varchar (100) not null, 
  Telefone varchar (10) not null,  Celular varchar(11) not null, 
  Email varchar (30) not null, 
  Cep varchar (8), 
  Endereco varchar (20) not null, 
  EndNumero varchar (20) not null, 
  EndComplemento varchar (10) null, 
  Bairro varchar (20) not null,  
  Cidade varchar (20)not null, 
  UF char (2)not null, 
  DataInclusao Date default(getdate()) not null,
  Ativo bit not null default(1)
  );
go

Insert into tb_Fornecedor ( Cnpj, NomeFantasia, RazaoSocial, Telefone, Celular, Email, Cep, Endereco, EndNumero, EndComplemento, Bairro, Cidade, UF) 
values	('99999999999999','Carrefour','CARREFOUR COMERCIO E INDUSTRIA LTDA.','41945590','994993860','vendas@carrefour.com.br','06435200','Av Bola','100','BL01','Jd California','Barueri','SP'),		
		('88888888888888','Wallmart','WAL-MART BRASIL LTDA.','41945591','994993861','vendas@walmart.com.br','06435201','Av Bola','200','BL02','Jd California','Barueri','SP'),
		('77777777777777','UZ Games','N C GAMES & ARCADES COM IMP EXP E L LTDA.','41945592','994993862','vendas@uzgames.com.br','06435202','Av Bola','300','BL03','Jd California','Barueri','SP'),
		('66666666666666','Sony','SONY BRASIL LTDA.','41945593','994993863','vendas@sony.com.br','06435203','Av Bola','400','BL04','Jd California','Barueri','SP'),
		('55555555555555','Microsoft','MICROSOFT INFORMATICA LTDA.','41945594','994993864','vendas@microsoft.com.br','06435204','Av Bola','500','BL05','Jd California','Barueri','SP'),
		('44444444444444','ShopB','SHOP B COMERCIO VIRTUAL LTDA.','41945595','994993865','vendas@shopb.com.br','06435205','Av Bola','600','BL06','Jd California','Barueri','SP');
go

Select * from tb_Fornecedor where Ativo = 1;
go

select cd_fornecedor, Cnpj, NomeFantasia, RazaoSocial, Telefone, Celular, Email from Tb_fornecedor


--drop table tb_fornecedor


---TABELA 6
create table tb_Genero 
(cd_Genero int identity(1,1) primary key, 
ds_Genero varchar(20) not null, 
Ativo bit not null default(1)
);
go

Insert into tb_Genero (ds_Genero) 
values	('Outros'),
		('Ação'),
		('Aventura'),
		('Corrida'),
		('Em Grupo / Familia'),
		('Esporte'),
		('Estratégia'),
		('Infantil'),
		('Luta'),
		('Música'),
		('Puzzle'),
		('RPG'),
		('Simulação'),
		('Suspense / Terror'),
		('Tiro');
go

Select cd_Genero, ds_Genero from tb_Genero where Ativo = 1;
go
	
	
---TABELA 7	
create table tb_Produto 
(cd_Genero int identity(1,1) 
primary key, ds_Genero varchar(20) not null, 
Ativo bit not null default(1)
);
go

Insert into tb_Genero (ds_Genero, Ativo) 
values	('Outros'),
		('Ação'),
		('Aventura'),
		('Corrida'),
		('Em Grupo / Familia'),
		('Esporte'),
		('Estratégia'),
		('Infantil'),
		('Luta'),
		('Música'),
		('Puzzle'),
		('RPG'),
		('Simulação'),
		('Suspense / Terror'),
		('Tiro');
go

Select cd_Genero, ds_Genero from tb_Genero where Ativo = 1;
go


--select distinct CIDADE,BAIRRO from tb_endereco

 go

 --create table Tb_Produto(
 --)


-- ,
--    CONSTRAINT FK_Tb_TipoProduto_Tb_Produto FOREIGN KEY (Cd_TipoProduto)
--    REFERENCES Tb_TipoProduto(Cd_TipoProduto)
--);

create table tb_Produto (cd_Produto int identity(1,1) primary key, 
Nome varchar(100) not null,
cd_TipoProduto varchar(100)not null,
cd_FaixaEtaria varchar(100)not null, 
cd_Plataforma varchar(100)not null, 
cd_Fabricante varchar(100)not null, 
cd_fornecedor varchar(100)not null, 
cd_Genero varchar(100)not null, 
Quantidade int not null, 
Condicao varchar(20)not null, 
Preco decimal (10,2), 
Ativo bit not null default(1)
);
go

Insert into tb_Produto (Nome,cd_TipoProduto, cd_FaixaEtaria, cd_Plataforma, cd_Fabricante, cd_fornecedor, cd_Genero, Quantidade, Condicao, Preco) 
values	('DRAGON BALL FIGHTERZ EDIÇÃO FIGHTERZ','1','3','4','1','1','9','20','novo','174.90'),   
		('FAR CRY 5 STEELBOOK','1','6','4','1','1','2','10','novo','249.90'),   
		('MONSTE ENERGY SUPERCROSS','1','1','4','1','1','4','15','novo','199.90'),   
		('JUST DANCE 2018 PTBR CPP (NAC-BRA) PS3 UBI','1','1','3','1','2','5','15','novo','199.90'),   
		('JUST DANCE 2018 PTBR CPP (NAC-BRA) PS3 UBI','1','1','3','1','2','5','12','novo','129.90'),   
		('FIFA 2018','1','2','3','1','2','9','9','novo','159.90'),   
		('DRAGON BALL z - BATTLE OF Z','1','1','4','1','3','1','30','novo','1599.90'),   
		('CONSOLE PS4 500GB SLIM + UNCHARTED','2','1','3','1','3','1','12','novo','650.90'),   
		('PLAYSTATION 3 + SUPER SLIM','2','1','2','2','4','1','10','novo','1799.90'),   
		('XONE 1TB BRANCO + ASSASSINS CREED ORIGINS + TOM CLANCYS','2','1','2','2','4','1','15','novo','2799.90'),   
		('XBOX ONE X 1TB','2','1','4','1','5','1','5','novo','279.90'),   
		('CONTROLE PS4 SEM FIO DUALSHOCK CAMUFLADO SONY','4','1','4','1','5','1','20','novo','259.90'),   
		('CONTROLE PS4 SEM FIO DUALSHOCK BLACK SONY','4','1','3','1','6','1','25','novo','129.90'),   
		('CONTROLE PS3 FEIR S/ FIO','4','1','3','1','6','1','13','novo','599.90'),   
		('HEADSET SONY WIRELESS STEREO GOLD - PS4, PS3 E PS VITA','3','1','4','1','2','1','10','novo','110.90'),   
		('HEADSET GAMER FEIR PC/PS4/PS3','3','1','3','1','2','1','25','novo','199.90'),   
		('HEADSET GAMES G230 DGTL PC','3','1','4','4','1','1','30','novo','199.90')   

go
 select Cd_TipoProduto,ds_TipoProduto from Tb_TipoProduto where Ativo=1;
 go


/*



Select 
---COISAS QUE IREI DEVOLVER---
	A.Nome,
	B.ds_TipoProduto,
	B.Cd_TipoProduto,
	A.cd_TipoProduto
	--, 
	--A.cd_FaixaEtaria, 
	--A.cd_Plataforma, 
	--A.cd_Fabricante, 
	--A.cd_fornecedor, 
	--A.cd_Genero  
---COISAS QUE IREI DEVOLVER---
from 
	tb_Produto AS A -- "as" utilizado para ser um apelido para a tabela exemplo A

INNER JOIN Tb_TipoProduto as B on B.Cd_TipoProduto = A.cd_TipoProduto

where A.Ativo = 1;
go
*/






select *from tb_Fornecedor
go


update tb_Fornecedor set 
NomeFantasia= 'Casas Bahia', 
Cnpj = '12345678901234', 
RazaoSocial='Bahia'
where cd_Fornecedor=11


	
---TABELA 8

create table tb_Cliente
(cd_cliente int identity (1,1) primary key,
Nome varchar (200) not null,
DtNasc Date not null,
Cpf varchar (20) not null,
Rg char (20) null,
Genero char (1) not null,
Endereco varchar (100) not null,
Numero char (4) not null,
Complemento varchar(100)null,
Cidade varchar (100) not null,
Cep char (8) not null,
Estado varchar (100)not null,
UF char(2) not null,
Email varchar (100) not null,
Telefone varchar (11) not null,
Celular varchar (15)not null

);
go 
select*from  tb_cliente
go



insert into tb_cliente (Nome, DtNasc,Cpf, Rg, Genero, Endereco, Numero,Complemento, Cidade, Cep, Estado, UF, Email, telefone, Celular)

values 

go


select cd_cliente, Nome,Cpf, Rg,Genero, Endereco, Numero,Complemento, Cidade, Cep, Estado, UF, Email, telefone, Celular from Tb_fornecedor




