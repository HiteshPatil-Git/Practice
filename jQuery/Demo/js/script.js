
$(document).ready(function () {

    let form = $("#form");
    enableFastFeedback(form);

    var modal = document.getElementById("myModal");

    // localStorage.clear();

    if ((JSON.parse(localStorage.getItem('listOfUsers'))) == null) {
        var list = [];

    } else {
        var list = JSON.parse(localStorage.getItem('listOfUsers'));
        list.forEach(initialDataToTable);

    }

    //Initial Data insertion in Table from LocalStorage
    function initialDataToTable(element, index) {
            console.log("list iterating");

            let tableBody = $("tbody");
            let tableRow = '<tr>';

            tableRow = DataToTable(element, tableRow, index);

            tableRow += "</tr>";
            tableBody.append(tableRow); 
    }


    //Password Visibility Toggle
    $("#eye").on("click", function () {
        console.log("button clicked");
        let passField = $("#password");
        if (passField.attr("type") === "password") {
            passField.attr("type", "text");
            $(this).attr("class", "fa fa-eye-slash password-icon");
        } else {
            passField.attr("type", "password");
            $(this).attr("class", "fa fa-eye password-icon");
        }
    });


    //Blank form to add new user by clicking ADD @ navbar
    $("#add").on("click", clearForm);

    //Clears form
    function clearForm() {

        $("#submit").css("display", "inline-block");
        $("#update").css("display", "none");
        $("#reset").data("index", "");
        $("#reset").attr("type", "reset");

        $("#form select").val("");
        $("#form .feedback").html("");
        $("#form input").val("").prop("checked", false);
        $("#form input").removeClass("invalid-field valid-field");
        $("#form select").removeClass("invalid-field valid-field");
    }

    //Reset button
    $("#form").on("click", "#reset", function (event) {

        if ($("#reset").attr("type") == "reset") {
            clearForm();
        } else {
            let currIndexValue = $("#reset").data("index");
            resetUpdateForm(currIndexValue);
        }
    });


    $("#tbody").on("click", ".row-no", function () {
        var rowNumber = $(this).closest("tr");
        console.log("Row no is " + rowNumber.index());
    })

    //Shows User details in form on-click Edit button against respective user
    $("#tbody").on("click", ".edit", function () {
        let curRow = $(this).closest("tr");
        console.log("Row no is " + curRow.index());

        let currIndexValue = curRow.index();
        console.log(currIndexValue);
        resetUpdateForm(currIndexValue);

    });


    //Getting user from list and Displaying user values in form
    function resetUpdateForm(currIndexValue) {
        //Getting user from list and Displaying user values in form
        const currPerson = list[currIndexValue];
        clearForm();

        $("#name").val(currPerson.name);
        $("#dob").val(currPerson.dob);
        $("#address").val(currPerson.address);
        $("#email").val(currPerson.email);
        $("#country").val(currPerson.country);
        $("#gender").val(currPerson.gender);
        $("#password").val(currPerson.password);
        $("#role").val(currPerson.role);

        var currHobbies = currPerson.hobbies;
        $("#hobby1").prop("checked", currHobbies.includes("Cricket"));
        $("#hobby2").prop("checked", currHobbies.includes("Reading"));
        $("#hobby3").prop("checked", currHobbies.includes("Writting"));

        $("#submit").css("display", "none");
        $("#update").css("display", "inline-block");
        $("#update").data("index", currIndexValue);
        $("#reset").data("index", currIndexValue);
        $("#reset").attr("type", "button");
    }


    //Updating user details on-click Update button
    $("#update").on("click", function (event) {
        let updateIndex = $("#update").data("index");

        const person = formDataProcess(list[updateIndex]);
        var validFormState = validateFormFields(person, event, "update");
        if (validFormState == true) {

            list[updateIndex] = person;
            localStorage.setItem('listOfUsers', JSON.stringify(list));

            // var tableRowEle = $(`#tbody tr:eq("${op}")`);
            let tableBody = $("tbody");
            let tableRow = "";
            console.log(tableRow);

            tableRow = DataToTable(person, tableRow, updateIndex);
            $(`#tbody tr:eq("${updateIndex}")`).html(`${tableRow}`);

            clearForm();
        } else {
            event.preventDefault();
        }

    });


    //Gender Updation from DropDown
    $("#tbody").on("change", ".edit-gender", function () {
        console.log("button clicked");

        let curRow = $(this).closest("tr");
        console.log("Row no is " + curRow.index());

        let updateIndex = curRow.index();
        console.log(updateIndex);

        let selectedOption = $(this).find(":selected").val();
        let genderBox = "Gender" + updateIndex;

        //Getting user from list, updating gender values, updating list and Table
        const existingPer = list[updateIndex];
        existingPer.gender = selectedOption;
        list[updateIndex] = existingPer;
        localStorage.setItem('listOfUsers', JSON.stringify(list));

        $(`#${genderBox}`).html(`<td id = "Gender${updateIndex}" > <select data-index="${updateIndex}" name="" class="edit-gender"><option value="${existingPer.gender}">${existingPer.gender}</option><option value="Male">Male</option><option value="Female">Female</option><option value="Other">Other</option></select></td>`);
    });

    //Model-PopUp for before deletion
    $("#tbody").on("click", ".delete", function () {
        console.log("button clicked");
        let curRow = $(this).closest("tr");
        console.log("Row no is " + curRow.index());

        let currIndexValue = curRow.index();
        console.log(currIndexValue);

        let modelBox = $(".modal-content");
        modal.style.display = "flex";
        // modal.style.display = "block";

        modelBox.append("<p>").html("<h2>Delete Record?</h2>");
        modelBox.append(`<div><button id="del-yes"  data-index="${currIndexValue}" class='mod-btn btn btn-danger'>Yes</button> 
        <button id="del-no" class="mod-btn btn btn-success" type="reset">No</button></div>`);


        {// if (confirm(text) == true) {

            //     var currIndexValue = $(this).data("index");
            //     console.log(currIndexValue);

            //     list.splice(currIndexValue, 1);
            //     list.forEach(element => {
            //         console.log(element);
            //     });

        }
    });

    //Deletes record
    $("#myModal").on("click", "#del-yes", function () {
        let remIndex = $(this).data("index");
        console.log(remIndex);
        list.splice(remIndex, 1);
        localStorage.setItem('listOfUsers', JSON.stringify(list));
        // list.forEach(element => {
        //     console.log(element);
        // });

        $(`#tbody tr:eq("${remIndex}")`).remove();
        clearForm();
        modal.style.display = "none";
    });

    //Aborts Delete operation & Removes PopUp
    $("#myModal").on("click", "#del-no", function () {
        modal.style.display = "none";
    });

    //Aborts Delete operation & Removes PopUp
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }


    //Form Data Processing for adding or updating user 
    function formDataProcess(person) {

        var name = $("#name").val();
        var dob = $("#dob").val();
        var address = $("#address").val();
        var email = $("#email").val();
        var country = $("#country").val();
        var gender = $("#gender").val();
        var password = $("#password").val();
        var role = $("#role").val();

        var hobbiesArray = [];
        ($("#hobby1").is(":checked") ? hobbiesArray.push($("#hobby1").data("hobby1")) : "");
        ($("#hobby2").is(":checked") ? hobbiesArray.push($("#hobby2").data("hobby2")) : "");
        ($("#hobby3").is(":checked") ? hobbiesArray.push($("#hobby3").data("hobby3")) : "");

        person.name = name;
        person.dob = dob;
        person.address = address;
        person.email = email;
        person.country = country;
        person.gender = gender;
        person.password = password;
        person.role = role;
        person.hobbies = hobbiesArray;

        return person;
    }


    //DataToTable
    function DataToTable(person, tableRow, op) {
        tableRow += '<td>' + person.name + "</td>";
        tableRow += '<td>' + person.dob + "</td>";
        tableRow += '<td>' + person.address + "</td>";
        tableRow += '<td>' + person.country + "</td>";
        tableRow += '<td>' + person.hobbies + "</td>";
        tableRow += `<td id="Gender${op}"><select data-index="${op}" name="" class="edit-gender"><option value="${person.gender}">${person.gender}</option><option value="Male">Male</option><option value="Female">Female</option><option value="Other">Other</option></select></td>`;
        tableRow += '<td>' + person.email + "</td>";
        tableRow += '<td>' + person.role + "</td>";
        tableRow += `<td> <button  data-index="${op}"  class="edit" >Edit</button> <button  data-index="${op}"   class="delete">Delete</button></td>`;
        
        return tableRow;
    }


    //New User entry on-click Submit button after filling input fields
    form.submit(function (event) {
        const person1 = {
            name: '', dob: '', address: '', country: '', hobbies: '', gender: '', email: '', password: '', role: ''
        }

        const person = formDataProcess(person1);
        // let checkedHobby = $("input[name='hobby']:checked");
        // let checkedHobby = person.hobbies;

        var validFormState = validateFormFields(person, event, "new");
        console.log("form status is " + validFormState);
        if (validFormState == true) {

            list.push(person);
            localStorage.setItem('listOfUsers', JSON.stringify(list));

            let index = list.length - 1;
            // list.forEach(element => {
            //     console.log(element);
            // });
            let tableBody = $("tbody");
            let tableRow = '<tr>';

            tableRow = DataToTable(person, tableRow, index);

            tableRow += "</tr>";
            tableBody.append(tableRow);

            clearForm();
            event.preventDefault();

        } else {
            event.preventDefault();
        }
    });


    //Validation of form fields on-click Submit button
    function validateFormFields(person, event, purpose) {
        let validFormFieldsArray = [];

        if (purpose == "new") {
            validFormFieldsArray.push(validateNameField(person.name, event));
        }
        validFormFieldsArray.push(validatePasswordField(person.password, event));
        validFormFieldsArray.push(validateAddressField(person.address, event));
        validFormFieldsArray.push(validateEmailField(person.email, event));
        validFormFieldsArray.push(validateHobbies(person.hobbies, event));
        validFormFieldsArray.push(validateHobbies(person.hobbies, event));
        validFormFieldsArray.push(validateGender(person.gender, event));
        validFormFieldsArray.push(validateCountry(person.country, event));
        validFormFieldsArray.push(validateRole(person.role, event));
        validFormFieldsArray.push(validateDOBField(person.dob, event));
        console.log("Array include false value is ===== " + validFormFieldsArray.includes(false));

        return !validFormFieldsArray.includes(false);
    }

    {   //Implementation of form-field validation

    function validateHobbies(checkedHobby, event) {
        if (checkedHobby.length === 0) {
            $("#hobby-feedback").text("Select atleast one hobby");
            $("input[name='hobby']").addClass("invalid-field").removeClass("valid-field");             
            return false;
        } else {
            $("#hobby-feedback").text("");
            $("input[name='hobby']").addClass("valid-field").removeClass("invalid-field"); 
            return true;
        }
    }

    function validateGender(selectedGender, event) {
        if (selectedGender == null) {
            $("#gender-feedback").text("Select Gender");
            $("#gender").addClass("invalid-field").removeClass("valid-field");                
            return false;
        } else {
            $("#gender-feedback").text("");
            $("#gender").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function validateCountry(selectedCountry, event) {
        if (selectedCountry == null) {
            $("#country-feedback").text("Select Country");
            $("#country").addClass("invalid-field").removeClass("valid-field");  
            return false;
        } else {
            $("#country-feedback").text("");
            $("#country").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }
    function validateRole(selectedRole, event) {
        if (selectedRole == null) {
            $("#role-feedback").text("Select Role");
            $("#role").addClass("invalid-field").removeClass("valid-field");  
            return false;
        } else {
            $("#role-feedback").text("");
            $("#role").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function validateNameField(name, event) {

        if (!isValidName(name)) {            
            $("#name-feedback").text("Name should be unique");
            $("#name").addClass("invalid-field").removeClass("valid-field");
            return false;
        } else {
            console.log("In Else "+name);
            $("#name-feedback").text("");
            $("#name").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function isValidName(name) {
        let isValid = true;
        name = name.toLowerCase().trim();
        if(name == ""){
            return false;
        }

        list.forEach(valid);
        function valid(element) {
            if (element.name.toLowerCase() === name) {
                isValid = false;
            }
        }
        return isValid;
    }
    function validateDOBField(dob, event) {
        if (!isValidDOB(dob)) {
            $("#dob-feedback").text("Select DOB");
            $("#dob").addClass("invalid-field").removeClass("valid-field");
            return false;
        } else {
            $("#dob-feedback").text("");

            $("#dob").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function isValidDOB(dob) {
        return dob !== "";
    }


    function validateEmailField(email, event) {
        if (!isValidEmail(email)) {
            $("#email-feedback").text("Password should contain min. 6 char");
            $("#email").addClass("invalid-field").removeClass("valid-field");
            return false;
        } else {
            $("#email-feedback").text("");
            $("#email").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function isValidEmail(email) {
        var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (!regex.test(email)) {
            console.log("false");
            return false;
        } else {
            console.log("okay");
            return true;
        }
    }

    function validatePasswordField(password, event) {
        if (!isValidPassword(password)) {
            $("#password-feedback").text("Password should contain min. 6 char");
            $("#password").addClass("invalid-field").removeClass("valid-field");
            return false;
        } else {
            $("#password-feedback").text("");
            $("#password").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function isValidPassword(password) {
        return password.length >= 6;
    }

    function validateAddressField(address, event) {
        if (!isValidAddress(address)) {
            $("#address-feedback").text("Address required");
            $("#address").addClass("invalid-field").removeClass("valid-field");
            return false;
        } else {
            $("#address-feedback").text("");
            $("#address").addClass("valid-field").removeClass("invalid-field");
            return true;
        }
    }

    function isValidAddress(address) {
        return address.trim() !== "";
    }

}


//Validation while form filling
function enableFastFeedback(formElement) {

    var nameInput = formElement.find("#name");
    var dobInput = formElement.find("#dob");
    var addressInput = formElement.find("#address");
    var emailInput = formElement.find("#email");
    var passwordInput = formElement.find("#password");
    var genderInput = formElement.find("#gender");
    var countryInput = formElement.find("#country");
    var roleInput = formElement.find("#role");
    var hobbyInput = $("input[name='hobby']");

    hobbyInput.change(function (event) {
        let checkedHobby = $("input[name='hobby']:checked");
        validateHobbies(checkedHobby, event)
    });

    genderInput.change(function (event) {
        let selectedGender = $(this).val();
        console.log(selectedGender);
        validateGender(selectedGender, event);
    });

    countryInput.change(function (event) {
        let selectedCountry = $(this).val();
        validateCountry(selectedCountry, event);
    });

    roleInput.change(function (event) {
        let selectedRole = $(this).val();
        validateRole(selectedRole, event);
    });

    nameInput.blur(function (event) {
        let name = $(this).val();
        console.log("name is "+name);
        validateNameField(name, event);
    });

    dobInput.blur(function (event) {
        let dob = $(this).val();
        validateDOBField(dob, event);
    });

    addressInput.blur(function (event) {
        let address = $(this).val();
        validateAddressField(address, event);
    });

    emailInput.blur(function (event) {
        let email = $(this).val();
        validateEmailField(email, event);
    });

    passwordInput.blur(function (event) {
        var password = $(this).val();
        validatePasswordField(password, event);
    });
}

    

});

