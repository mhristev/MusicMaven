using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public static class ExceptionMessages
    {
        public static string InvalidId = "Enter a valid id.";
        public static string InvalidTitle = "Enter a valid title.";
        public static string InvalidDescription = "Enter a valid description.";
        public static string InvalidRating = "Enter a valid rating between 0 and 10.";
        public static string InvalidUsername = "Enter a valid username.";
        public static string InvalidEmail = "Enter a valid email.";
        public static string InvalidPassword = "Enter a valid password.";
        public static string InvalidImage = "Enter a valid image.";
        public static string InvalidMusicUnitName = "Enter a valid music unit name.";
        public static string InvalidDurationInSeconds = "Enter a valid duration in seconds.";
        public static string InvalidNumberOfArtistsInAlbum = "Album should have at least 1 artist.";

        public static string InvalidUserType = "Enter a valid user type ENUM.";
        public static string InvalidMusicUnitType = "Enter a valid music unit type ENUM.";
        public static string InvalidArtistType = "Enter a valid artist type ENUM.";
        public static string InvalidGenreType = "Enter a valid genre type ENUM.";

        public static string InvalidFormatEmail = "Invalid email format.";
        public static string DuplicateArtistsInAlbum = "This album has duplicate artists";

        public static string EmptyRequiredFields = "Please fill in all the required fields to proceed with the operation.";
        public static string AuthenticationFailed = "Authentication failed.";

        public static string EmailExists = "This email alreay exists in the system.";
        public static string UsernameExists = "This username alreay exists in the system.";
    }
}
