using System.Windows.Forms;

namespace Lab1_ping
{
    public class MIp:Address
    {
        public Status _status=Status.NOT_AVALIBLE;
        public string hostname="Not avalible";
    
        public enum Status
        {
            NOT_AVALIBLE,
            AVALIBLE
        } 
        public MIp(int s1, int s2, int s3, int s4) : base(s1, s2, s3, s4)
        {
        }
    }
}