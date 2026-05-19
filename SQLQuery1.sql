
ALTER VIEW [dbo].[vwBalantaDeVerificare] AS
SELECT 
    -- Wrap your unique identifier in ISNULL to force it to be NOT NULL
    ISNULL(Cont.Id, 0) AS Id, 

    Cont.Simbol AS Simbol,
    Cont.Denumire AS Denumire,
	COALESCE(Cont.SID, 0) AS [SID],
	COALESCE(Cont.SIC, 0) AS SIC,
	COALESCE(SUM(Rulaje.SumaD), 0) AS [Rulaj D],
	COALESCE(SUM(Rulaje.SumaC), 0) AS [Rulaj C],
	COALESCE(Cont.SID, 0) + COALESCE(SUM(Rulaje.SumaD), 0) AS [TSD],
	COALESCE(Cont.SIC, 0) + COALESCE(SUM(Rulaje.SumaC), 0) AS [TSC]
FROM Cont 
LEFT JOIN Rulaje ON Cont.Id = Rulaje.IdCont
GROUP BY 
	Cont.Id, 
	Cont.Simbol, 
	Cont.Denumire, 
	Cont.SID, 
	Cont.SIC
--SELECT * FROM vwBalantaDeVerificare