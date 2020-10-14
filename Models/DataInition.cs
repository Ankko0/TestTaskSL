using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softline.Models
{
    public class DataInition
    {
        public static void Init(UserContext db)
        {
            if (!db.Users.Any())
            {
                db.Users.AddRange(
                    new User { FullName = "Иванов Сергей Иванович", Birthday = DateTime.Parse("06/11/1957"), Position= "Начальник", MaternityLeave = false, Description = "Просто хороший человек" },
                    new User { FullName = "Петров Иван Иванович", Birthday = DateTime.Parse("18/02/1988"), Position = "Бухгалтер", MaternityLeave = false },
                    new User { FullName = "Васильева Анна Петровна", Birthday = DateTime.Parse("22/12/1997"), Position = "Менеджер", MaternityLeave = false},
                    new User { FullName = "Григорьева Нина Петровна", Birthday = DateTime.Parse("06/09/1988"), Position = "Менеджер", MaternityLeave = true },
                    new User { FullName = "Максимов Сергей Михайлович", Birthday = DateTime.Parse("1/1/1994"), Position = "Сис. администратор", MaternityLeave = false },
                    new User { FullName = "Жмышенко Валерий Альбертович", Birthday = DateTime.Parse("14/11/1954"), Position = "Уборщик", MaternityLeave = false, Description = "Очень любит пиццу" },
                    new User { FullName = "Прокопьев Геннадий Иванович", Birthday = DateTime.Parse("13/5/1992"), Position = "Менеджер", MaternityLeave = false },
                    new User { FullName = "Захаров Иннокентий Абрамович", Birthday = DateTime.Parse("16/08/1978"), Position = "Бухгалтер", MaternityLeave = false },
                    new User { FullName = "Полежайкина Галина Сергеевна", Birthday = DateTime.Parse("04/04/1989"), Position = "Аналитик", MaternityLeave = false },
                    new User { FullName = "Симонова Полина Бенедиктовна", Birthday = DateTime.Parse("12/10/1992"), Position = "Менеджер", MaternityLeave = true });
                db.SaveChanges();
            }
        }
        
    }
}
