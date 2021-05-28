(function($) {
 "use strict";

/* ==============================================
PARALLAX
=============================================== */

    $.stellar({
        horizontalScrolling: false,
        verticalOffset: 100
    });

/* ==============================================
BACK TO TOP
=============================================== */

    jQuery('a.backtotop').click(function(){
        jQuery('html, body').animate({scrollTop: '0px'}, 800);
        return false;
    });

/* ==============================================
DROPDOWN MENU
=============================================== */

   $('.dark-style .dropdown').on('show.bs.dropdown', function(e){
      var $dropdown = $(this).find('.dropdown-menu');
      var orig_margin_top = parseInt($dropdown.css('margin-top'));
      $dropdown.css({'margin-top': (orig_margin_top + 30) + 'px', opacity: 0}).animate({'margin-top': orig_margin_top + 'px', opacity: 1}, 420, function(){
         $(this).css({'margin-top':''});
      });
   });

/* ==============================================
BOOTSTRAP SELECT
=============================================== */

  $('.selectpicker').selectpicker({
    style: 'btn-default',
    size: 6
  });

/* ==============================================
FUN FACTS
=============================================== */

  function count($this){
    var current = parseInt($this.html(), 10);
    current = current + 1; /* Where 50 is increment */
    
    $this.html(++current);
      if(current > $this.data('count')){
        $this.html($this.data('count'));
      } else {    
        setTimeout(function(){count($this)}, 50);
      }
    }        
    
    $(".stat-count").each(function() {
      $(this).data('count', parseInt($(this).html(), 10));
      $(this).html('0');
      count($(this));
  });

/* ==============================================
LOADER
=============================================== */

  jQuery(window).load( function() {
    setTimeout( function() {
        jQuery("#loader").delay(400).fadeOut(500);
        jQuery(".loader-logo");
        jQuery(".loader-back-text");
        jQuery(".loader");
    }, 4000 );
  });


})(jQuery);


