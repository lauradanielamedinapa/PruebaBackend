using Xunit;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica_Backend_CSharp.Controllers;
using PruebaTecnica_Backend_CSharp.Data;
using PruebaTecnica_Backend_CSharp.Models;
using System.Linq;

public class MarcasAutosControllerTests
{
    [Fact]
    public void GetMarcas_ReturnsMarcas()
    {
        var options = new DbContextOptionsBuilder<AutoContext>()
            .UseInMemoryDatabase(databaseName: "MarcasAutosTest")
            .Options;

        using (var context = new AutoContext(options))
        {
            context.MarcasAutos.Add(new MarcaAuto { Id = 1, Nombre = "Toyota" });
            context.SaveChanges();

            var controller = new MarcasAutosController(context);
            var result = controller.GetMarcas();

            Assert.Equal(1, result.Value.Count());
        }
    }
}
