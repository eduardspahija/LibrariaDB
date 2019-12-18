create or replace NONEDITIONABLE TRIGGER FATURA_D_TRIG AFTER INSERT ON FATURA_DETAJET
FOR EACH ROW
declare llojifat char(1);
begin
      select f.fatura_lloji into llojifat from fatura f where f.faturaId = :new.faturaId;
      IF llojifat = 'D' THEN
        UPDATE libri l SET l.sasia = l.sasia - :new.sasia where :new.libriId = l.libriId;
      ELSE
        UPDATE libri l SET l.sasia = l.sasia + :new.sasia where :new.libriId = l.libriId;
      END IF;  
 END;