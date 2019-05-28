using System;
namespace BridgePattern.Models
{
    public class TimeSorter : Sorter
    {
        public void timerSort(object obj)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Sort(obj);
            sw.Stop();

            // 結果表示
            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($" {ts}");
            Console.WriteLine($" {ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($" {sw.ElapsedMilliseconds}ミリ秒");
        }
    }
}
