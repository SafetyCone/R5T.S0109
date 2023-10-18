using System;
using System.Threading.Tasks;


namespace R5T.S0109
{
    class Program
    {
        static async Task Main()
        {
            await Scripts.Instance.Publish_Project_ToDirectoryPath();
        }
    }
}