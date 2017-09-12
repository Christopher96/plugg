<?php include("includes/login.php"); ?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8" /> 
	<title>Login</title>
	<link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
<main>
	<span id="error"><?= $error; ?></span>
	<form method="post" action="">
		<div><span>Användarnamn: </span><input type="text" name="username"></div>
		<div><span>Lösenord: </span><input type="password" name="password"></div>
		<button type="submit">Logga in</button>
	</form>
</main>
</body>
</html>