dmcs Gigasecond.cs GigasecondTest.cs -r:../NUnit-2.6.3/bin/nunit.framework.dll -target:library
monolinker -a ../NUnit-2.6.3/bin/nunit.framework.dll -a Gigasecond.dll
mono ../NUnit-2.6.3/bin/nunit-console.exe output/Gigasecond.dll
