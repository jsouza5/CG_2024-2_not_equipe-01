﻿using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace gcgcg
{
    public static class Program
    {
        private static void Main()
        {
            var nativeWindowSettings = new NativeWindowSettings()
            {
                ClientSize = new Vector2i(800, 800),
                Title = "CG_N1",
                // This is needed to run on macos
                Flags = ContextFlags.ForwardCompatible,
            };

            //TODO: encontrar o comando certo para não dar problema de dobrar a resolução de tela no MacOS
            // ToolkitOptions.Default.EnableHighResolution = false;

            using var window = new Mundo(GameWindowSettings.Default, nativeWindowSettings);
            window.Run();
        }
    }
}
