using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagykonyv
{
    public partial class FrmListan : Form
    {
        public static SqlConnection connectionString;

        public FrmListan()
        {
            //Kezdes 2021-03-18  17:45
            //Vege 2021-03-18 20:38

            AppDomain.CurrentDomain.SetData(
                "DataDirectory",
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly()
                    .Location.Replace(@"bin\Debug", @"\")));
            connectionString = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\nagykonyvDTS.mdf;Integrated Security=True");
            InitializeComponent();
        }

        private void ujKonyvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKonyv(connectionString,true,null);
            frm.ShowDialog();
        }

        private void FillDgv(string keresoSzo)
        {
            dgv_konyvek.Rows.Clear();

            connectionString.Open();

            var result = new SqlCommand("select * from konyv inner join szerzo on konyv.szerzoId = szerzo.Id where cim like('%"+ keresoSzo + "%') or nev like('%" + keresoSzo + "%') ORDER BY helyezes; ", connectionString).ExecuteReader();
            while (result.Read())
            {
                dgv_konyvek.Rows.Add(result[0], result.GetInt32(3), result.GetString(5), result.GetString(1));
            }
            result.Close();
            connectionString.Close();

        }

        private void FrmListan_Load(object sender, EventArgs e)
        {
            FillDgv("");
        }

        private void tbx_kereses_TextChanged(object sender, EventArgs e)
        {
            FillDgv(tbx_kereses.Text);
        }



        private void dgv_konyvek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connectionString.Open();
            var result = new SqlCommand("select * from konyv inner join szerzo on konyv.szerzoId = szerzo.Id where konyv.id = "+ int.Parse(dgv_konyvek.Rows[e.RowIndex].Cells[0].Value.ToString()) + "; ", connectionString).ExecuteReader();
            result.Read();
            var konyv = new KonyvModel()
            {
                Id = result.GetInt32(0),
                Cim = result.GetString(1),
                SzerzoId = result.GetInt32(2),
                Helyezes = result.GetInt32(3)
            };
            connectionString.Close();
            result.Close();

            var frm = new FrmKonyv(connectionString, false, konyv);
            frm.ShowDialog();
        }

        private void FrmListan_Activated(object sender, EventArgs e)
        {
            FillDgv("");
        }
    }
}
