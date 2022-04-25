using System;
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

        public static Task<T> ToTask<T>(this AsyncOperation op, Func<T> makeValue) =>
            op.ToTask(makeValue());

        public static Task<T> ToTask<T>(this AsyncOperation op, T value) =>
            op.ToTask(() => value);

    }

}