using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Activities;

namespace Chris.Blog.MsmqWorkflow.WorkflowService
{

    public sealed class LogMessageText : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);

            // write contents to file
            File.AppendAllLines(@"c:\dev\wcf-msmq-practice\logfile.log", new[] {text + "\n"});
        }
    }
}
