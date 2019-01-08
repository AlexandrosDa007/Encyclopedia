'use strict';
const mysql = require('mysql');

// let con = mysql.createConnection({
//     host: '83.212.103.59',
//     user: 'user1',
//     password: '1234567890',
//     database: 'foo'
// });

let con = mysql.createConnection({
    host: 'db4free.net',
    user: 'alator2',
    password: '1234567890',
    database: 'alatorsdb2'
});


con.connect((err) => {
    if (err) {
        console.log('Database error');
        console.log(err);
        throw err;
    }
});

module.exports = con;