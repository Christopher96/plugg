
<?php

$load = true;

if( date("w") == 0 ) {
	$load = false;
	return;
}

if( isset($_SERVER['CONTEXT_DOCUMENT_ROOT']) ){
	$root = $_SERVER['CONTEXT_DOCUMENT_ROOT'];
} else {
	$root = $_SERVER['DOCUMENT_ROOT'];
}

define("BOOKINGS_DATA_PATH", $root."/writeable/data/bookings.data");

spl_autoload_register(function($class){
	require_once("classes/{$class}.php");
});

$main = new Main(new BookingManager);