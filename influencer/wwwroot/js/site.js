jQuery(function () {
    var $loading = jQuery('.loading').hide();
    jQuery(document)
        .ajaxStart(function () {
            $loading.show();
        })
        .ajaxStop(function () {
            $loading.hide();
        });
    var pathname = window.location.pathname;
    $("#navbar .nav-link:not(.scrollto)").each(function () {
        if ($(this).attr("href") == pathname) {
            $(this).addClass("active");
        }
    })
})