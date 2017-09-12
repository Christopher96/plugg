<?php
	
	function getInfo(){

		$info = array();

		if (!empty($_SERVER['HTTP_CLIENT_IP'])) {
		    $info['ip_address'] = $_SERVER['HTTP_CLIENT_IP'];
		} elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR'])) {
		    $info['ip_address'] = $_SERVER['HTTP_X_FORWARDED_FOR'];
		} else {
		    $info['ip_address'] = $_SERVER['REMOTE_ADDR'];
		}


		$info['date'] = date("Y-m-d, H:i:s");

		$day = date("N");
		$info['date_text'] = "Fortfarande inte fredag.";
		if( $day == 5 )
			$info['date_text'] = "Äntligen fredag!!!";

		$info['user_agent'] = $_SERVER["HTTP_USER_AGENT"];

		$info['path'] = $_SERVER["PHP_SELF"];

		return $info;

	}
?>
