
<?php 
include("connexioninscription.php");
 
// on prépare la requête SQL
	$affichage = "SELECT *	FROM inscription";

	// on l'exécute
	$requete = $bdd->query($affichage);

	// si la requete n'a pas renvoyée d'erreur ET (noté &&) si on a au moins un résultat 
	if( $requete && $requete->num_rows > 0 ) {

		// démarrons une boucle sur tous résultats renvoyés
		while ($lesresultats = $requete->fetch_assoc()) {
			echo $lesresultats['drone'].''.$lesresultats['Prénom'].''.'<br/>';
			echo ''.$lesresultats['Nom'].''.$lesresultats['mail'].'<br/>';
			$lesresultats['password'].'<br/>';
			echo $lesresultats['numero de telephone'].'<br/>';
			echo $lesresultats['envoi'].'<br/>';
		}
	}
$bdd->close();
?>
