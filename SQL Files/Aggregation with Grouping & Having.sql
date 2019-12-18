-- Query 1 with Grouping and Having

select concat(concat(p.emri.emri, ' '), p.emri.mbiemri) as Bleresi, sum(fd.sasia*fd.qmimi) as vleraFatures 
from fatura_detajet fd inner join fatura f on f.faturaId = fd.faturaId
inner join personat p on p.personId = f.klientiId
where f.fatura_lloji = 'D'
group by concat(concat(p.emri.emri, ' '), p.emri.mbiemri)
having sum(fd.sasia*fd.qmimi) > 50
order by sum(fd.sasia*fd.qmimi) desc
fetch next 3 rows only

-- Query 2 with Grouping and Having

select concat(concat(p.emri.emri, ' '), p.emri.mbiemri) as Bleresi, sum(fd.sasia*fd.qmimi) as vleraTotale
from fatura_detajet fd inner join fatura f on f.faturaId = fd.faturaId
inner join personat p on p.personId = f.klientiId
INNER JOIN libri l ON fd.libriId = l.libriId inner join botuesi b on b.botuesiId = l.botuesiid
where f.fatura_lloji = 'D' and b.vendi = 'Prishtine' and
extract (month from data_Fatures) >= extract(month from ADD_MONTHS(SYSDATE, -1))
group by concat(concat(p.emri.emri, ' '), p.emri.mbiemri)
order by sum(fd.sasia*fd.qmimi) desc
fetch next 5 rows only

