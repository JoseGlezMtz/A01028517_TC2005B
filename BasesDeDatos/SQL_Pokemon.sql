DROP database IF exists carta_Pokemon;

CREATE DATABASE IF NOT EXISTS carta_Pokemon;

USE carta_Pokemon;

CREATE TABLE Carta (
  ID_Carta INT PRIMARY KEY AUTO_INCREMENT,
  Nombre VARCHAR(255) NOT NULL,
  Tipo_Carta VARCHAR(255) NOT NULL,
  Raresa VARCHAR(255) NOT NULL,
  Descripcion TEXT NOT NULL

)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE Jugador (
  ID_Jugador INT PRIMARY KEY AUTO_INCREMENT,
  Nombre_Jugador VARCHAR(255) NOT NULL,
  Nickname VARCHAR(255) NOT NULL,
  Monedas INT NOT NULL
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE Mazo (
  ID_Mazo INT PRIMARY KEY AUTO_INCREMENT,
  Nombre_Mazo VARCHAR(255) NOT NULL,
  ID_Jugador INT NOT NULL,
  FOREIGN KEY (ID_Jugador) REFERENCES Jugador(ID_Jugador)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE Cartas_de_pertenencia (
  ID_Carta INT NOT NULL,
  ID_Mazo INT NOT NULL,
  Cantidad INT NOT NULL,
  PRIMARY KEY (ID_Carta, ID_Mazo),
  FOREIGN KEY (ID_Carta) REFERENCES Carta(ID_Carta),
  FOREIGN KEY (ID_Mazo) REFERENCES Mazo(ID_Mazo)
)ENGINE=MyISAM;

CREATE TABLE Habilidad (
  ID_Habilidad INT PRIMARY KEY AUTO_INCREMENT,
  Nombre VARCHAR(255) NOT NULL,
  Costo VARCHAR(255) NOT NULL,
  Descripcion TEXT NOT NULL,
  ID_Carta INT NOT NULL,
  FOREIGN KEY (ID_Carta) REFERENCES Carta(ID_Carta)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE Torneo (
  ID_Torneo INT PRIMARY KEY AUTO_INCREMENT,
  Nombre_Torneo VARCHAR (255) NOT NULL,
  ID_jugador INT NOT NULL,
  FOREIGN KEY (ID_jugador) REFERENCES Jugador(ID_Jugador)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

Select * from Torneo;