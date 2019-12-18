--Windowing

SELECT l.titulli, fd.sasia*fd.qmimi as vlerashitjes,
SUM(fd.sasia*fd.qmimi) OVER() AS total_vlerashitjes,
SUM(fd.sasia*fd.qmimi) OVER(PARTITION BY f.faturaId) AS fatura_vlerashitjes
FROM fatura f inner join fatura_detajet fd on f.faturaId = fd.faturaId
inner join libri l on l.libriid = fd.libriid
where f.fatura_lloji = 'D'
ORDER BY l.titulli;

-- Ranking

SELECT RANK() OVER (ORDER BY sum(fd.sasia*fd.qmimi) DESC) Ranku, l.titulli, sum(fd.sasia*fd.qmimi) as vlera_shitjes
FROM libri l INNER JOIN fatura_detajet fd on fd.libriid = l.libriid 
group by l.titulli;

SELECT DENSE_RANK() OVER (ORDER BY l.sasia DESC) Ranku, l.titulli, l.sasia FROM libri l      