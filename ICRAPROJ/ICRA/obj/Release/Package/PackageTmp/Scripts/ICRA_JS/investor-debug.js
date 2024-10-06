$(document).ready(function () {
  $('.event_calendar').slick({
    arrow: true,
    infinite: true,
    autoplay: false,
    speed: 300,
    slidesToShow: 5,
    centerMode: true,
    variableWidth: false,
    responsive: [
      {
        breakpoint: 1600,
        settings: {
          adaptiveHeight: true,
          slidesToShow: 3,
        }
      },
      {
        breakpoint: 1023,
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
      {
        breakpoint: 375,
        settings: {
          slidesToShow: 1,
          centerMode: false,
        }
      }
    ]
  });

  $('.rtg_nav_btn').on('click', function(){
    if($('.rtg_inner .acc_nav').css('left') === '-320px'){
      console.log('yes');
      $('.rtg_inner .acc_nav').animate({'left':'0'});
      $('.rtg_nav_btn').addClass('open_sub_nav');
    }else{
      console.log('fgdfg');
      $('.rtg_inner .acc_nav').animate({'left':'-320px'});
      $('.rtg_nav_btn').removeClass('open_sub_nav');
    }
  });


});
//# sourceMappingURL=maps/investor-debug.js.map
