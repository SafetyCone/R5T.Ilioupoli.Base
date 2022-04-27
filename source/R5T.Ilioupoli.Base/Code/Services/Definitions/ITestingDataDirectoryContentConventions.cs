using System;using R5T.T0064;


namespace R5T.Ilioupoli
{[ServiceDefinitionMarker]
    public interface ITestingDataDirectoryContentConventions:IServiceDefinition
    {
        string BasicTextFileName { get; }

        // Visual Studio solution files.
        string NewVisualStudio2017SolutionFileName { get; }
        string NewVisualStudio2019SolutionFileName { get; }
        string ExampleVisualStudioSolutionFileName { get; }

        // Visual Studio project files.
        string ExampleVisualStudioProjectFileName01 { get; }
        string ExampleVisualStudioProjectFileName02 { get; }
    }
}
