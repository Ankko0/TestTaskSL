using Microsoft.EntityFrameworkCore;
using System;

namespace Softline.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { FullName = "Иванов Сергей Иванович", Birthday = DateTime.Parse("06/11/1957"), Position = "Начальник", MaternityLeave = false, Description = "Просто хороший человек", Id = Guid.NewGuid() },
                    new User { FullName = "Петров Иван Иванович", Birthday = DateTime.Parse("18/02/1988"), Position = "Бухгалтер", MaternityLeave = false, Id = Guid.NewGuid() },
                    new User { FullName = "Васильева Анна Петровна", Birthday = DateTime.Parse("22/12/1997"), Position = "Менеджер", MaternityLeave = false, Id = Guid.NewGuid() },
                    new User { FullName = "Григорьева Нина Петровна", Birthday = DateTime.Parse("06/09/1988"), Position = "Менеджер", MaternityLeave = true, Id = Guid.NewGuid() },
                    new User { FullName = "Максимов Сергей Михайлович", Birthday = DateTime.Parse("1/1/1994"), Position = "Сис. администратор", MaternityLeave = false, Id = Guid.NewGuid() },
                    new User { FullName = "Жмышенко Валерий Альбертович", Birthday = DateTime.Parse("14/11/1954"), Position = "Уборщик", MaternityLeave = false, Description = "Очень любит пиццу", Id = Guid.NewGuid() },
                    new User { FullName = "Прокопьев Геннадий Иванович", Birthday = DateTime.Parse("13/5/1992"), Position = "Менеджер", MaternityLeave = false, Id = Guid.NewGuid() },
                    new User { FullName = "Захаров Иннокентий Абрамович", Birthday = DateTime.Parse("16/08/1978"), Position = "Бухгалтер", MaternityLeave = false, Id = Guid.NewGuid() },
                    new User { FullName = "Полежайкина Галина Сергеевна", Birthday = DateTime.Parse("04/04/1989"), Position = "Аналитик", MaternityLeave = false, Id = Guid.NewGuid() },
                    new User { FullName = "Симонова Полина Бенедиктовна", Birthday = DateTime.Parse("12/10/1992"), Position = "Менеджер", MaternityLeave = true, Id = Guid.NewGuid() });


        }

    }
}
