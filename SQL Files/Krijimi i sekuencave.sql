-- Krijimi i auto_number tek tabela Libri kolona libriId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE libri_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_libriSEQ
before insert on libri
for each row
begin
  select libri_seq.nextval
  into :new.libriId 
  from dual;
end;

-- Krijimi i auto_number tek tabela Botuesi kolona botuesiId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE botuesi_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_botuesiSEQ
before insert on botuesi
for each row
begin
  select botuesi_seq.nextval
  into :new.botuesiId 
  from dual;
end;

-- Krijimi i auto_number tek tabela Personat kolona personId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE personat_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_personatSEQ
before insert on personat
for each row
begin
  select personat_seq.nextval
  into :new.personId 
  from dual;
end;

-- Krijimi i auto_number tek tabela Puntoret kolona puntoriId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE puntoret_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_puntoretSEQ
before insert on puntoret
for each row
begin
  select puntoret_seq.nextval
  into :new.puntoriId 
  from dual;
end;

-- Krijimi i auto_number tek tabela Pagesa_llojet kolona pagesa_llojiId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE pagesa_llojet_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_pagesa_llojetSEQ
before insert on pagesa_llojet
for each row
begin
  select pagesa_llojet_seq.nextval
  into :new.pagesat_llojiId 
  from dual;
end;

-- Krijimi i auto_number tek tabela Fatura kolona faturaId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE fatura_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_faturaSEQ
before insert on fatura
for each row
begin
  select fatura_seq.nextval
  into :new.faturaId 
  from dual;
end;

-- Krijimi i auto_number tek tabela Pagesat kolona pagesaId nepermjet sekuences dhe triggerave.

CREATE SEQUENCE pagesat_seq START WITH 1 INCREMENT BY 1;

create or replace trigger trg_pagesatSEQ
before insert on pagesat
for each row
begin
  select pagesat_seq.nextval
  into :new.pagesaId 
  from dual;
end;
