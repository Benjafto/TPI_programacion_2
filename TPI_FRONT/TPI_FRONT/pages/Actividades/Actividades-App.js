const selectCategoria = document.querySelector('#categoriaSelect')
const ratingActividades = document.querySelector('#activities-item-rating')
const card_rating = document.querySelector('#card_rating')
const cart_rating_container = document.querySelector('#cart_rating_container')
const row_rating = document.querySelector('#row_rating')


async function responseSelect() {
    var token = localStorage.getItem("token")
    console.log(token)
    await fetch('https://localhost:7016/api/Categoria',{
        method: 'GET',
        headers: new Headers({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin':'*',
            'Authorization' : "Bearer " + token
        }),
        mode:'cors'
    }).then((res)=> res.json()).then(json => {

        const allOption = document.createElement('option');
        allOption.value = 'Todas';
        allOption.innerHTML = 'Todas';
        selectCategoria.appendChild(allOption);
        for(let i = 0; i < json.length; i++){
            let option = document.createElement('option')
            option.value = json[i].idCategoria
            option.innerHTML = json[i].descripcion
            selectCategoria.appendChild(option)
        }
    })
}

responseSelect()

let actividades = []; // Variable para almacenar todas las actividades

// Guardar actividades al obtenerlas en responsePuntuaciones()

// Función para renderizar las actividades filtradas
function mostrarActividades(actividadesFiltradas) {
    row_rating.innerHTML = ''; // Limpia las tarjetas anteriores
    actividadesFiltradas.forEach(actividad => {
        const cardHTML = `
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body text-center">
                        <div class="activities-item-rating">
                        </div>
                        <h5 class="card-title">${actividad.nombre}</h5>
                        <p class="card-text">${actividad.descripcion}</p>
                        <p class="activities-item-price">$${actividad.costo.toFixed(2)}</p>
                        <p class="activities-item-description">${actividad.idCategoria}</p>
                    </div>
                    <div class="card-footer bg-white border-top-0">
                        <a href="#" class="btn btn-reservar btn-lg w-100">Reservar ahora</a>
                    </div>
                </div>
            </div>
        `;
        row_rating.innerHTML += cardHTML;
    });
}

async function responsePuntuaciones(){
    await fetch('https://localhost:7016/api/Actividade',{
        method: 'GET',
        headers: new Headers({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin':'*',
        }),
        mode: 'cors'
    }).then((res) => res.json()).then(json => {
        actividades = json; // Guarda todas las actividades aquí
        mostrarActividades(actividades); // Llama a mostrarActividades con todas al inicio
    });
}
responsePuntuaciones()
// Agrega un event listener al <select> para filtrar actividades
selectCategoria.addEventListener('change', () => {
    const categoriaSeleccionada = selectCategoria.value;
    console.log(categoriaSeleccionada)
    const actividadesFiltradas = categoriaSeleccionada === 'Todas' ? 
                                 actividades : 
                                 actividades.filter(a => {return a.idCategoria == categoriaSeleccionada});
    console.log(actividadesFiltradas)
    mostrarActividades(actividadesFiltradas);
});





/*                                     <span class="stars">${'★'.repeat(json.puntuacion)}${'☆'.repeat(5 - json.puntuacion)}</span>
                                    <span class="rating">${json.puntuacion.toFixed(2)}</span> */
/*  */
