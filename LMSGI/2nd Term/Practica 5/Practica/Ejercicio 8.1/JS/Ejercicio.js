let change_img_btn = document.getElementById("change_img");
let change_h1_btn = document.getElementById("change_h1");
let change_p_btn = document.getElementById("change_p");


change_img_btn.addEventListener("click", function() {
    
    let img = document.getElementsByTagName("img")[0];
    if (img.alt == 'toothless') {
        img.src = "img/toothless_meme.jpg";
        img.alt = "toothless_meme"
    } else {
        img.src = "img/toothless.jpg";
        img.alt = "toothless";
    }
})

change_h1_btn.addEventListener("click", function() {
    let h1 = document.getElementsByTagName("h1")[0];
    if (h1.innerText == "Tu dragon") {
        h1.innerText = "Este es mi dragon";
    } else {
        h1.innerText = "Tu dragon";
    }
    
})

change_p_btn.addEventListener("click", function() {
    let p = document.getElementsByTagName("p")[0];
    if (p.innerText == "Ahora solo hay memes.") {
        p.innerText = "Cuando era niño, habia dragones."
    } else {
        p.innerText = "Ahora solo hay memes."
    }
    
})