$('document').ready(function(){
    $('.btn-extras').click(function(e){
        e.preventDefault();
        e.stopPropagation();
        $(this).closest('.package').find('.extras').slideToggle();
    });
});