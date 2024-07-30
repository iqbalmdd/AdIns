SELECT 
    b.KODEBRG,
    b.NAMABRG,
    SUM(j.JUMLAH) AS JML_JUAL
FROM
    BARANG b
JOIN
    JUAL j ON j.KODEBRG = b.KODEBRG
GROUP BY 
    b.KODEBRG, b.NAMABRG;
