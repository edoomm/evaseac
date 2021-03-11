<?php

$insert1st = "";
$params = "";

include 'readcsv.php';
include '../../database/evaseacdb.php';
$link = open_database();

$messages = array();
$messages["error_queries"] = array();
$messages["error_mysql"] = array();

if(isset($_FILES['file_name'])){
    $data = getFileContent();
    $noRow = -1;

    foreach($data as $row){
        $query = "";

        $counter = 0;
        $noRow++;
        $col_num = count($row);
        foreach ($row as $col) {
            $counter++;
            if (isTableName($col)) {
                $tableName = substr($col, 1, strlen($col) - 2);
                // Deleting
                if (mysqli_query($link, "DELETE FROM " . $tableName) === FALSE) {
                    array_push($messages["error_queries"], "DELETE FROM " . $tableName);
                    array_push($messages["error_mysql"], "MySQL Error(" . mysqli_errno($link) . "):\n" . mysqli_error($link));
                }
                // delete($link, $tableName);

                $insert1st = "INSERT INTO " . $tableName;
                $noRow = 1;
            }
            else if ($noRow == 2) {
                if ($counter == 1) 
                    $params = "($col";
                else
                    $params .= $col;

                if ($counter != $col_num)
                    $params .= ", ";
                else
                    $params .= ") VALUE";
            }
            else if ($counter == 1)
                $query = "$insert1st $params (" . getSQLValue($col);
            else
                $query .=  getSQLValue($col);

            if ($noRow > 2) {
                if ($counter != $col_num)
                    $query .= ", ";
                else if (!isTableName($col)) {
                    $query .= ")";
                    // update($link, $query, $messages);
                    // Updating
                    // if (mysqli_query($link, $query) === FALSE) {
                    //     array_push($messages["error_queries"], $query);
                    //     array_push($messages["error_mysql"], "MySQL Error(" . mysqli_errno($link) . "):\n" . mysqli_error($link));
                    // }
                }
            }
        }
    }
    mysqli_close($link);
}

function isTableName($string) {
    if (empty($string))
        return false;
    if ($string[0] == "-" && $string[strlen($string) - 1] == "-")
        return true;
    return false;
}

function getSQLValue($value) {
    if (empty($value))
        return "NULL";
    if (!is_numeric($value))
        return "'$value'";

    return $value;
}

function delete($link, $tableName) {
    // echo "DELETE FROM $tableName\n";
    $query = "DELETE FROM $tableName";
    // mysqli_query($link, $query);
}

function update($link, $query, $messages) {
    // echo "$query\n";
    // mysqli_query($link, $query);
    // array_push($messages, $query);
}

echo json_encode($messages);

?>