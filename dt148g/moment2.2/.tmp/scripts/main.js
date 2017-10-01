$(document).ready(function() {

    $('.bootstrap-content').hide();
    $('#bootstrap .btn').click(function(e) {
        e.preventDefault();

        var open = $(this).data('open') == true;

        if(!open) {
            $('.bootstrap-content').slideDown();
            $(this).html('Stäng');
        } else {
            $('.bootstrap-content').slideUp();
            $(this).html('Läs mer...');
        }

        $(this).data('open', !open);

    });
});
