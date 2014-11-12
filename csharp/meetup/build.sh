dmcs Meetup.cs MeetupTest.cs -r:../NUnit-2.6.3/bin/nunit.framework.dll -target:library
monolinker -a ../NUnit-2.6.3/bin/nunit.framework.dll -a Meetup.dll
mono ../NUnit-2.6.3/bin/nunit-console.exe output/Meetup.dll
