using Dapper;
using Respository.Model;
using Respository.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Controller
{
    public class DapperController
    {
        public SqlConnection _connection;
        public DapperController(SqlConnection connection)
        {
            _connection = connection;
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }
        public async void CreateTable()
        {
            if (! await CheckTableExist("Team"))
            {
                var result = _connection.Execute(Sqls.CreateTableTeam);
                if (Convert.ToInt16(result) != -1)
                {
                    throw new ApplicationException("Failed to create Team table");
                }
            }
                
            if (! await CheckTableExist("Player"))
            {
                var result = _connection.Execute(Sqls.CreateTablePlayer);
                if (Convert.ToInt16(result) != -1)
                {
                    throw new ApplicationException("Failed to create Player table");
                }
            }
        }
        public async void DropTables()
        {
            var result = await _connection.ExecuteAsync(Sqls.DropTablePlayerQuery);
            if (result != -1)
            {
                throw new ApplicationException("Failed to drop table Player");
            }
            result = await _connection.ExecuteAsync(Sqls.DropTableTeamQuery);
            if (result != -1)
            {
                throw new ApplicationException("Failed to drop table Team");
            }
        }
        private async Task<bool> CheckTableExist(string Table)
        {
            var result = await _connection.QuerySingleAsync<bool>(Sqls.CheckIfTableExistsQuery, new { TableName = Table });
            return result;
        }
        public async void FillTableTeam()
        {
            var Teams = new List<Team>
            {
                new Team()
                {
                    Name = "Vasco da Gama",
                    Country = "Brazil"
                },
                new Team()
                {
                    Name = "Manchester United",
                    Country = "England"
                },
                new Team()
                {
                    Name = "Real Madrid",
                    Country = "Spain"
                },
                new Team()
                {
                    Name = "Porto",
                    Country = "Portugal"
                },
                new Team()
                {
                    Name = "PSG",
                    Country = "French"
                },
                new Team()
                {
                    Name = "Milan",
                    Country = "Italy"
                },
            };
            await _connection.ExecuteAsync(Sqls.InsertTeamQuery, Teams);
        }

        public async void FillTablePlayer()
        {
            var Players = new List<Player>
            {
                new Player()
                {
                    Name = "Philipe Coutinho",
                    Age = 30,
                    Position = Position.midfielder,
                    TeamId = 1
                },
                new Player()
                {
                    Name = "Alex Teixeira",
                    Age = 34,
                    Position = Position.midfielder,
                    TeamId = 1
                },
                new Player()
                {
                    Name = "Cristiano Ronaldo",
                    Age = 37,
                    Position = Position.Attack,
                    TeamId = 2
                },
                new Player()
                {
                    Name = "Rodrygo",
                    Age = 21,
                    Position = Position.Attack,
                    TeamId = 3
                },
                new Player()
                {
                    Name = "Pepe",
                    Age = 38,
                    Position = Position.Defender,
                    TeamId = 4
                },
                new Player()
                {
                    Name = "Messi",
                    Age = 35,
                    Position = Position.midfielder,
                    TeamId = 5
                },
                new Player()
                {
                    Name = "Mike Malgnam",
                    Age = 30,
                    Position = Position.GoalKeeper,
                    TeamId = 6
                },
            };
            await _connection.ExecuteAsync(Sqls.InsertPlayerQuery, Players);
        }
    }
}
