jQuery(function () {
    var $loading = jQuery('.loading').hide();
    jQuery(document)
        .ajaxStart(function () {
            $loading.show();
        })
        .ajaxStop(function () {
            $loading.hide();
        });
})