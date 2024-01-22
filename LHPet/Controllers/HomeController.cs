using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Epaminondas Silva", "857.032.958-41", "epaminondas.silva@senai.br", "Garfield");
        Cliente cliente2 = new Cliente(02, "Alan Patrick Lourenço", "039.618.250-09", "alan.patrick@senai.br", "Bart");
        Cliente cliente3 = new Cliente(03, "Pedro Henrique Konzen", "800.777.920-50", "pedro.henrique.konzen@senai.br", "Patchon");
        Cliente cliente4 = new Cliente(04, "Fabiano Baldasso", "933.622.400-03", "fabiano.baldasso@senai.br", "Toddy");
        Cliente cliente5 = new Cliente(05, "Sergio Rochet", "911.702.988-00", "sergio.rochet@senai.br", "Luizito");

        //lista de clientes e atribuir os clientes
        List<Cliente> ListaClientes = new List<Cliente>();
        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);
        ListaClientes.Add(cliente4);
        ListaClientes.Add(cliente5);

        ViewBag.listaClientes = ListaClientes;

        //instancias do tipo fornecedor e atribuir os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "PetShop Boys", "79.340.045/0001-65", "petshopboys@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Internacional Pets", "12.121.363/0001-64", "internacionalpets@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "Saci INC", "80.313.179/0001-76", "saciinc@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "Gigante Felinos", "19.308.865/0001-48", "gigantefelinos@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "Beira Rio Dogs", "32.100.900/0001-05", "beirariodogs@pet.org");

        //lista de fornecedores
        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = ListaFornecedores;

      return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
