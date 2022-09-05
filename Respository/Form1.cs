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
        public const string ConectionSqlServer = "Server=localhost,1433;Database=master;User ID=sa;Password=Password123!;Integrated Security=false;TrustServerCertificate=true;";
        //EntityFramework
        public AppDbContext DbContext;
        //REDIS
        private ConnectionMultiplexer BaseRedis;
        private readonly IDatabase Base;
        //Dapper
        public SqlConnection Connection { get; set; }
        public DapperController DC;
        public Form1()
        {
            InitializeComponent();
            DbContext = new AppDbContext(ConectionSqlServer);
            BaseRedis = ConnectionMultiplexer.Connect("localhost:6379,password=fIbfYgOvdXwHTZCDod5oVy2A1Ih0WRHLvhbLG9QQ");
            Base = BaseRedis.GetDatabase();
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
            TeamController tc = new TeamController(DbContext);
            tc.AddTeam(team);
            tc.AddTeam(team2);
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
            PlayerController pl = new PlayerController(DbContext);
            pl.AddPlayer(player);
            pl.AddPlayer(player2);
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
            MessageBox.Show("Tables created with success!");
        }

        private void btnPpopularTables_Click(object sender, EventArgs e)
        {
            DC.FillTableTeam();
            DC.FillTablePlayer();
            MessageBox.Show("Populated tables with success!");
        }        

        private void btnDeleteTables_Click(object sender, EventArgs e)
        {
            DC.DropTables();
            MessageBox.Show("Deleted tables with success!");
        }
    }
}