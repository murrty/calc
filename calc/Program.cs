using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace calc {
    internal static class Program {

        #region Version Information
        /// <summary>
        /// The current version of the program.
        /// </summary>
        public const decimal CurrentVersion = 1.0m;
        /// <summary>
        /// Whether the program is a beta version.
        /// </summary>
        public const bool IsBetaVersion = true;
        /// <summary>
        /// The version of the current beta program.
        /// </summary>
        public const string BetaVersion = "1.0-pre2";
        #endregion

        #region Runtime Fields
        /// <summary>
        /// Gets whether the program is running in debug mode.
        /// </summary>
        public static bool DebugMode {
            get; private set;
        } = false;

        /// <summary>
        /// Gets or sets the exit code of the application.
        /// </summary>
        public static int ExitCode {
            get; set;
        } = 0;

        /// <summary>
        /// The mutex of the program instance.
        /// </summary>
        private static Mutex Instance;
        /// <summary>
        /// The GUID of the program.
        /// </summary>
        private static readonly GuidAttribute ProgramGUID =
            (GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), true)[0];
        /// <summary>
        /// Whether the program should enforce a single instance.
        /// </summary>
        private const bool SingleInstance = false;
        #endregion

        [STAThread]
        static int Main(string[] args) {
#if DEBUG
            DebugMode = true;
            //long f = 0x7F_FF_FF_FF_FF_FF_FF_FF;
            //MessageBox.Show(f.ToString("#,##0"));
#endif
            if (DebugMode || !SingleInstance || (Instance = new(true, ProgramGUID.Value)).WaitOne(TimeSpan.Zero, true)) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Ini.Initialize();
                Application.Run(new frmMain());
                if (!DebugMode && SingleInstance) {
                    Instance.ReleaseMutex();
                }
            }
            else {
                ExitCode = 1152; // Cannot start more than one instance of the specified program.
            }
            return ExitCode;
        }

    }
}
