﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using admin_cms.Models;
using Microsoft.AspNetCore.Http;
using admin_cms.Models.Infraestrutura.Autenticacao;

namespace admin_cms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Logado]
        public IActionResult Index(string nome)
        {
            var cookieNome = Request.Cookies["nome"];

            if (string.IsNullOrEmpty(nome) )
            {
                  ViewBag.nome = cookieNome;
            }
            else
            {
                  ViewBag.nome = nome;
            }
           

            return View();
        }

        public IActionResult Privacy()
        {
            // this.HttpContext.Session.SetString("alunos", "hello world");
            // return View();
            /*****************Teste*****************/
            //  this.HttpContext.Response.Cookies.Append("alunos", "alunos do tornese", new CookieOptions
            // {
            //     // Expires = DateTimeOffset.UtcNow.AddDays(1).AddMinutes(-5)
            //     // Expires = DateTimeOffset.UtcNow.AddSeconds(3),
            //     Expires = DateTimeOffset.UtcNow.AddMinutes(3),
            //     HttpOnly = true,
            // });
            //this.HttpContext.Session.SetString("alunos", "do tornese um programador");
            return View();
        }

        public IActionResult Sair()
        {
            this.HttpContext.Response.Cookies.Delete("adm_cms");
            return Redirect("/login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
