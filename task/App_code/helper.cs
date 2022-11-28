using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace task.App_code
{
    public static class OutputHelper
    {
        public static HtmlString CreateList()
        {
            Context context = new Context();
            var results = from b in context.basicLists
                          join c in context.categories
                          on b.Cat.Id equals c.Id
                          select new { id=b.Id,name= b.Name, cat=c.Name };
            string result = "<table><th>id</th><th>Name</th><th>Category</th>";
            Console.WriteLine(results);
            foreach (var item in results)
            {
                result = $"{result}<tr><td>{item.id}</td><td>{item.name}</td><td>{item.cat}</td></tr>";
            }
            result = $"{result}</table>";
            return new HtmlString(result);
        }
    }
}
