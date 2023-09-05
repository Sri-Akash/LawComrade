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
	try
	{
		$username = $_POST["user"];
		$email = $_POST["email"];
		$password = $_POST["pass"];
		$confirm_password = $_POST["conpass"];
		if (empty($username) || empty($email) || empty($password) || empty($confirm_password)) 
		{
			?>
			<script>
				alert('Please fill out all fields');
				window.location.href="register.html";
	   		</script>
			<?php
		} 
		else 
		{
			if (!preg_match("/^[a-zA-Z0-9]{4,20}$/", $username)) 
			{
				?>
				<script>
					alert('Username must be alphanumeric and between 4 and 20 characters.');
					window.location.href="register.html";
				</script>
				<?php
			}
			elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) 
			{
				?>
				<script>
					alert('Invalid email format.');
					window.location.href="register.html";
				</script>
				<?php
			}
			elseif (!preg_match("/^(?=.*[a-zA-Z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$/", $password)) 
			{
				?>
				<script>
					alert('Password must be at least 8 characters and contain at least one letter, one number, and one special character.');
					window.location.href="register.html";
				</script>
				<?php
			}
			elseif ($password !== $confirm_password) 
			{
				?>
				<script>
					alert('Passwords do not match.');
					window.location.href="register.html";
				</script>
				<?php
			} 
			else 
			{
				$stmt = $conn->prepare("INSERT INTO signup (username, email, pass) VALUES (?, ?, ?)");
				$stmt->bind_param("sss", $username, $email, $password);
				$stmt->execute();
				$stmt->close();
				header("Location: login.html");
				exit();
			}
		}
	}
	catch (mysqli_sql_exception $e) 
	{
		?>
		<script>
			alert('Email Id Already Exists');
			window.location.href="register.html";
		</script>
		<?php
	}
?>