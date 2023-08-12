using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.AuthFilters;

namespace WebApplication1.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AirController : ApiController
    {
        // Employee Endpoints
        [HttpGet]
        [Route("api/employees/all")]
        public HttpResponseMessage GetAllEmployees()
        {
            try
            {
                var data = EmployeeService.GetEmployees();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/employees/{id}")]
        public HttpResponseMessage GetEmployee(int id)
        {
            try
            {
                var data = EmployeeService.GetEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/employees/create")]
        public HttpResponseMessage CreateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var result = EmployeeService.CreateEmployee(employeeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/employees/update")]
        public HttpResponseMessage UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var result = EmployeeService.UpdateEmployee(employeeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/employees/{id}")]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            try
            {
                var result = EmployeeService.DeleteEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        // Admin Endpoints
        [HttpGet]
        [Route("api/admins/all")]
        public HttpResponseMessage GetAllAdmins()
        {
            try
            {
                var data = AdminService.GetAdmins();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/admins/{id}")]
        public HttpResponseMessage GetAdmin(int id)
        {
            try
            {
                var data = AdminService.GetAdmin(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/admins/create")]
        public HttpResponseMessage CreateAdmin(AdminDTO adminDTO)
        {
            try
            {
                var result = AdminService.CreateAdmin(adminDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/admins/update")]
        public HttpResponseMessage UpdateAdmin(AdminDTO adminDTO)
        {
            try
            {
                var result = AdminService.UpdateAdmin(adminDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/admins/{id}")]
        public HttpResponseMessage DeleteAdmin(int id)
        {
            try
            {
                var result = AdminService.DeleteAdmin(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        // Customer Endpoints
        [HttpGet]
        [Route("api/customers/all")]
        public HttpResponseMessage GetAllCustomers()
        {
            try
            {
                var data = CustomerService.GetCustomers();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/customers/{id}")]
        public HttpResponseMessage GetCustomer(int id)
        {
            try
            {
                var data = CustomerService.GetCustomer(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/customers/create")]
        public HttpResponseMessage CreateCustomer(CustomerDTO customerDTO)
        {
            try
            {
                var result = CustomerService.CreateCustomer(customerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/customers/update")]
        public HttpResponseMessage UpdateCustomer(CustomerDTO customerDTO)
        {
            try
            {
                var result = CustomerService.UpdateCustomer(customerDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/customers/{id}")]
        public HttpResponseMessage DeleteCustomer(int id)
        {
            try
            {
                var result = CustomerService.DeleteCustomer(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // Flight Endpoints
        [HttpPost]
        [Route("api/flights/create")]
        public HttpResponseMessage CreateFlight(FlightDTO flightDTO)
        {
            try
            {
                var result = FlightService.CreateFlight(flightDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/flights/update")]
        public HttpResponseMessage UpdateFlight(FlightDTO flightDTO)
        {
            try
            {
                var result = FlightService.UpdateFlight(flightDTO);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/flights/{id}")]
        public HttpResponseMessage DeleteFlight(int id)
        {
            try
            {
                var result = FlightService.DeleteFlight(id);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
