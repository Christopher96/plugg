<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>TränaKnäna</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
<h1>TränaKnäna</h1>
<?php

	require_once("init.php");

	if( $load ){
		include("includes/booking_table.php");
		include("includes/booking_form.php");
	} else {
		echo "<h1>Vi erbjuder inga spinningpass på söndagar, kom tillbaka på måndag!</h1>";
	}
?>

</body>
</html>