using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_Ass_W8
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksisql;
        MySqlCommand commandsql;
        MySqlDataAdapter adaptersql;
        string connectionstring;
        string sqlquery;
        DataTable dtpemain = new DataTable();
        DataTable dtteam = new DataTable();
        DataTable dtdetail = new DataTable();
        DataTable dtdetail2 = new DataTable();
        DataTable dtteam2 = new DataTable();
        DataTable dttanggal = new DataTable();
        DataTable dthome = new DataTable();
        DataTable dtaway = new DataTable();
        DataTable dttarung = new DataTable();







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTeamatas.Visible = false;
            comboBoxPlayerbawah.Visible = false;
            comboBoxteammatch.Visible = false;
            comboBoxtanggal.Visible = false;
            labelgscored.Visible = false;
            labelnational.Visible = false;
            labelnama.Visible = false;
            labelpmissed.Visible = false;
            labelteam.Visible = false;
            labelycards.Visible = false;
            labelrcards.Visible = false;
            labelsqnum.Visible = false;
            labelposisi.Visible = false;
            dataGridViewkanan.Visible = false;
            dataGridViewkiri.Visible = false;
            dataGridViewmatch.Visible = false;

            connectionstring = "server=localhost;uid=root;pwd=Noel1517;database=premier_league";
            koneksisql = new MySqlConnection(connectionstring);

            sqlquery = "SELECT team_name FROM team ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dtteam);
            comboBoxTeamatas.DataSource = dtteam;
            comboBoxTeamatas.ValueMember = "team_name";
            comboBoxTeamatas.DisplayMember = "team_name";

        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxPlayerbawah.Visible = true;
            comboBoxTeamatas.Visible = true;


        }

     

        private void comboBoxTeamatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtdetail.Clear();
            dtpemain.Clear();

            sqlquery = "select p.player_name  from player p, team t where p.team_id = t.team_id AND t.team_name ='" + comboBoxTeamatas.SelectedValue.ToString() + "' ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dtpemain);
            comboBoxPlayerbawah.DataSource = dtpemain;
            comboBoxPlayerbawah.ValueMember = "player_name";
            comboBoxPlayerbawah.DisplayMember = "player_name";
        }

     
        private void comboBoxPlayerbawah_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtdetail.Clear();
            dtdetail2.Clear();

            sqlquery = "select p.player_name, t.team_name, n.nation, p.playing_pos, p.team_number from player p, team t, nationality n where p.team_id = t.team_id AND p.nationality_id = n.nationality_id AND p.player_name = '" + comboBoxPlayerbawah.SelectedValue.ToString() + "' group by 1,2,3,4,5;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dtdetail);

            labelgscored.Visible = true;
            labelnational.Visible = true;
            labelnama.Visible = true;
            labelpmissed.Visible = true;
            labelteam.Visible = true;
            labelycards.Visible = true;
            labelrcards.Visible = true;
            labelsqnum.Visible = true;
            labelposisi.Visible = true;

            labeljwbnama.Text = dtdetail.Rows[0][0].ToString();
            labeljwbteam.Text = dtdetail.Rows[0][1].ToString();
            labeljwbnation.Text = dtdetail.Rows[0][2].ToString();
            labeljwbposisi.Text = dtdetail.Rows[0][3].ToString();
            labeljwbnum.Text = dtdetail.Rows[0][4].ToString();

            sqlquery = "select ifnull(sum(d.type = \"CY\"),\"0\"), ifnull(sum(d.type = \"CR\"),\"0\"), ifnull(sum(d.type = \"GO\"),\"0\"), ifnull(sum(d.type = \"PM\"),\"0\") from dmatch d, player p where d.player_id = p.player_id AND p.player_name = '" + comboBoxPlayerbawah.SelectedValue.ToString() + "' ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dtdetail2);
            labeljwbycards.Text = dtdetail2.Rows[0][0].ToString();
            labeljwbrcards.Text = dtdetail2.Rows[0][1].ToString();
            labeljwbgscored.Text = dtdetail2.Rows[0][2].ToString();
            labeljwbpenalty.Text = dtdetail2.Rows[0][3].ToString();
        }
        private void comboBoxTeamatas_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        private void comboBoxPlayerbawah_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void showMatchDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxtanggal.Visible = true;
            comboBoxteammatch.Visible = true;

            sqlquery = "SELECT team_name FROM team ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dtteam2);
            comboBoxteammatch.DataSource = dtteam2;
            comboBoxteammatch.ValueMember = "team_name";
            comboBoxteammatch.DisplayMember = "team_name";

            
        }

      
        private void comboBoxteammatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dttanggal.Clear();

            dataGridViewmatch.Visible = true;
            dataGridViewkiri.Visible = true;
            dataGridViewkanan.Visible = true;

            sqlquery = "select m.match_id from `match` m, team t where (t.team_id = m.team_home or t.team_id = m.team_away) AND t.team_name = '" + comboBoxteammatch.SelectedValue.ToString() + "' ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dttanggal);
            comboBoxtanggal.DataSource = dttanggal;
            comboBoxtanggal.ValueMember = "match_id";
            comboBoxtanggal.DisplayMember = "match_id";

           
        }
       

        private void comboBoxtanggal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dthome.Clear();
            dtaway.Clear();
            dttarung.Clear();

            sqlquery = "select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from `match` m, player p, team t where t.team_id = m.team_home AND p.team_id = m.team_home AND m.match_id = '" + comboBoxtanggal.SelectedValue.ToString() + "' ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dthome);
            dataGridViewkiri.DataSource = dthome;

            sqlquery = "select t.team_name as 'Team Name', p.player_name as 'Player Name', p.playing_pos as 'Position' from `match` m, player p, team t where t.team_id = m.team_away AND p.team_id = m.team_away AND m.match_id = '" + comboBoxtanggal.SelectedValue.ToString() + "' ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dtaway);
            dataGridViewkanan.DataSource = dtaway;

            sqlquery = "SELECT d.minute as `minute`, t.team_name as 'Team Name', p.player_name as 'Player Name', if(d.type = \"CR\",\"Red Card\",if(d.type = \"CY\",\"Yellow Card\",if(d.type = \"GW\",\"Own Goal\",if(d.type = \"GO\",\"Goal Scored\",if(d.type = \"PM\",\"Penalty Miss\",\"Goal Penalty\"))))) as 'Type' FROM dmatch d, player p, team t where p.player_id = d.player_id AND t.team_id = d.team_id AND d.match_id = '" + comboBoxtanggal.SelectedValue.ToString() + "' ;";
            commandsql = new MySqlCommand(sqlquery, koneksisql);
            adaptersql = new MySqlDataAdapter(commandsql);
            adaptersql.Fill(dttarung);
            dataGridViewmatch.DataSource = dttarung;

        }
        private void comboBoxtanggal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
