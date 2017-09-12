<?php

class BookingManager {

	private $bookings_array;

	function __construct(){
		$this->bookings_array = $this->getBookings();
	}

	function getBookings(){
		if( !isset($bookings_array) ){
			$bookings_data = file_get_contents(BOOKINGS_DATA_PATH);
			return ( !empty($bookings_data) ) ? unserialize( $bookings_data ) : array();
		} else {
			return $bookings_array;
		}
	}


	function updateBookings(){
		file_put_contents(BOOKINGS_DATA_PATH, serialize($this->bookings_array));
	}

	function createBooking( $isDayPass, $spinningCycle, $name ){
		$booking = new Booking( $isDayPass, $spinningCycle, $name );

		array_push($this->bookings_array, $booking);
		$this->updateBookings();
	}


	function removeBooking( $ID ){
		if( isset($this->bookings_array[$ID]) ){

			unset($this->bookings_array[$ID]);
			$this->bookings_array = array_values($this->bookings_array);

			$this->updateBookings();
		}

	}

}