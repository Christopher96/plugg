<?php

class Connect extends mysqli {
	
	private $dbhost = "localhost";
	private $dbuser = "root";
	private $dbpass = "root";
	private $db = "dhchat";

	function __construct(){
 
		parent::__construct( $this->dbhost, $this->dbuser, $this->dbpass, $this->db );

		if ($this->connect_errno) {
	    	printf("Connect failed: %s\n", $this->connect_error);
	    	exit();
		}
	}

	function asdf(){
		return 'asdf'
	}


}