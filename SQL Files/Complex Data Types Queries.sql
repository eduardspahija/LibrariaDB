-- SELECT - që përmban atribute të tipeve komplekse
-- 1

SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia,
       p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, 
       p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email
FROM personat p;

-- 2

SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, 
       p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, 
       p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email 
FROM personat p where lower(p.emri.emri) like '%edu%';  --'%" + sKerkimi + "%'"

-- 3

SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia,
       p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, 
       p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email
FROM personat p where lower(p.emri.mbiemri) like '%spa%';     --'%" + sKerkimi + "%'"

-- 4

SELECT p.PersonId,p.emri.emri as emri, p.emri.mbiemri as mbiemri, p.nr_personal, p.gjinia, 
       p.telefoni, p.adresa.adresa as adresa, p.adresa.qyteti as qyteti, 
       p.adresa.kodi_postal as kodi_postal, p.adresa.shteti as shteti, p.email 
FROM personat p where lower(p.emri.emri) like  '%edu%'/*'%" + sEmri + "%' */ and lower(p.emri.mbiemri) like '%spa%';/*'%" + sMbiemri + "%'"*/

-- INSERT – që regjistron të dhëna në atribute komplekse

-- Insertimi i dy apo me shume rreshtave

INSERT ALL
INTO personat (emri, nr_personal, gjinia, email, adresa, data_regjistrimit)
Values (emri('Eduard', 'Spahija'), '1230907996', 'M', 'eduard-spahija@hotmail.com', 
        adresa('Rr. Mehmet Gradica','Prishtine','Kosove', '10000'), date '2019-07-10')
INTO personat (emri, nr_personal, gjinia, email, adresa, data_regjistrimit)
Values (emri('Edon', 'Shkuliqi'), '1210299547', 'M', 'edonshkuliqi@hotmail.com', 
        adresa('Rr. Azem Shkreli','Prishtine','Kosove', '10000'), date'2019-07-10')
SELECT * FROM dual;  

-- Insertimi i nje rreshti

INSERT INTO personat(emri, nr_personal, gjinia, email, telefoni, adresa)
Values(emri('Majlinda', 'Kelmendi'), '1238549657', 'F', 'majlindakelmendi@hotmail.com',
'049 574 845',adresa('Rr. Isa Boletini', 'Peje', 'Kosove', '20000'));

-- INSERT – që regjistron të dhëna në atribute komplekse - qe eshte perdorur brenda aplikacionit

/*
INSERT INTO personat(emri, nr_personal, gjinia, email, telefoni, adresa)
VALUES (emri('" + sEmri + "', '" + sMbiemri + "'), '" + sNrPersonal + "', 
	   '" + sGjinia + "', '" + sEmail + "',
       '" + sTelefoni + "', 
	   adresa('" + sAdresa + "', '" + sQyteti + "', '" + sShteti + "', '" + sKodiPostal + "'));
*/

-- UPDATE – që modifikon të dhënat e atributeve komplekse

UPDATE personat p 
SET p.emri.emri = 'Nita',
	p.emri.mbiemri = 'Osmoni',
	p.nr_personal = '125746898',
	p.gjinia = 'F',
	p.email = 'nitaosmani@hotmail.com', 
	p.adresa.adresa = 'Rr. Luigj Gurakuqi, 7'
	p.adresa.qyteti = 'Mitrovice', 
	p.adresa.kodi_Postal = '20000',
	p.adresa.shteti = 'Kosove', 
	p.telefoni=  '049 578 468' 
WHERE p.PersonId = 42;

-- UPDATE – që modifikon të dhënat e atributeve komplekse - qe eshte perdorur brenda aplikacionit

/*
UPDATE personat p 
SET p.emri.emri = '" + sEmri + "',
    p.emri.mbiemri = '" + sMbiemri + "',
    p.nr_personal = '" + sNrPersonal + "', 
	p.gjinia = '" + sGjinia + "',
    p.email = '" + sEmail + "', 
	p.adresa.adresa = '" + sAdresa + "',
    p.adresa.qyteti = '" + sQyteti + "', p.adresa.kodi_Postal = '" + sKodiPostal + "', 
    p.adresa.shteti = '" + sShteti + "', p.telefoni=  '" + sTelefoni + "'" 
WHERE p.PersonId = '" + lPersonId.ToString() + "';
*/