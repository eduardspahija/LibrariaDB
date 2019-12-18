create or replace function LLogaritVleraFatures(nfaturaId IN number)
return number
is VleraFatures number(12,2);
begin
select sum(fd.sasia*fd.qmimi) into VleraFatures from fatura_detajet fd where fd.faturaId = nfaturaId;
return(VleraFatures);
end LLogaritVleraFatures;

SELECT LLogaritVleraFatures(31) AS "Llogaritja e vleres se fatures" FROM DUAL;
