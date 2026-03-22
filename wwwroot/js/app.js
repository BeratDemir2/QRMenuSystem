const API = "https://localhost:7046/api";
let selectedTableId = null;

document.getElementById("loadTablesBtn").onclick = loadTables;

function loadTables() {
    fetch(`${API}/Tables`)
        .then(res => res.json())
        .then(tables => {
            const container = document.getElementById("tablesContainer");
            container.innerHTML = "";

            tables.forEach(t => {
                const div = document.createElement("div");
                div.className = "table-card " + (t.status === "Empty" ? "table-empty" : "table-full");
                div.innerText = "Masa " + t.id;

                if (t.status === "Empty") {
                    div.onclick = () => selectTable(t);
                }

                container.appendChild(div);
            });
        });
}

function selectTable(table) {
    selectedTableId = table.id;
    document.getElementById("tablesScreen").classList.add("hidden");
    document.getElementById("menuScreen").classList.remove("hidden");
    document.getElementById("menuTitle").innerText = `Masa ${table.id} için Menü`;
    loadMenu();
}

function loadMenu() {
    fetch(`${API}/MenuItems`)
        .then(res => res.json())
        .then(items => {
            const container = document.getElementById("menuContainer");
            container.innerHTML = "";

            items.forEach(i => {
                const div = document.createElement("div");
                div.innerText = `${i.name} - ${i.price}₺`;
                container.appendChild(div);
            });
        });
}
