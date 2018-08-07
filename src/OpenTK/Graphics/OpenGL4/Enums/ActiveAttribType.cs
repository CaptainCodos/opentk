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
    /// Used in GL.GetActiveAttrib.
    /// </summary>
    public enum ActiveAttribType
    {
        /// <summary>
        /// Original was GL_NONE = 0x0
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140A,

        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8B50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8B51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8B52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8B53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8B54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8B55,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8B5A,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8B5B,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8B5C,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8B65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8B66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8B67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8B68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8B69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8B6A,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        /// </summary>
        UnsignedIntVec2 = 0x8DC6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        /// </summary>
        UnsignedIntVec3 = 0x8DC7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        /// </summary>
        UnsignedIntVec4 = 0x8DC8,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2 = 0x8F46
        /// </summary>
        DoubleMat2 = 0x8F46,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3 = 0x8F47
        /// </summary>
        DoubleMat3 = 0x8F47,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4 = 0x8F48
        /// </summary>
        DoubleMat4 = 0x8F48,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2X3 = 0x8F49
        /// </summary>
        DoubleMat2x3 = 0x8F49,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2X4 = 0x8F4A
        /// </summary>
        DoubleMat2x4 = 0x8F4A,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3X2 = 0x8F4B
        /// </summary>
        DoubleMat3x2 = 0x8F4B,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3X4 = 0x8F4C
        /// </summary>
        DoubleMat3x4 = 0x8F4C,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4X2 = 0x8F4D
        /// </summary>
        DoubleMat4x2 = 0x8F4D,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4X3 = 0x8F4E
        /// </summary>
        DoubleMat4x3 = 0x8F4E,

        /// <summary>
        /// Original was GL_DOUBLE_VEC2 = 0x8FFC
        /// </summary>
        DoubleVec2 = 0x8FFC,

        /// <summary>
        /// Original was GL_DOUBLE_VEC3 = 0x8FFD
        /// </summary>
        DoubleVec3 = 0x8FFD,

        /// <summary>
        /// Original was GL_DOUBLE_VEC4 = 0x8FFE
        /// </summary>
        DoubleVec4 = 0x8FFE
    }
}
