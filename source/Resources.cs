﻿using IL2CPU.API.Attribs;

namespace Oceano
{
    public class Resources
    {
        [ManifestResourceStream(ResourceName = "Oceano.Resources.font.psf")]
        public static byte[] font;
        [ManifestResourceStream(ResourceName = "Oceano.Resources.wallpaper.bmp")]
        public static byte[] wallpaper;
        [ManifestResourceStream(ResourceName = "Oceano.Resources.settings.bmp")]
        public static byte[] settings;
        [ManifestResourceStream(ResourceName = "Oceano.Resources.window.bmp")]
        public static byte[] window;
    }
}
