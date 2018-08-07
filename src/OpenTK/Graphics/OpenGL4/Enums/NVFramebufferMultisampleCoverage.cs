//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NVFramebufferMultisampleCoverage
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB
        /// </summary>
        RenderbufferCoverageSamplesNV = 0x8CAB,

        /// <summary>
        /// Original was GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10
        /// </summary>
        RenderbufferColorSamplesNV = 0x8E10,

        /// <summary>
        /// Original was GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11
        /// </summary>
        MaxMultisampleCoverageModesNV = 0x8E11,

        /// <summary>
        /// Original was GL_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12
        /// </summary>
        MultisampleCoverageModesNV = 0x8E12
    }
}
