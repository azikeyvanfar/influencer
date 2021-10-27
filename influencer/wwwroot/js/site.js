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
    });
    $("form").find("input").first().focus();
});
var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = window.location.search.substring(1),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;

    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');

        if (sParameterName[0] === sParam) {
            return typeof sParameterName[1] === undefined ? true : decodeURIComponent(sParameterName[1]);
        }
    }
    return false;
};