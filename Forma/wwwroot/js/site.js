// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



//ADD 
$("button#addmetoda").on("click", function (ev) {

    var noviKorisnik = {};    
    noviKorisnik.Ime = $("input#Ime").val();
    noviKorisnik.Prezime = $("input#Prezime").val();
    noviKorisnik.Ulica = $("input#Ulica").val();
    noviKorisnik.Grad = $("input#Grad").val();
    noviKorisnik.Upit = $("input#Upit").val();
    noviKorisnik.PostanskiBroj = $('input#PostanskiBroj').val();
    console.log(noviKorisnik);

    $.ajax({
        url: '/api/Korisnik',
        method: 'post',
        data: JSON.stringify(noviKorisnik),
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data);

    });

});

$("button#postmetoda2").on("click", function (ev) {

    var noviProizvod = {};
    noviProizvod.Naziv = $("input#naziv").val();
    noviProizvod.Cijena = $("input#cijena").val();
    console.log(noviProizvod);

    $.ajax({
        url: '/api/Proizvod',
        method: 'post',
        data: JSON.stringify(noviProizvod),
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data);

    });

});
///////////////////////////////

//Get (dohvati)
$("button#dohvati").on("click", function (ev) {
    GetById($("input#Id").val()).then(function (data) {
        $("input#Id").val(data.id);
        $("input#Ime").val(data.ime);
        $("input#Prezime").val(data.prezime);
        $("input#Ulica").val(data.ulica);
        $('input#PostanskiBroj').val(data.postanskiBroj);
        $("input#Grad").val(data.grad);
        $("input#Upit").val(data.upit);
        console.log(data);
    });
});

$("button#dohvati2").on("click", function (ev) {
    GetById($("input#Id").val()).then(function (data) {
        $("input#Id").val(data.id);
        $("input#naziv").val(data.Naziv);
        $("input#cijena").val(data.Cijena);        
        console.log(data);
    });
});
///////////////////////////////

//EDIT (obavezan je ID)
$("button#putmetoda").on("click", function (ev) {
    
    var noviKorisnik = {};
    noviKorisnik.ID = $("input#Id").val();
    noviKorisnik.Ime = $("input#Ime").val();
    noviKorisnik.Prezime = $("input#Prezime").val();
    noviKorisnik.Ulica = $("input#Ulica").val();
    noviKorisnik.PostanskiBroj = $('input#PostanskiBroj').val();
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
    }).then(function (data) {  
        console.log(data);

    });

    
});

$("button#putmetoda2").on("click", function (ev) {

    var noviProizvod = {};
    noviProizvod.ID = $("input#Id").val();
    noviProizvod.Ime = $("input#Ime").val();
    console.log(noviProizvod);

    $.ajax({
        url: '/api/Proizvod',
        method: 'put',
        data: JSON.stringify(noviKorisnik),
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data);

    });


});

//Get (ID)
$("#getid").on("click", function (event) {
    console.log(event);
    var Id = $("input#Id4").val();
    GetById(Id).then(function (data) {
        console.log(data);
        $("div#content").html(JSON.stringify(data));

    });
});

function GetById(id) {
    return $.ajax({
        url: '/api/korisnik/' + id,
        method: 'get',
        headers: {
            'Access-Control-Allow-Origin': true
        }
    });
};
//Delete (ID)
$("#deleteid").on("click", function (event) {

    var Id = $("input#Id4delete").val();
    $.ajax({
        url: '/api/korisnik/' + Id,
        method: 'delete',
        headers: {
            'Access-Control-Allow-Origin': true
        }
    }).then(function (data) {
         
    });
});

$("#deleteid2").on("click", function (event) {

    var Id = $("input#Id5delete").val();
    $.ajax({
        url: '/api/Proizvod/' + Id,
        method: 'delete',
        headers: {
            'Access-Control-Allow-Origin': true
        }
    }).then(function (data) {

    });
});
//////////////////////////

//Get all
$("button#get").on("click", function () {

    $.ajax({
        url: "/api/korisnik",
        method: 'get',
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data);


    });


});

$("button#get2").on("click", function () {

    $.ajax({
        url: "/api/Proizvod",
        method: 'get',
        headers: {
            'Access-Control-Allow-Origin': true,
            'Content-Type': 'application/json; charset=utf-8',
        }
    }).then(function (data) {
        console.log(data);


    });


});
/////////////////////
