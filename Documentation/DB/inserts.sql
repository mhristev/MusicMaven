INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('blueprint', 'The Blueprint', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.8, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('blueprint', 'HIP_HOP', '2001-09-11');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('jay_z', 'Jay Z', 'https://drive.google.com/uc?id=1QsCRdJrZkWfskLnryOEUfZL2bpkEb8sn', 8.2, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('jay_z', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('blueprint', 'jay_z');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('takeover', 'Takeover', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('izzo_h.o.v.a.', 'Izzo (H.O.V.A)', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('girls_girls_girls', 'Girls, Girls, Girls', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('takeover', 311, 'blueprint'),
('izzo_h.o.v.a.', 245, 'blueprint'),
('girls_girls_girls', 265, 'blueprint');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('lemonade', 'Lemonade', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.9, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('lemonade', 'RnB', '2016-04-23');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('beyonce', 'Beyonce', 'https://drive.google.com/uc?id=1R2umc2nphAz3RYPhH5NuRAOcTt7Khokj', 9.1, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('beyonce', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('lemonade', 'beyonce');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hold_up', 'Hold Up', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('formation', 'Formation', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('sorry', 'Sorry', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('hold_up', 212, 'lemonade'),
('formation', 231, 'lemonade'),
('sorry', 234, 'lemonade');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('to_pimp_a_butterfly', 'To Pimp a Butterfly', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 4.7, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('to_pimp_a_butterfly', 'HIP_HOP', '2015-03-15');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('kendrick_lamar', 'Kendrick Lamar', 'https://drive.google.com/uc?id=1SYP1EP9KWz4vfwHuKEqX795Lf_4zok68', 9.3, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('kendrick_lamar', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('to_pimp_a_butterfly', 'kendrick_lamar');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('king_kunta', 'King Kunta', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('alright', 'Alright', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 4.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('the_blacker_the_berry', 'The Blacker the Berry', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('king_kunta', 234, 'to_pimp_a_butterfly'),
('alright', 309, 'to_pimp_a_butterfly'),
('the_blacker_the_berry', 295, 'to_pimp_a_butterfly');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('watch_the_throne', 'Watch The Throne', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('watch_the_throne', 'HIP_HOP', '2011-08-08');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('kanye_west', 'Kanye West', 'https://drive.google.com/uc?id=1iPQxExw64EMxs1tpfP6znjsDG_Ay2OnA', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('kanye_west', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('watch_the_throne', 'kanye_west'),
       ('watch_the_throne', 'jay_z');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('no_church_in_the_wild', 'No Church in the Wild', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('gotta_have_it', 'Gotta Have It', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('otis', 'Otis', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('no_church_in_the_wild', 319, 'watch_the_throne'),
('gotta_have_it', 140, 'watch_the_throne'),
('otis', 176, 'watch_the_throne');