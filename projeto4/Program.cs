using System;
using projeto4.Entities;

namespace projeto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Coment c1 = new Coment("Tenha um bom dai! ");
            Coment c2 = new Coment("wow isso é incrível");
            Post p1 = new Post(
                DateTime.Parse("05/08/2019 15:11:44"), "viajando para a nova zelandia" , "eu vou visitar este país maravilhoso", 12);

            p1.AddComment(c1);
            p1.AddComment(c2);


            Coment d1 = new Coment("Boa noite ");
            Coment d2 = new Coment("Que a força esteja com você ");
            Post p2 = new Post(
                DateTime.Parse("28 / 07 / 2018 23:14:19"), "Boa noite, galera", "Te vejo amanhã", 15);

            p2.AddComment(d1);
            p2.AddComment(d2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
