using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using System.Windows.Threading;
using Dev2.Common.Interfaces;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Warewolf.Studio.AntiCorruptionLayer;

namespace Warewolf.Studio.ViewModels
{
    public class SplashViewModel : BindableBase, ISplashViewModel
    {
        string _serverVersion;
        string _studioVersion;

        public SplashViewModel(IServer server, IExternalProcessExecutor externalProcessExecutor)
        {
            if (server == null) throw new ArgumentNullException("server");
            if (externalProcessExecutor == null) throw new ArgumentNullException("externalProcessExecutor");
            Server = server;
            ExternalProcessExecutor = externalProcessExecutor;

            Uri conUri = new Uri(Resources.Languages.Core.ContributorsUrl);
            ContributorsUrl = conUri;
            Uri comUri = new Uri(Resources.Languages.Core.CommunityUrl);
            CommunityUrl = comUri;
            Uri expUri = new Uri(Resources.Languages.Core.ExpertHelpUrl);
            ExpertHelpUrl = expUri;
            Uri devUri = new Uri(Resources.Languages.Core.DevUrl);
            DevUrl = devUri;
            Uri warewolfUri = new Uri(Resources.Languages.Core.WarewolfUrl);
            WarewolfUrl = warewolfUri;
            WarewolfCopyright = Resources.Languages.Core.WarewolfCopyright;

            ContributorsCommand = new DelegateCommand(() => externalProcessExecutor.OpenInBrowser(ContributorsUrl));
            CommunityCommand = new DelegateCommand(() => externalProcessExecutor.OpenInBrowser(CommunityUrl));
            ExpertHelpCommand = new DelegateCommand(() => externalProcessExecutor.OpenInBrowser(ExpertHelpUrl));
            DevUrlCommand = new DelegateCommand(() => externalProcessExecutor.OpenInBrowser(DevUrl));
            WarewolfUrlCommand = new DelegateCommand(() => externalProcessExecutor.OpenInBrowser(WarewolfUrl));            
        }

        public IServer Server { get; set; }
        public IExternalProcessExecutor ExternalProcessExecutor { get; set; }
        public ICommand ContributorsCommand { get; set; }
        public ICommand CommunityCommand { get; set; }
        public ICommand ExpertHelpCommand { get; set; }
        public ICommand DevUrlCommand { get; set; }
        public ICommand WarewolfUrlCommand { get; set; }
        public string ServerVersion
        {
            get
            {
                return _serverVersion;
            }
            set
            {
                _serverVersion = value;
                OnPropertyChanged("ServerVersion");
            }
        }
        public string StudioVersion
        {
            get
            {
                return _studioVersion;
            }
            set
            {
                _studioVersion = value;
                OnPropertyChanged("StudioVersion");
            }
        }
        public Uri DevUrl { get; set; }
        public Uri WarewolfUrl { get; set; }
        public Uri ContributorsUrl { get; set; }
        public Uri CommunityUrl { get; set; }
        public Uri ExpertHelpUrl { get; set; }
        [ExcludeFromCodeCoverage]
        public string WarewolfCopyright { get; set; }

        public void ShowServerVersion()
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                ServerVersion = "Version " + Server.GetServerVersion();
                StudioVersion = "Version " + Utils.FetchVersionInfo();
            });
            
        }
    }
}