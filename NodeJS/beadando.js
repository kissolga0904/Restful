var http = require("http");
const https = require('https');
var express = require('express');
var app = express();
var mysql = require('mysql2');
var bodyParser = require('body-parser');
const {connect} = require("http2");
const swaggerJSDoc = require('swagger-jsdoc');
const swaggerUI = require('swagger-ui-express');
const { version } = require("os");
const AdminPw = "123";
const options = {
    hostname: '127.0.0.1',
    port: 443,
    path: '/SOP_server_index.php',
    method: 'GET',
    rejectUnauthorized: false,
    requestCert: true,
    agent: false
}

const swaggerOptions ={
    definition:{
        openapi:'3.0.0',
        info:{
            title: 'Játékok API',
            version:'1.0.0',
            description: 'Játékok API a játékok menedzseléséhez',
            contact:{
                name: 'Kiss Olga QLCBH6',
                email: 'kissolga0904@gmail.com',
            },
            servers:['http://localhost:3000']
        }
    },
    apis:["beadando.js"]
}
const swaggerDocs = swaggerJSDoc(swaggerOptions);
app.use('/api-docs', swaggerUI.serve, swaggerUI.setup(swaggerDocs));

app.use(function(reg, res, next){
    res.header("Content-Type", 'application/json');
    next();
});

var connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    port: '3306',
    password: '',
    database: 'rest'
});
connection.connect(function(err){
    if(err) throw err;
    console.log('A csatlakozás sikerült...')
});

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({
    extended: true
}));
var server = app.listen(3000, "127.0.0.1", function(){
    var host = server.address().address;
    var port = server.address().port;
    console.log("A következő portot figyeljük: https://%s:%s", host, port)
});

/**
 * @swagger
 * definitions:
 *  Jatekok:
 *   type: object
 *   properties:
 *    id:
 *     type: integer
 *     description: id of the game
 *     example: '2'
 *    nev:
 *     type: string
 *     description: name of the game
 *     example: 'Cyberpunk 2077' 
 *    mufaj:
 *     type: string
 *     description: type of the game
 *     example: 'akció'
 *    kiado:
 *     type: string
 *     description: publisher of the game
 *     example: 'CD Projekt'
 *    jatekmod:
 *     type: string
 *     description: mode of the game
 *     example: 'egyjátékos'
 */


/**
 * @swagger
 * /jatekok:
 *  get:
 *   summary: get all games
 *   description: get all games
 *   responses:
 *    200:
 *     description: succes
 *    500:
 *     description: error
 */
app.get('/jatekok', function(req, res){
    connection.query('SELECT * FROM jatekok', function(error, results, fields){
        if(error) throw error;
        res.json(results);
    });
});
/**
 * @swagger
 * /jatekok/{id}:
 *  get:
 *   summary: get game by id
 *   description: Get a game by id
 *   parameters:
 *    - in: path
 *      name: id
 *      schema:
 *       type: integer
 *      required: true
 *      description: id of the game
 *      example: 1
 *   responses:
 *    200:
 *     description: success
 */
app.get('/jatekok/:id', function(req, res){
    console.log(req);
    connection.query('SELECT * FROM jatekok WHERE id=?', [req.params.id],function(error, results, fields){
        if (error) throw error;
        res.json(results);
    });
});

/**
 * @swagger
 * /addjatekok/{pw}:
 *  post:
 *   summary: create game
 *   description: create game to the database
 *   parameters:
 *    - in: path
 *      name: pw
 *      schema:
 *       type: string
 *      required: true
 *      description: Admin password for CRUD.
 *      example: 123
 *   requestBody:
 *    content:
 *     application/json:
 *      schema:
 *       $ref: '#/definitions/Jatekok'
 *   responses:
 *    200:
 *     description: game created succesfully
 *    500:
 *     description: failure in creating game
 */
app.post('/addjatekok/:pw', function(req, res){
    if(req.params.pw == AdminPw){
        var postData = req.body;
        connection.query('INSERT INTO jatekok SET ?', postData, function(error, results, fields){
            if(error) throw error;
            res.json(results);
        });
    }
    else{
        return res.status(403).json({'"403"':'"Unauthorized"'});
    };
});
/**
 * @swagger
 * /updatejatekok/{id}/{pw}:
 *  put:
 *   summary: update game
 *   description: update game
 *   consumes:
 *    - application/json
 *   produces:
 *    - application/json
 *   parameters:
 *    - in: path
 *      name: id
 *      schema:
 *       type: integer
 *      required: true
 *      description: id of the user
 *      example: 2
 *    - in: path
 *      name: pw
 *      schema:
 *       type: string
 *      required: true
 *      description: Admin password for CRUD.
 *      example: 123
 *    - in: body
 *      name: body
 *      required: true
 *      description: body object
 *      schema:
 *       $ref: '#/definitions/Jatekok'
 *   requestBody:
 *    content:
 *     application/json:
 *      schema:
 *       $ref: '#/definitions/Jatekok'
 *   responses:
 *    200:
 *     description: success
 *     content:
 *      application/json:
 *       schema:
 *        $ref: '#/definitions/Jatekok'
 */
 
app.put('/updatejatekok/:id/:pw', function(req, res){
    if(req.params.pw == AdminPw){
        connection.query('UPDATE jatekok SET nev = "'+req.body.nev+'", mufaj = "'+req.body.mufaj+'", kiado = "'+req.body.kiado+'", jatekmod = "'+req.body.jatekmod+'" WHERE id = '+req.params.id, function(error, results, fields) {
            if (error) throw error;
            res.json(results);
          });
    }
    else{
        return res.status(403).json({'"403"':'"Unauthorized"'});
    };
});
/**
 * @swagger
 * /deletejatekok/{id}/{pw}:
 *  delete:
 *   summary: delete game
 *   description: delete game
 *   parameters:
 *    - in: path
 *      name: id
 *      schema:
 *       type: integer
 *      required: true
 *      description: id of the game
 *      example: 3
 *    - in: path
 *      name: pw
 *      schema:
 *       type: string
 *      required: true
 *      description: Admin password for CRUD.
 *      example: 123
 *   responses:
 *    200:
 *     description: success
 */

app.delete('/deletejatekok/:id/:pw', function(req, res) {
    if (req.params.pw == AdminPw) {
      connection.query('DELETE FROM jatekok WHERE id ='+req.params.id, function(error, results, fields) {
        if (error) throw error;
        res.json(results);
      });
    }
    else {
      return res.status(403).json({'"403"':'"Unauthorized"'});
    };
  });

  app.get('/jatekokPHP', function(req, res1) {
    let data = [];
    let jatekok;
    const req1 = https.request(options, res => {
      console.log('Incoming GET request...');
      console.log(`statusCode: ${res.statusCode}`)
    
      res.on('data', chunk => {
        data.push(chunk);
      });
  
      res.on('end', () => {
        console.log('Response ended: ');
        jatekok = JSON.parse(Buffer.concat(data).toString());
        res1.send(jatekok);
      });
    })
    
    req1.on('error', error => {
      console.error(error)
    })
    req1.end();
  });
  