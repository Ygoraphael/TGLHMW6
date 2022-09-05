using Dapper;
using Respository.Controller;
using Respository.Data;
using Respository.Model;
using Respository.Query;
using StackExchange.Redis;
using System.Data.SqlClient;

namespace Respository
{
    public partial class Form1 : Form
    {
        
        public const string ConectionSqlServer = "Server=localhost,1433;Database=master;User ID=sa;Password=Password123!;Integrated Security=false;TrustServerCertificate=true;MultipleActiveResultSets=True";
        //EntityFramework
        public List<Team> Teams = new List<Team>();
        public List<Player> Players = new List<Player>();
        public AppDbContext DbContext;
        public TeamController TeamController;
        public PlayerController PlayerController;
        //REDIS
        private ConnectionMultiplexer BaseRedis;
        private IDatabase Base;
        //Dapper
        public SqlConnection Connection { get; set; }
        public DapperController DC;
        public Form1()
        {
            InitializeComponent();
            InitializeConfigsEF();
            InitializeConfigsRedis();
            InitializeConfigsDapper();
        }

        private void InitializeConfigsEF()
        {
            DGV.DataSource = Teams;
            DGVP.DataSource = Players;
            DbContext = new AppDbContext(ConectionSqlServer);
            TeamController = new TeamController(DbContext);
            PlayerController = new PlayerController(DbContext);
        }
        private void InitializeConfigsRedis()
        {
            BaseRedis = ConnectionMultiplexer.Connect("localhost:6379,password=fIbfYgOvdXwHTZCDod5oVy2A1Ih0WRHLvhbLG9QQ");
            Base = BaseRedis.GetDatabase();
        }
        private void InitializeConfigsDapper()
        {
            Connection = new SqlConnection(ConectionSqlServer);
            DC = new DapperController(Connection);
        }

        private void btnEfInsert_Click(object sender, EventArgs e)
        {
            var team = new Team()
            {
                Name = "Vasco da Gama",
                Country = "Brazil"
            };
            var team2 = new Team()
            {
                Name = "Shakhtar Donetsk",
                Country = "Ukraine"
            };
            var player = new Player()
            {
                TeamId = 1,
                Name = "Neymar",
                Age = 33,
                Position = Position.Attack
            };
            var player2 = new Player()
            {
                TeamId = 2,
                Name = "Alex Teixeira",
                Age = 34,
                Position = Position.Attack
            };
            try
            {
                TeamController.AddTeam(team);
                TeamController.AddTeam(team2);
                PlayerController.AddPlayer(player);
                PlayerController.AddPlayer(player2);
                RefreshDgvEF();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error trying to save players! \n" + er.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Base.StringSet("Team", "Vasco da Gama");
            MessageBox.Show("Set Key value 'Vasco da Gama' with success!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Base.StringGet("Team"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Base.KeyDelete("Team");
            MessageBox.Show("Deleted Key with success!");
        }

        private void btnCreateTableAsync(object sender, EventArgs e)
        {
            DC.CreateTable();
            RefreshDgvEF();
            MessageBox.Show("Tables created with success!");
        }

        private void btnPpopularTables_Click(object sender, EventArgs e)
        {
            DC.FillTableTeam();
            DC.FillTablePlayer();
            RefreshDgvEF();
            MessageBox.Show("Populated tables with success!");
        }        

        private void btnDeleteTables_Click(object sender, EventArgs e)
        {
            DC.DropTables();
            DGV.DataSource = null;
            DGV.Refresh();
            DGVP.DataSource = null;
            DGVP.Refresh();
            MessageBox.Show("Deleted tables with success!");
        }

        private void RefreshDgvEF()
        {
            try
            {
                Teams = TeamController.GetAllTeam();
                DGV.DataSource = Teams;
                DGV.Refresh();
                Players = PlayerController.GetAllPlayer();
                DGVP.DataSource = Players;
                DGVP.Refresh();

            }
            catch (Exception er)
            {
                MessageBox.Show("Could not find the table! \n"+er.Message);
            }
        }
    }
}