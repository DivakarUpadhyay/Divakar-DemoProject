$(document).ready(function(){
    $('.popup-youtube').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: true,
        closeOnBgClick:true
    });

    $(".tvc_blurb_hld").slick({
        infinite: true,
        arrows: true,
        dots: true,
        fade:false,
        autoplay: true,
        speed:500,
        autoplaySpeed: 3000,
        slidesToShow: 1,
        slidesToScroll: 1,
        pauseOnFocus:false,
        pauseOnHover:true,
        adaptiveHeight: true,
        responsive: [
            {}
        ]
    });

    $('.dash_btn').on('click', function(){
        $('.rating_filter_box_hld').fadeIn(100);
    });

    $('.dash_btn').magnificPopup({
        type: 'ajax',
        fixedContentPos: true,
        closeOnBgClick: true
    });

    $('.view_desc').on('click', function(){
        $('.rating_detail__instrument').fadeIn(100);
    });
   

    if($('.audio_btn').length === 1) {
        window.bannerAudioFunc();   // From main.js     
    }
});
//# sourceMappingURL=maps/rating-debug.js.map
