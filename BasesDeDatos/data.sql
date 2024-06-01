use carta_Pokemon;
INSERT INTO Carta (Nombre, Tipo_Carta, Raresa, Descripcion) VALUES
('Pikachu', 'Eléctrico', 'Común', 'Un ratón eléctrico que puede lanzar rayos.'),
('Charizard', 'Fuego', 'Raro', 'Un dragón que lanza llamas.'),
('Bulbasaur', 'Planta', 'Común', 'Un dinosaurio pequeño con una planta en la espalda.'),
('Squirtle', 'Agua', 'Común', 'Una pequeña tortuga que dispara agua.');

INSERT INTO Jugador (Nombre_Jugador, Nickname, Monedas) VALUES
('Ash Ketchum', 'Ash', 1000),
('Misty Waterflower', 'Misty', 800),
('Brock Slate', 'Brock', 1200),
('Gary Oak', 'Gary', 1500);

INSERT INTO Mazo (Nombre_Mazo, ID_Jugador) VALUES
('Equipo Eléctrico', 1),
('Equipo Agua', 2),
('Equipo Fuego', 3),
('Equipo Planta', 4);

INSERT INTO Cartas_de_pertenencia (ID_Carta, ID_Mazo, Cantidad) VALUES
(1, 1, 2),
(2, 3, 1),
(3, 4, 3),
(4, 2, 2);

INSERT INTO Habilidad (Nombre, Costo, Descripcion, ID_Carta) VALUES
('Impactrueno', '20', 'Un ataque eléctrico básico.', 1),
('Llamarada', '50', 'Un potente ataque de fuego.', 2),
('Latigazo', '15', 'Ataque físico con látigo de planta.', 3),
('Pistola Agua', '10', 'Ataque con un chorro de agua.', 4);

INSERT INTO Torneo (Nombre_Torneo, ID_jugador) VALUES
('Torneo de Kanto', 1),
('Torneo de Johto', 2),
('Torneo de Hoenn', 3),
('Torneo de Sinnoh', 4);

