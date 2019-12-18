-- Krijimi i tipeve komplekse

CREATE TYPE emri AS OBJECT
(emri varchar(20),
 mbiemri varchar(20));
 
CREATE TYPE adresa AS OBJECT (
adresa varchar2(50),
qyteti varchar2(20),
shteti varchar2(30),
kodi_Postal char(5));

-- Krijimi i tipeve 

CREATE TYPE kategoria_t AS OBJECT( 
emri varchar2(50));

CREATE TYPE autori_t AS OBJECT( 
emri varchar2(50));

-- Krijimi i tipeve qe perdoren si tabela te objekteve

CREATE TYPE kategoria_tab IS TABLE OF kategoria_t;

CREATE TYPE autori_tab IS TABLE OF autori_t;