-- Krijimi i cluster-it 

CREATE CLUSTER fatura_faturaDetajet (faturaId int);

-- Krijimi i indexit per cluster-in

CREATE INDEX cluster_index_fatura_faturaDetajet ON CLUSTER fatura_faturaDetajet;