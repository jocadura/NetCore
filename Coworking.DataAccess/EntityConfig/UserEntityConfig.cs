using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.DataAccess.EntityConfig
{
    public class UserEntityConfig
    {
        /// <summary>
        /// Define de properties to generate de Entity in datebase
        /// </summary>
        /// <param name="entityBuilder"></param>
        public static void setEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.ToTable("Users");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
        }
    }
}
