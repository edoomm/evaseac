<?php

include_once '../../database/evaseacdb.php';
$conn = open_database();

$user = $_POST["user"];
$pwd = $_POST["password"];

$query = "SELECT * FROM Usuario WHERE usuario = '$user' and password = '$pwd'";
$numRows = mysqli_num_rows(mysqli_query($conn, $query));

mysqli_close($conn);

if ($numRows == 1)
    echo "true";
else
    echo "false";

?>