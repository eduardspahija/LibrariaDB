-- Krijimi i Cursor-it

DECLARE
  CURSOR c_fatura_detajet IS
  SELECT  f.fatura_lloji, fd.libriid, fd.sasia  FROM fatura f inner join fatura_detajet fd  on f.faturaId = fd.faturaId;    
   r_fatura_detajet c_fatura_detajet%ROWTYPE;
BEGIN
  UPDATE libri SET sasia = 0;
  OPEN c_fatura_detajet;
  LOOP
  FETCH  c_fatura_detajet  INTO r_fatura_detajet;
  EXIT WHEN c_fatura_detajet%NOTFOUND;
  -- update sasia per librin aktual
  IF r_fatura_detajet.fatura_lloji = 'H' THEN
    UPDATE libri set sasia = sasia + r_fatura_detajet.sasia WHERE libriid = r_fatura_detajet.libriid;
  ELSE
    UPDATE libri set sasia = sasia - r_fatura_detajet.sasia WHERE libriid = r_fatura_detajet.libriid;
  END IF;
  END LOOP;
  CLOSE c_fatura_detajet;
END;
