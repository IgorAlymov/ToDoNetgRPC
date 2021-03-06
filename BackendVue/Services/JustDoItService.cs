using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace BackendVue
{
    public class JustDoItService : JustDoIt.JustDoItBase
    {
        private readonly ILogger<JustDoItService> _logger;
        
        public JustDoItService(ILogger<JustDoItService> logger)
        {
            _logger = logger;
        }

        public override Task<Task> AddIssue(TaskName request, ServerCallContext context)
        {
            Random random = new Random();
            return System.Threading.Tasks.Task.FromResult(new Task
            {
                Id = random.Next(1000),
                Name = request.Name,
                Checked = false
            });
        }

        public override Task<Result> RemoveIssue(TaskId request, ServerCallContext context)
        {
            //Удаляем задачу
            
            return System.Threading.Tasks.Task.FromResult(new Result
            {
                Result_ = true
            });
        }

        public override Task<Result> UpdateIssue(Task request, ServerCallContext context)
        {
            //Обновляем задачу
            
            return System.Threading.Tasks.Task.FromResult(new Result
            {
                Result_ = true
            });
        }
    }
}