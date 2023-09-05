<!DOCTYPE html>
<html>
<head>
  <title>Search Results</title>
  <style>
    /* add any necessary styles for your search bar here */
  </style>
</head>
<body>
  <header>
    <img src="assets/img/Law-comrade.png" alt="Law Comrade" width="200px">
  </header>
  <main>
    <form action="search.php" method="get">
      <label for="searchTerm">Search:</label>
      <input type="text" name="searchTerm" id="searchTerm">
      <input type="submit" value="Search">
    </form>
    <h1>Search Results</h1>
    <?php
    // Database connection variables
    $servername = "localhost";
    $username = "Cust";
    $password = "";
    $dbname = "LawBuddy";

    // Create connection
    $conn = mysqli_connect($servername, $username, $password, $dbname);

    // Check connection
    if (!$conn) {
      die("Connection failed: " . mysqli_connect_error());
    }

    // Get the search term from the form submission
    $searchTerm = $_GET["searchTerm"];

    // SQL query to select the strings to compare to the search term
    $sql = "SELECT answer FROM qa";

    // Execute the query and get the result set
    $result = mysqli_query($conn, $sql);

    // Create an empty array to store the strings and their similarity scores
    $strings = array();

    // Loop through the result set and calculate the similarity score for each string
    while ($row = mysqli_fetch_assoc($result)) {
      $string = $row["answer"];
      $score = levenshtein($searchTerm, $string);
      $strings[] = array("string" => $string, "score" => $score);
    }

    // Sort the array by the similarity scores in ascending order
    usort($strings, function($a, $b) {
      return $a['score'] - $b['score'];
    });

    // Display the sorted strings and their similarity scores
    foreach ($strings as $string) {
      echo "<p>" . $string["string"] . " (Score: " . $string["score"] . ")</p>";
    }

    // Close the database connection
    mysqli_close($conn);
    ?>
  </main>
  <footer>
    <!-- add any necessary footer content here -->
  </footer>
</body>
</html>
