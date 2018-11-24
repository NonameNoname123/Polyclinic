CREATE DATABASE PDataBase;
USE PDataBase;

CREATE table user(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	name TEXT NOT NULL,
	surname TEXT NOT NULL,
	patronymic TEXT NOT NULL,
	login TEXT NOT NULL,
	password TEXT NOT NULL
);

CREATE table appointment(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	doctor_id INTEGER NOT NULL,
	patient_id INTEGER NULL,
	commonAppontment BIT NOT NULL,
	duration TIME NULL,
	appontmentDateTime DATETIME,
	status INTEGER DEFAULT 0,
	FOREIGN KEY (doctor_id) REFERENCES user (id),	
	FOREIGN KEY (patient_id) REFERENCES user (id)	
);

CREATE table patientRole(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	policy TEXT NOT NULL,
	password TEXT NOT NULL,
	address TEXT NOT NULL,
	phoneNumber TEXT NOT NULL,
	user_id INTEGER NOT NULL,
	FOREIGN KEY (user_id) REFERENCES user (id)
);

CREATE table doctorRole(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	user_id INTEGER NOT NULL,
	FOREIGN KEY (user_id) REFERENCES user (id)
);

CREATE table speciality(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	name TEXT NOT NULL,
	doctor_id INTEGER NOT NULL,
	FOREIGN KEY (doctor_id) REFERENCES doctorRole (id)
);

CREATE table adminRole(
	id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	user_id INTEGER NOT NULL,
	FOREIGN KEY (user_id) REFERENCES user (id)
);