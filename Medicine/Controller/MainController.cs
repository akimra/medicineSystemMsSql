using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicine.Model;

namespace Medicine.Controller
{
    class MainController
    {
        private IAuthProfile currentUser = null;

        public string Authorize(string login, string passwordHash)
        {
            // Метод осуществляет авторизацию с помощью переданных из view данных (логин, пароль)
            // возвращает тип авторизируемого пользователя (доктор, администратор, пациент)
            // в строковом представлении, либо строковое сообщение, что такой юзер не найден
            // в зависимости от типа авторизованного юзера показывается определенная форма
            // также определяется поле currentUser - текущий пользователь для хранения состояния
            // какой пользователь в системе на данный момент

            using (MedicineDbContext db = new MedicineDbContext())
            {
                List<IAuthProfile> authList = new List<IAuthProfile>();
                authList.AddRange(db.Administrators);
                authList.AddRange(db.PacientAuths);
                authList.AddRange(db.DoctorAuths);

                foreach (var a in authList)
                {
                    if (a.GetLogin() == login && a.GetHashPassword() == passwordHash)
                    {
                        currentUser = a;
                        break;
                    }
                }

                if (currentUser == null)
                {
                    return "not found";
                }
                else
                {
                    return currentUser.GetTypeAuth();
                }
            }
        }
    }
}
