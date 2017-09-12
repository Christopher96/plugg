<?php

	$error = "";

	if( isset($_SESSION['username']) ){
		redirect();
	} else {
		if( !empty($_REQUEST['username']) && !empty($_REQUEST['password']) ){

			$username = $_REQUEST['username'];
			$password = $_REQUEST['password'];

			if( $username === "admin" && $password === "password" ){
				session_start();
				$_SESSION['username'] = $username;
				logUser( $username, true );

				redirect();
			} else {
				$error = "Felaktigt användarnamn/lösenord.";
				logUser( $username, false );  
			}
		}
	}

	function logUser($username, $success){

		$date = date("Y-m-d, H:i:s");
		$prefix = ($success) ? "Lyckad" : "Misslyckad";
		$success_txt = $prefix." inlogging för användare '".$username."'";
		$separator = ", ";

		$attempt = $date.$separator.$success_txt."\n";

		$path = $_SERVER['CONTEXT_DOCUMENT_ROOT']."/writeable/logs/recent_logins.txt";

		file_put_contents($path, $attempt, FILE_APPEND);
	}

	function redirect(){
		header("location: profile.php");
	}
?>