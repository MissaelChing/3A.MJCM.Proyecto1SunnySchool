function uncheck() {
    var checkbox1 = document.getElementById("only-one");
    var checkbox2 = document.getElementById("only-two");
    checkbox1.onclick = function () {
        if (checkbox1.checked != false) {
            checkbox2.checked = null;
        }
    }
    checkbox2.onclick = function () {
        if (checkbox2.checked != false) {
            checkbox1.checked = null;
        }
    }
}
