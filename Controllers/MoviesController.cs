﻿using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        public readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {   
            var allMovies = await _service.GetAllAsync(n=>n.Cinema);
            return View(allMovies);
        }


        //Get:Movies/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }


        //GEt: Movies/Create

        public IActionResult Create() {
            return View();
        }
    }
}
