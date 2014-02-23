namespace FreeQuant.QuantRouterLib.Data
{
    public class LogonStatus
    {
        public bool IsLoggedIn { get; set; }

        public string Text { get; set; }

        public LogonStatus()
        {
            this.IsLoggedIn = false;
            this.Text = string.Empty;
        }
    }
}
