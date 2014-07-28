using System;
using System.Windows.Forms;
using AF.FWK.MonitoringServices.Configuration;
using AF.FWK.MonitoringServices.Kpi;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ScanKPI_Click(object sender, EventArgs e)
        {
            
            var clientkpi = new KpiConsultationClient();

            var compteurAppels = 0;
            var result = clientkpi.Select(MonitoringConfig.Current.ApplicationName, "Appels",null,null,100);
            foreach (var kpi in result)
            {
                compteurAppels++;
            }
            Appels.Text = compteurAppels.ToString();
            ApplicationAttribute.Text = MonitoringConfig.Current.ApplicationName;

            var compteurClients = 0;
            result = clientkpi.Select(MonitoringConfig.Current.ApplicationName, "ClientDetecte", null, null, 100);
            foreach (var kpi in result)
            {
                compteurClients++;
            }
            ClientsDetectes.Text = compteurClients.ToString();

            var compteurNonClients = 0;
            result = clientkpi.Select(MonitoringConfig.Current.ApplicationName, "ClientNonDetecte", null, null, 100);
            foreach (var kpi in result)
            {
                compteurNonClients++;
            }
            NonClients.Text = compteurNonClients.ToString();
        }

    }
}
