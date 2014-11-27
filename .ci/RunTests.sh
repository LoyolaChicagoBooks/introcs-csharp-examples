#!/bin/sh -x

mono --runtime=v4.0 .nuget/NuGet.exe install NUnit.Runners -Version 2.6.1 -o packages

runTest(){
   mono --runtime=v4.0 packages/NUnit.Runners.2.6.1/tools/nunit-console.exe -noxml -nodots -labels -stoponerror $@
   if [ $? -ne 0 ]
   then   
     exit 1
   fi
}


# Run any DLL that has nunit at the end of its name. This is our convention
# for examples that have associated NUnit tests.

for unit_test in $(find . -name '*_nunit.dll')
do
   runTest $unit_test
done

exit $?
