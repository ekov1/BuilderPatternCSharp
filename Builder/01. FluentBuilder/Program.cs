namespace _01._FluentBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMediaPost post = new SocialMediaPostBuilder()
                .AddTitle("The Builder Pattern")
                .AddContent(@"A creational design pattern that intends to 
                              abstract steps of construction of objects 
                              so that different implementations of these steps can 
                              construct different representations of objects.")
                .AddAuthor("Kristian Ekov")
                .AddTag("#designpatterns")
                .AddTag("#csharp")
                .AddLink("https://somelink.io")
                .Build();
        }
    }
}