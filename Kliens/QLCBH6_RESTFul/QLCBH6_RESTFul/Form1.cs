using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCBH6_RESTFul
{
    public partial class Form1 : Form
    {
        public static bool PwChecked = false;
        public Form1()
        {
            InitializeComponent();
            Gridbeolvasás();
        }
        public void Gridbeolvasás()
        {
            RestClient client = new RestClient("http://127.0.0.1:3000/jatekok");
            var request = new RestRequest(Method.GET);

            var response = client.Execute<List<Jatekok>>(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            List<Jatekok> jatekok = new JsonSerializer().Deserialize<List<Jatekok>>(response);
            Jatekok_Grid.DataSource = jatekok;
        }

        private void Jatekok_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Jatekok_ID.Text = Jatekok_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            Jatekok_NEV.Text = Jatekok_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            Jatekok_MUFAJ.Text = Jatekok_Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            Jatekok_KIADO.Text = Jatekok_Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            Jatekok_JATEKMOD.Text = Jatekok_Grid.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void Jatekok_POST_Click(object sender, EventArgs e)
        {
            if (PwChecked == false)
            {
                Passwordform pwform = new Passwordform();
                pwform.Show();
                return;
            }

            if ((Jatekok_NEV.Text == "" || Jatekok_NEV.Text == null) || (Jatekok_MUFAJ.Text == "" || Jatekok_MUFAJ.Text == null) || (Jatekok_KIADO.Text == "" || Jatekok_KIADO.Text == null) || (Jatekok_JATEKMOD.Text == "" || Jatekok_JATEKMOD.Text == null))
            {
                MessageBox.Show("A mezőket (id, név, műfaj, kiadó, játékmód) nem lehet üresen hagyni!");
                return;
            }

            RestClient client = new RestClient("http://127.0.0.1:3000/addjatekok/123");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                nev = Jatekok_NEV.Text,
                mufaj = Jatekok_MUFAJ.Text,
                kiado = Jatekok_KIADO.Text,
                jatekmod = Jatekok_JATEKMOD.Text
            });

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Jatekok_NEV.Text = "";
            Jatekok_MUFAJ.Text = "";
            Jatekok_KIADO.Text = "";
            Jatekok_JATEKMOD.Text = "";
            Gridbeolvasás();
        }

        private void Jatekok_PUT_Click(object sender, EventArgs e)
        {
            if (PwChecked == false)
            {
                Passwordform pwform = new Passwordform();
                pwform.Show();
                return;
            }

            if ((Jatekok_ID.Text == "" || Jatekok_ID.Text == null) || (Jatekok_NEV.Text == "" || Jatekok_NEV.Text == null) || (Jatekok_MUFAJ.Text == "" || Jatekok_MUFAJ.Text == null) || (Jatekok_KIADO.Text == "" || Jatekok_KIADO.Text == null) || (Jatekok_JATEKMOD.Text == "" || Jatekok_JATEKMOD.Text == null))
            {
                MessageBox.Show("A mezőket (id, név, műfaj, kiadó, játékmód) nem lehet üresen hagyni!");
                return;
            }

            int id;
            if (!int.TryParse(Jatekok_ID.Text, out id))
            {
                MessageBox.Show("Az ID mező csak számokat tartalmazhat!");
                return;
            }

            RestClient client = new RestClient(String.Format("http://127.0.0.1:3000/updatejatekok/{0}/123", int.Parse(Jatekok_ID.Text)));
            var request = new RestRequest(Method.PUT);

            request.RequestFormat = DataFormat.Json;

            //TODO: Ha TextBoxok üresek akkor a cella értékeit használni.
            //Vagy nem lehet üres mezőkkel updatelni.
            request.AddJsonBody(new
            {
                nev = Jatekok_NEV.Text,
                mufaj = Jatekok_MUFAJ.Text,
                kiado = Jatekok_KIADO.Text,
                jatekmod = Jatekok_JATEKMOD.Text
            });

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Jatekok_NEV.Text = "";
            Jatekok_MUFAJ.Text = "";
            Jatekok_KIADO.Text = "";
            Jatekok_JATEKMOD.Text = "";
            Gridbeolvasás();
        }

        private void Jatekok_DELETE_Click(object sender, EventArgs e)
        {
            if (PwChecked == false)
            {
                Passwordform pwform = new Passwordform();
                pwform.Show();
                return;
            }

            if (Jatekok_ID.Text == "" || Jatekok_ID.Text == null)
            {
                MessageBox.Show("Az ID mezőt nem lehet üresen hagyni!");
                return;
            }

            int id;
            if (!int.TryParse(Jatekok_ID.Text, out id))
            {
                MessageBox.Show("Az ID mező csak számokat tartalmazhat!");
                return;
            }

            RestClient client = new RestClient(String.Format("http://127.0.0.1:3000/deletejatekok/{0}/123", int.Parse(Jatekok_ID.Text)));
            var request = new RestRequest(Method.DELETE);

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            Jatekok_NEV.Text = "";
            Jatekok_MUFAJ.Text = "";
            Jatekok_KIADO.Text = "";
            Jatekok_JATEKMOD.Text = "";
            Gridbeolvasás();
        }

        private void PHPGRID_Click(object sender, EventArgs e)
        {
            PhpForm phpform = new PhpForm();
            phpform.Show();
        }
    }
}
