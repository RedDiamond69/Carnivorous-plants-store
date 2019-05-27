$(document).ready(function () {
    $('#header').removeClass('default');
    $(window).scroll(function () {
        if ($(this).scrollTop() > 80) {
            $('#header').addClass('default').fadeIn("slow");
        } else {
            $('#header').removeClass('default').fadeIn("slow");
        };
    });
});

$(document).ready(function () {
    var url = window.location.pathname;
    $('a.nav-link').each(function () {
        $(this).removeClass('active font-weight-bold')
        if ($(this).attr('href') === url) {
            $(this).addClass('active font-weight-bold');
        }
    });
});