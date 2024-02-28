using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
namespace SalesWebMvc.Controllers;

public class DepartamentController : Controller
{
    public IActionResult Index()
    {
        //iniciei uma lista do tipo departamento
        List<Departament> list = new List<Departament>();
        //adicionei dados
        list.Add(new Departament{ Id = 1, Name = "Eletronics"});
        list.Add(new Departament{ Id = 2, Name = "Fashion"});
        //retornando a lista na tela para o usuario
        return View(list);
    }
}