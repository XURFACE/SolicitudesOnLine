$.fn.si = function() {
	$.support = {
		opacity: !($.browser.msie && /MSIE 6.0/.test(navigator.userAgent))
	};
	if ($.support.opacity) {
		$(this).each(function(i) {
			if ($(this).is(":file")) {
				var $input = $(this);
				$(this).wrap('<label class="cabinet" id="cabinet'+i+'"></label>');
				$("label#cabinet"+i)
					.wrap('<div class="si"></div>')
					.after('<div class="uploadButton"><div></div></div><label class="selectedFile"></label>')
					.live("mousemove", function(e) {
					if (typeof e == 'undefined') e = window.event;
					if (typeof e.pageY == 'undefined' &&  typeof e.clientX == 'number' && document.documentElement)
					{
						e.pageX = e.clientX + document.documentElement.scrollLeft;
						e.pageY = e.clientY + document.documentElement.scrollTop;
					};
					
					var ox = oy = 0;
					var elem = this;
					if (elem.offsetParent)
					{
						ox = elem.offsetLeft;
						oy = elem.offsetTop;
						while (elem = elem.offsetParent)
						{
							ox += elem.offsetLeft;
							oy += elem.offsetTop;
						};
					};
		
					var x = e.pageX - ox;
					var y = e.pageY - oy;
					var w = this.offsetWidth;
					var h = this.offsetHeight;
		
					$input.css("top", y - (h / 2)  + 'px');
					$input.css("left", x - (w + 30) + 'px');
				});
				
				$(this).change(function() {
					$container = $(this).closest("div.si");
					$("label.selectedFile", $container).html($(this).val());
				})
			}
		});
	}
};