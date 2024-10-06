var isMobile = new Object();
isMobile.Android = function () {
	return navigator.userAgent.match(/Android/i);
};

isMobile.BlackBerry = function () {
	return navigator.userAgent.match(/BlackBerry/i);
};
isMobile.iOS = function () {
	return navigator.userAgent.match(/iPhone|iPad|iPod/i);
};

isMobile.iPad = function () {
	return navigator.userAgent.match(/iPad/i);
};
isMobile.Opera = function () {
	return navigator.userAgent.match(/Opera Mini/i);
};
isMobile.Windows = function () {
	return navigator.userAgent.match(/IEMobile/i);
};

isMobile.Firefox = function () {
	return navigator.userAgent.match(/Firefox/gi);
};
isMobile.InternetExplorer = function () {
	return navigator.userAgent.match(/MSIE/gi);
};
isMobile.Opera = function () {
	return navigator.userAgent.match(/Opera/gi);
};
isMobile.Safari = function () {
	return navigator.userAgent.match(/Safari/gi);
};
isMobile.any = function () {
	return (
		isMobile.Android() ||
		isMobile.BlackBerry() ||
		isMobile.iOS() ||
		isMobile.Opera() ||
		isMobile.Windows()
	);
};
if (isMobile.any() && isMobile.iPad() == null) {
	//return;
}

var ua = window.navigator.userAgent;
var is_ie = /MSIE|Trident/.test(ua);

