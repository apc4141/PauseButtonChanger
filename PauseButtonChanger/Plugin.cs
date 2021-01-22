using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace PauseButtonChanger
{

    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        //internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        public void Init(Zenjector zenjector, IPALogger logger)
        {
            //Instance = this;
            Log = logger;
            zenjector.OnApp<Main.AppInstaller>();
        }

        #region BSIPA Config
        //Uncomment to use BSIPA's config
        /*
        [Init]
        public void InitWithConfig(Config conf)
        {
            Configuration.PluginConfig.Instance = conf.Generated<Configuration.PluginConfig>();
            Log.Debug("Config loaded");
        }
        */
        #endregion

        [OnEnable]
        public void OnEnable()
        {
            
        }

        [OnDisable]
        public void OnDisable()
        {
            
        }

        [OnExit]
        public void OnApplicationExit()
        { 
            
        }
    }
}
