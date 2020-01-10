
<?php
try
{
	$bdd = new mysqli('localhost','root','','PPE SLAM2');
}
catch (Exception $e)
{
        die('Erreur : ' . $e->getMessage());
}
?>
