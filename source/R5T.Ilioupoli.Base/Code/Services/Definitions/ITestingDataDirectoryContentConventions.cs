using System;


namespace R5T.Ilioupoli
{
    public interface ITestingDataDirectoryContentConventions
    {
        string BasicTextFileName { get; }

        string NewVisualStudio2017SolutionFileName { get; }
        string NewVisualStudio2019SolutionFileName { get; }
        string ExampleVisualStudioSolutionFileName { get; }
    }
}
