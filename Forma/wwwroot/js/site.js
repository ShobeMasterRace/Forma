// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$("form#postForma").on("submit", function (ev) {

    ev.preventDefault();
    ev.stopPropagation();
    var noviKorisnik = {};
    noviKorisnik.ID = $("input#Id").val();
    noviKorisnik.Ime = $("input#Ime").val();
    noviKorisnik.Prezime = $("input#Prezime").val();
    noviKorisnik.Ulica = $("input#Ulica").val();
    noviKorisnik.Grad = $("input#Grad").val();
    noviKorisnik.Upit = $("input#Upit").val();
    console.log(noviKorisnik);

    $.ajax({
        url: '/api/Korisnik',
        method: 'put',
        data: JSON.stringify(noviKorisnik),
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    })

    //$.post('/api/Korisnik', noviKorisnik, function () {})
})
$("button#getid").on("click", function () {
    var stariKorisnik = {};
    stariKorisnik.ID = $("input#Id").val();
    stariKorisnik.Ime = $("input#Ime").val();
    stariKorisnik.Prezime = $("input#Prezime").val();
    stariKorisnik.Ulica = $("input#Ulica").val();
    stariKorisnik.Grad = $("input#Grad").val();
    stariKorisnik.Upit = $("input#Upit").val();
    console.log(stariKorisnik);

    $.ajax({
        url: '/api/korisnik',
        method: 'get',
        data: JSON.stringify(idKorisnik),
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data)


    })
})

$("button#get").on("click", function () {

    $.ajax({
        url: "/api/korisnik",
        method: 'get',
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data)


    })


})

