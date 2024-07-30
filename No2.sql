SELECT 
    KodeBarang, 
    StokAkhir
FROM 
    HistoriStokBarang
WHERE 
    Tanggal = (SELECT MAX(Tanggal)
               FROM HistoriStokBarang AS latest
               WHERE latest.KodeBarang = HistoriStokBarang.KodeBarang);
