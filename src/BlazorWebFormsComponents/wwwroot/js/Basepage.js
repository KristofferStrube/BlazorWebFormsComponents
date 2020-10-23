var FormatClientClick = function () {
	var elementsToReplace = document.querySelectorAll("*[onclientclick]");
	for (var el of elementsToReplace) {
		if (!el.getAttribute("data-onclientclick")) {
			console.debug(el.getAttribute("onclientclick"));
			el.addEventListener('click', function (e) { eval(e.target.getAttribute('onclientclick')) });
			el.setAttribute("data-onclientclick", "1");
		}
	}
};

export function setTitle(title) {
		document.title = title;
}

export function getTitle() {
		return document.title;
}

export function OnAfterRender() {
		console.debug("Running Window.load function");
		FormatClientClick();
}
