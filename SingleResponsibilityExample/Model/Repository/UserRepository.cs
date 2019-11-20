using System.Collections.Generic;
using SingleResponsabilityExample.Model.Domain;

namespace SingleResponsabilityExample.Infrastructure
{
    public class UserRepository{

        public List<User> getUsuarios (){


                return new List<User>(){
                    new User(1,"Javier",25),
                    new User(2,"Harry",29),
                    new User(3,"Aldo",27),
                    new User(4,"Suazo",26),
                    new User(5,"Tiger",28),
                    new User(6,"Jimmy",27),
                    new User(7,"Pollo",26)
                 };

        }
    }
}