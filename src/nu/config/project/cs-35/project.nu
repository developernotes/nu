﻿<?xml version="1.0" encoding="utf-8" ?>
<project>
  <folders>
    <folder path=".${PathSeparator}src" />
    <folder path=".${PathSeparator}src${PathSeparator}${ProjectName}" />
    <folder path=".${PathSeparator}src${PathSeparator}${ProjectName}.Tests" />
    <folder path=".${PathSeparator}lib"  />
    <folder path=".${PathSeparator}tools" />
    <folder path=".${PathSeparator}build" />
    <folder path=".${PathSeparator}build${PathSeparator}docs" />
  </folders>
  <files>
    <file source=".${PathSeparator}Default.sln" destination="${PathSeparator}src${PathSeparator}${ProjectName}.sln" />
    <file source=".${PathSeparator}Default.csproj" destination="${PathSeparator}src${PathSeparator}${ProjectName}${PathSeparator}${ProjectName}.csproj" />
    <file source=".${PathSeparator}Default.Tests.csproj" destination="${PathSeparator}src${PathSeparator}${ProjectName}.Tests${PathSeparator}${ProjectName}.Tests.csproj" />
    <file source=".${PathSeparator}nant.build" destination="${PathSeparator}src${PathSeparator}nant.build" />
    <file source=".${PathSeparator}build.bat" destination=".${PathSeparator}build.bat" />
  </files>
  <packages>
    <package name="" />
    <package name="" />
  </packages>
</project>