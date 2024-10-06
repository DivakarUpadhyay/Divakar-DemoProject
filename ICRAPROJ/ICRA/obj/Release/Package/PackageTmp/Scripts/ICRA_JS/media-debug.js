$(document).ready(function(){
    $('.img-gallery').magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true,
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
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
    $('#latestGallery').magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true,
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
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
    $('#photoGallery').magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true,
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
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
    // Video Popup
    $('.popup-youtube, .popup-vimeo, .popup-gmaps, .video-thumb').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false,
        gallery: {
            enabled: true
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
    // Video & Image Gallery 
    $('.icra-gallery').magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true,
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
        },
        fixedContentPos: false,
        callbacks: {
            beforeOpen: function () {
                $('body').css('overflow', 'hidden');
            },
            beforeClose: function () {
                $('body').css('overflow', 'auto');
            },
            elementParse: function (item) {
                console.log(item.el[0].className);
                if (item.el[0].className == 'video') {
                    item.type = 'iframe',
                        item.iframe = {
                            patterns: {
                                youtube: {
                                    index: 'youtube.com/', // String that detects type of video (in this case YouTube). Simply via url.indexOf(index).
                                    id: 'v=', // String that splits URL in a two parts, second part should be %id%
                                    // Or null - full URL will be returned
                                    // Or a function that should return %id%, for example:
                                    // id: function(url) { return 'parsed id'; } 
                                    src: '//www.youtube.com/embed/%id%?autoplay=1' // URL that will be set as a source for iframe. 
                                },
                                vimeo: {
                                    index: 'vimeo.com/',
                                    id: '/',
                                    src: '//player.vimeo.com/video/%id%?autoplay=1'
                                },
                                gmaps: {
                                    index: '//maps.google.',
                                    src: '%id%&output=embed'
                                }
                            }
                        }
                } else {
                    item.type = 'image',
                        item.tLoading = 'Loading image #%curr%...',
                        item.mainClass = 'mfp-img-mobile',
                        item.image = {
                            tError: '<a href="%url%">The image #%curr%</a> could not be loaded.'
                        }
                }
            }
        },
        closeOnBgClick: false
    });
    $('.imgSlider').slick({
        dots: false,
        arrows: true,
        infinite: false,
        speed: 300,
        slidesToShow: 5,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1499,
                settings: {
                    slidesToShow: 4
                }
            },
            {
                breakpoint: 1199,
                settings: {
                    slidesToShow: 3
                }
            },
            {
                breakpoint: 991,
                settings: {
                    slidesToShow: 3
                }
            },
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
    $('#podcasts').slick({
        dots: true,
        infinite: false,
        speed: 300,
        slidesToShow: 1,
        slidesToScroll: 1
    });
    $('#avPodcasts').slick({
        dots: true,
        infinite: false,
        speed: 300,
        slidesToShow: 2,
        slidesToScroll: 1,
        responsive: [
            {
            breakpoint: 575,
                settings: {
                    slidesToShow: 1
                }
            }
        ]
    });
    $('#latestGallery').slick({
        dots: true,
        infinite: false,
        speed: 300,
        slidesToShow: 1,
        slidesToScroll: 1
    });
    
});
//# sourceMappingURL=maps/media-debug.js.map
