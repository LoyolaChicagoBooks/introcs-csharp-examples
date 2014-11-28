MONO_VER=$1

# Install Mono (OS X)
wget "http://download.mono-project.com/archive/${MONO_VER}/macos-10-x86/MonoFramework-MDK-${MONO_VER}.macos10.xamarin.x86.pkg"
sudo installer -pkg "MonoFramework-MDK-${MONO_VER}.macos10.xamarin.x86.pkg" -target /

# Install NuGet (platform-independent)

wget http://nuget.org/nuget.exe
