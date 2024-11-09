async function obtenerDiaDelViaje() {
    console.log("asdfgh");
    var token = localStorage.getItem("token")
    
    try {
      const response = await fetch('https://localhost:7016/api/Usuario', {
        method: 'GET',
        headers: new Headers({
          'Content-Type': 'application/json',
          'Access-Control-Allow-Origin': '*',
          'Authorization': "Bearer " + token
        })
      });
  
      if (!response.ok) {
        throw new Error(`Error en la solicitud: ${response.statusText}`);
      }
  
      const usuarioData = await response.json();
      const fechaInicio = new Date(usuarioData.fech_abordo);
      const fechaFin = new Date(usuarioData.fech_desbordo);
      const hoy = new Date();

      const diferenciaDias = Math.ceil((hoy - fechaInicio) / (1000 * 60 * 60 * 24)) + 1;
      mostrarDiaDelViaje(diferenciaDias);
    } catch (error) {
      console.error('Error al obtener el día del viaje:', error);
    }
  }
  
  function mostrarDiaDelViaje(diaDelViaje) {
    const navbarElemento = document.getElementById('diaViaje');
    if (navbarElemento) {
        if(diaDelViaje < 1) {
            navbarElemento.textContent = `El viaje aun no comenzo`;
        } else if (diaDelViaje > 7) {
            navbarElemento.textContent = `Viaje finalizado`;
        } else {
            navbarElemento.textContent = `Día del viaje: ${diaDelViaje}`;
        }
    }
  }
  
  // Llamar a la función después de cargar el DOM
  document.addEventListener("DOMContentLoaded", obtenerDiaDelViaje());
  