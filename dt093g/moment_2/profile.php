<?php
	session_start();

	if( !isset($_SESSION['username']) || isset($_REQUEST['logout']) ){
		header("location: logout.php");
	}
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8" /> 
	<title>Profile</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
<main>
	<h3>Välkommen <?= $_SESSION['username']; ?></h3>
	<form method="post" action="?logout=true">
		<button type="submit">Logga ut</button>
	</form>
</main>
</body>
</html>	