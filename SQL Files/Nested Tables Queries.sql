-- INSERT � q� regjistron t� dh�na n� tabela t� mb�rthyera

-- Insertimi i dy apo me shume rreshtave

INSERT ALL
INTO libri (barkodi,titulli,isbn,botuesiId,qmimi,sasia,kategoria,autori) 
VALUES ('5941021000899', 'Hajdi', '9780789462008' ,3,3,20, 
kategoria_tab(kategoria_t('Roman'), 
              kategoria_t('Per femije'), 
              kategoria_t('Drame'),
              kategoria_t('Aventure')),
autori_tab(autori_t('Johanna Spyri')))
INTO libri (barkodi,titulli,isbn,botuesiId,qmimi,sasia,kategoria,autori) 
VALUES ('9788853615787', 'Aventurat e Tom Sojerit', '9781615701292' ,1,3,20, 
kategoria_tab(kategoria_t('Roman'), 
              kategoria_t('Per femije'), 
              kategoria_t('Aventure')),
autori_tab(autori_t('Mark Twain')))
SELECT * FROM dual; 

-- Insertimi i nje rreshti

INSERT INTO libri (barkodi,titulli,isbn,botuesiId,qmimi,sasia,kategoria,autori) 
VALUES ('554703400749', 'Beni ecen vetem', '8750789464004' ,2,3,50, 
kategoria_tab(kategoria_t('Roman'), 
              kategoria_t('Per femije'), 
              kategoria_t('Aventure')),
autori_tab(autori_t('Ki�o Blushi')))

-- Insertimi i tabel�s s� mb�rthyer

INSERT INTO TABLE(SELECT l.kategoria FROM libri l WHERE l.titulli = 'Hajdi') 
VALUES ('Poezi');

-- DELETE � q� fshin� t� dh�na  brenda tabel�s s� mb�rthyer

DELETE FROM TABLE (SELECT l.kategoria FROM libri l WHERE l.titulli = 'Hajdi') k
WHERE k.emri='Romance';

-- UPDATE - q� modifikon t� dh�nat brenda tabel�s t� mb�rthyer

UPDATE TABLE (SELECT kategoria FROM libri WHERE titulli = 'Hajdi') k
SET VALUE(k) = kategoria_t('Romance') 
WHERE VALUE(k) = kategoria_t('Poezi');

-- SELECT - q� p�rmban atribute t� tabelave t� mb�rthyera
-- 1

SELECT titulli, isbn, cardinality(kategoria) as "Numri i kategorive", cardinality(autori) as "Numri i autoreve" 
FROM libri;

-- 2

SELECT l.titulli, l.sasia, l.qmimi
FROM libri l, TABLE (l.kategoria) k 
WHERE k.emri = 'Drame'
ORDER BY l.titulli;

-- 3

SELECT l.titulli, k.emri
FROM libri l, 
THE( SELECT kategoria FROM libri where titulli = 'Hajdi' ) k
WHERE l.titulli='Hajdi';

-- 4

SELECT l.titulli, k.emri
FROM libri l, 
THE( SELECT kategoria FROM libri where titulli = 'Hajdi' ) k;



