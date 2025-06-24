
const contenedor = document.getElementById("contenedor-personajes");
const btnMostrar = document.getElementById("btnmostrar");
const formularioPersonajes = document.getElementById("FormularioPersonajes");

function renderPersonajes(personajes) {
  contenedor.innerHTML = "";

  if (!Array.isArray(personajes) || personajes.length === 0) {
    contenedor.innerHTML = "<p style='text-align:center;'>No hay personajes para mostrar.</p>";
    return;
  }

  const countInfo = document.createElement("p");
  countInfo.textContent = `Se encontraron ${personajes.length} personaje(s).`;
  countInfo.style.fontWeight = "bold";
  countInfo.style.textAlign = "center";
  countInfo.style.width = "100%";
  contenedor.appendChild(countInfo);

  personajes.forEach(p => {
    const card = document.createElement("div");
    card.className = "card";
    card.innerHTML = `
      <img src="${p.image}" alt="${p.name}" />
      <h3>${p.name}</h3>
      <p>${p.status} - ${p.species}</p>
      <p>${p.gender}</p>
      <p><strong>Origen:</strong> ${p.origin.name}</p>
    `;
    contenedor.appendChild(card);
  });
}


function mostrarError(mensaje) {
  contenedor.innerHTML = `<p style="color:red; text-align:center;">${mensaje}</p>`;
}


btnMostrar.addEventListener("click", () => {
  fetch("https://rickandmortyapi.com/api/character")
    .then(res => {
      if (!res.ok) throw new Error("Error en la solicitud");
      return res.json();
    })
    .then(data => renderPersonajes(data.results))
    .catch(() => mostrarError("Error al cargar personajes."));
});


formularioPersonajes.addEventListener("submit", (e) => {
  e.preventDefault();

  const name = document.getElementById("name").value.trim();
  const status = document.getElementById("status").value.trim();
  const species = document.getElementById("species").value.trim();
  const type = document.getElementById("Origen").value.trim();
  const gender = document.getElementById("gender").value.trim();

 
  const params = new URLSearchParams();
  if (name) params.append("name", name);
  if (status) params.append("status", status);
  if (species) params.append("species", species);
  if (type) params.append("Origen", type);
  if (gender) params.append("gender", gender);

  fetch(`https://rickandmortyapi.com/api/character/?${params.toString()}`)
    .then(res => {
      if (!res.ok) throw new Error("Filtro inválido o sin resultados");
      return res.json();
    })
    .then(data => renderPersonajes(data.results))
    .catch(() => mostrarError("No se encontraron personajes con esos filtros."));
});