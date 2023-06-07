function changeBackgroundColor() {
    let bandPreviews = document.getElementsByClassName("band-preview");

    for (var i = 0; i < bandPreviews.length; i++) {
        bandPreviews[i].style.backgroundColor = "rgba(0,237,255,47)";
    }
}
