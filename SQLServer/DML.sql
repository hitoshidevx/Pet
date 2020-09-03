--DML --> DATA MANIPULATION LANGUAGE
INSERT INTO Clinicas(Nome, Endereco) VALUES
('Pet amigos', 'Vila Menck'),
('KaruAmigo', 'Osasco'),
('Petz', 'São Paulo');

INSERT INTO Donos(Nome) VALUES
('Julia Souza'),
('Carla Elias'),
('Fernando Lucas');

INSERT INTO TipoDePet(Descricao) VALUES
('Gato'),
('Cachorro'),
('Coelho');

INSERT INTO Veterinario(CRMV, Nome, IdClinicas) VALUES
('9393ks', 'Paula Abraico', 1),
('9948jd', 'Júlio',2),
('2678kl', 'Francisco',3);

INSERT INTO Atendimento(Descricao, DataAtendimento, IdPet, IdVet) VALUES
('Cirurgia','2020-08-04T20:30:00',2,2),
('Consulta','2020-09-01T10:30:00',3,3),
('Exame','2020-11-19T15:30:00',4,1);

INSERT INTO Pet(Nome, DataNascimento, IdRaca, IdDonos) VALUES
('Suzi', '2010-09-17T15:30:00', 3,1),
('Meg', '2010-09-17T15:30:00', 2, 2),
('Big', '2010-09-17T15:30:00',1,3);


INSERT INTO Raca(Descricao, IdTipoDePet) VALUES
('Pinscher', 2),
('Sem raça', 1),
('Pardal',3);


/*UPDATE Donos SET
Nome = 'Luana Croft'
WHERE IdDonos = 3 */


--DELETE FROM Raca WHERE IdRaca = 1;

-- DQL
-- * ALL (TUDO)
SELECT * from Clinicas;
SELECT * from Donos;
SELECT * from TipoDePet;
SELECT * from Veterinario;
SELECT * from Atendimento;
SELECT * from Pet;
SELECT * from Raca;