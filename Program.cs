using Solutions;

var watch = new System.Diagnostics.Stopwatch();
            
watch.Start();

// Static Method call for the Sherlock And Squares Coding Challenge
Console.WriteLine(SherlockAndSquares.Solve(3, 9));

watch.Stop();

Console.WriteLine(watch.Elapsed + " Outer Method Elapsed Time");