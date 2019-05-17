<?php


$dbname = 'UnityDB';
$dbuser = 'camilo';
$dbpass = 'Noviembre2018';
$dbhost = 'localhost';

//conectarce al servidor mysql  (servidor,user,pasword,NombreBD)
$conect = new mysqli($dbhost, $dbuser, $dbpass,$dbname);

$userID = $_REQUEST['UserId'];

//consultar la tabla, lo q uno pone en select es lo q va a buscar
$consulta = mysqli_query($conect, "SELECT * FROM Animacion WHERE UserId ='$userID' AND Pose=1 LIMIT 1");

        //este es un arreglo llamado $botones1, aqui estoy obteniendo toda la info
while($potenciometro= mysqli_fetch_array($consulta))
{   //y stas son variables, lo q queda dentro de a comilla sencilla e el nombre en la db
	$pose = $potenciometro['Pose'];
	$pot1 = $potenciometro['Pot1'];	
	$pot2 = $potenciometro['Pot2'];
	$pot3 = $potenciometro['Pot3'];
	$pot4 = $potenciometro['Pot4'];
	$pot5 = $potenciometro['Pot5'];	
	$pot6 = $potenciometro['Pot6'];
	$pot7 = $potenciometro['Pot7'];
	$pot8 = $potenciometro['Pot8'];
	$pot9 = $potenciometro['Pot9'];
}

$resul= $pose." ".$pot1." ".$pot2." ".$pot3." ".$pot4." ".$pot5." ".$pot6." ".$pot7." ".$pot8." ".$pot9;

echo $resul;



?>