$('document').ready(function () {
    $('.price').each(function () {
        $(this).append(': $' + $(this).attr('data-price') + ' per person');
    });

    $('.perDay').each(function(){
        $(this).append(' per day');
    });

    $('.btn-extras').click(function (e) {
        e.preventDefault();
        e.stopPropagation();
        $(this).closest('.package').find('.extras').slideToggle();
    });

    $('.btn-book').click(function (e) {
        e.preventDefault();
        var packageID = $(this).closest('.package').attr('data-packageID');
    });
});
