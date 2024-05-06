DELIMITER //

CREATE   FUNCTION F_Supprimer_Precription(id_supprimerMedicament INT, id_supprimerdosage INT,Type_supprimerindividue INT)
    RETURNS INT
BEGIN
    DECLARE Response INT DEFAULT 0;

DELETE FROM prescrire
WHERE id_medicament = id_supprimerMedicament AND 	id_dosage   = id_supprimerdosage AND id_type_individu = Type_supprimerindividue ;


IF NOT EXISTS (SELECT 1 FROM prescrire WHERE id_medicament = id_supprimerMedicament AND 	id_dosage   = id_supprimerdosage AND id_type_individu = Type_supprimerindividue) THEN
        SET Response = 1;
END IF;

RETURN Response;
END//

DELIMITER ; 