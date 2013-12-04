$('document').ready(function() {
    $('.packages .price').each(function() {
        $(this).append(': $' + $(this).attr('data-price') + ' per person');
    });

    $('.packages .perDay').each(function() {
        $(this).append(' per day');
    });

    $('.btn-extras').click(function(e) {
        e.preventDefault();
        e.stopPropagation();
        $(this).closest('.package').find('.extras').slideToggle();
    });

    $('.btn-book').click(function(e) {
        e.preventDefault();
        var packageID = $(this).closest('.package').attr('data-packageID');
        $('.packages').hide();
        $('.bookingForms .package').each(function() {
            if ($(this).attr('data-packageID') == packageID) {
                $(this).show();
            } else {
                $(this).hide();
            }
            $('.bookingForms').show();
        });
    });

    $('.btn-confirm').click(function(e) {
        e.preventDefault();
        var package = $(this).closest('.package');
        var packageID = $(this).closest('.package').attr('data-packageID');
        var numBase = package.find('.price-base').val();
        var priceBase = package.find('.price-base').attr('data-price');
        var chargeBase = numBase * priceBase;
        if (packageID == 1) {
            var numInstruct = $('#numInstruct-1').val();
            alert(numInstruct);
            var priceInstruct = $('#numInstruct-1').attr('data-price');
            var chargeInstruct = numInstruct * priceInstruct;
            var numRent = $('#numRent-1').find('.price').val();
            var daysRent = $('#numRentt-1').find('.days').val();
            var priceRent = $('#numRentt-1').find('.price').attr('data-price');
            var chargeRent = numRent * priceRent * daysRent;
        }
        var subTotal = chargeBase + chargeInstruct + chargeRent;
        var discount = 0;
        if (numBase >= 5) {
            discount = 0.1 * subTotal;
        }
        var total = subTotal - discount;
        var deposit = 0.5 * subTotal;
        var conf = package.find('.confirmation');
        conf.find('numBase').html(numBase);
        conf.find('priceBase').html(priceBase);
        conf.find('').html();
        conf.find('').html();
        conf.find('').html();
        conf.find('').html();
        conf.find('').html();
        conf.find('').html();
        conf.find('').html();
        conf.find('').html();
        conf.show();
    });
});
