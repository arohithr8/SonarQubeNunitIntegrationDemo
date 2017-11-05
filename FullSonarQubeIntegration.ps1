if($args.Length -ne 4)
{
    Write-Error "Expected 4 arguments: SonarQubeInstance, SonarQubePort, SonarQubeUser, SonarQubeLoginToken"
    return;
}

$SonarQubeInstance = $args[0];
$SonarQubePort = $args[1];
$SonarQubeUser = $args[2];
$SonarQubeLoginToken = $args[3];

#Cleanup
Remove-Item NUnitResults.xml
Remove-Item opencover.xml

#Step 1:
#Setup analyzers
Invoke-Expression "$env:ProgramData\chocolatey\bin\SonarQube.Scanner.MSBuild.exe begin /k:SonarQubeNUnitIntegrationDemo /d:'sonar.host.url=$SonarQubeInstance' /d:'sonar.host.port=$SonarQubePort' /d:'sonar.user=$SonarQubeUser' /d:'sonar.login=$SonarQubeLoginToken' /d:'sonar.cs.opencover.reportsPaths=opencover.xml'"

#Step 2:
#Rebuild
msbuild.exe /t:Rebuild SonarQubeNUnitIntegration.sln

# Step 3:
# Run code coverage
.\Packages\OpenCover.4.6.519\tools\OpenCover.Console.exe "-target:.\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe" "-targetargs:.\Demo.Tests\bin\Debug\Demo.Tests.dll" "-register:user" "-output:opencover.xml"

# Step 4:
# Finish analysis 
Invoke-Expression "$env:ProgramData\chocolatey\bin\SonarQube.Scanner.MSBuild.exe end /d:'sonar.login='$SonarQubeLoginToken"