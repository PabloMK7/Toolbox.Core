﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Toolbox.Core.Imaging
{
    public class DefaultSwizzle : IPlatformSwizzle
    {
        public TexFormat OutputFormat { get; set; } = TexFormat.RGBA8_UNORM;

        public bool IsOuputRGBA8 => false;

        public byte[] DecodeImage(STGenericTexture texture, byte[] data, uint width, uint height, int array, int mip) {
            return data;
        }
    }
}
