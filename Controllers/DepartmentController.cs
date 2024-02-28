using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
namespace SalesWebMvc.Controllers;

public class DepartmentController : Controller
{
    public IActionResult Index()
    {
        //iniciei uma lista do tipo departamento
        List<Department> list = new List<Department>();
        //adicionei dados
        list.Add(new Department{ Id = 1, Name = "Eletronics"});
        list.Add(new Department{ Id = 2, Name = "Fashion"});
        //retornando a lista na tela para o usuario
        return View(list);
    }
}