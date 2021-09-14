using System;
using System.Text;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFunctionBoilerplate
{
    public static class Function1
    {
        [Function("Function1")]
        public static void Run([QueueTrigger("yourqueuename")] byte[] myQueueItem,
            FunctionContext context)
        {
            var myQueueItemAsString = Encoding.UTF8.GetString(myQueueItem);

            var logger = context.GetLogger("Function1");
            logger.LogInformation($"C# Queue trigger function processed: {myQueueItemAsString}");
        }
    }
}
