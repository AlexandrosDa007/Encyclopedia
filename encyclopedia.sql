CREATE TABLE Role(
	role_id INT AUTO_INCREMENT PRIMARY KEY,
	role_name VARCHAR(30) NOT NULL
);

CREATE TABLE Education_Level(
	education_level_id INT AUTO_INCREMENT PRIMARY KEY,
	education_level_name VARCHAR(30) NOT NULL
);

CREATE TABLE User(
	user_id INT AUTO_INCREMENT PRIMARY KEY,
	user_name VARCHAR(40) NOT NULL,
	user_surname VARCHAR(50) NOT NULL,
	user_date_of_birth DATE NOT NULL,
	user_gender CHAR CHECK (user_gender IN ('M','F')),
	user_tel VARCHAR(15),
	user_role_id INT,
	user_education_level_id INT,
	user_description VARCHAR(250),
	user_image MEDIUMBLOB, -- 16MB size approx.
	FOREIGN KEY(user_role_id) REFERENCES Role(role_id),
	FOREIGN KEY(user_education_level_id) REFERENCES Education_Level(education_level_id)
);

CREATE TABLE Account(
	account_id INT NOT NULL PRIMARY KEY,
	account_username VARCHAR(40) NOT NULL UNIQUE,
	account_password VARCHAR(40) NOT NULL, -- Hash value -> to be deleted
	-- account_salted_password_hash CHAR(64) NOT NULL,
	-- account_password_salt CHAR(16) NOT NULL,
	account_email VARCHAR(60) NOT NULL UNIQUE,
	account_created_at DATE NOT NULL,
	FOREIGN KEY(account_id) REFERENCES User(user_id)
);

CREATE TABLE Contact_Group(
	group_id INT AUTO_INCREMENT PRIMARY KEY,
	group_name VARCHAR(30) NOT NULL,
	owner_id INT NOT NULL,
	FOREIGN KEY(owner_id) REFERENCES User(user_id)
);

CREATE TABLE Contact(
	user_id INT NOT NULL,
	contact_id INT NOT NULL,
	group_id INT,
	PRIMARY KEY (user_id, contact_id),
	FOREIGN KEY(user_id) REFERENCES User(user_id),
	FOREIGN KEY(contact_id) REFERENCES User(user_id),
	FOREIGN KEY(group_id) REFERENCES Contact_Group(group_id)
);

CREATE TABLE Category(
	category_id INT AUTO_INCREMENT PRIMARY KEY,
	category_name VARCHAR(40) NOT NULL
);

CREATE TABLE Lemma(
	lemma_title VARCHAR(200) PRIMARY KEY,
	lemma_body MEDIUMBLOB NOT NULL,
	category_id INT NOT NULL,
	FOREIGN KEY(category_id) REFERENCES Category(category_id)
);

CREATE TABLE Edited_Lemma(
	lemma_title VARCHAR(200) NOT NULL,
	editor_id INT NOT NULL,
	edited_lemma_body MEDIUMBLOB NOT NULL,
	edited_lemma_created_at DATE NOT NULL,
	edited_lemma_updated_at DATE NOT NULL,
	PRIMARY KEY (lemma_title, editor_id),
	FOREIGN KEY(lemma_title) REFERENCES Lemma(lemma_title),
	FOREIGN KEY(editor_id) REFERENCES User(user_id)
);

CREATE TABLE Favorite_Lemma(
	lemma_title VARCHAR(200) NOT NULL,
	user_id INT NOT NULL,
	favorite_lemma_created_at DATE NOT NULL,
	PRIMARY KEY (lemma_title, user_id),
	FOREIGN KEY(lemma_title) REFERENCES Lemma(lemma_title),
	FOREIGN KEY(user_id) REFERENCES User(user_id)
);

CREATE TABLE Shared_Lemma( -- lemmata shared with sender's contacts
	sender_id INT NOT NULL,
	receiver_id INT NOT NULL,
	lemma_title VARCHAR(200) NOT NULL,
	if_edited_lemma CHAR NOT NULL CHECK (if_edited_lemma IN ('0','1')), -- If it is an edited lemma, or a common one.
	sending_date DATETIME NOT NULL,
	additional_notes VARCHAR(250),
	PRIMARY KEY (sender_id, receiver_id, lemma_title, sending_date),
	FOREIGN KEY(sender_id) REFERENCES User(user_id),
	FOREIGN KEY(receiver_id) REFERENCES User(user_id),
	FOREIGN KEY(lemma_title) REFERENCES Lemma(lemma_title)
);
