# AsyncOp to Task

Unity package for converting builtin async operation objects such as
`AsyncOperation` to .Net Tasks.

## Installation

Install via [OpenUPM](https://openupm.com) using 
`openupm add dev.comradevanti.async-op-to-task`

## Usage

### [AsyncOperation](https://docs.unity3d.com/ScriptReference/AsyncOperation.html)

Simply add `.ToTask()` to the operation object in order to await it. This
will create a value-less `Task`. If you want to add a result-value to the
task, you can call one of the overloads which allow you to specify one.

```
// Example operation
var op = SceneManager.LoadSceneAsync("MyScene"); 

// Simple value-less task
await op.ToTask(); 

// Await the task with a specific result value
var v1 = await op.ToTask(5); 

// Await the task with the result being calculated by the given function
var v2 = await op.ToTask(() => "done"); 
```