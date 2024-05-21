CREATE VIEW V_ListerComposition
AS
Select
 C.id_medicament,C.qte_composant,CM.id_composant, CM.lib_composant FROM constituer AS C
join composant As CM on C.id_composant  = CM.id_composant 
 