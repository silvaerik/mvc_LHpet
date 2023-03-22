using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpet.Models;

namespace LHpet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Erik R. da Silva", "123.456.789.10", "silva2610@hotmail.com", "Luna");
        Cliente cliente2 = new Cliente(02, "Joäo Paulo", "124.421.356.65", "joao.paulo@hotmail.com", "Bud");
        Cliente cliente3 = new Cliente(03, "Antonio da Silva", "027.889.799-10", "bico@hotmail.com", "Tekila");
        Cliente cliente4 = new Cliente(04, "Donizete da Silva", "363.266.648-29", "uba@hotmail.com", "Nero");
        Cliente cliente5 = new Cliente(05, "Renato Carniato", "556.557.558-59", "carniato@hotmail.com", "nono");
        
        // Lista de Clientes e atribuiçáo de fornecedores
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        
        ViewBag.listaClientes = listaClientes;
        
        // instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "#DOG LTDA", "07.590.511/0001-00", "arthur.antunes@gsp.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "CASA DOS PETS", "04.432.109/0010-10", "rafasc@hotmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "NOVA PETS", "01.000.111/0001-01", "crepaldi@hotmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "PETITIRAPINA", "08.588.688/0100-99", "carlos@yahoo.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "DONAPETS", "09.881.911/0001-15", "alex@sp.com.br");     

        // Lista de Fornecedores e atribuiçáo de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
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
