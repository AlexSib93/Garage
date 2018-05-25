$(function () {
    $(".container.list div").click(function (index,item) {
        console.log(this);
        alert($(this).text());
    });
})