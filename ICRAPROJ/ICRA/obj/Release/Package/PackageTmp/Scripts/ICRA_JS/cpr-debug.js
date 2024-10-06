$(document).ready(function(){
    $('#podcasts').slick({
        dots: true,
        infinite: false,
        speed: 300,
        slidesToShow: 1,
        slidesToScroll: 1
    });

    $('.popup-youtube').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: true,
        closeOnBgClick:true
    });

    $('.sector_con .selectBox').on('change', function (e) {
        if(this.selectedIndex == 0){
            $('.subscribe_panel .sector_con h3').css({'visibility':'hidden'});
            $('.subscribe_panel .sub_sector_con').fadeOut(10);
        }else{
            $('.subscribe_panel .sector_con h3').css({'visibility':'visible'});
            $('.subscribe_panel .sub_sector_con').fadeIn(100);
            $('.subscribe_panel .no_sector_selected').fadeOut(100);
            $('.subscribe_panel .result_blurb_hld').fadeIn(100);
        }
        
    });
});
//# sourceMappingURL=maps/cpr-debug.js.map
