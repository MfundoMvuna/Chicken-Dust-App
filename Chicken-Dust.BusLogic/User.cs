namespace Chicken_Dust.BusLogic
{
    public class User
    {
        int userID;
        string userName;
        string userSurname;
        string password;
        int phoneNumber;
        string email;
        string location;
        string address;

        public int UserID { get {  return userID; } set {  userID = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string UserSurname { get { return userSurname; } set { userSurname = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int PhoneNumber { get {  return phoneNumber; } set {  phoneNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Location { get { return location; } set { location = value; } }
        public string Address { get { return address; } set { address = value; } }
      
    }
}