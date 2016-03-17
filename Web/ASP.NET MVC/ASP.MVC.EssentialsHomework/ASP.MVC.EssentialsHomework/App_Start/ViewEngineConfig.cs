namespace System.Web.Mvc
{
    public class ViewEngineConfig
    {
        public static void RegisterViewEngines()
        {
            /////Remove All Engine
            ViewEngines.Engines.Clear();
            /////Add Razor Engine
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}