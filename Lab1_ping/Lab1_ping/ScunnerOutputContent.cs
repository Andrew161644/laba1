using System;
using System.Collections;
using System.Threading;
using System.Windows.Forms;
using ThreadState = System.Diagnostics.ThreadState;

namespace Lab1_ping
{
    public class ScunnerOutputContent
    {
        private DataGridView dataGridView;
        private BarUpdater _barUpdater;

        public ScunnerOutputContent(DataGridView dataGridView,BarUpdater barUpdater)
        {
            this.dataGridView = dataGridView;
            this._barUpdater = barUpdater;
        }

        /*public void addAll(ArrayList addresses)
        {
            foreach (MIp ip in addresses)
            {
                
                dataGridView.Invoke(new Set((s) => dataGridView.Rows.Add(s,s.hostname,s._status)),ip);
            }
        }

        public void clear()
        {
            dataGridView.Invoke(new Clear((() => dataGridView.Rows.Clear())));
        }*/

        public void add(MIp ip)
        {
            _barUpdater.update();
            dataGridView.Invoke(new Set((s) =>
                {
                    
                    dataGridView.Rows.Add(s, s.hostname, s._status);
                }
            ),ip);
        }

        public void update(ArrayList list)
        {
            
            dataGridView.Invoke(new updateGrid(((s) =>
                    {
                        dataGridView.Rows.Clear();
                        foreach (MIp s1 in list)
                        {
                            dataGridView.Rows.Add(s1, s1.hostname, s1._status);
                        }
                    }
                )),list);
        }

        private delegate void Set(MIp ip);
        private delegate void updateGrid(ArrayList list);
        private delegate void Clear();

    }
}