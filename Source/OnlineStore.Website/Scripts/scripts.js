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
    let urlControllerName = window.location.pathname.split('/')[1].toLowerCase();
    $('a.nav-link').each(function () {
        let linkControllerName = $(this).attr('href').split('/')[1].toLowerCase();
        if (urlControllerName === linkControllerName) {
            $('a.nav-link').removeClass('active font-weight-bold');
           $(this).addClass('active font-weight-bold');
        }
    });
});

$(document).ready(function () {
    var url = window.location.pathname;
    console.log(url);
    if (url === '/product') {
        $('a.list-group-item-action').first().addClass('active font-weight-bold');
    }
    else {
        url = window.location.pathname.split('?')[0].split('/')[3];
        $('a.list-group-item-action').each(function () {
            if ($(this).attr('href').split('?')[0].split('/')[3] === url) {
                $('a.list-group-item-action').removeClass('active font-weight-bold');
                $(this).addClass('active font-weight-bold');
            }
        });
    }
});

$(document).ready(function () {
    $('#sortOrder, #pageSize').change(function () {
        $('#sortConfirm').click();
    });
});