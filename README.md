# LoadScreenButtonAPI-VRC
!!!Currently Buttons Only Work On HomeWorld Load Its So Odd Working On Fix!!!

A Button API I Made For Rose That Makes It Easy To Add Single Buttons To The Load Screen!

If You have any questions feel free to contact me at https://discord.gg/rosemod or contact me By my discord username Lime/Pyro/Creed#1212!

if used throw a note with my discord name in the code :)

![Showcase](https://github.com/pyrotoxic11/LoadScreenButtonAPI-VRC/blob/main/LoadButtonExample.png)

![Example Code](https://github.com/pyrotoxic11/LoadScreenButtonAPI-VRC/blob/main/examplecode.png)

![Example gif](https://i.imgur.com/of6HLtW.gif)

HOW TO USE

      LoadButton Restart = new LoadButton(new Vector3(-1269.999f, 1175.384f, 0f), new Vector3(1, 1, 1), "Restart", "RestartLoadButton", delegate
            {
               Process.Start("vrchat.exe", Environment.CommandLine.ToString()); Process.GetCurrentProcess().Kill();
            }, Color.white, Color.red);
            
You can also change the background of the button but it is null by default.
