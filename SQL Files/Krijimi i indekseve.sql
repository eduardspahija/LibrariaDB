-- Krijimi i Bitmap Indeksave

CREATE bitmap INDEX gjinia_index ON personat (gjinia);
CREATE bitmap INDEX fatura_lloji_index ON fatura (fatura_lloji);

-- Krijimi i Indekseve Normale 

CREATE INDEX libri_barkodi_index on libri (barkodi); 
CREATE INDEX libri_titulli_index on libri (titulli);
CREATE INDEX libri_ISBN_index on libri (ISBN);
CREATE INDEX libri_botuesi_index on libri (botuesiId);
CREATE INDEX personat_emri_index on personat (emri.emri,emri.mbiemri);
CREATE INDEX personat_nr_personal_index on personat (nr_personal);
CREATE INDEX botuesi_emri_index on botuesi (botuesi_emri);
CREATE INDEX fatura_pagesa_lloji_index on fatura (pagesa_llojiId);
CREATE INDEX fatura_klientiId_index on fatura (klientiId);
CREATE INDEX fatura_puntoriId_index on fatura (puntoriId);
CREATE INDEX pagesat_faturaId_index on pagesat (faturaId);
CREATE INDEX puntoret_personat_index on puntoret (personId);
CREATE INDEX fatura_detajet_libriId_index on fatura_detajet (libriId);

-- Krijimi i Unique Indekseve

CREATE UNIQUE INDEX punetoret_username_index on puntoret (userName);
CREATE UNIQUE INDEX personat_email_index on personat (email);
CREATE UNIQUE INDEX personat_nr_personal_index on personat (nr_personal);

-- Krijimi i Function Based Indekseve

CREATE INDEX libri_titulli_index_upper ON libri (LOWER(titulli));
CREATE INDEX personat_emri_index_lower ON personat (LOWER(emri.emri),LOWER(emri.mbiemri));