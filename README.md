# LoadScreenButtonAPI-VRC
A Button API I Made For Rose That Makes It Easy To Add Single Buttons To The Load Screen!
If You have any questions feel free to contact me at https://discord.gg/nbuaZEMT7g or contact me By my discord username Lime/Pyro/Creed#1212!
How To USE
{
    ```cs
     LoadButton Restart = new LoadButton(new Vector3(-1246.402f, 1175.384f, 0f), new Vector3(1, 1, 1), "Restart", "RestartLoadButton", delegate
           {
               Process.Start("vrchat.exe", Environment.CommandLine.ToString()); Process.GetCurrentProcess().Kill();
           });```cs

}