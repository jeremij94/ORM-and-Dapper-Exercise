<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <RootNamespace>ORM_Dapper</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <None Remove="Dapper" />
    <None Remove="MySql.Data" />
    <None Remove="Microsoft.Extensions.Configuration.Json" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Dapper" Version="2.0.123" />
    <PackageReference Include="MySql.Data" Version="8.0.31" />
    <PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="6.0.0" />
  </ItemGroup>
  <ItemGroup>
    <None Update="appsettings.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
</Project>
