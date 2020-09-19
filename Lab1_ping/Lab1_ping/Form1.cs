using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace Lab1_ping
{
    public partial class Form1 : Form
    {
        private Generator _generator=new Generator();
        private ByteOperations _byteOperations= new ByteOperations();
        public Form1()
        {
            InitializeComponent();
            dataGridView_scanning.Columns.Add("IP","IP");
            dataGridView_scanning.Columns.Add("DNS","DNS");
            dataGridView_scanning.Columns.Add("Status","Status");
            progressBar_scan.Maximum = 100;
            progressBar_scan.Minimum = 0;
            
            nud1.Maximum = 255;
            nud2.Maximum = 255;
            nud3.Maximum = 255;
            nud4.Maximum = 255;
            nud5.Maximum = 255;
            nud6.Maximum = 255;
            nud7.Maximum = 255;
            nud8.Maximum = 255;
            
            nud1.Value = 255;
            nud2.Value = 250;
            nud3.Value = 254;
            nud4.Value = 0;
            nud5.Value = 255;
            nud6.Value = 250;
            nud7.Value = 255;   
            nud8.Value = 0;
        }

        public void onAnalisClick(object sender, EventArgs e)
        {
            textBox_mask.Text = "";
            textBox_network.Text = "";
            textBox_gateway.Text = "";
            textBox_broadcast.Text = "";
            Int32 selectedRowCount =
                dataGridView_scanning.Rows.GetRowCount(DataGridViewElementStates.Selected);
            ArrayList l1=new ArrayList();
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    l1.Add(
                        new Address(dataGridView_scanning.SelectedRows[i].Cells[0].Value.ToString())
                        );
                }
            }

            for (int i = 0; i < l1.Count - 1; i++)
            {
                for (int j = i + 1; j < l1.Count; j++)
                {
                    if ((Address) l1[i] > (Address) l1[j])
                    {
                        Address temp = (Address) l1[i];
                        l1[i] = (Address) l1[j];
                        l1[j] = temp;
                    }
                }
            }

            Address mask = _byteOperations.getMask((Address)l1[0],(Address)l1[l1.Count-1]);
            Debug.WriteLine(mask.toDoubleC());
            Address network = _byteOperations.kon((Address)l1[l1.Count-1],mask);
            Address chanel = _byteOperations.dizunk((Address)l1[l1.Count-1],_byteOperations.not(mask));
            textBox_mask.Text = mask.ToString();
            textBox_network.Text = network.ToString();
            textBox_broadcast.Text = chanel.ToString();
            network.S4 += 1;
            textBox_gateway.Text = network.ToString();
        }

        private  void btn_scan_Click(object sender, EventArgs e)
        {
            
            dataGridView_scanning.Rows.Clear();
            progressBar_scan.Value = 0;
            
            Address start = new Address(
                Decimal.ToInt32(nud1.Value), 
                Decimal.ToInt32(nud2.Value),
                Decimal.ToInt32(nud3.Value),
                Decimal.ToInt32(nud4.Value));
            Address finish = new Address(
                Decimal.ToInt32(nud5.Value),
                Decimal.ToInt32(nud6.Value),
                Decimal.ToInt32(nud7.Value),
                Decimal.ToInt32(nud8.Value));
            Debug.WriteLine(start);
            Debug.WriteLine(finish);
            ArrayList l=_generator.generate(start, finish);
            BarUpdater barUpdater=new BarUpdater(progressBar_scan,l.Count);
            Debug.WriteLine("Generation complete");
            Scunner scunner=new Scunner(l);
            
           scunner.scan(new  ScunnerOutputContent(dataGridView_scanning,barUpdater));
            
            Debug.WriteLine("exit");
            
        }
        

    }
}
