$(document).ready(function(){
	$("#banner").slick({
        infinite: true,
        arrows: true,
        dots: true,
        fade:false,
        autoplay: false,
        speed:500,
        autoplaySpeed: 3000,
        slidesToShow: 1,
        slidesToScroll: 1,
        pauseOnFocus:false,
        pauseOnHover:false,
        responsive: [
            {
              breakpoint: 1023,
              settings: {
                adaptiveHeight: true,
                dots:false
              }
            }
        ]
    });

    $(".scroll_arrow").click(function() {
        $('html, body').animate({
            scrollTop: $(".research_in_focus").offset().top +  20
        }, 1000);
    });

    $('.crp_slider_con').slick({
      dots: false,
      infinite: true,
      autoplay: false,
      speed: 300,
      slidesToShow: 2,
      centerMode: false,
      variableWidth: true,
    });

    $('.popup-youtube').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: true,
        closeOnBgClick:true
    });

    $('.actions-sliders').slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      dots:true,
      arrows: false,
      autoplay: true,
      adaptiveHeight: true,
      infinite: true,
      speed: 400,
      vertical: true,
      verticalSwiping: true
  });

  $('.m_pause').on('click',function(){
    $(this).css({'display':'none'});
    $('.m_play').css({'display':'block'});
    $('.marquee_content').css({'animation-play-state':'paused'});
  });
  $('.m_play').on('click',function(){
    $(this).css({'display':'none'});
    $('.m_pause').css({'display':'block'});
    $('.marquee_content').css({'animation-play-state':'running'});
  });

  $('.research_hld').slick({
    slidesToShow: 3,
    slidesToScroll: 1,
    dots:false,
    arrows: false,
    autoplay: true,
    infinite: true,
    speed: 400,
    responsive: [
      {
        breakpoint: 10000,
        settings: "unslick"
     },
      {
        breakpoint: 1100,
        settings: {
          slidesToShow: 2,
          arrows: true,
        }
      },
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 1,
          arrows: true,
        }
      }
    ]
});


});
//# sourceMappingURL=maps/home-debug.js.map
