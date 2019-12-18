-- Krijimi i viewave 
 
-- 1      
CREATE OR REPLACE VIEW LibratENjeBotuesi AS(
SELECT l.titulli, l.ISBN, b.botuesi_emri
FROM libri l inner join botuesi b on b.botuesiid = l.botuesiid
WHERE b.botuesi_emri like '%Dukagjini%');

-- 2

CREATE OR REPLACE VIEW LibratNeSasineMeTeMadhe AS(
SELECT titulli, barkodi, sasia, qmimi
FROM libri 
ORDER BY sasia desc
FETCH NEXT 10 ROWS ONLY);

SELECT * FROM LibratNeSasineMeTeMadhe

-- 3

CREATE OR REPLACE VIEW vw_personat AS (
SELECT p.personId, p.emri.emri as emri, p.emri.mbiemri as mbiemri
FROM personat p);

SELECT * FROM  vw_personat 

-- 4

CREATE OR REPLACE VIEW vw_adresat AS (
SELECT p.personid, p.emri.emri as emri, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, p.adresa.kodi_postal as kodi_postal , p.adresa.shteti as shteti
FROM personat p);

-- 5

CREATE OR REPLACE VIEW vw_VleraFatures AS (  
SELECT faturaId, sum(sasia*qmimi) as vlera 
FROM fatura_detajet
GROUP BY faturaId);

-- 6

CREATE OR REPLACE VIEW vw_botuesi as(
select botuesi_emri from botuesi)
 
-- Update View 
     
UPDATE vw_personat p 
SET p.emri = 'Ardi', 
	p.mbiemri = 'Spahija' 
WHERE p.personId = 1;

UPDATE vw_adresat p 
SET p.qyteti = 'Prizren', 
	p.kodi_postal = '30000' 
WHERE p.personId = 1;

SELECT * 
FROM vw_personat p 
WHERE p.personId = 1

-- Insert View

INSERT INTO vw_botuesi (botuesi_emri)
VALUES ('Buzuku')
