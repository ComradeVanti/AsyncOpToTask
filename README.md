# AsyncOp.ToTask

[![openupm](https://img.shields.io/npm/v/dev.comradevanti.asyncop-totask?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/dev.comradevanti.asyncop-totask/)

Unity package for converting builtin `AsyncOperation` objects to .Net Tasks.

## Installation


Install via [OpenUPM](https://openupm.com) using 
`openupm add dev.comradevanti.asyncop-totask`

## Usage

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