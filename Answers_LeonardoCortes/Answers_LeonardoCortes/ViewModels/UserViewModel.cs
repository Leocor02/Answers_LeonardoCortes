using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Answers_LeonardoCortes.Models;

namespace Answers_LeonardoCortes.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public UserRole MyUserRole { get; set; }
        public Country MyCountry { get; set; }
        public UserStatus MyUserStatus { get; set; }
        public User MyUser { get; set; }
        public Ask MyAsk { get; set; }

        public UserDTO MiUsuarioDTO { get; set; }
        public UserViewModel()
        {
            MyUserRole= new UserRole();
            MyCountry= new Country();
            MyUserStatus= new UserStatus();
            MiUsuarioDTO= new UserDTO();
            MyUser= new User();
            MyAsk= new Ask();
        }

        public async Task<UserDTO> GetUserData(int id)
        {
            try
            {
                UserDTO user = new UserDTO();

                user = await MiUsuarioDTO.GetUserData(id);

                if (user == null)
                {
                    return null;
                }
                else
                {
                    return user;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> AddNewQuestion(DateTime pDate,
                                               string pAsk1,
                                               bool pIsStrike,
                                               string pAskDetail,
                                               int pUserId,
                                               int pAskStatusId)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyAsk.Date = pDate;
                MyAsk.Ask1 = pAsk1;
                MyAsk.IsStrike = pIsStrike;
                MyAsk.AskDetail = pAskDetail;
                MyAsk.UserId = pUserId;
                MyAsk.AskStatusId = pAskStatusId;
               

                bool R = await MyAsk.AddQuestion();

                return R;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                IsBusy = false;
            }


        }

    }
}
