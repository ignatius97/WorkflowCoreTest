using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace workflowTest.Data
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public string Id => "HelloWorld";
        public int Version => 1;

        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith(context =>
            {
                Console.WriteLine("Hello world");
                return ExecutionResult.Next();
            })
            .Then(context =>
            {
                Console.WriteLine("Goodbye world");
                return ExecutionResult.Next();
            });
        }
    }
}
