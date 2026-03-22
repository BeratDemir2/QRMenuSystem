// 🔹 BACKEND ADRESİ
const API = "https://localhost:7046/api";

// 🔹 SAYFA YÜKLENDİĞİNDE BUTONU BAĞLA
document.addEventListener("DOMContentLoaded", () => {
    console.log("ADMIN.JS YÜKLENDİ");

    const btn = document.getElementById("addTableBtn");
    btn.onclick = addTable;
});

// 🔹 BUTONA BASILINCA ÇALIŞAN FONKSİYON
function addTable() {
    console.log("BUTONA BASILDI");

    const tableNo = document.getElementById("tableNumberInput").value;
    const msg = document.getElementById("tableMessage");

    fetch(`${API}/Tables`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            tableNumber: Number(tableNo),
            status: "Empty"
        })
    })
        .then(res => {
            if (res.ok) {
                msg.innerText = "✅ Masa başarıyla eklendi";
                msg.style.color = "green";
            } else {
                msg.innerText = "❌ Masa eklenemedi";
                msg.style.color = "red";
            }
        })
        .catch(() => {
            msg.innerText = "❌ Sunucuya bağlanılamadı";
            msg.style.color = "red";
        });
}
