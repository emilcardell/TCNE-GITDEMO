using Nancy;

namespace TCNE_GITDEMO
{
	public class HcModule : NancyModule
	{
		public HcModule()
		{
			Get["/"] = _ => "Tjo!";
		}
	}
}