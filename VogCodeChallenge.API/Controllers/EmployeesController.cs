﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeeSeedData _mockData = new EmployeeSeedData();

        // GET api/employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _mockData.GetAll();
        }

        // GET api/employees/{departmentId}
        [HttpGet("{departmentId}")]
        public IList<Employee> Get(int departmentId)
        {
            // TODO: change to grab only the employees with the specified dept id..
            return _mockData.ListAll();
        }
    }
}
