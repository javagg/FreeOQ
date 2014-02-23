namespace FreeQuant.QuantRouterLib.Data
{
    public class Logon
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Logon()
        {
            this.Username = string.Empty;
            this.Password = string.Empty;
        }
    }
}
