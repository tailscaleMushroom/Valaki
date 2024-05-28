using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Testcontainers.MySql;

namespace Valaki.Test
{
    public class ValakiApiFactory : WebApplicationFactory<Program>, IAsyncLifetime
    {
        private readonly MySqlContainer _mySqlContainer = new MySqlBuilder()
            .WithImage("mysql:8.0")
            .WithDatabase("TestDB")
            .WithPassword("Test1234")
            .Build();

        public async Task InitializeAsync()
        {
            await _mySqlContainer.StartAsync();
        }

        public async Task DisposeAsync()
        {
            await _mySqlContainer.StopAsync();
        }
    }
}