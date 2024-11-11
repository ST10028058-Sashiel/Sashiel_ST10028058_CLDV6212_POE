﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Sashiel_ST10028058_CLDV6212_POE.Controllers
{
    public class AppRolesController : Controller
    {
        // Controller to Add Roles Only admins can see

            private readonly RoleManager<IdentityRole> _roleManager;

            public AppRolesController(RoleManager<IdentityRole> roleManager)
            {
                _roleManager = roleManager;
            }


            public IActionResult Index()
            {
                var roles = _roleManager.Roles;
                return View(roles);
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Create(IdentityRole model)
            {
                if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
                }
                return RedirectToAction("Index");
            }
        }
    }



//# Assistance provided by ChatGPT
//# Code and support generated with the help of OpenAI's ChatGPT.
// code attribution
// W3schools
//https://www.w3schools.com/cs/index.php

// code attribution
//Bootswatch
//https://bootswatch.com/

// code attribution
// https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio

// code attribution
// https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-8.0&tabs=visual-studio

// code attribution
// https://youtu.be/qvsWwwq2ynE?si=vwx2O4bCAFDFh5m_