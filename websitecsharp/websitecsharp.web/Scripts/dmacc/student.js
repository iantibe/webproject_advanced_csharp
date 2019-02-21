function searchPerson() {

    var search = $("#searchString").val();

    $.ajax({
        url: "Search",
        data: { searchString: search.toString() }
    }).done(function (data) {
        $("#firstname").val(data.FirstName);
        $("#lastname").val(data.LastName);
        $("#gender").val(data.PersonGender);
        $("#email").val(data.Email);
        $("#phonenumber").val(data.PhoneNumber);
    })
}

function updatePerson() {
    var firstname = $("#firstname").val();
    var lastname = $("#lastname").val();
    var email = $("#email").val();
    var gender = $("#gender").val();
    var phonenumber = $("#phonenumber").val();

    $.ajax({
        url: "UpdatePerson",
        dataType: "json",
        data: {
            FirstName: firstname,
            LastName: lastname,
            Email: email,
            PhoneNumber: phonenumber,
            PersonGender: gender,


        }


    }).done(function (data) {
        if (data) {
            $("#successmessage").remove("hidden")
                .addClass("visible");
        } else {
            $("#errormessage").remove("hidden")
                .addClass("visible");
        }


    });
    
}