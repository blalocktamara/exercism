dmcs School.cs GradeSchoolTest.cs -r:../NUnit-2.6.3/bin/nunit.framework.dll -target:library
monolinker -a ../NUnit-2.6.3/bin/nunit.framework.dll -a School.dll
mono ../NUnit-2.6.3/bin/nunit-console.exe output/School.dll
