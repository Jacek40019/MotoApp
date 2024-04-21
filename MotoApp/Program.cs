﻿
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee, int>();
employeeRepository.Add(new Employee { FirstName = "Adam" });
employeeRepository.Add(new Employee { FirstName = "Marek" });
employeeRepository.Add(new Employee { FirstName = "Zuzia" });
employeeRepository.Save();