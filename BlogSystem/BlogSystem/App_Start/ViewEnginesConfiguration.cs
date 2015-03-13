namespace BlogSystem
{
    using System.Web.Mvc;

    /// <summary>
    /// Class that clears and configures the needed engines in Global.asax
    /// </summary>
    internal class ViewEnginesConfiguration
    {
        /// <summary>
        /// Clears and Registers the engines
        /// </summary>
        /// <param name="viewEngineCollection">Holds the collection with the engines which will be configured</param>
        internal static void RegisterViewEngines(ViewEngineCollection viewEngineCollection)
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}
