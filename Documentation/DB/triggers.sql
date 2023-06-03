CREATE TRIGGER DeleteMusicUnitOnSongDelete
ON Song
AFTER DELETE
AS
BEGIN
    delete from Review where musicUnitId in (select id from deleted)
    delete from MusicUnit where id in (select id from deleted)
END;

CREATE TRIGGER DeleteSongsOnAlbumDelete
ON Album
INSTEAD OF DELETE
AS
BEGIN
    delete from Review where musicUnitId in (select id from deleted)
    delete from AlbumArtists where albumId in (select id from deleted)
    delete from Song where albumId in (select id from deleted)
    delete from Album where id in (select id from deleted)
    delete from MusicUnit where id in (select id from deleted)
END;
    

CREATE TRIGGER DeleteDiscographyOnArtistDelete
ON Artist
INSTEAD OF DELETE
AS
BEGIN
  DECLARE @deletedArtistId NVARCHAR(100);
  SELECT @deletedArtistId = Id FROM deleted;

  delete from Review where musicUnitId=@deletedArtistId
    -- Delete all solo albums of the artist
    delete from AlbumArtists where artistId = @deletedArtistId and albumId in (
  SELECT albumId
FROM AlbumArtists
WHERE albumId IN (
  SELECT albumId 
  FROM AlbumArtists 
  WHERE artistId = @deletedArtistId
)
GROUP BY albumId
HAVING COUNT(*) > 1
)

DELETE FROM Album where id IN (SELECT albumId FROM AlbumArtists WHERE artistId = @deletedArtistId AND albumId IN (
        SELECT albumId FROM AlbumArtists WHERE artistId = @deletedArtistId
        GROUP BY albumId
        HAVING COUNT(*) = 1
        )
    )
  delete from Artist where id = @deletedArtistId
  delete from MusicUnit where id = @deletedArtistId
END;

