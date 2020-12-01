var isHidden = false;

function MoveNavigationBar() {
    var navbar = document.getElementById('LeftNavigationBarId');
    var leftBlank = document.getElementById('LeftBlankId');
    var rightContent = document.getElementById('RightContentId');
    /* changes */
    var buttonIcon = document.getElementById('LNBMBImage');
    if (isHidden == false) {
        navbar.style.transform = "translateX(-200px)";
        leftBlank.style.width = "50px";
        rightContent.style.width = "calc(100% - 50px)";
        /* changes */
        buttonIcon.style.transform = "rotate(180deg)";
        isHidden = true;
    }
    else {
        navbar.style.transform = "translateX(0px)";
        leftBlank.style.width = "250px";
        rightContent.style.width = "calc(100% - 250px)";
        /* changes */
        buttonIcon.style.transform = "rotate(0deg)";
        isHidden = false;
    }
}