-- Krijimi i tabeles libri

CREATE TABLE libri(
libriId number(8,0) PRIMARY KEY, 
barkodi varchar2(20) NOT NULL, 
titulli varchar2(100) NOT NULL, 
isbn varchar2(20),
botuesiId number(3,0) NOT NULL,
qmimi number(12,2) NOT NULL, 
sasia number(5,0) NOT NULL,
kategoria kategoria_tab,
autori autori_tab,
CONSTRAINT barkodi_unique UNIQUE (barkodi),
CONSTRAINT isbn_unique UNIQUE (isbn),
CONSTRAINT check_qmimi
CHECK (qmimi > 0),
CONSTRAINT check_sasia
CHECK (sasia >= 0))
NESTED TABLE kategoria STORE AS kategoria_nested
NESTED TABLE autori STORE AS autori_nested;

-- Krijimi i tabeles botuesi

CREATE TABLE botuesi(
botuesiId number(3,0) PRIMARY KEY, 
botuesi_emri varchar2(50) NOT NULL,
vendi varchar2(30));

-- Krijimi i tabeles personat

CREATE TABLE personat(
personId number(7,0) PRIMARY KEY, 
emri emri NOT NULL, 
nr_personal varchar2(20) NOT NULL, 
gjinia char(1) NOT NULL,
telefoni varchar2(20),
email varchar2(50), 
adresa adresa,
data_regjistrimit date DEFAULT sysdate NOT NULL,
CONSTRAINT email_unique UNIQUE (email),
CONSTRAINT nr_personal_unique UNIQUE (nr_personal),
CONSTRAINT check_gjinia
CHECK (gjinia in ('m', 'M', 'f', 'F')));

-- Krijimi i tabeles puntoret

CREATE TABLE puntoret(
puntoriId number(3,0) PRIMARY KEY, 
personId number(7,0) NOT NULL,
pozita varchar2(30),
userName varchar(30) NOT NULL,
fjalekalimi varchar(20) NOT NULL,
menaxherid number(3,0),
FOREIGN KEY(personId) references personat(personId) ON DELETE CASCADE,
FOREIGN KEY(menaxherId) references puntoret(puntoriID) ON DELETE CASCADE,
CONSTRAINT userName_unique UNIQUE (userName));

-- Krijimi i tabeles pagesa_llojet

CREATE TABLE pagesa_llojet(
pagesat_llojiId number(1) PRIMARY KEY, 
lloji_pageses varchar2(20));

-- Krijimi i tabeles fatura

CREATE TABLE fatura(
faturaId number(7,0) PRIMARY KEY, 
fatura_lloji char(1) NOT NULL, 
pagesa_llojiId number(1) NOT NULL, 
klientiId number(7,0) NOT NULL,
puntoriId number(3,0) NOT NULL,
data_fatures date NOT NULL,
FOREIGN KEY(pagesa_llojiId) references pagesa_llojet(pagesat_llojiId),
FOREIGN KEY(klientiId) references personat(personId),
FOREIGN KEY(puntoriId) references puntoret(puntoriId),
CONSTRAINT check_fatura_lloji
CHECK (fatura_lloji in ('h', 'H', 'd', 'D')))
cluster fatura_faturaDetajet (faturaId);

-- Krijimi i tabeles fatura_detajet

CREATE TABLE fatura_detajet(
faturaId number(7,0) NOT NULL,
libriId number(8,0) NOT NULL,
sasia number(5,0) NOT NULL,
qmimi number(12,2) NOT NULL,
TVSH number(5,2),
PRIMARY KEY (faturaId,libriId),
FOREIGN KEY(faturaId) references fatura(faturaId) on delete cascade on update cascade,
FOREIGN KEY(libriId) references libri(libriId),
CONSTRAINT check_qmimi
CHECK (qmimi > 0))
cluster fatura_faturaDetajet (faturaId);

-- Krijimi i tabeles pagesat

CREATE TABLE pagesat(
pagesaId number(7,0) PRIMARY KEY, 
faturaId number(7,0) NOT NULL,
data_pageses date NOT NULL,
FOREIGN KEY(faturaId) references fatura(faturaId));