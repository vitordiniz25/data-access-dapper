using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletando uma tag");
            Console.WriteLine("------------------");
            Console.Write("Qual o Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag deletada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar a tag");
                Console.WriteLine(ex);
            }
        }
    }
}