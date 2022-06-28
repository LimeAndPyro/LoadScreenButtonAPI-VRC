# LoadScreenButtonAPI-VRC
A Button API I Made For Rose That Makes It Easy To Add Single Buttons To The Load Screen!

If You have any questions feel free to contact me at https://discord.gg/nbuaZEMT7g or contact me By my discord username Lime/Pyro/Creed#1212!

if used throw a note with my discord name in the code :)

(https://github.com/pyrotoxic11/LoadScreenButtonAPI-VRC/blob/main/LoadButtonExample.png)

HOW TO USE

     LoadButton Restart = new LoadButton(new Vector3(-1246.402f, 1175.384f, 0f), new Vector3(1, 1, 1), "Restart", "RestartLoadButton", delegate
           {
               Process.Start("vrchat.exe", Environment.CommandLine.ToString()); Process.GetCurrentProcess().Kill();
           });
