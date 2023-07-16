
namespace PRS_GROUP.Tests
{
   
    public class DataContextTests
    {
        [Fact]
        public void DbContext_Configuration_Should_Use_Sqlite_Data_Source()
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            var dbContext = new DataContext();
            object value = dbContext.OnConfiguring(optionsBuilder);
            object value1 = optionsBuilder.IsConfigured.Should().BeTrue();
            optionsBuilder.Options.Extensions.Should().ContainSingle(e =>
                e.GetType() == typeof(SqliteOptionsExtension)
                && ((SqliteOptionsExtension)e).ConnectionString == "Data Source=.\\DataFile1");
        }

        [Fact]
        public void DataContext_Should_Have_DbSet_For_Users()
        {
            
            var dbContext = new DataContext();
            var usersDbSet = dbContext.Users;
            usersDbSet.Should().NotBeNull();
        }

        [Fact]
        public void DataContext_Should_Have_DbSet_For_Admins()
        {
            var dbContext = new DataContext();
            var adminsDbSet = dbContext.Admins;
            adminsDbSet.Should().NotBeNull();
        }

        [Fact]
        public void DataContext_Should_Have_DbSet_For_Patients()
        {
            var dbContext = new DataContext();
            var patientsDbSet = dbContext.Patients;
            patientsDbSet.Should().NotBeNull();
        }
    }

}