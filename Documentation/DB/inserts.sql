INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('blueprint', 'The Blueprint', 'blueprint.jpg', 4.8, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('blueprint', 'HIP_HOP', '2001-09-11');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('jay_z', 'Jay Z', 'jay.png', 8.2, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('jay_z', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('blueprint', 'jay_z');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('takeover', 'Takeover', 'takeover.jpg', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('izzo_h.o.v.a.', 'Izzo (H.O.V.A)', 'izzo_hova.jpg', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('girls_girls_girls', 'Girls, Girls, Girls', 'girls_girls_girls.jpg', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('takeover', 311, 'blueprint'),
('izzo_h.o.v.a.', 245, 'blueprint'),
('girls_girls_girls', 265, 'blueprint');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('lemonade', 'Lemonade', 'lemonade.jpg', 4.9, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('lemonade', 'RnB', '2016-04-23');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('beyonce', 'Beyonce', 'beyonce.png', 9.1, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('beyonce', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('lemonade', 'beyonce');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hold_up', 'Hold Up', 'hold_up.jpg', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('formation', 'Formation', 'formation.jpg', 4.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('sorry', 'Sorry', 'sorry.jpg', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('hold_up', 212, 'lemonade'),
('formation', 231, 'lemonade'),
('sorry', 234, 'lemonade');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('to_pimp_a_butterfly', 'To Pimp a Butterfly', 'to_pimp_a_butterfly.jpg', 4.7, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('to_pimp_a_butterfly', 'HIP_HOP', '2015-03-15');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('kendrick_lamar', 'Kendrick Lamar', 'kendrick.png', 9.3, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('kendrick_lamar', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('to_pimp_a_butterfly', 'kendrick_lamar');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('king_kunta', 'King Kunta', 'king_kunta.jpg', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('alright', 'Alright', 'alright.jpg', 4.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('the_blacker_the_berry', 'The Blacker the Berry', 'the_blacker_the_berry.jpg', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('king_kunta', 234, 'to_pimp_a_butterfly'),
('alright', 309, 'to_pimp_a_butterfly'),
('the_blacker_the_berry', 295, 'to_pimp_a_butterfly');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('watch_the_throne', 'Watch The Throne', 'watch_the_throne.jpg', 4.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('watch_the_throne', 'HIP_HOP', '2011-08-08');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('kanye_west', 'Kanye West', 'kanye_west.png', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('kanye_west', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('watch_the_throne', 'kanye_west'),
       ('watch_the_throne', 'jay_z');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('no_church_in_the_wild', 'No Church in the Wild', 'no_church_in_the_wild.jpg', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('niggas_in_paris', 'Niggas in Paris', 'niggas_in_paris.jpg', 4.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('otis', 'Otis', 'otis.jpg', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('no_church_in_the_wild', 319, 'watch_the_throne'),
('niggas_in_paris', 219, 'watch_the_throne'),
('otis', 176, 'watch_the_throne');