using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DataAccess.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace SEProje.ToDo.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> GetirAdminOlmayanlar()
        {
            return _appUserDal.GetirAdminOlmayanlar();
        }

        public List<AppUser> GetirAdminOlmayanlar(string aranacakKelime, int aktifSayfa = 1)
        {
            return _appUserDal.GetirAdminOlmayanlar(aranacakKelime, aktifSayfa);
        }
    }
}
