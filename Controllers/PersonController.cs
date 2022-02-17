using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC2.Models;
using MVC2.Service;
using MVC2.Data;

namespace MVC2.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonService _personservice;

    public PersonController(ILogger<PersonController> logger, IPersonService person)
    {
        _personservice = person;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var item = _personservice.AllPerson().ToList();
        return View(item);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person persons)
    {
        {           
            _personservice.Create(persons);            
            return RedirectToAction("Index");
        }
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        var item = PersonData.Persons.FirstOrDefault(m => m.Id == id);
        if (item == null){
            return NotFound();
        }
        return View(item);
    }
    [HttpPost]
    public IActionResult Delete(Person persons)
    {
        _personservice.Delete(persons);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        var item = PersonData.Persons.FirstOrDefault(m => m.Id == id);
        if (item == null){
            return NotFound();
        }
        return View(item);
    }
    [HttpPost]
    public IActionResult Edit(Person persons)
    {
        _personservice.Edit(persons);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Detail(int? id)
    {
        var item = PersonData.Persons.FirstOrDefault(m => m.Id == id);
        if (item == null){
            return NotFound();
        }
        return View(item);
    }
}
