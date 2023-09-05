<!DOCTYPE html>
<html>
<head>
	<title>FAQ Search Results</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!-- Favicons -->
	<link href="assets/img/favicon1.png" rel="icon">
  	<link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">
	<style>
		body {
			font-family: Arial, sans-serif;
			background-color: #f5f5f5;
			margin: 0;
			padding: 0;
		}
		.container {
		max-width: 800px;
		margin: 0 auto;
		padding: 20px;
		box-sizing: border-box;
		}

		h1 {
			text-align: center;
			margin-top: 0;
			margin-bottom: 20px;
			color: #37517e;

		}
		p {
			margin: 10;
			padding: 10px;
			background-color: white;
			border: 1px solid #ccc;
			border-radius: 4px;
			box-sizing: border-box;
			margin-bottom: 10px;
		}

		.no-results {
			background-color: #f44336;
			color: white;
			padding: 10px;
			border-radius: 4px;
			box-sizing: border-box;
			margin-bottom: 10px;
		}
</style>
</head>
<body>	
	<h1>FAQ Search Results</h1>
	<img src="assets/img/Law-comrade.png" alt="law comrade" style="max-width: 100%; height: auto; width: 20%; display: block; margin: auto;">
	<?php
	// Connect to the database
	$servername = "localhost";
	$username = "Cust";
	$password = "";
	$dbname = "LawBuddy";
	$conn = mysqli_connect($servername, $username, $password, $dbname);

	// Check connection
	if (!$conn) {
		die("Connection failed: " . mysqli_connect_error());
	}

	// Get user input from form submission
	$question = $_POST["question"];
	$aspect = $_POST["aspect"];

	// Construct the SQL query
	$sql = "SELECT answer FROM qa WHERE question LIKE '%$question%' AND aspect = '$aspect'";

	// Execute the query and get the results
	$result = mysqli_query($conn, $sql);

	// Check if any results were found
	if (mysqli_num_rows($result) > 0) {
		// Display the results
		while($row = mysqli_fetch_assoc($result)) {
			echo "<p>" . $row["answer"] . "</p>";
		}
	} else {
		// Display a message if no results were found
		echo "<p>No results found.</p>";
	}

	// Close the database connection
	mysqli_close($conn);
	?>
</body>
</html>
