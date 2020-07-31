function setstatus(id, value) {
    console.log(id);
    console.log(value);
    return;
    $.ajax({
        url : "",
        type: "GET",
        data: { id: id, status: value },
        success: function (res) {
            console.log(res);
        }
    });
}