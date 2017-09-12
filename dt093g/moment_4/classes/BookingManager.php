<?php

class BookingManager {

	private $con;

	function __construct(){
		$this->con = new Connect;
	}

	function getBookings(){

		$bookings = array();

		if( $result = $this->con->query("SELECT * FROM Bookings") ){

			while ($row = $result->fetch_assoc()) {
		       	$bookings[] = $row;
		    }

			$result->close();
		}

		return $bookings;
	}

	function createBooking( $d, $c, $n ){

		$t = date("Y-m-d, H:i:s");

		// The (?,?,?) below are parameter markers used for variable binding
		$sql = "INSERT INTO Bookings (daypass, cycle, name, timestamp) VALUES (?,?,?,?)";

		if( $stmt = $this->con->prepare($sql) ){

			$stmt->bind_param("iiss", $d, $c, $n, $t); // bind variables
			$stmt->execute(); // execute the prepared statement
		}


		$stmt->close(); // close the prepared statement
	}


	function removeBooking( $ID ){

		// The (?,?,?) below are parameter markers used for variable binding
		$sql = "DELETE FROM Bookings WHERE ID=?";

		if( $stmt = $this->con->prepare($sql) ){

			$stmt->bind_param("i", $ID); // bind variables
			$stmt->execute(); // execute the prepared statement
		}

		$stmt->close(); // close the prepared statement

	}

}