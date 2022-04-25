using System.Threading.Tasks;
using UnityEngine;

namespace Dev.ComradeVanti.AsyncOpToTask
{

    public static class AsyncOperationExt
    {

        public static Task ToTask(this AsyncOperation op)
        {
            var completionSource = new TaskCompletionSource<bool>();

            op.completed += _ => completionSource.SetResult(true);

            return completionSource.Task;
        }

    }

}