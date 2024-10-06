$(document).ready(function(){
    $('.year_list').slick({
        dots: false,
        infinite: true,
        autoplay: true,
        speed: 300,
        slidesToShow: 2,
        centerMode: false,
        variableWidth: true,
        focusOnSelect: true,
        asNavFor: '.year_det'
    });

    $('.year_det').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        infinite: true,
        arrows: true,
        fade: true,
        asNavFor: '.year_list'
    });

    $('.feature_slider_hld').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        infinite: true,
        arrows: true,
        fade: false,
    });

    var leader_type_li = $('.leader_type').find('li');
    $(leader_type_li).each(function(){
        $(this).on('click', function(){
            var currType = $(this).attr('id');
            var currData = '#team_' + currType;
            $('.team_persons').css({'display':'none'});
            $(currData).fadeIn();
            $(leader_type_li).removeClass('active_tab');
            $(this).addClass('active_tab');
        });
    });
    $('#board_of_directors').trigger( "click" );

    $('.profile_blurb .p_service').each(function(){
        $(this).on('click', function(){
            var currPro = $(this).attr('id');
            var currProData = '#data_' + currPro;
            $('.pro').css({'display':'none'});
            $(currProData).fadeIn();
            $('.p_service').css({'display':'block'});
            $(this).css({'display':'none'});
        });
    });

    $('.bod_popup_link').magnificPopup({
        type: 'ajax',
        fixedContentPos: true,
        closeOnBgClick: true
    });
});
//# sourceMappingURL=maps/about-us-debug.js.map
