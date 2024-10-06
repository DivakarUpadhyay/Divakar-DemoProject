$(document).ready(function(){

    $('.crp_slider_con').slick({
        dots: false,
        arrows: true,
        infinite: true,
        autoplay: true,
        speed: 300,
        slidesToShow: 2,
        centerMode: false,
        variableWidth: true,
    });

    $('.trending_reports .tiles_hld').slick({
        dots: false,
        infinite: true,
        autoplay: true,
        speed: 300,
        slidesToShow: 3,
        centerMode: false,
        variableWidth: false,
        adaptiveHeight: true,
        responsive: [
            {
                breakpoint: 1100,
                settings: {
                  slidesToShow: 2,
                }
            },
            {
                breakpoint: 767,
                settings: {
                  slidesToShow: 1,
                }
            },
        ]
    });

    $('#podcasts').slick({
        dots: true,
        infinite: false,
        speed: 300,
        slidesToShow: 1,
        slidesToScroll: 1
    });

    $('.popup-youtube, .popup-vimeo, .popup-gmaps, .video-thumb').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false,
        gallery: {
            enabled: false
        },
        closeOnBgClick: false,
        callbacks: {
            beforeOpen: function () {
                $('body').css('overflow', 'hidden');
            },
            beforeClose: function () {
                $('body').css('overflow', 'auto');
            }
        }
    });
    
    $('.popup-youtube').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: true,
        closeOnBgClick:true
    });

    if($('.audio_btn').length === 1) {
        window.bannerAudioFunc();   // From main.js     
    }

    $('.sector_type_con .sector_type_blurb').each(function(){
        $(this).on('click', function(){
            $('.sector_type_con .sector_type_blurb').removeClass('active');
            $(this).addClass('active');
            $('html, body').animate({
                scrollTop: $('.abt_rating .search_hld').offset().top 
              }, 1000)
        });
    });
});
//# sourceMappingURL=maps/research-debug.js.map
