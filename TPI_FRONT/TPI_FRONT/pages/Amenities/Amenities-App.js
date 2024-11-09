const selectCategoria = document.querySelector('#categoriaSelect');
const row_amenities = document.querySelector('#row_amenities');

let amenities = [];

// Función para obtener y mostrar categorías en el <select>
async function responseSelect() {
    await fetch('https://localhost:7016/api/Categoria',{
        method: 'GET',
        headers: new Headers({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin':'*'
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
responseSelect();

// Función para mostrar las amenities filtradas en el contenedor
function mostrarAmenities(amenitiesFiltradas) {
    row_amenities.innerHTML = ''; // Limpia las tarjetas anteriores
    amenitiesFiltradas.forEach(amenity => {
        const cardHTML = `
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body text-center">
                        <div class="activities-item-rating">
                        </div>
                        <h5 class="card-title">${amenity.nombre}</h5>
                        <p class="card-text">${amenity.descripcion}</p>
                        <p class="activities-item-description">${amenity.idCategoria}</p>
                    </div>
                    <div class="card-footer bg-white border-top-0">
                        <a href="#" class="btn btn-reservar btn-lg w-100">Reservar ahora</a>
                    </div>
                </div>
            </div>
        `;
        row_amenities.innerHTML += cardHTML; // Asegúrate de usar `row_amenities`
    });
}

// Función para obtener y almacenar amenities en la variable global
async function responsePuntuaciones() {
    await fetch('https://localhost:7016/api/Amenities', {
        method: 'GET',
        headers: new Headers({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin': '*',
        }),
        mode: 'cors'
    }).then((res) => res.json()).then(json => {
        amenities = json; // Guarda todas las amenities aquí
        mostrarAmenities(amenities); // Muestra todas las amenities al inicio
    });
}

responsePuntuaciones();

// Agrega un listener para filtrar por categoría
selectCategoria.addEventListener('change', () => {
    const categoriaSeleccionada = selectCategoria.value;
    console.log('Categoría seleccionada:', categoriaSeleccionada);

    // Filtra según la categoría seleccionada
    const amenitiesFiltradas = categoriaSeleccionada === 'Todas' ?
                               amenities : 
                               amenities.filter(a => a.idCategoria == categoriaSeleccionada);
    mostrarAmenities(amenitiesFiltradas); // Muestra las amenities filtradas
});
