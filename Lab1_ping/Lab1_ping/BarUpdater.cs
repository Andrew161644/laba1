using System.Diagnostics;
using System.Windows.Forms;

namespace Lab1_ping
{
    public class BarUpdater
    {
        private ProgressBar _bar;
        private int max;
        private int now_contains=0;

        public BarUpdater(ProgressBar bar, int max)
        {
            _bar = bar;
            this.max = max;
        }

        public int update()
        {
            now_contains=now_contains+1;
            int a= now_contains * 100 / max;
            /*_bar.Value = a;*/
            _bar.Invoke(new barUpdate(((s) =>
                    {
                        _bar.Value = a;
                        Debug.WriteLine("bar value "+a);
                    }
            )),a);
            return a;
        }
        private delegate void barUpdate(int a);
    }
}