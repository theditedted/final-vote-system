<?php


$host = 'localhost';
$username = 'thedskie';
$password = 'password15!!'; // Replace 'your_password' with the actual password
$database = 'fingervotesystem';

// Create a connection
$conn = new mysqli($host, $username, $password, $database);

// Check the connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>