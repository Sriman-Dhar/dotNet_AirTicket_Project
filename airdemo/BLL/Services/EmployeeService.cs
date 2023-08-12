using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static bool CreateEmployee(EmployeeDTO employeeDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var employee = mapper.Map<Employee>(employeeDTO);

            return DataAccessFactory.EmployeeDataAccess().Create(employee);
        }
        public static bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var employee = mapper.Map<Employee>(employeeDTO);

            return DataAccessFactory.EmployeeDataAccess().Update(employee);
        }
        public static bool DeleteEmployee(int id)
        {
            return DataAccessFactory.EmployeeDataAccess().Delete(id);
        }
        public static List<EmployeeDTO> GetEmployees()
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            var convertedData = mapper.Map<List<EmployeeDTO>>(data);
            return convertedData;
        }
        public static EmployeeDTO GetEmployee(int id)
        {
            var data = DataAccessFactory.EmployeeDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            var convertedData = mapper.Map<EmployeeDTO>(data);
            return convertedData;
        }

    }
}
