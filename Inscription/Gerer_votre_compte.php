<?php 
include("connexioninscription.php"); //inclus et exécute le fichier, message d'avertissement si absent

$sexe=$_GET['drone'];//fait circuler les information dans la barre de recherche
$prenom=$_GET['Prénom'];
$nom=$_GET['Nom'];
$mail=$_GET['mail'];
$password=$_GET['password'];
$mail=$_GET['mail'];
$telephone=$_GET['numero de telephone'];
$envoi=$_GET['envoi'];

$sql = "UPDATE inscription SET "(drone='$sexe',Prénom='$prenom',Nom='$nom',password='$password',mail='$mail',numero de telephone='$telephone',envoi='$envoi') //changement des valeurs de la table
VALUES ('','$sexe','$prenom','$nom','$mail','$password','$mail','$telephone','$envoi')";

if ($bdd->query($sql) === TRUE) //test de l'execution de la requete
{
    echo "Votre compte a été modifié avec succès";
} 
else 
{
    echo "Erreur dans la modification: " . $sql . "<br>" . $bdd->error;
}
?>
