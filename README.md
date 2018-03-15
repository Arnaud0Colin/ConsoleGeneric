# ConsoleGeneric

### Display
```C#
for(int i =0; i<100; i++)
{
    Display.RenderConsoleProgress(i, ConsoleColor.White, $"{i:D2}%");
    System.Threading.Thread.Sleep(50);
}
```
### Gauge
```C#
Gauge.count = 100;
for(int i =0; i<100; i++)
{
  UpdateGauge(i);
}
```

### Init Trace
```C#
 TraceFile.Fichier = "MyLog.txt";
 ```
 ### Use Trace
 ```C#
 TraceFile.WriteLine($"===  ===");
 ```
