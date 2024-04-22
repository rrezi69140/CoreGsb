DELIMITER //

CREATE PROCEDURE verifierConnexion ( p_login VARCHAR(255),  p_mdp VARCHAR(255), OUT p_resultat BOOLEAN)
RETURN BOOLEAN
BEGIN
    DECLARE v_mot_de_passe VARCHAR(255);
    
    -- Récupérer le mot de passe associé au login fourni
    SELECT pwd_visiteur INTO v_mot_de_passe FROM gsb WHERE login_visiteur = p_login LIMIT 1;
    
    -- Vérifier si le mot de passe correspond
    IF v_mot_de_passe IS NOT NULL AND v_mot_de_passe = p_mdp THEN
        SET p_resultat = TRUE;
    ELSE
        SET p_resultat = FALSE;
    END IF;
END //

DELIMITER ;
