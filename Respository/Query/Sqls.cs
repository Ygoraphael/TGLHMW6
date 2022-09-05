namespace Respository.Query
{
    public class Sqls
    {
        public const string CheckIfTableExistsQuery = $@"
            IF (EXISTS (SELECT *
                FROM INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'dbo'
                AND TABLE_NAME = @TableName))
            SELECT 1
            ELSE SELECT 0
        ";
        public const string InsertTeamQuery = $@"
            INSERT INTO dbo.Team (Name, Country)
            VALUES (@Name, @Country)
        ";
        public const string InsertPlayerQuery = $@"
            INSERT INTO dbo.Player (Name, Age, Position, TeamId)
            VALUES (@Name, @Age, @Position, @TeamId)
        ";
        public const string DropTableTeamQuery = $@" DROP TABLE Team";
        public const string DropTablePlayerQuery = $@" DROP TABLE Player";
        public const string CreateTableTeam = $@"
            CREATE TABLE dbo.Team(
                Id Int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
                Name nVarchar(300) NOT NULL,
                Country nVarchar(300) NOT NULL
            )
        ";
        public const string CreateTablePlayer = $@"
            CREATE TABLE dbo.Player(
                Id Int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
                Name nVarchar(300) NOT NULL,
                Age Int NOT NULL,
                Position Int NOT NULL,
                TeamId Int NOT NULL,
                FOREIGN KEY (TeamId) REFERENCES Team(Id))
        ";
    }

}
