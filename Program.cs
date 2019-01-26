using Cassia;

namespace SignYouOut
{
    class Program
    {
        static readonly ITerminalServicesManager manager = new TerminalServicesManager();
        
        static void Main(string[] args) {
            using (ITerminalServer server = manager.GetLocalServer()) {
                server.Open();

                foreach (ITerminalServicesSession session in server.GetSessions()) {
                    if (session.UserAccount == null || session.SessionId == 0) {
                        continue; // Don't touch system session
                    }
                    if (session.SessionId == manager.CurrentSession.SessionId) {
                        continue; // Don't touch current session
                    }

                    session.Logoff();
                }
            }
        }
    }
}
