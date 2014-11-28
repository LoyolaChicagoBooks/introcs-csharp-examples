MONO_VER=$1

# Install Mono 2.x (OS X worker on Travis)

wget "http://download.mono-project.com/archive/${MONO_VER}/macos-10-x86/MonoFramework-MDK-${MONO_VER}.macos10.xamarin.x86.dmg"
hdid "MonoFramework-MDK-${MONO_VER}.macos10.xamarin.x86.dmg"
sudo installer -pkg "/Volumes/Mono Framework MDK ${MONO_VER}/MonoFramework-MDK-${MONO_VER}.macos10.xamarin.x86.pkg" -target /

# Install NuGet (platform-independent)

wget http://nuget.org/nuget.exe
