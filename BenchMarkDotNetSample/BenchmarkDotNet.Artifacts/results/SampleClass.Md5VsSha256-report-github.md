```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22621.4169/22H2/2022Update/SunValley2)
12th Gen Intel Core i5-1235U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


```
| Method | Mean      | Error     | StdDev    | Median    |
|------- |----------:|----------:|----------:|----------:|
| Sha256 |  5.521 μs | 0.2847 μs | 0.7745 μs |  5.290 μs |
| Md5    | 21.236 μs | 0.4742 μs | 1.2575 μs | 21.020 μs |
