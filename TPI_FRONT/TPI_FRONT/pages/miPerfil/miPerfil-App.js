document.addEventListener("DOMContentLoaded", function() {
    // Función para obtener los datos de la API
    async function getUserProfile() {
    var token = localStorage.getItem("token")

      try {
        const response = await fetch('https://localhost:7016/api/Usuario',{ method: 'GET',
            headers: new Headers({
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin':'*',
                'Authorization' : "Bearer " + token
            }),}); // Reemplaza con la URL de tu API
        if (!response.ok) {
          throw new Error('Error al obtener los datos');
        }
        
        const data = await response.json();
        
        // Actualizar los elementos del perfil con la información obtenida
        document.getElementById('username').textContent = data.userName;
        document.getElementById('nombre').textContent = data.nombre;
        document.getElementById('apellido').textContent = data.apellido;
        document.getElementById('habitacion').textContent = data.nroHabitacion;
        document.getElementById('zona').textContent = data.zonaHab;
        document.getElementById('estado').textContent = data.estadoUser;
        document.getElementById('fechaInicio').textContent = data.fech_abordo.substring(0,10);
        document.getElementById('fechaFin').textContent = data.fech_desbordo.substring(0,10);
      } catch (error) {
        console.error('Error:', error);
        alert('No se pudo cargar la información del perfil.');
      }
    }
  
    // Llamada a la función para obtener el perfil
    getUserProfile();
  });
  