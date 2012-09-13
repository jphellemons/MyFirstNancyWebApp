using Nancy;

namespace MyFirstNancyWebApp
{
    public class HelloNancy: NancyModule
    {
        public HelloNancy()
        {
            Get["/"] = parameters => "Hello World";
            Get["/hello/{name}"] = parameters => "Hello " + parameters.name;

            Get["/products"] = parameters => View["products.html", new ProductsModel(){Code="C1009", Name ="Product name here"}];
        }    
    }

    public class ProductsModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}