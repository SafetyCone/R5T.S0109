using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.S0109
{
    [FunctionalityMarker]
    public partial interface IScripts : IFunctionalityMarker
    {
        public async Task Publish_Project_ToDirectoryPath()
        {
            /// Inputs.
            var projectFilePath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.C0003\source\R5T.C0003\R5T.C0003.csproj";
            var publishOutputDirectoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.C0003\source\R5T.C0003\bin\publish\";


            /// Run.
            await Instances.PublishOperator.Publish(
                projectFilePath,
                publishOutputDirectoryPath);
        }
    }
}
