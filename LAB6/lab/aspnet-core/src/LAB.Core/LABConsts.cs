using LAB.Debugging;

namespace LAB
{
    public class LABConsts
    {
        public const string LocalizationSourceName = "LAB";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3d0771aeb335492d907d03175e884c7c";
    }
}
