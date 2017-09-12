<?php

class Booking {
	private $isDayPass;
	private $spinningCycle;
	private $name;
	private $timeStamp;

	function __construct($isDayPass, $spinningCycle, $name){
		$this->isDayPass = $isDayPass;
		$this->spinningCycle = $spinningCycle;
		$this->name = $name;
		$this->timeStamp = date("Y-m-d, H:i:s");
	}

	function __toString(){
		$pass = ($this->isDayPass) ? "Dagspass" : "Kvällspass";
		return "<td>".$this->timeStamp."</td><td>".$this->name."</td><td>".$pass."</td><td>".$this->spinningCycle."</td>";
	}

	function getPass(){
		return $this->isDayPass;
	}

	function getCycle(){
		return $this->spinningCycle;
	}
}