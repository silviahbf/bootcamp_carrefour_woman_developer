﻿var path = @"D:\!Dio\Directory_And_DirectoryInfo\globo";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta: {path}");
Console.WriteLine("Pressione ENTER para finalizar.");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}.");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo {e.Name}.");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}.");
}