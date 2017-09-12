<?php 

class Main {

	private $manager;

	function __construct( BookingManager $manager ){
		$this->manager = $manager;

		if( isset($_GET['remove']) ){
			$this->manager->removeBooking( $_GET['remove'] );
		}

		if( ( isset($_POST['daypass']) || isset($_POST['nightpass']) ) && isset($_POST['signature']) ){
			if( isset($_POST['daypass']) ) $this->manager->createBooking( true, $_POST['daypass'], $_POST['signature']);
			if( isset($_POST['nightpass']) ) $this->manager->createBooking( false, $_POST['nightpass'], $_POST['signature']);
		}
	}

	function generateBookingList(){

		$bookings = $this->manager->getBookings();

		foreach($bookings as $booking) {
			$pass = ($booking["daypass"]) ? "Dagspass" : "Kvällspass";
			echo "<tr><td><a href='?remove=".$booking["ID"]."'>Avboka</a></td><td>".$booking["timestamp"]."</td><td>".$booking["name"]."</td><td>".$pass."</td><td>".$booking["cycle"]."</td></tr>";
		}
	}

	function generateCycleOptions( $daypass ){

		$bookings = $this->manager->getBookings();

		for($i=1; $i<=10; $i++){

			$disabled = "";

			foreach ($bookings as $booking) {
				if( $booking["cycle"] == $i ){
					if( ($booking["daypass"] && $daypass) || ( !$booking["daypass"] && !$daypass ) ){
						$disabled = "disabled";
						break;
					}
				}
			}

			$name = ($daypass) ? "daypass" : "nightpass";

			echo "$i<input type='radio' name='$name' value='$i' $disabled>  ";
		}
	}

}