using System.Linq;
using SingleResponsabilityExample.Model.Domain;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SingleResponsabilityExample.Context
{

//este es un ejemplo de lo que debemos evitar ya que esta clase tiene mucha responsabilidad
    public class ContextUser
    {
       
        private MySqlConnection db {get;set;}
        public ContextUser(string connectionString)
        {
           
            db=new MySqlConnection(connectionString);
        }

        public ContextUser()
        {
            
        }
        
        public void getUsuarios()
        {
            
            //abrir conexion a db
            using (var cmd=db.CreateCommand())
            {
                
                //obtenerUsuarios

                 var UsersList=new List<User>(){
                    new User(1,"Javier",25),
                    new User(2,"Harry",29),
                    new User(3,"Aldo",27),
                    new User(4,"Suazo",26),
                    new User(5,"Tiger",28),
                    new User(6,"Jimmy",27),
                    new User(7,"Pollo",26)
                 };



                // escribir en la consola 

                System.Console.WriteLine("*******Lista de Usuarios*********");
                foreach (var user in UsersList)
                {
                    System.Console.WriteLine("{ID-{0}, Nombre {1}, Edad {2}  }",user.Id,user.Name,user.Age);
                    
                }
                

            }

           
           

            
        }
    }
}