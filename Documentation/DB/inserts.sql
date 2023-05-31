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
VALUES ('the_rules_back', 'The Rulers Back', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('takeover', 'Takeover', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('izzo', 'Izzo (H.O.V.A.)', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('girls_girls_girls', 'Girls, Girls, Girls', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('jigga_that_nigga', 'Jigga That Nigga', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('u_dont_know', 'U Dont Know', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hola_hovito', 'Hola Hovito', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('heart_of_the_city', 'Heart of the City (Aint No Love)', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('never_change', 'Never Change', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('song_cry', 'Song Cry', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('all_i_need', 'All I Need', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('renegade', 'Renegade', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('blueprint_momma_loves_me', 'Blueprint (Momma Loves Me)', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('lyrical_exercise', 'Lyrical Exercise', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('girls_girls_girls_part_2', 'Girls, Girls, Girls Part 2', 'https://drive.google.com/uc?id=1USHtM0UPUUjkgnCnnSV6THddaIgCp7fQ', 4.2, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('the_rules_back', 232, 'blueprint'),
('takeover', 311, 'blueprint'),
('izzo', 248, 'blueprint'),
('girls_girls_girls', 265, 'blueprint'),
('jigga_that_nigga', 234, 'blueprint'),
('u_dont_know', 212, 'blueprint'),
('hola_hovito', 196, 'blueprint'),
('heart_of_the_city', 252, 'blueprint'),
('never_change', 295, 'blueprint'),
('song_cry', 307, 'blueprint'),
('all_i_need', 212, 'blueprint'),
('renegade', 341, 'blueprint'),
('blueprint_momma_loves_me', 249, 'blueprint'),
('lyrical_exercise', 212, 'blueprint'),
('girls_girls_girls_part_2', 300, 'blueprint');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('lemonade', 'Lemonade', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.9, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('lemonade', 'RnB', '2016-04-23');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('renaissance', 'RENAISSANCE', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.0, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('renaissance', 'POP', '2022-07-29');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('renaissance', 'beyonce');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('rebirth', 'Rebirth', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('divine', 'Divine', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('eternity', 'Eternity', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('royal', 'Royal', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('serenade', 'Serenade', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('celestial', 'Celestial', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('empower', 'Empower', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('magnificence', 'Magnificence', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('enchant', 'Enchant', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('legacy', 'Legacy', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('resilience', 'Resilience', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('vibrant', 'Vibrant', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('harmony', 'Harmony', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('inspire', 'Inspire', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('euphoria', 'Euphoria', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('journey', 'Journey', 'https://drive.google.com/uc?id=1dgadxExDSEl5T0pkZMeJ7jrNb2fki-_E', 9.6, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('rebirth', 265, 'renaissance'),
('divine', 314, 'renaissance'),
('eternity', 245, 'renaissance'),
('royal', 278, 'renaissance'),
('serenade', 305, 'renaissance'),
('celestial', 289, 'renaissance'),
('empower', 332, 'renaissance'),
('magnificence', 391, 'renaissance'),
('enchant', 276, 'renaissance'),
('legacy', 318, 'renaissance'),
('resilience', 360, 'renaissance'),
('vibrant', 295, 'renaissance'),
('harmony', 324, 'renaissance'),
('inspire', 287, 'renaissance'),
('euphoria', 407, 'renaissance'),
('journey', 291, 'renaissance');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('beyonce', 'Beyonce', 'https://drive.google.com/uc?id=1R2umc2nphAz3RYPhH5NuRAOcTt7Khokj', 9.1, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('beyonce', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('lemonade', 'beyonce');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('pray_you_catch_me', 'Pray You Catch Me', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hold_up', 'Hold Up', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('don_t_hurt_yourself', 'Dont Hurt Yourself', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('sorry', 'Sorry', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('6_inch', '6 Inch', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('daddy_lessons', 'Daddy Lessons', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('love_drought', 'Love Drought', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('sandcastles', 'Sandcastles', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('forward', 'Forward', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('freedom', 'Freedom', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('all_night', 'All Night', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('formation', 'Formation', 'https://drive.google.com/uc?id=1Y8hFD5GtrTkI3AcSdiwpErEgk69NA8tf', 4.9, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('pray_you_catch_me', 235, 'lemonade'),
('hold_up', 221, 'lemonade'),
('don_t_hurt_yourself', 218, 'lemonade'),
('sorry', 232, 'lemonade'),
('6_inch', 237, 'lemonade'),
('daddy_lessons', 241, 'lemonade'),
('love_drought', 229, 'lemonade'),
('sandcastles', 245, 'lemonade'),
('forward', 251, 'lemonade'),
('freedom', 289, 'lemonade'),
('all_night', 320, 'lemonade'),
('formation', 242, 'lemonade');


    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('to_pimp_a_butterfly', 'To Pimp a Butterfly', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.7, 'ALBUM');

    INSERT INTO Album (id, genre, releaseDate)
    VALUES ('to_pimp_a_butterfly', 'HIP_HOP', '2015-03-15');


    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('damn', 'DAMN', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.5, 'ALBUM');

    INSERT INTO Album (id, genre, releaseDate)
    VALUES ('damn', 'HIP_HOP', '2017-04-14');

    INSERT INTO AlbumArtists (albumId, artistId)
    VALUES ('damn', 'kendrick_lamar');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('blood', 'BLOOD.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.2, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('dna', 'DNA.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.5, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('yah', 'YAH.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.1, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('element', 'ELEMENT.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.3, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('feel', 'FEEL.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.2, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('loyalty', 'LOYALTY. (feat. Rihanna)', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.4, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('pride', 'PRIDE.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.3, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('humble', 'HUMBLE.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.6, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('lust', 'LUST.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.2, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('love', 'LOVE. (feat. Zacari)', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.4, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('xxx', 'XXX. (feat. U2)', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.5, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('fear', 'FEAR.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.3, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('god', 'GOD.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.1, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('duckworth', 'DUCKWORTH.', 'https://drive.google.com/uc?id=1TnsW6b4dj_BJ9dA-tr9tMk263x1mKA6A', 9.2, 'SONG');

    INSERT INTO Song (id, durationInSeconds, albumId)
    VALUES
    ('blood', 58, 'damn'),
    ('dna', 185, 'damn'),
    ('yah', 162, 'damn'),
    ('element', 210, 'damn'),
    ('feel', 193, 'damn'),
    ('loyalty', 228, 'damn'),
    ('pride', 257, 'damn'),
    ('humble', 177, 'damn'),
    ('lust', 307, 'damn'),
    ('love', 223, 'damn'),
    ('xxx', 289, 'damn'),
    ('fear', 434, 'damn'),
    ('god', 244, 'damn'),
    ('duckworth', 282, 'damn');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('kendrick_lamar', 'Kendrick Lamar', 'https://drive.google.com/uc?id=1SYP1EP9KWz4vfwHuKEqX795Lf_4zok68', 9.3, 'ARTIST');

    INSERT INTO Artist (id, artistType)
    VALUES ('kendrick_lamar', 'SOLO');

    INSERT INTO AlbumArtists (albumId, artistId)
    VALUES ('to_pimp_a_butterfly', 'kendrick_lamar');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('wesleys_theory', 'Wesleys Theory', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.7, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('for_free', 'For Free? (Interlude)', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.2, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('king_kunta', 'King Kunta', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.8, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('institutionalized', 'Institutionalized', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.5, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('these_walls', 'These Walls', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.6, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('u', 'u', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.9, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('alright', 'Alright', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.8, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('for_sale', 'For Sale? (Interlude)', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.3, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('mortal_man', 'Mortal Man', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.5, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('blacker_the_berry', 'The Blacker the Berry', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.7, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('i', 'i', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.8, 'SONG');

    INSERT INTO MusicUnit (id, name, image, avgRating, type)
    VALUES ('mortal_man', 'Mortal Man', 'https://drive.google.com/uc?id=1ou6e1Mr6X1Uh6zXx5NxTrMqi7Fw1L0QU', 9.5, 'SONG');

    INSERT INTO Song (id, durationInSeconds, albumId)
    VALUES
    ('wesleys_theory', 256, 'to_pimp_a_butterfly'),
    ('for_free', 54, 'to_pimp_a_butterfly'),
    ('king_kunta', 234, 'to_pimp_a_butterfly'),
    ('institutionalized', 394, 'to_pimp_a_butterfly'),
    ('these_walls', 443, 'to_pimp_a_butterfly'),
    ('u', 554, 'to_pimp_a_butterfly'),
    ('alright', 442, 'to_pimp_a_butterfly'),
    ('for_sale', 181, 'to_pimp_a_butterfly'),
    ('mortal_man', 356, 'to_pimp_a_butterfly'),
    ('blacker_the_berry', 337, 'to_pimp_a_butterfly'),
    ('i', 337, 'to_pimp_a_butterfly'),
    ('mortal_man', 356, 'to_pimp_a_butterfly');



INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('watch_the_throne', 'Watch The Throne', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('watch_the_throne', 'HIP_HOP', '2011-08-08');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('mbdtf', 'My Beautiful Dark Twisted Fantasy', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.8, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('mbdtf', 'HIP_HOP', '2010-11-22');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('mbdtf', 'kanye_west');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('kanye_west', 'Kanye West', 'https://drive.google.com/uc?id=1iPQxExw64EMxs1tpfP6znjsDG_Ay2OnA', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('kanye_west', 'SOLO');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('watch_the_throne', 'kanye_west'),
       ('watch_the_throne', 'jay_z');
INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('dark_fantasy', 'Dark Fantasy', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('gorgeous', 'Gorgeous', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('power', 'Power', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('all_of_the_lights', 'All of the Lights', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('monster', 'Monster', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('so_appalled', 'So Appalled', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('devil_in_a_new_dress', 'Devil in a New Dress', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('runaway', 'Runaway', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hell_of_a_life', 'Hell of a Life', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('blame_game', 'Blame Game', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('lost_in_the_world', 'Lost in the World', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('who_will_survive_in_america', 'Who Will Survive in America', 'https://drive.google.com/uc?id=1WIxVmI7vOHWCj4mACutpo9yExp8gSpLl', 9.0, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('dark_fantasy', 275, 'my_beautiful_dark_twisted_fantasy'),
('gorgeous', 334, 'my_beautiful_dark_twisted_fantasy'),
('power', 248, 'my_beautiful_dark_twisted_fantasy'),
('all_of_the_lights', 356, 'my_beautiful_dark_twisted_fantasy'),
('monster', 394, 'my_beautiful_dark_twisted_fantasy'),
('so_appalled', 426, 'my_beautiful_dark_twisted_fantasy'),
('devil_in_a_new_dress', 518, 'my_beautiful_dark_twisted_fantasy'),
('runaway', 564, 'my_beautiful_dark_twisted_fantasy'),
('hell_of_a_life', 312, 'my_beautiful_dark_twisted_fantasy'),
('blame_game', 491, 'my_beautiful_dark_twisted_fantasy'),
('lost_in_the_world', 256, 'my_beautiful_dark_twisted_fantasy'),
('who_will_survive_in_america', 108, 'my_beautiful_dark_twisted_fantasy');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('no_church_in_the_wild', 'No Church in the Wild', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('lift_off', 'Lift Off', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('niggas_in_paris', 'Niggas in Paris', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('otis', 'Otis', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('gotta_have_it', 'Gotta Have It', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('new_day', 'New Day', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('that_s_my_bitch', 'Thats My Bitch', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('welcome_to_the_jungle', 'Welcome to the Jungle', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('who_gon_stop_me', 'Who Gon Stop Me', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('murder_to_excellence', 'Murder to Excellence', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('made_in_america', 'Made in America', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('why_i_love_you', 'Why I Love You', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.9, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('illest_motherfucker_alive', 'Illest Motherfucker Alive', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('h_a_m', 'H.A.M', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 9.7, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('no_church_in_the_wild', 289, 'watch_the_throne'),
('lift_off', 254, 'watch_the_throne'),
('niggas_in_paris', 224, 'watch_the_throne'),
('otis', 213, 'watch_the_throne'),
('gotta_have_it', 231, 'watch_the_throne'),
('new_day', 296, 'watch_the_throne'),
('that_s_my_bitch', 214, 'watch_the_throne'),
('welcome_to_the_jungle', 280, 'watch_the_throne'),
('who_gon_stop_me', 280, 'watch_the_throne'),
('murder_to_excellence', 333, 'watch_the_throne'),
('made_in_america', 253, 'watch_the_throne'),
('why_i_love_you', 296, 'watch_the_throne'),
('illest_motherfucker_alive', 210, 'watch_the_throne'),
('h_a_m', 283, 'watch_the_throne');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('war_is_the_answer', 'War is the Answer', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 8.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('war_is_the_answer', 'ROCK', '2009-09-22');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('ffdp', 'Five Finger Death Punch', 'https://drive.google.com/uc?id=1qvdY9JQI6dGMxBD7xNdj5C6XV1FDVWAZ', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('ffdp', 'BAND');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('war_is_the_answer', 'ffdp');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('dying_breed', 'Dying Breed', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hard_to_see', 'Hard to See', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('bulletproof', 'Bulletproof', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('no_one_gets_left_behind', 'No One Gets Left Behind', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('crossing_over', 'Crossing Over', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('burn_it_down', 'Burn It Down', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('far_from_home', 'Far from Home', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('falling_in_hate', 'Falling in Hate', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('my_own_hell', 'My Own Hell', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('canto_34', 'Canto 34', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('bad_company', 'Bad Company', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('war_is_the_answer', 'War Is the Answer', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('succubus', 'Succubus', 'https://drive.google.com/uc?id=1OLaA9VE9auBzecahCH3SOafNCMbfD45Y', 4.3, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('dying_breed', 237, 'war_is_the_answer'),
('hard_to_see', 233, 'war_is_the_answer'),
('bulletproof', 208, 'war_is_the_answer'),
('no_one_gets_left_behind', 236, 'war_is_the_answer'),
('crossing_over', 213, 'war_is_the_answer'),
('burn_it_down', 239, 'war_is_the_answer'),
('far_from_home', 252, 'war_is_the_answer'),
('falling_in_hate', 242, 'war_is_the_answer'),
('my_own_hell', 218, 'war_is_the_answer'),
('canto_34', 277, 'war_is_the_answer'),
('bad_company', 330, 'war_is_the_answer'),
('war_is_the_answer', 256, 'war_is_the_answer'),
('succubus', 248, 'war_is_the_answer');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('death_of_a_bachelor', 'Death of a Bachelor', 'https://drive.google.com/uc?id=1wzTXAbMsZfxbtUIlWwr_BDbeKGMp_FQa', 8.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('death_of_a_bachelor', 'ROCK', '2016-01-15');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('panic_at_the_disco', 'Panic! At The Disco', 'https://drive.google.com/uc?id=1PqMcCkT9BA4X2GTomafxfAvJQvQq9hhE', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('panic_at_the_disco', 'BAND');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('death_of_a_bachelor', 'panic_at_the_disco');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('victorious', 'Victorious', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('don_t_threaten_me_with_a_good_time', 'Dont Threaten Me with a Good Time', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('hallelujah', 'Hallelujah', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('emperor_s_new_clothes', 'Emperors New Clothes', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('death_of_a_bachelor', 'Death of a Bachelor', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('crazy=genius', 'Crazy=Genius', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('la_devotee', 'LA Devotee', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('golden_days', 'Golden Days', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('the_good_the_bad_and_the_dirty', 'The Good, The Bad and The Dirty', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('house_of_memories', 'House of Memories', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('impossible_year', 'Impossible Year', 'https://drive.google.com/uc?id=1Of-bWkR7OQDRZ_ME_1XQ2usnhk3EK-hk', 4.5, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('victorious', 186, 'death_of_a_bachelor'),
('don_t_threaten_me_with_a_good_time', 190, 'death_of_a_bachelor'),
('hallelujah', 181, 'death_of_a_bachelor'),
('emperor_s_new_clothes', 192, 'death_of_a_bachelor'),
('death_of_a_bachelor', 189, 'death_of_a_bachelor'),
('crazy=genius', 185, 'death_of_a_bachelor'),
('la_devotee', 190, 'death_of_a_bachelor'),
('golden_days', 203, 'death_of_a_bachelor'),
('the_good_the_bad_and_the_dirty', 174, 'death_of_a_bachelor'),
('house_of_memories', 196, 'death_of_a_bachelor'),
('impossible_year', 176, 'death_of_a_bachelor');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('master_of_puppets', 'Master Of Puppets', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('master_of_puppets', 'ROCK', '1986-03-03');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('metallica', 'Metallica', 'https://drive.google.com/uc?id=1hW0ezHsKPAAgLOdGq90VWsKmkjFL8Z_p', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('metallica', 'BAND');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('master_of_puppets', 'metallica');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('battery', 'Battery', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('master_of_puppets', 'Master of Puppets', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('the_thing_that_should_not_be', 'The Thing That Should Not Be', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('welcome_home_sanitarium', 'Welcome Home (Sanitarium)', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('disposable_heroes', 'Disposable Heroes', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('leper_messiah', 'Leper Messiah', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('orion', 'Orion', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('damage_inc', 'Damage, Inc.', 'https://drive.google.com/uc?id=1kVjcP-1KgcnHKkmjDftPQHD43tH1-jwZ', 9.6, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('battery', 312, 'master_of_puppets'),
('master_of_puppets', 516, 'master_of_puppets'),
('the_thing_that_should_not_be', 394, 'master_of_puppets'),
('welcome_home_sanitarium', 385, 'master_of_puppets'),
('disposable_heroes', 437, 'master_of_puppets'),
('leper_messiah', 347, 'master_of_puppets'),
('orion', 478, 'master_of_puppets'),
('damage_inc', 330, 'master_of_puppets');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('dookie', 'Dookie', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.5, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('dookie', 'ROCK', '1994-02-01');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('american_idiot_albm', 'American Idiot', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.1, 'ALBUM');

INSERT INTO Album (id, genre, releaseDate)
VALUES ('american_idiot_albm', 'ROCK', '204-09-21');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('american_idiot_albm', 'green_day');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('american_idiot', 'American Idiot', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('jesus_of_suburbia', 'Jesus of Suburbia', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.6, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('holiday', 'Holiday', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('boulevard_of_broken_dreams', 'Boulevard of Broken Dreams', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.8, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('are_we_the_waiting', 'Are We the Waiting', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('st_jimmy', 'St. Jimmy', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.5, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('give_me_novacaine', 'Give Me Novacaine', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.1, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('shes_a_rebel', 'Shes a Rebel', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('extraordinary_girl', 'Extraordinary Girl', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.2, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('letterbomb', 'Letterbomb', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.3, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('wake_me_up_when_september_ends', 'Wake Me Up When September Ends', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.7, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('homecoming', 'Homecoming', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.4, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('whatsername', 'Whatsername', 'https://drive.google.com/uc?id=18il-G13ZrC89-4REzpIYSBKdbOYIaSvC', 9.5, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('american_idiot', 176, 'american_idiot_albm'),
('jesus_of_suburbia', 558, 'american_idiot_albm'),
('holiday', 223, 'american_idiot_albm'),
('boulevard_of_broken_dreams', 262, 'american_idiot_albm'),
('are_we_the_waiting', 168, 'american_idiot_albm'),
('st_jimmy', 176, 'american_idiot_albm'),
('give_me_novacaine', 216, 'american_idiot_albm'),
('shes_a_rebel', 120, 'american_idiot_albm'),
('extraordinary_girl', 215, 'american_idiot_albm'),
('letterbomb', 259, 'american_idiot_albm'),
('wake_me_up_when_september_ends', 285, 'american_idiot_albm'),
('homecoming', 559, 'american_idiot_albm'),
('whatsername', 266, 'american_idiot_albm');


INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('green_day', 'Green Day', 'https://drive.google.com/uc?id=1ItX5FBYKN6-F36SgVKS78OvE5R-5ChMB', 9.0, 'ARTIST');

INSERT INTO Artist (id, artistType)
VALUES ('green_day', 'BAND');

INSERT INTO AlbumArtists (albumId, artistId)
VALUES ('dookie', 'green_day');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('burnout', 'Burnout', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('having_a_blast', 'Having a Blast', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('chump', 'Chump', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('longview', 'Longview', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('welcome_to_paradise', 'Welcome to Paradise', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('pulling_teeth', 'Pulling Teeth', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('basket_case', 'Basket Case', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('she', 'She', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('sassafras_roots', 'Sassafras Roots', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('when_i_come_around', 'When I Come Around', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('coming_clean', 'Coming Clean', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('eminent_drummer', 'Eminent Drummer', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO MusicUnit (id, name, image, avgRating, type)
VALUES ('in_the_end', 'In the End', 'https://drive.google.com/uc?id=1D93UmBhMs9p4cCajOzY5HqdArUFBNkTK', 9.0, 'SONG');

INSERT INTO Song (id, durationInSeconds, albumId)
VALUES
('burnout', 157, 'dookie'),
('having_a_blast', 173, 'dookie'),
('chump', 129, 'dookie'),
('longview', 223, 'dookie'),
('welcome_to_paradise', 221, 'dookie'),
('pulling_teeth', 143, 'dookie'),
('basket_case', 186, 'dookie'),
('she', 141, 'dookie'),
('sassafras_roots', 136, 'dookie'),
('when_i_come_around', 178, 'dookie'),
('coming_clean', 94, 'dookie'),
('eminent_drummer', 100, 'dookie'),
('in_the_end', 167, 'dookie');
