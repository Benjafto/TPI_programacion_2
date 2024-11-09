const selectCategoria = document.querySelector('#categoriaSelect')
const row_servicios = document.querySelector('#row_servicios')


// obtenerCategorias();

let servicios = [];

// Función para renderizar los servicios filtrados
function mostrarServicios(serviciosFiltrados) {
    row_servicios.innerHTML = '';
    serviciosFiltrados.forEach(servicio => {
        const cardHTML = `
            <div class="col-md-6 col-lg-3 mb-4">
                <div class="card h-100">
                    <div class="card-body text-center">
                        <h5 class="card-title">${servicio.nombre}</h5>
                        <p class="card-text">${servicio.descripcion}</p>
                        <p class="service-price">$${servicio.idTematica}</p>
                        <p class="service-category">${servicio.idTipoServicio}</p>
                    </div>
                    <div class="card-footer bg-white border-top-0">
                        <a href="#" class="btn btn-reservar btn-lg w-100">Reservar ahora</a>
                    </div>
                </div>
            </div>
        `;
        row_servicios.innerHTML += cardHTML;
    });
}

async function obtenerServicios(){
    await fetch('https://localhost:7016/api/ServicioGastronomico',{
        method: 'GET',
        headers: new Headers({
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin': '*',
        }),
        mode: 'cors'
    }).then((res) => res.json()).then(json => {
        servicios = json;
        mostrarServicios(servicios); 
    });
}

obtenerServicios();
selectCategoria.addEventListener('change', () => {
    const tipoSeleccionado = selectCategoria.value;
    const serviciosFiltrados = tipoSeleccionado === 'Todos' ? 
                               servicios : 
                               servicios.filter(s => s.idTipoServicio == tipoSeleccionado);
    mostrarServicios(serviciosFiltrados);
});
