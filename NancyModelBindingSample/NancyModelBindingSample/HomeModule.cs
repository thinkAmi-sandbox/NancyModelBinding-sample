using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyModelBindingSample
{
    using Nancy;
    using Nancy.ModelBinding; 

    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get["/vtom"] = _ => View["v_to_m", new HomeModel()];

            Post["/vtom"] = _ =>
            {
                // ModelBinding
                var model = this.Bind<HomeModel>();

                return Response.AsJson<HomeModel>(model);
            };

            Get["/mtov"] = _ =>
            {
                var model = new HomeModel()
                {
                    Text = "piyo",
                    TextArea = "hello razor",
                    Tel = "987-6543-210",
                    Url = "https://example.com",
                    Email = "hogehoge@example.com",
                    Date = DateTime.Parse("2015/1/1"),
                    Checkbox = true,
                    RadioButtonValue = "good"
                };

                return Negotiate
                .WithView("m_to_v")
                .WithModel(model);
            };

            Post["/mtov"] = _ => Response.AsJson<HomeModel>(this.Bind<HomeModel>()); 
        }
    }
}
