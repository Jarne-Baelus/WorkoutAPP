readdays()
readminutes()

function readdays() {
    let days = document.getElementById('days').value;
    document.getElementById('dayscounter').innerHTML = days
}
function readminutes() {
    let minutes = document.getElementById('time').value;
    document.getElementById('minutescounter').innerHTML = minutes
}
console.log("active")