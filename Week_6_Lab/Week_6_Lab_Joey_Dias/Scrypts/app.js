function sum() {
    if (validate()) {
        var fName = document.getElementById("fName").value;
        var lName = document.getElementById("lName").value;
        var age = document.getElementById("age").value;
        var summary = fName + " " + lName + ", " + age;
        document.getElementById("summary").innerText = summary;
    } else alert("Please fill out ALL fields");
}

function validate() {
    var fName = document.getElementById("fName").value;
    var lName = document.getElementById("lName").value;
    var age = document.getElementById("age").value;
    if (fName == "" || lName == "" || age == "") return false;
    else return true;
}