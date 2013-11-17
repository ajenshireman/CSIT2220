$('document').ready(function(){
    $('.btn-extras').click(function(e){
        e.preventDefault();
        e.stopPropagation();
        $(this).closest('.package').find('.extras').slideToggle();
    });

    $('.package-name').wrapInner('<a href="#"></a>');
    
    $('.package-name').click(function(e){
        e.preventDefault();
        e.stopPropagation();
        $(this).closest('.package').find('.details').slideToggle();
    });
    
});