/*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

var winWT = $(window).innerWidth();
var winHT = $(window).innerHeight();

var disableScrolling = function(){
	var x=window.scrollX;
	var y=window.scrollY;
	window.onscroll=function(){window.scrollTo(x, y);};
}
var enableScrolling = function(){
	window.onscroll=function(){};
}
window.onbeforeunload = function () {
	//window.scrollTo(0, 0);
}

$(window).on('load', function(){
	//window.scrollTo(0, 0);
});



$(document).ready(function(){
	$(".slimmenu").slimmenu({
		resizeWidth: '1200',
		collapserTitle: '',
		animSpeed: '500',
		easingEffect: null,
		indentChildren: true,
		childrenIndenter: '&nbsp;'
	});

	var navWT = $("header .nav_hld").innerWidth();
	$(".nav-icon").on('click',function(){
		//return;
		if($(this).hasClass("open")){
			$(".nav-icon").removeClass("open");
			$("header .nav_hld").animate({ left: -navWT + "px" }, 300);
			$('.menu_overlay').css({ display: 'none' });
			$('body').css({overflowY:'scroll'}); 
			$('.menu_overlay').removeClass('overlay_for_menu');
		}else{
			$(this).addClass("open");
			$("header .nav_hld").animate({ left: 0 }, 300);
			$('.menu_overlay').css({ display: 'block' });
			$('body').css({overflow:'hidden'}); 
			$('.menu_overlay').addClass('overlay_for_menu');
		}
	});

	$(".menu_overlay").on('click',function () {
		$(".nav-icon").trigger("click");
	});
	
	var setMobineNav = function(){
		if(winWT <= 1200){
			var tempHdQuickLinksDesk = $('.hd_quick_links').remove();
			var tempHdLoginIconDesk = $('header .login').remove();
			$('.nav_hld .container').append(tempHdQuickLinksDesk);
			$('header .hd_top_con').append(tempHdLoginIconDesk);

			$('header .icon_search').on('click', function(){
				$(this).css({'display':'none'});
				$('header .icon_close').css({'display':'block'});
				$('header .search_hld').addClass('open_search_box');
				$('header .search_hld .textBox').focus();
				$('.menu_overlay').css({ display: 'block' });
				$('header .menu_overlay').addClass('zIndex_for_serach');
			});

			$('header .icon_close').on('click', function(){
				$(this).css({'display':'none'});
				$('header .icon_search').css({'display':'block'});
				$('header .search_hld .textBox').val('');
				$('header .search_hld').removeClass('open_search_box');
				$('.menu_overlay').css({ display: 'none' });
				$('header .menu_overlay').removeClass('zIndex_for_serach');
			});

		}else{
			var tempHdQuickLinksMob = $('.hd_quick_links').remove();
			var tempHdLoginIconMob = $('header .login').remove();
			$('.hd_top_con').append(tempHdQuickLinksMob);
			$('header nav').append(tempHdLoginIconMob);
			$('header .icon_search').on('click', function(){
				$(this).css({'display':'none'});
				$('header .icon_close').css({'display':'block'});
				$('header .search_hld .textBox').focus();
				//$('.menu_overlay').css({ display: 'block' });
			});
			$('header .icon_close').on('click', function(){
				$(this).css({'display':'none'});
				$('header .icon_search').css({'display':'block'});
				$('header .search_hld .textBox').val('');
				//$('.menu_overlay').css({ display: 'none' });
			});
			$("header .search_hld .textBox").focus(function() {
				$('header .icon_search').css({'display':'none'});
				$('header .icon_close').css({'display':'block'});
			});
		}
	}
	setMobineNav();
	
	/*****************************************************************************************/
	/*****************************************************************************************/

	$('.switch_tab_hld').each(function(){
        var currTab = $(this).find('.tab');
        $(currTab).each(function(){
            $(this).on('click', function(event){
                var position = $(this).position();
                var width = $(this).innerWidth();
				var currDetPanel = '#tab_' + $(this).attr('tabId');
                $(this).parent().find('.slider').css({"left":+ position.left,"width":width});
                $(currTab).removeClass('active');
                $(this).addClass('active');
				var switchDetPanel = '#' + $(this).parent().parent().attr('id');
				$(switchDetPanel).find('.switch_det_panel').removeClass('show');
				$(currDetPanel).addClass('show');
				$("audio").not(this).each(function(index, audio) {
					audio.pause();
					audio.currentTime = 0;
				});
				
            });
        });
		
    });

    function resetSwithSlider(){
		var switchActiveTabArr = $('.switch_tab_hld').find('.active');
		switchActiveTabArr.each(function(){
			var THIS = $(this);
			var position = THIS.position();
			var width = THIS.innerWidth();
			//console.log(position, width);
			setTimeout(function(){
				THIS.parent().find('.slider').css({"left":+ position.left,"width":width});
			}, 1000);
		});
		
		
    }
    resetSwithSlider();


	$('.switch_filter_tab_hld').each(function(){
        var currTab = $(this).find('.tab');
        $(currTab).each(function(){
            $(this).on('click', function(event){
                var position = $(this).position();
                var width = $(this).innerWidth();
				var currDetPanel = '#tab_' + $(this).attr('tabId');
                $(this).parent().find('.slider').css({"left":+ position.left,"width":width});
                $(currTab).removeClass('active');
                $(this).addClass('active');
            });
        });
    });

	function resetSwithSliderForFilter(){
		var switchActiveTabArr = $('.switch_filter_tab_hld').find('.active');
		switchActiveTabArr.each(function(){
			var THIS = $(this);
			var position = THIS.position();
			var width = THIS.innerWidth();
			//console.log(position, width);
			setTimeout(function(){
				THIS.parent().find('.slider').css({"left":+ position.left,"width":width});
			}, 1000);
		});
		
		
    }
    resetSwithSliderForFilter();

	/*****************************************************************************************/
	/*****************************************************************************************/

	function pxTOvh(value) {
		var w = window,
		d = document,
		e = d.documentElement,
		g = d.getElementsByTagName('body')[0],
		x = w.innerWidth || e.clientWidth || g.clientWidth,
		y = w.innerHeight|| e.clientHeight|| g.clientHeight;

		var result = (100*value)/y;
		$(".popup_con").innerHTML = result; 
		return result;
	}

	$('.leader_board .leader_blurb_hld .leader_blurb').on('click', function(){
		window.onPopupLoadCheckHeight();
	});

	window.onPopupLoadCheckHeight = function(){
		var popupInnerHT
		setTimeout(function(){
			popupInnerHT = $('.popup_hld .popup_con').innerHeight();
			var vhH = pxTOvh(popupInnerHT);
			//console.log(vhH);
			if(vhH >= 75){
				//console.log('yes');
				$('.popup_con').css({overflowY:'scroll'});
			}
		}, 10);
	} 

	/*****************************************************************************************/
	/*****************************************************************************************/
	var headerTopHT;
	var headerHTInVH;
	var setHeaderSearchResultHT = function(){
		headerTopHT = $('header .hd_top').innerHeight();
		headerHTInVH = pxTOvh(headerTopHT);
		//console.log(headerTopHT);
		var newSearchResultHT = 100 - headerHTInVH;
		$('.header_search_res_hld').css({top:headerTopHT+'px'});
		//console.log(newSearchResultHT);
	}
	setHeaderSearchResultHT();

	window.showHeaderSearchResult = function(){
		$('.header_search_res_hld').css({display:'block'});
	}
	window.hideHeaderSearchResult = function(){
		$('.header_search_res_hld').css({display:'none'});
	}
	$('header .icon_search').on('click', function(){
		window.showHeaderSearchResult();
		$('body').css({overflowY:'hidden'});
	});
	$('header .icon_close').on('click', function(){
		window.hideHeaderSearchResult();
		$('body').css({overflowY:'scroll'});
	});
	$("header .search_hld .textBox").focus(function() {
		window.showHeaderSearchResult();
		$('body').css({overflowY:'hidden'});
	});
	/* $("header .search_hld .textBox").blur(function() {
		window.hideHeaderSearchResult();
		$('header .icon_close').css({'display':'none'});
		$('header .icon_search').css({'display':'block'});
		$('header .search_hld .textBox').val('');
	}); */
	
	/*****************************************************************************************/
	/*****************************************************************************************/

	$('.subscribe_rating_reports').magnificPopup({
        type: 'ajax',
        fixedContentPos: true,
        closeOnBgClick: true
    });

	$(window).resize(function(){
		winWT = $(window).innerWidth();
		setHeaderSearchResultHT();
		setMobineNav();
		resetSwithSlider();
		resetSwithSliderForFilter();
	});

	/*****************************************************************************************/
	/*****************************************************************************************/

	window.showReportContentTooltip = function(){
		$('.rep_det_con').each(function(){
			$(this).hover(
				function() {
					var currToolTip = $(this).find('.tootip_con');
					var currTollTipHT = $(this).find('.tootip_con').innerHeight();
					//console.log('yes', currTollTipHT);
					currToolTip.css({bottom: -currTollTipHT - 10 + 'px'})
				}, function() {
					//console.log('no')
				}
			  );
		});
	}
	window.showReportContentTooltip();

	/*****************************************************************************************/
	/*****************************************************************************************/

	window.bannerAudioFunc = function(){
		$('.audio_btn').on('click', function(){
			if($('.audio_btn .mute').css('display') === 'block'){
				$('.audio_player')[0].play();
				$('.unmute').css({'display':'block'});
				$('.mute').css({'display':'none'});
			}else{
				$('.audio_player')[0].pause();
				$('.unmute').css({'display':'none'});
				$('.mute').css({'display':'block'});
			}
		});
	
		/* var isChrome = /Chrome/.test(navigator.userAgent) && /Google Inc/.test(navigator.vendor);
		if (!isChrome) {
			$('#iframeAudio').remove()
		}
		else {
			$('#playAudio').remove() // just to make sure that it will not have 2x audio in the background 
		} */
	
		/* let audioPlaying = true,
			backgroundAudio, browser;
		browser = navigator.userAgent.toLowerCase();
		$('<audio class="audio1" src="assets/audio/demo-file.mp3" loop></audio>').prependTo('body');
		if (!browser.indexOf('firefox') > -1) {
			$('<embed id="background-audio" src="assets/audio/demo-file.mp3" autostart="1"></embed>').prependTo('body');
			backgroundAudio = setInterval(function () {
				$("#background-audio").remove();
				$('<embed id="background-audio" src="assets/audio/demo-file.mp3"></embed>').prependTo('body');
			}, 120000); // 120000 is the duration of your audio which in this case 2 mins.
		} */
	
		$.fn.isInViewport = function() {
			var elementTop = $(this).offset().top;
			var elementBottom = elementTop + $(this).outerHeight();
			var elementMiddle = elementTop + $(this).outerHeight() / 2;
			var viewportTop = $(window).scrollTop();
			var viewportBottom = viewportTop + $(window).height();
			var viewportMiddle = viewportTop + $(window).height()/2;
			if(viewportMiddle > elementTop && viewportMiddle < elementBottom){
			   return true;
			}else{
			   return false;
			}
			//return elementBottom > viewportTop && elementTop < viewportBottom;
		 };
	
		 function checkInViewPort(){
			if($('#banner').isInViewport()){
				/* $('.audio_player')[0].play();
				$('.unmute').css({'display':'block'});
				$('.mute').css({'display':'none'}); */
			}else{
				$('.audio_player')[0].pause();
				$('.unmute').css({'display':'none'});
				$('.mute').css({'display':'block'});
			}
		 }
		 $(window).on('resize scroll', checkInViewPort);
	}

	$("audio").on("play", function() {
        $("audio").not(this).each(function(index, audio) {
            audio.pause();
			audio.currentTime = 0;
        });
    });
	
	 
});

//# sourceMappingURL=maps/main-debug.js.map
