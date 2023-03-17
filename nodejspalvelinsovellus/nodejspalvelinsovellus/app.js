// Luodaan express-sovellus
const express = require('express');
const app = express();

// Staattisten tiedostojen hakemisto
app.use(express.static('public'));

// Reititt‰misen m‰‰ritt‰minen: etusivu
app.get('/', function (req, res) {
    res.sendFile(__dirname + '/public/index.html');
});

// Reititt‰misen m‰‰ritt‰minen: yritysesittelysivu
app.get('/yritys', function (req, res) {
    res.sendFile(__dirname + '/public/yritys.html');
});

// Reititt‰misen m‰‰ritt‰minen: yhteystiedot sivu
app.get('/yhteystiedot', function (req, res) {
    res.sendFile(__dirname + '/public/yhteystiedot.html');
});

// Reititt‰misen m‰‰ritt‰minen: henkilˆkuntasivu
app.get('/henkilokunta', function (req, res) {
    res.sendFile(__dirname + '/public/henkilokunta.html');
});

// Kuunnellaan porttia 3000
app.listen(3000, function () {
    console.log('Sivusto on k‰ynniss‰ osoitteessa http://localhost:3000');
});