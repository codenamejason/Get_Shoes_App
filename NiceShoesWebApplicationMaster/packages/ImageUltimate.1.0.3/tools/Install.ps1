# install.ps1
param($rootPath, $toolsPath, $package, $project)

$DTE.ItemOperations.Navigate("http://docs.gleamtech.com/imageultimate/?nuget=" + $package.Version, $DTE.vsNavigateOptions.vsNavigateOptionsNewWindow)
