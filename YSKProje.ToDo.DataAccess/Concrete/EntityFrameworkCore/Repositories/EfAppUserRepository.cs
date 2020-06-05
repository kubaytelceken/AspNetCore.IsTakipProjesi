﻿using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
        public List<AppUser> getirAdminOlmayanlar()
        {
            using var context = new ToDoContext();
            return context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, toTableResult => toTableResult.userRole.RoleId, role => role.Id, (resultToTable, resultRole) => new
            {
                user = resultToTable.user,
                userRoles = resultToTable.userRole,
                roles = resultRole
            }).Where(I => I.roles.Name == "Member").Select(I => new AppUser {
                    Id = I.user.Id,
                    Name = I.user.Name,
                    Surname = I.user.Surname,
                    Picture = I.user.Picture,
                    Email = I.user.Email,
                    UserName = I.user.UserName
            }).ToList();
        }


        public List<AppUser> getirAdminOlmayanlar(out int toplamSayfa,string aranacakKelime,int aktifSayfa=1)
        {
            using var context = new ToDoContext();
            var result = context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
            {
                user = resultTable.user,
                userRoles = resultTable.userRole,
                roles = resultRole
            }).Where(I => I.roles.Name == "Member").Select(I => new AppUser()
            {
                Id = I.user.Id,
                Name = I.user.Name,
                Surname = I.user.Surname,
                Picture = I.user.Picture,
                Email = I.user.Email,
                UserName = I.user.UserName

            });

            toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);

            if (!string.IsNullOrWhiteSpace(aranacakKelime))
            {
                result = result.Where(I => I.Name.ToLower().Contains(aranacakKelime.ToLower()) || I.Surname.ToLower().Contains(aranacakKelime.ToLower()));
                toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);

            }



            result = result.Skip((aktifSayfa - 1) * 3).Take(3);

            return result.ToList();
        }
    }
}
