<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title>Actualizar base de datos</title>
    <meta name='viewport'
        content='width=device-width,initial-scale=1,minimum-scale=1,maximum-scale=1,user-scalable=no' />

    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
        integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <!-- Icon -->
    <link rel="icon" href="../../imgs/Evaseac.ico">
</head>

<body>

    <!-- Modal container -->
    <div class="container">
        <!-- Button trigger modal -->
        <button id="authModalButton" type="button" class="btn btn-primary" data-toggle="modal" data-target="#authModal"
            hidden>
            Authenticate
        </button>

        <!-- Modal -->
        <div class="modal fade" id="authModal" tabindex="-1" role="dialog" aria-labelledby="authModalTitle"
            aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header justify-content-center">
                        <h5 class="modal-title">Autenticación</h5>
                    </div>
                    <div class="modal-body">
                        <form>
                            <div class="form-row">
                                <label for="user" class="col-form-label">Usuario:</label>
                                <input type="text" class="form-control" id="user" required>
                            </div>
                            <div class="form-row">
                                <label for="password" class="col-form-label">Contraseña:</label>
                                <input type="password" class="form-control" id="password" required>
                            </div>
                        </form>
                    </div>
                    <div class="modal-footer justify-content-center">
                        <button id="btnAuth" type="submit" class="btn btn-primary">Ingresar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="scripts">
        <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
        </script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"
            integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous">
        </script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"
            integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous">
        </script>
    </div>
</body>

</html>

<script>
    $(document).ready(function () {
        // showing auth modal
        $("#authModalButton").click();
    });

    // closing event from Modal
    $('#authModal').on('hidden.bs.modal', function (e) {
        // verify authentication
        alert("Necesita autenticarse para poder usar esta página");
        $('#authModal').modal('show')
    })

    $("#btnAuth").click(function(){
        $.ajax({
            url: "./auth.php",
            method: "POST",
            data: {user: $("#user").val(), password: $("#password").val()},
            cache: false,
            success: function (respax) {
                alert(respax);
            }
        });
    });
</script>