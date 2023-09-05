<?php

	$servername = "localhost";
	$username = "Cust";
	$password = "";
	$database = "LawBuddy";
	$conn = new mysqli($servername, $username, $password,$database);

	if ($conn->connect_error) 
	{
  		die("Connection failed: " . $conn->connect_error);
	}
	$email =  $_POST['email']; 
	$pass = $_POST['pass'];
	
	if(!empty($email) && !empty($pass))
	{
		$query = "SELECT email, pass FROM signup WHERE email=? AND pass=?";
		$stmt = mysqli_prepare($conn, $query);
		mysqli_stmt_bind_param($stmt, "ss", $email, $pass);
		mysqli_stmt_execute($stmt);
		$result = mysqli_stmt_get_result($stmt);
	
		if ($result->num_rows == 1) 
		{
			?>
			<script>
		 		alert('Logged in successfully');
				window.location.href="index - Copy.html";
		 	</script>
			<?php
		} 
		else 
		{
			?>
			<script>
		 		alert('Please Enter the Regitered Email Id and Password');
				window.location.href="login.html";
		 	</script>
			<?php

		}
	} 
	else 
	{
		?>
			<script>
		 		alert('Email and Password are required');
				window.location.href="login.html";
		 	</script>
		<?php
		// echo "Email and password are required";
	}
	

?>