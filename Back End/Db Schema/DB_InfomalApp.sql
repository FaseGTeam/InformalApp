CREATE DATABASE DB_InformalApp;

USE DB_InformalApp;

CREATE TABLE Trabajador(
    IdTrabajador INT NOT NULL AUTO_INCREMENT,
    Cédula INT NOT NULL,
    Nombre VARCHAR(25) NOT NULL,
    Apellido VARCHAR(25) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Profesión VARCHAR(30) NOT NULL,
    ExpTrabajo VARCHAR(10) NOT NULL,
    HojaVida BOOLEAN not NULL, 
    PRIMARY KEY (IdTrabajador)
)  ENGINE=InnoDB;

CREATE TABLE Contratista(
    IdConstratista INT NOT NULL AUTO_INCREMENT,
	Cédula INT NOT NULL,
    Nombre VARCHAR(25) NOT NULL,
    Apellido VARCHAR(25) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Cargo VARCHAR(30) NOT NULL,
    EmpresaCon VARCHAR(45) NOT NULL,
    PRIMARY KEY (IdConstratista)
)  ENGINE=InnoDB;

CREATE TABLE Labor(
    IdLabor INT NOT NULL AUTO_INCREMENT,
	Descripción VARCHAR(50) NOT NULL,
    FecIniLabor DATE NOT NULL,
    FecFinLabor DATE NOT NULL,
    IdContratista INT NOT NULL,
    IdTrabajador INT NOT NULL,
    IdTipoLabor INT NOT NULL,
    PRIMARY KEY (IdLabor),
    CONSTRAINT IdTipoLabor   FOREIGN KEY (IdTipoLabor)   REFERENCES TipoLabor (IdTipo),
    CONSTRAINT IdTrabajador  FOREIGN KEY (IdTrabajador)  REFERENCES Trabajador (IdTrabajador),
    CONSTRAINT IdContratista FOREIGN KEY (IdContratista) REFERENCES Contratista (IdConstratista)
)  ENGINE=InnoDB;

CREATE TABLE TipoLabor(
    IdTipo INT NOT NULL AUTO_INCREMENT,
	Nombre VARCHAR(30) NOT NULL,
    Descripción VARCHAR(50) NOT NULL,
    IdEstado INT NOT NULL,
    PRIMARY KEY (IdTipo),
    CONSTRAINT IdEstado FOREIGN KEY (IdEstado) REFERENCES Estado (IdEstado)
)  ENGINE=InnoDB;

CREATE TABLE LOG(
    IdLog INT NOT NULL AUTO_INCREMENT,
	IdTipoLog INT NOT NULL,
    DetalleLog VARCHAR(100) NOT NULL,
    FechaLog DATE NOT NULL,
    PRIMARY KEY (IdLog),
    CONSTRAINT IdTipoLog FOREIGN KEY (IdTipoLog) REFERENCES TipoLog (IdTipoL)
)  ENGINE=InnoDB;

CREATE TABLE PropuestaTrabajo(
    IdPropuesta INT NOT NULL AUTO_INCREMENT,
	IdLabor INT NOT NULL,
    IdContratista INT NOT NULL,
    IdTrabajador INT NOT NULL,
    IdEstado INT NOT NULL,
    PRIMARY KEY (IdPropuesta),
    CONSTRAINT IdLabor       FOREIGN KEY (IdLabor)       REFERENCES Labor (IdLabor),
    CONSTRAINT IdTrabajador  FOREIGN KEY (IdTrabajador)  REFERENCES Trabajador (IdTrabajador),
    CONSTRAINT IdContratista FOREIGN KEY (IdContratista) REFERENCES Contratista (IdConstratista),
    CONSTRAINT IdEstado      FOREIGN KEY (IdEstado)      REFERENCES Estado (IdEstado)
)  ENGINE=InnoDB;

CREATE TABLE Estado(
    IdEstado INT NOT NULL AUTO_INCREMENT,
	CódigoEstado INT NOT NULL,
    Descripción VARCHAR(30) NOT NULL,
    PRIMARY KEY (IdEstado)
)  ENGINE=InnoDB;

CREATE TABLE TipoLog(
    IdTipoL INT NOT NULL AUTO_INCREMENT,
	CódigoTipoL INT NOT NULL,
    DescripciónL VARCHAR(25) NOT NULL,
    PRIMARY KEY (IdTipoL)
)  ENGINE=InnoDB;
