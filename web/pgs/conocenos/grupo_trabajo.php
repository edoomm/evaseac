<?php
define('NOM_MEM1', 'eugenia');
define('NOM_MEM2', 'elias');
define('PLACEHOLDER', '../../imgs/placeholder-user.jpg');
?>

<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <title>Evaseac - Grupo de trabajo</title>

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width = device-width, initial-scale = 1">

    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <!-- Styles -->
    <link rel="stylesheet" href="../../css/custom.css">
    <!-- Icon -->
    <link rel="icon" href="../../imgs/Evaseac.ico">
  </head>
  <body>

    <!-- Header -->
    <div class="jumbotron"
      style="margin-bottom: 0px;
      height: 175px;
      background-image: url('../../imgs/header.png');
      background-repeat: no-repeat;
      background-position: center;
      ">
    </div>

    <!-- Navigation Bar -->
    <nav class="navbar navbar-expand-md navbar-dark bg-primary sticky-top">

      <button class="navbar-toggler" data-toggle="collapse" data-target="#navbar_menu">
        <p><span class="navbar-toggler-icon"></span>Menú</p>
      </button>

      <div class="collapse navbar-collapse justify-content-md-center" id="navbar_menu">
        <ul class="navbar-nav" style="margin-bottom: -20px; margin-top: -10px">
          <li class="nav-item" style="padding-right: 35px; padding-left: 35px;">
            <a class="nav-link" href="../../index.html"><p class="lead">Inicio</p></a>
          </li>
          <li class="nav-item dropdown" style="padding-right: 35px; padding-left: 35px;">
            <a class="nav-link dropdown-toggle active" data-toggle="dropdown" data-target="#nav_conocenos" href="#">
              <font class="lead">Conócenos</font>
            </a>
            <div class="dropdown-menu" aria-labelledby="nav_conocenos">
              <a class="dropdown-item" href="grupo_trabajo.html">Grupo de trabajo</a>
              <a class="dropdown-item" href="investigacion.html">Investigación</a>
            </div>
          </li>
          <li class="nav-item" style="padding-right: 35px; padding-left: 35px;">
            <a class="nav-link" href="#" onclick="btnConsultar_Click();"><p class="lead">Consultar</p></a>
          </li>
          <li class="nav-item" style="padding-right: 35px; padding-left: 35px;">
            <a class="nav-link" href="../sitios/ingresar.html" onclick=""><p class="lead">Insertar</p></a>
          </li>
        </ul>
      </div>
    </nav>

    <br>

    <!-- Principal Members -->
    <div class="container">
      <?php
      // defining str_contains function
      if (!function_exists('str_contains')) {
        function str_contains(string $haystack, string $needle): bool
        {
            return '' === $needle || false !== strpos($haystack, $needle);
        }
      }

      include '../../database/evaseacdb.php';
      $conn = open_database();
      
      $result = mysqli_query($conn, "SELECT Etiqueta, Foto FROM Miembro ORDER BY ID ASC LIMIT 2");

      $lbls = array();
      $phts = array();
      while ($row = mysqli_fetch_array($result)) {
        array_push($lbls, $row["Etiqueta"]);
        array_push($phts, $row["Foto"]);
      }

      // Remove members that not contain "eugenia" or "elias"
      for ($i=0; $i < count($lbls); $i++) { 
        if (!str_contains(strtolower($lbls[$i]), NOM_MEM1) && !str_contains(strtolower($lbls[$i]), NOM_MEM2)) {
          unset($lbls[$i]);
          array_splice($lbls, 0);
        }
      }
      $WHERE_CLAUSE = "";
      if (count($lbls) >= 1) {
        $WHERE_CLAUSE = " WHERE Etiqueta != '$lbls[0]'";
      }
      if (count($lbls) == 2) {
        $WHERE_CLAUSE .= " AND Etiqueta != '$lbls[1]'";
      }

      ?>

        <div class="row">
        <?php
        if (mysqli_num_rows($result) > 0) {
          for ($i=0; $i < count($lbls); $i++) { 
        ?>
          <!-- TODO: Center if it's only one principal member -->
          <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="card">
              <div class="media">
                <a href="#" class="pull-left" id="<?php echo $lbls[$i]; ?>" onclick="memberClicked(this);">
                  <img src="<?php echo (!is_null($phts[$i])) ? $phts[$i] : PLACEHOLDER; ?>" class="media-object" alt="Sample Image" style="padding-right: 15px; height: 200px;">
                </a>
                <div class="media-body">
                  <h2 class="media-heading"><?php echo $lbls[$i]; ?></h2>
                </div>
              </div>
            </div>
          </div>
        <?php
          }
        }
        ?>
        </div>
    </div>
    <br>
    <!-- Members -->
    <div class="container">
    <script>
    console.log("<?php echo "SELECT Etiqueta, Foto FROM Miembro" . $WHERE_CLAUSE; ?>");
    </script>
      <?php        
        // $result = mysqli_query($conn, "SELECT Etiqueta, Foto FROM Miembro WHERE Etiqueta != '" . NOM_ELIAS ."' AND Etiqueta != '" . NOM_EUGEN . "'");
        $query = "SELECT Etiqueta, Foto FROM Miembro" . $WHERE_CLAUSE;
        $result = mysqli_query($conn, $query);

        $labels = array();
        $photos = array();

        while ($row = mysqli_fetch_array($result)) {
          array_push($labels, $row["Etiqueta"]);
          array_push($photos, $row["Foto"]);
        }
      ?>

      <?php
        for ($i=0; $i < count($labels); $i++) {
          if (($i % 3) == 0) {
      ?>
      <div class="row">
      <?php
          }
          // // Assigning photo
          if (is_null($photos[$i])) {
            $photo = "../../imgs/placeholder-user.jpg";
          }
          else {
            $photo = $photos[$i];
          }
      ?>
      <div class="col-xs-12 col-sm-4 col-md-4">
        <div class="card">
          <a href="#" style="text-decoration:none; color: #0060B6;" id="<?php echo $labels[$i]; ?>" onclick="memberClicked(this);">
            <div class="card-body text-center" style="height: 300px;">
                <script type="text/javascript">
                </script>
                <p><img class=" img-fluid" src="<?php echo $photo; ?>" alt="card image" style="height: 150px;"></p>
                <h4 class="card-title"><?php echo $labels[$i]; ?></h4>
            </div>
          </a>
        </div>
      </div>
      <?php
        if (($i % 3) == 2) {
      ?>
      </div>
      <br>
      <?php
          }
      ?>
      <?php
        }
        if ((($i - 1) % 3) != 2) {
      ?>
      </div>
      <br>
      <?php
        }
      ?>
    </div>
    <br><br>

    <!-- Hidden required form to update mysql table -->
    <form class="" action="../setdate.php" method="post" hidden>
      <input type="text" name="page" value="sitios/sitios.php">
      <input type="text" name="date" id="txtDate1" value="">
      <input type="text" name="sitio" value="">
      <input type="text" name="responsable" value="">
      <input type="submit" value="Sitios" id="btnSubmit1">
    </form>
    <form class="" action="../consultar/setinfo.php" method="post" hidden>
      <input type="text" name="date" id="txtDate2" value="">
      <input type="submit" value="Sitios" id="btnSubmit2">
    </form>
    <form class="" action="personal.php" method="post" hidden>
      <input type="text" name="txtLabel" value="" id="txtLabel">
      <input type="submit" value="personal" id="btnPersonal">
    </form>

    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>
<script>
  window.onload = function(){
    var date = new Date();
    document.getElementById('txtDate1').value = document.getElementById('txtDate2').value = date.getFullYear() + "-" + ("0" + (date.getMonth() + 1)).slice(-2);
  }

  function btnInsertar_Click(){
    document.getElementById('btnSubmit1').click();
  }
  function btnConsultar_Click(){
    document.getElementById('btnSubmit2').click();
  }

  function memberClicked(a) {
    document.getElementById('txtLabel').value = a.id;
    // alert(document.getElementById('txtLabel').value);
    document.getElementById('btnPersonal').click();
  }


</script>
