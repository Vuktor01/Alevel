using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string result = await ConcatenateTextAsync();
        Console.WriteLine(result);
    }

    static async Task<string> ReadFileAsync(string filePath)
    {
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                return await sr.ReadToEndAsync();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception reading file {filePath}: {e.Message}");
            return string.Empty;
        }
    }

    static async Task<string> ConcatenateTextAsync()
    {
        string helloFilePath = "D:\\Logger\\Homework3.5Solution\\Hello.txt";
        string worldFilePath = "D:\\Logger\\Homework3.5Solution\\World.txt";

        Task<string> readHelloTask = ReadFileAsync(helloFilePath);
        Task<string> readWorldTask = ReadFileAsync(worldFilePath);

        await Task.WhenAll(readHelloTask, readWorldTask);

        return readHelloTask.Result + readWorldTask.Result;
    }
}