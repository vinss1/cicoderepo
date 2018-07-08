using System.Reflection;
using System.Runtime.InteropServices;
using FEV.TOPexpert.Common.ConfigurationManagement.HelloWorld;

[assembly: AssemblyTitle("ConsoleApp1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration(VersionProvider.BuildConfiguration)]
[assembly: AssemblyCompany("FEV Europe GmbH")]
[assembly: AssemblyProduct("ConsoleApp1 " + VersionProvider.BuildConfiguration)]
[assembly: AssemblyCopyright("Copyright © FEV Europe GmbH 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("3569d257-5a2d-4080-8f81-caf15d4dd800")]

[assembly: AssemblyVersion("1.0.0")]

[assembly: AssemblyFileVersion("1.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0-" + VersionProvider.CommitID)]