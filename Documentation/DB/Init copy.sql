
CREATE TABLE MusicUnit (
    id NVARCHAR(100) PRIMARY KEY,
    name NVARCHAR(200) NOT NULL,
    image NVARCHAR(200) NOT NULL,
    avgRating FLOAT NOT NULL,
    type NVARCHAR(100) NOT NULL
);
CREATE TABLE Artist (
    id NVARCHAR(100) PRIMARY KEY,
    artistType NVARCHAR(50) NOT NULL,
    FOREIGN KEY (id) REFERENCES MusicUnit(id)
);

CREATE TABLE Album (
    id NVARCHAR(100) PRIMARY KEY NOT NULL,
    genre NVARCHAR(50) NOT NULL,
    releaseDate DATETIME NOT NULL,
    FOREIGN KEY (id) REFERENCES MusicUnit(id)
);

CREATE TABLE AlbumArtists (
    albumId NVARCHAR(100)  NOT NULL ,
    artistId NVARCHAR(100) NOT NULL,
    PRIMARY KEY (albumId, artistId),
    FOREIGN KEY (albumId) REFERENCES Album(id),
    FOREIGN KEY (artistId) REFERENCES Artist(Id)
);

CREATE TABLE Song (
    id NVARCHAR(100) PRIMARY KEY,
    durationInSeconds INT NOT NULL,
    albumId NVARCHAR(100) NOT NULL,
    FOREIGN KEY (id) REFERENCES MusicUnit(id),
    FOREIGN KEY (albumId) REFERENCES Album(id)
);

CREATE TABLE Review (
    id NVARCHAR(100) PRIMARY KEY,
    title NVARCHAR(200) NOT NULL,
    description TEXT NOT NULL,
    creationDate DATETIME NOT NULL,
    rating FLOAT NOT NULL,
    musicUnitId NVARCHAR(100) NOT NULL,
    creatorId NVARCHAR(100) NOT NULL,
    FOREIGN KEY (musicUnitId) REFERENCES MusicUnit(id),
    FOREIGN KEY (creatorId) REFERENCES [User](id)
);

CREATE TABLE ReviewLike (
    reviewId NVARCHAR(100) NOT NULL,
    userId NVARCHAR(100) NOT NULL,
    PRIMARY KEY (reviewId, userId),
    FOREIGN KEY (reviewId) REFERENCES Review(id),
    FOREIGN KEY (userId) REFERENCES [User](id)
);

CREATE TABLE [User] (
    id NVARCHAR(100) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) NOT NULL,
    hashedPassword TEXT NOT NULL,
    type NVARCHAR(50) NOT NULL
);

CREATE TABLE UserFollowing (
    userId NVARCHAR(100) NOT NULL,
    followingId NVARCHAR(100) NOT NULL,
    PRIMARY KEY (userId, followingId),
    FOREIGN KEY (userId) REFERENCES [User](id),
    FOREIGN KEY (followingId) REFERENCES [User](id)
);
