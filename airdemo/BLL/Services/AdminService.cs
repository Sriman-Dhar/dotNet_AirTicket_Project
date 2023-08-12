using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> GetAdmins()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var convertedData = mapper.Map<List<AdminDTO>>(data);
            return convertedData;
        }

        public static AdminDTO GetAdmin(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var convertedData = mapper.Map<AdminDTO>(data);
            return convertedData;
        }

        public static bool CreateAdmin(AdminDTO adminDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var admin = mapper.Map<Admin>(adminDTO);

            return DataAccessFactory.AdminDataAccess().Create(admin);
        }

        public static bool UpdateAdmin(AdminDTO adminDTO)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var admin = mapper.Map<Admin>(adminDTO);

            return DataAccessFactory.AdminDataAccess().Update(admin);
        }

        public static bool DeleteAdmin(int id)
        {
            return DataAccessFactory.AdminDataAccess().Delete(id);
        }
    }
}
