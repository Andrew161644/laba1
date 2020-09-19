using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Lab1_ping
{
    public class UpdateContainer
    {
        private DataGridView _gridView;
        private ArrayList ips;

        public UpdateContainer(DataGridView gridView,ArrayList ips)
        {
            _gridView = gridView;
            _gridView.Rows.Clear();
            this.ips = ips;
        }

        public void subscribe()
        {
            foreach (MIp ip in ips)
            {
                ip.UpdateContainer = this;
            }
        }

        public void update(MIp address)
        {
            
        }
    }
}