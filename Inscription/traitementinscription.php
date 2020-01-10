<?php 
include("connexioninscription.php");

$sexe=$_GET['drone'];
$prenom=$_GET['Prénom'];
$nom=$_GET['Nom'];
$mail=$_GET['mail'];
$password=$_GET['password'];
$mail=$_GET['mail'];
$telephone=$_GET['numero de telephone'];
$envoi=$_GET['envoi'];

$sql = "INSERT INTO inscription(id,drone,Prénom,Nom,password,mail,numero de telephone,envoi)
VALUES ('','$sexe','$prenom','$nom','$mail','$pas sword','$mail','$telephone','$envoi')";

if ($bdd->query($sql) === TRUE) {
    echo "Votre compte a été créer";
} else {
    echo "Error: " . $sql . "<br>" . $bdd->error;
}
?>
