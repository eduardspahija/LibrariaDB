SELECT concat(concat(p.emri.emri,' '),p.emri.mbiemri) as "Emri i Punetorit", puntoriid, menaxherid, 
prior concat(concat(p.emri.emri, ''),p.emri.mbiemri), level
from puntoret pu inner join personat p on p.personid=pu.personid
connect by prior puntoriid=menaxherid
start with menaxherid is NULL ;