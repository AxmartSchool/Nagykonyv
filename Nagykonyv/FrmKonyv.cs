using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagykonyv
{
    public partial class FrmKonyv : Form
    {
        private readonly SqlConnection _connectionString;
        private readonly bool rogzit;
        private readonly KonyvModel konyv;
        private Dictionary<string, int> szerzok;
        public FrmKonyv(SqlConnection connectionString, bool rogzit, KonyvModel konyv)
        {
            InitializeComponent();
            _connectionString = connectionString;
            this.rogzit = rogzit;
            this.konyv = konyv;
        }

        private void FrmKonyv_Load(object sender, EventArgs e)
        {


            _connectionString.Open();
            var result = new SqlCommand("select * from szerzo order by Id; ", _connectionString).ExecuteReader();

            szerzok = new Dictionary<string, int>();

            while (result.Read())
            {
                szerzok.Add(result.GetString(1), result.GetInt32(0));
            }
            _connectionString.Close();
            result.Close();

            cbx_szerzo.DataSource = new BindingSource(szerzok, null);
            cbx_szerzo.DisplayMember = "Key";
            cbx_szerzo.ValueMember = "Value";


            if (rogzit)
            {
                btn_modositas.Enabled = false;
                btn_torles.Enabled = false;
            }
            else
            {
                btn_rogzites.Enabled = false;
                tbx_id.Text = konyv.Id.ToString();
                tbx_cim.Text = konyv.Cim;
                tb_helyezes.Text = konyv.Helyezes.ToString();
                cbx_szerzo.SelectedIndex = cbx_szerzo.FindStringExact(szerzok.FirstOrDefault(szerzo => szerzo.Value == konyv.SzerzoId).Key);

            }

        }

        private void btn_rogzites_Click(object sender, EventArgs e)
        {
            if (megerosites("rogziteni"))
            {
                if (ellenorzesSikeres())
                {
                    _connectionString.Open();
                    string query = $"Insert into konyv values ({tbx_id.Text},'{tbx_cim.Text}', {cbx_szerzo.SelectedValue}, {tb_helyezes.Text}) ;";
                    var insertCommand = new SqlCommand(query, _connectionString).ExecuteNonQuery();
                    _connectionString.Close();
                    this.Close();
                }





            }

            

        }

        private bool ellenorzesSikeres()
        {
            if (tbx_id.Text.Trim().Length == 0 || !int.TryParse(tbx_id.Text.Trim(), out int num))
            {
                tb_helyezes.Text = "hibas Id";
                return false;
            }

            if (tbx_cim.Text.Trim().Length == 0)
            {
                tbx_cim.Text = "hianyos cim";
                return false;
            }

            if (tb_helyezes.Text.Trim().Length == 0 || !int.TryParse(tb_helyezes.Text.Trim(), out int num2))
            {
                tb_helyezes.Text = "hibas helyezes";
                return false;
            }

            if (cbx_szerzo.Text.Trim().Length == 0)
            {
                return false;
            }

            return true;
        }

        private bool megerosites(string gombNev) {

            var res = MessageBox.Show(
                "Biztos vagy benne , hogy " + gombNev + " szeretnel?",
                "negerosites",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                 );
            if (res == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btn_modositas_Click(object sender, EventArgs e)
        {
            if (megerosites("modositani"))
            {
                if (ellenorzesSikeres())
                {
                    _connectionString.Open();
                    string query = $"update konyv set  id = {tbx_id.Text}, cim = '{tbx_cim.Text}',  szerzoId = {cbx_szerzo.SelectedValue}, helyezes = {tb_helyezes.Text} where id = {tbx_id.Text};";
                    //MessageBox.Show(query);
                    var updateCommand = new SqlCommand(query, _connectionString).ExecuteNonQuery();
                    _connectionString.Close();
                    this.Close();
                }





            }


        }

        private void btn_torles_Click(object sender, EventArgs e)
        {
            if (megerosites("torolni"))
            {

                    _connectionString.Open();
                    string query = $"delete from konyv where id = {tbx_id.Text};";
                    //MessageBox.Show(query);
                    var updateCommand = new SqlCommand(query, _connectionString).ExecuteNonQuery();
                    _connectionString.Close();
                    this.Close();
                    


            }


        }
    }
}
