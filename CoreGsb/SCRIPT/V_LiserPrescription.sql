CREATE VIEW V_ListerPrescription
AS
Select
P.id_medicament,   I.lib_type_individu	, D.qte_dosage ,D.unite_dosage,P.posologie FROM prescrire AS P
join dosage As D on P.id_dosage = D.id_dosage
join type_individu As I on P.id_type_individu  = I.id_type_individu 