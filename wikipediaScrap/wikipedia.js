'use strict';
/* jshint ignore:start */

const wtf = require('wtf_wikipedia');
const axios = require('axios');
const dbcon = require('./db.js');
const colors = require('colors');



async function getRandomArticleName(categoryName) {
    let url = `https://en.wikipedia.org/wiki/Special:RandomInCategory/${categoryName}`;
    console.log(colors.blue(url));
    let data;
    let title
    try {
        data = await axios.get(url);
        data = data.data.substring(0, 500);
        let pattern = /<title>.+<\/title>/i;
        let titleTag = data.match(pattern)[0];
        title = titleTag.substring(7, titleTag.length - 20);
        title = title.replace(/ /g, '_');
        if (title.includes('Category:')) {
            console.log(colors.yellow(`Title contains the word Category.Finding another!!`));
            let category = title.substring(9, title.length);
            title = await getRandomArticleName(category);
        } else if (title.includes('Portal:')) {
            console.log(colors.yellow(`Title contains the word Portal.Finding another!!`));
            title = '000';
        } else if (title.includes('Wikipedia:')) {
            console.log(colors.yellow(`Title contains the word Wikipedia.Finding another!!`));
            title = '000';
        }else if (title.includes('Template:')) {
            console.log(colors.yellow(`Title contains the word Template.Finding another!!`));
            title = '000';
        }else if (title.includes('Index of')) {
            console.log(colors.yellow(`Title contains the words Index of.Finding another!!`));
            title = '000';
        }
    } catch (e) {
        console.log(e);
        console.log(colors.red(`Axios error. Finding another.`));
        title = '000';
    }
    return title;
}

async function getPageContent(page) {
    let doc = await wtf.fetch(page);
    if (!doc) {
        console.log(`Didn't find article with name: ${page}`);
        return;
    }

    let sections = doc.sections();
    let article = [];
    for (let i = 0; i < sections.length; i++) {
        let section = sections[i];
        let title = section.title();
        let text = section.text();
        let html = section.html();
        html = html.replace(/<a[^>]*>/img,'');
        html = html.replace(/<\/a[^>]*>/img,'');
        if (text) { //Ean iparxei keimeno
            article.push(html);
        }
    }
    return article;

}

async function populateDB() {
    const categories = ['Academic_disciplines', 'Arts', 'Business', 'Concepts', 'Culture', 'Education', 'Entertainment', 'Events', 'Geography', 'Health', 'History', 'Humanities', 'Language', 'Law', 'Life', 'Mathematics', 'Nature', 'People', 'Philosophy', 'Politics', 'Reference', 'Religion', 'Science', 'Society', 'Sports', 'Technology', 'Universe', 'World'];

    let title;
    for (let category of categories) {
        let titles = [];
        let lemmata = [];
        for (let i = 0; i < 20; i++) {
            do {
                title = await getRandomArticleName(category);
                title = title.replace(/_/g,' ');
            } while (titles.includes(title) || title === '000');
            console.log(colors.green(`Title:${title}`));
            let lemma = await getPageContent(title);
            titles.push(title);
            lemmata.push(lemma);
        }
        await insertLemmataOnDB(titles, lemmata, category);
    }
}

async function insertLemmataOnDB(titles, lemmata, category) {
    let catID = await new Promise((resolve, reject) => {
        let query1 = `SELECT * FROM Category WHERE category_name='${category}'`;
        dbcon.query(query1, (error, result, fields) => {
            console.log(query1);
            if (error)
                throw error;
            return resolve(result[0].category_id);
        });
    });
    for (let i = 0; i < titles.length; i++) {
        let title = titles[i];
        let lemma = lemmata[i];
        let lemmaU = ``;
        if (!lemma){
        	continue;
        }
        for (let j = 0; j < lemma.length; j++) {
            lemmaU += lemma[j];
        }
        try {
            await new Promise((resolve, reject) => {
                let query1 = `INSERT INTO Lemma(lemma_title,lemma_body,category_id) VALUES(${dbcon.escape(title)},${dbcon.escape(lemmaU)},${catID})`;
                dbcon.query(query1, (error, result, fields) => {
                    if (error)
                        return reject(error);
                    return resolve();
                });
            });
        }
        catch(error){
            console.log(colors.red(error));
        }

    }
    console.log(`Done with->${category}`);

}

populateDB();


/* jshint ignore:end */