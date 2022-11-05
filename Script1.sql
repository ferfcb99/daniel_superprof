-- crear db 
-- DDL, DML
-- DDL : Data definition language
-- DML : Data manage language

CREATE DATABASE Escuela;

USE Escuela;

drop Database Escuela;

CREATE TABLE Tutor
(
 id_tutor int identity(1, 1), -- este campo es autoincrementable de 1 en 1
 nombre varchar(30) not null,
 constraint pk_id_tutor primary key(id_tutor)
);

DROP TABLE Tutor;

INSERT INTO Tutor(nombre) VALUES('Fernando');
INSERT INTO Tutor(nombre) VALUES('Saul'),('Juan');
INSERT INTO Tutor(nombre) VALUES('Fernando');

SELECT t.* FROM Tutor t;

CREATE TABLE Alumno
(
 matricula Varchar(10) not null,
 nombre_alumno varchar(20) not null,
 id_tutor int not null,
 constraint pk_matricula primary key(matricula),
 constraint fk_id_tutor foreign key(id_tutor) references Tutor(id_tutor) ON DELETE CASCADE ON UPDATE CASCADE
);

INSERT INTO Alumno(matricula,nombre_alumno,id_tutor) VALUES ('202113A','Paola',1);

INSERT INTO Alumno(matricula,nombre_alumno,id_tutor) VALUES ('202112B','Juan',3);

INSERT INTO Alumno(matricula,nombre_alumno,id_tutor) VALUES ('202111B','Samuel',2);

SELECT * FROM Alumno;

drop table Alumno;