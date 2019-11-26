﻿using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

public class NamerTests :
    VerifyBase
{
    [Fact]
    public Task Runtime()
    {
        UniqueForRuntime();
        return Verify(Namer.runtime);
    }

    [Fact]
    public Task RuntimeAndVersion()
    {
        UniqueForRuntimeAndVersion();
        return Verify(Namer.runtimeAndVersion);
    }

    [Fact]
    public Task AssemblyConfiguration()
    {
        UniqueForAssemblyConfiguration();
        return Verify("Foo");
    }

    public NamerTests(ITestOutputHelper output) :
        base(output)
    {
    }
}