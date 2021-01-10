<?php

include 'readcsv.php';
if(isset($_FILES['file_name'])){
    $data = getFileContent();
    echo count($data[0]) . "\n\n";
    foreach($data as $row){
        $counter = 0;
        $col_num = count($row);
        foreach ($row as $col) {
            $counter++;
            echo $col;
            if ($counter != $col_num)
                echo ", ";
        }
        echo "\n";

        // echo $row[0] . "\n";

        // $id_linea = $row[0];
        // $sku = $row[1];
        // $descripcion = $row[2];
        // $generico = $row[3];
        // $unidad_medida = 1; 

        // $sql_query = "INSERT INTO Producto (sku, id_linea, generico, unidad_medida, descripcion) VALUES('".$sku."','".$id_linea."','".$generico."','".$unidad_medida."','".$descripcion."')";
        // echo $sql_query . "\n";
        // mysqli_query($conn, $sql_query);
    }
    // mysqli_close($con);
}

?>