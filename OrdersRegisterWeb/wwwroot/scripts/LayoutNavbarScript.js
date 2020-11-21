var isHidden = false;

function MoveNavigationBar() {
    var navbar = document.getElementById('LeftNavigationBarId');
    var leftBlank = document.getElementById('LeftBlankId');
    var rightContent = document.getElementById('RightContentId');
    if (isHidden == false) {
        navbar.style.transform = "translateX(-200px)";
        leftBlank.style.width = "50px";
        rightContent.style.width = "calc(100% - 50px)";
        isHidden = true;
    }
    else {
        navbar.style.transform = "translateX(0px)";
        leftBlank.style.width = "250px";
        rightContent.style.width = "calc(100% - 250px)";
        isHidden = false;
    }
}