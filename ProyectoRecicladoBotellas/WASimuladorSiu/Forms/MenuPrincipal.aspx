<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="WASimuladorSiu.Forms.MenuPrincipal" %>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Página Principal</title>
    <link href="../Styles/SPrincipalPage.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
</head>

<body>
    <header>
        <nav>
            <a href="Login.aspx">SIU</a>
            <a href="#">TOUR VIRTUAL</a>
            <a href="#">CONTACTANOS</a>
        </nav>
        <section class="textos-header">
            <h1>UNIVALLE</h1>
            <h2>La respuesta cientifica al futuro</h2>
        </section>
        <div class="wave" style="height: 150px; overflow: hidden;">
            <svg viewBox="0 0 500 150" preserveAspectRatio="none"
                style="height: 100%; width: 100%;">
                <path d="M0.00,49.98 C150.00,150.00 349.20,-50.00 500.00,49.98 L500.00,150.00 L0.00,150.00 Z"
                    style="stroke: none; fill: #9b0839">
                </path>
            </svg>
        </div>
    </header>

    <footer>
        <div class="contenedor-footer">
            <div class="content-foo">
                <h4>Estudiantes</h4>
                <p>Infraestructura</p>
                <p>Estudiantes Internacionales</p>
                <p>Bienestar Universitario</p>
            </div>
            <div class="content-foo">
                <h4>Comunícate</h4>
                <p>info@univalle.edu</p>
            </div>
            <div class="content-foo">
                <h4>En las redes</h4>
                <p>Facebook</p>
                <p>Instagram</p>
                <p>@univalle</p>
            </div>
        </div>
        <h2 class="titulo-final">&copy;Copyright 2022 Univalle. Todos los derechos reservados</h2>
    </footer>
</body>

</html>
