<?php 

	include("info.php"); 
	$info = getInfo();
?>

<section>
	<h2>Information</h2>
	<ul>
		<li><b>IP Adress: </b><span><?= $info['ip_address']; ?></span></li>
		<li><b>Datum: </b><span><?= $info['date'].", ".$info['date_text'] ?></span></li>
		<li><b>User Agent: </b><span><?= $info['user_agent']; ?></span></li>
		<li><b>Sökväg/filnamn: </b><span><?= $info['path']; ?></span></li>
	</ul>
</section>