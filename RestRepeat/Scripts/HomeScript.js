
$(document).ready(function () {
    $("#showLeft").click(function () {
        $("#menu1").slideToggle(1000);
    });
});
$(document).ready(function () {
    $("#showRight").click(function () {
        $("#menu2").slideToggle(1000);
    });
});

$('.dropdown-toggle').dropdown();

$('#myModal').on('shown.bs.modal', function () {
    $('#myInput').focus()
})
$('#myCarousel').carousel();
$('.dropdown-toggle').dropdown()
$().dropdown('toggle')


