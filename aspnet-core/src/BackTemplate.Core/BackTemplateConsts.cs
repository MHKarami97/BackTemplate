using BackTemplate.Debugging;

namespace BackTemplate
{
    public class BackTemplateConsts
    {
        public const string LocalizationSourceName = "BackTemplate";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7883f047aadf4825adee2c1ff64435e3";
    }
}
