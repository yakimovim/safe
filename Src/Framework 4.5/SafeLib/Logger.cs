using log4net;
using log4net.Config;
using System.Diagnostics;

namespace EdlinSoftware.Safe.SafeLib
{
    /// <summary>
    /// This class encapsulates logger functionality.
    /// </summary>
    public static class Logger
    {

        /// <summary>
        /// Gets logger instance.
        /// </summary>
        public static ILog Log { get; } = LogManager.GetLogger("LOGGER");

        /// <summary>
        /// Initializes the logger.
        /// </summary>
        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
