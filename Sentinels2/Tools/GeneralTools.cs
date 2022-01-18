using Microsoft.Win32;

namespace Sentinels2.Tools
{
    internal class GeneralTools
    {
        public string GetRegistro(string vChave, string appName)
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + appName + "\\", true);
            return regKey.GetValue(vChave).ToString();
        }

        public static bool fGetInslalledProgram(String sProgramName)
        {
            String sUninstall = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(sUninstall))
            {
                foreach (String skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        if (Left(sk.GetValue("DisplayName").ToString(), sProgramName.Length) == sProgramName)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public static string Left(string sk, int l)
        {
            return "";
        }
    }
}
