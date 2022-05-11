namespace comServiceWF
{
    public class Credential
    {
        public int ClientId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Client? Client { get; set; }
        public Credential()
        {
            Login = "";
            Password = "";
        }
        public Credential(string login, string pass, int clientId)
        {
            Login = login;
            Password = pass;
            ClientId = clientId;
        }
    }
}
