let ul = document.getElementById("list");
let add_element_btn = document.getElementById("add_element");
let delete_last_btn = document.getElementById("delete_last_element");

/* Como la función de crear objetos en la lista se ha vuelto extensa, y cada vez encuentro cosas para
agregar, creo que es optimo utilizar una función a parte de la creada en el listener.
Aún asi, dejaré comentado mi viejo listener aqui.

add_element_btn.addEventListener("click", function() {
    // Le pediremos al usuario que ingrese un texto nuevo.
    let new_text = prompt("Añade un nuevo elemento.");
    // Si el texto nuevo, no se encuentra vacio, lo añadiremos.
    // No queremos añadir elementos vacios a la lista.
    if (new_text !== '') {
        let li = document.createElement("li");

        let checkbox = document.createElement("input");
        checkbox.type = "checkbox";
        
        let li_text = document.createTextNode(new_text);
        li.appendChild(checkbox);
        li.appendChild(li_text);
        ul.appendChild(li);
    } else {
        alert("El elemento agregado, estaba vacio. Completa el espacio.")
    }
})
*/

// Crearemos nuestros nuevos elementos de manera dinamica con esta función.
function addNewLiElement(new_text) {
    // Creamos el li y el input, al cual asignamos el tipo de checkbox.
    let li = document.createElement("li");
    let checkbox = document.createElement("input");
    checkbox.type = "checkbox";

    // Crearemos un label, el cual contendrá la información que queremos agregar a la lista.
    let to_do_label = document.createElement('label');
    to_do_label.innerHTML = new_text;
    to_do_label.className = "to_do_label";
    // Tambien crearemos un label para la basura.
    let trash_label = document.createElement('label');
    trash_label.innerHTML = "🗑️";
    trash_label.className = "trash_label";


    // appendChild para cada apartado, en orden de visualización. Primero checkbox, luego texto y finalmente, label.
    
    li.appendChild(checkbox);
    li.appendChild(to_do_label);
    li.appendChild(trash_label);

    // Luego agarramos ese li y lo sumamos a ul.
    ul.appendChild(li);
}

add_element_btn.addEventListener("click", function() {
    // Le pediremos al usuario que ingrese un texto nuevo.
    let new_text = prompt("Añade un nuevo elemento.");
    // Si el texto nuevo, no se encuentra vacio, lo añadiremos.
    // No queremos añadir elementos vacios a la lista.
    if (new_text !== '') {
        addNewLiElement(new_text);
    } else {
        alert("El elemento agregado, estaba vacio. Completa el espacio.")
    }
    
})

delete_last_btn.addEventListener("click", function() {
    let ul_every_element = ul.getElementsByTagName("li");
    ul_every_element[ul_every_element.length - 1].remove();

})

// With this, we'll create an eventListenert for the father, the UL.
ul.addEventListener("click", function(e) {
    // Once ul was clicked, we'll triger a function that recieves e as a parameter.
    // e is used in JS as an event.
    // After that, we will use target to select the item clicked, and we will check if it was an input.
    if(e.target.nodeName == "INPUT") {
        // As target is the checkbox, its next sibiling is the "to_do_list" label, so we will catch it through
        // nextSibling property.
        let to_do_label = e.target.nextSibling;

        
        if (to_do_label.style.textDecoration != 'line-through'){
            to_do_label.style.textDecoration = 'line-through';

        } else {
            to_do_label.style.textDecoration = 'none';
        }
        
    }
    else if (e.target.nodeName == "LABEL" && e.target.class == "trash_label") {
        // If the .trash_label label was clicked, we will select its parent and we will remove it.
        e.target.parentElement.remove();
    }
})