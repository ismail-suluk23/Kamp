using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService 
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

    
        
        public void Add(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("kayıt olundu");
            }
            else
            {
                Console.WriteLine("Dogrulama Başarısız Kayıt başarısız");
            }
      
        }  
        

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
