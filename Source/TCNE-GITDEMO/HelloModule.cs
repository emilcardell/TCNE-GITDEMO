using Nancy;

namespace TCNE_GITDEMO
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = _ => "Erlo!";
						Get["/canberger"] = _ => "Håkan is best!";
				}
    }
}