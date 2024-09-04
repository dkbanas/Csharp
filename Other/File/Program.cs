
string filePath = "example.txt";
//Create and save
if (!File.Exists(filePath))
{
    File.WriteAllText(filePath, "Initial text");
    Console.WriteLine("--File is created and saved--");
}

//Read
string content = File.ReadAllText(filePath);
Console.WriteLine("--Content of file:--");
Console.WriteLine(content);

//Update
string newContent = content + "\nNew Line added";
File.WriteAllText(filePath, newContent);
Console.WriteLine("--File content updated--");

//Read update
content = File.ReadAllText(filePath);
Console.WriteLine("--Updated file content:--");
Console.WriteLine(content);

// DeleteFile
try
{
    File.Delete(filePath);
    Console.WriteLine("--File deleted--");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}