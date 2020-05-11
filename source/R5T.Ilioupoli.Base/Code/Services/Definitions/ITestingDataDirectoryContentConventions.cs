using System;


namespace R5T.Ilioupoli
{
    public interface ITestingDataDirectoryContentConventions
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
