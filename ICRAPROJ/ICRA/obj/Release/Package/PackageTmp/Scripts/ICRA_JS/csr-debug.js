$(document).ready(function(){
    $('.csr_list_con').slick({
        dots: false,
        arrows: true,
        infinite: true,
        autoplay: false,
        speed: 300,
        slidesToShow: 2,
        centerMode: false,
        variableWidth: true,
        focusOnSelect: true
    });

    $('.imgSlider').slick({
        dots: false,
        arrows: true,
        infinite: false,
        speed: 300,
        slidesToShow: 3,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 767,
                settings: {
                    slidesToShow: 2
                }
            },
            {
            breakpoint: 480,
                settings: {
                    slidesToShow: 1
                }
            }
        ]
    });

    $('.img-gallery').magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true,
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
        },
        image: {
          // options for image content type
          titleSrc: 'title'
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

    $('.bod_popup_link').magnificPopup({
        type: 'ajax',
        fixedContentPos: true,
        closeOnBgClick: true
    });
    
});
//# sourceMappingURL=maps/csr-debug.js.map
