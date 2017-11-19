
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_PROGRAM_ATTRIB_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;

		/// <summary>
		/// [GL] Value of GL_PROGRAM_RESULT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int PROGRAM_RESULT_COMPONENTS_NV = 0x8907;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_RESULT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;

		/// <summary>
		/// [GL] Value of GL_MAX_PROGRAM_GENERIC_RESULTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public const int MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;

		/// <summary>
		/// [GL] glProgramLocalParameterI4iNV: Binding for glProgramLocalParameterI4iNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4NV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameterI4iNV != null, "pglProgramLocalParameterI4iNV not implemented");
			Delegates.pglProgramLocalParameterI4iNV(target, index, x, y, z, w);
			LogCommand("glProgramLocalParameterI4iNV", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramLocalParameterI4ivNV: Binding for glProgramLocalParameterI4ivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4NV(Int32 target, UInt32 index, Int32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameterI4ivNV != null, "pglProgramLocalParameterI4ivNV not implemented");
					Delegates.pglProgramLocalParameterI4ivNV(target, index, p_params);
					LogCommand("glProgramLocalParameterI4ivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramLocalParametersI4ivNV: Binding for glProgramLocalParametersI4ivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParametersI4NV(Int32 target, UInt32 index, Int32 count, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParametersI4ivNV != null, "pglProgramLocalParametersI4ivNV not implemented");
					Delegates.pglProgramLocalParametersI4ivNV(target, index, count, p_params);
					LogCommand("glProgramLocalParametersI4ivNV", null, target, index, count, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramLocalParameterI4uiNV: Binding for glProgramLocalParameterI4uiNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglProgramLocalParameterI4uiNV != null, "pglProgramLocalParameterI4uiNV not implemented");
			Delegates.pglProgramLocalParameterI4uiNV(target, index, x, y, z, w);
			LogCommand("glProgramLocalParameterI4uiNV", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramLocalParameterI4uivNV: Binding for glProgramLocalParameterI4uivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParameterI4uivNV != null, "pglProgramLocalParameterI4uivNV not implemented");
					Delegates.pglProgramLocalParameterI4uivNV(target, index, p_params);
					LogCommand("glProgramLocalParameterI4uivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramLocalParametersI4uivNV: Binding for glProgramLocalParametersI4uivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramLocalParametersI4uiNV(Int32 target, UInt32 index, Int32 count, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramLocalParametersI4uivNV != null, "pglProgramLocalParametersI4uivNV not implemented");
					Delegates.pglProgramLocalParametersI4uivNV(target, index, count, p_params);
					LogCommand("glProgramLocalParametersI4uivNV", null, target, index, count, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramEnvParameterI4iNV: Binding for glProgramEnvParameterI4iNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4NV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameterI4iNV != null, "pglProgramEnvParameterI4iNV not implemented");
			Delegates.pglProgramEnvParameterI4iNV(target, index, x, y, z, w);
			LogCommand("glProgramEnvParameterI4iNV", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramEnvParameterI4ivNV: Binding for glProgramEnvParameterI4ivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4NV(Int32 target, UInt32 index, Int32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameterI4ivNV != null, "pglProgramEnvParameterI4ivNV not implemented");
					Delegates.pglProgramEnvParameterI4ivNV(target, index, p_params);
					LogCommand("glProgramEnvParameterI4ivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramEnvParametersI4ivNV: Binding for glProgramEnvParametersI4ivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParametersI4NV(Int32 target, UInt32 index, Int32 count, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParametersI4ivNV != null, "pglProgramEnvParametersI4ivNV not implemented");
					Delegates.pglProgramEnvParametersI4ivNV(target, index, count, p_params);
					LogCommand("glProgramEnvParametersI4ivNV", null, target, index, count, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramEnvParameterI4uiNV: Binding for glProgramEnvParameterI4uiNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglProgramEnvParameterI4uiNV != null, "pglProgramEnvParameterI4uiNV not implemented");
			Delegates.pglProgramEnvParameterI4uiNV(target, index, x, y, z, w);
			LogCommand("glProgramEnvParameterI4uiNV", null, target, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramEnvParameterI4uivNV: Binding for glProgramEnvParameterI4uivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParameterI4uivNV != null, "pglProgramEnvParameterI4uivNV not implemented");
					Delegates.pglProgramEnvParameterI4uivNV(target, index, p_params);
					LogCommand("glProgramEnvParameterI4uivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glProgramEnvParametersI4uivNV: Binding for glProgramEnvParametersI4uivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void ProgramEnvParametersI4uiNV(Int32 target, UInt32 index, Int32 count, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramEnvParametersI4uivNV != null, "pglProgramEnvParametersI4uivNV not implemented");
					Delegates.pglProgramEnvParametersI4uivNV(target, index, count, p_params);
					LogCommand("glProgramEnvParametersI4uivNV", null, target, index, count, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramLocalParameterIivNV: Binding for glGetProgramLocalParameterIivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramLocalParameterINV(Int32 target, UInt32 index, [Out] Int32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterIivNV != null, "pglGetProgramLocalParameterIivNV not implemented");
					Delegates.pglGetProgramLocalParameterIivNV(target, index, p_params);
					LogCommand("glGetProgramLocalParameterIivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramLocalParameterIuivNV: Binding for glGetProgramLocalParameterIuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramLocalParameterINV(Int32 target, UInt32 index, [Out] UInt32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramLocalParameterIuivNV != null, "pglGetProgramLocalParameterIuivNV not implemented");
					Delegates.pglGetProgramLocalParameterIuivNV(target, index, p_params);
					LogCommand("glGetProgramLocalParameterIuivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramEnvParameterIivNV: Binding for glGetProgramEnvParameterIivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramEnvParameterINV(Int32 target, UInt32 index, [Out] Int32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterIivNV != null, "pglGetProgramEnvParameterIivNV not implemented");
					Delegates.pglGetProgramEnvParameterIivNV(target, index, p_params);
					LogCommand("glGetProgramEnvParameterIivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetProgramEnvParameterIuivNV: Binding for glGetProgramEnvParameterIuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_program4")]
		public static void GetProgramEnvParameterINV(Int32 target, UInt32 index, [Out] UInt32[] @params)
		{
			Debug.Assert(@params.Length >= 4);
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramEnvParameterIuivNV != null, "pglGetProgramEnvParameterIuivNV not implemented");
					Delegates.pglGetProgramEnvParameterIuivNV(target, index, p_params);
					LogCommand("glGetProgramEnvParameterIuivNV", null, target, index, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramLocalParameterI4iNV pglProgramLocalParameterI4iNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramLocalParameterI4ivNV pglProgramLocalParameterI4ivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramLocalParametersI4ivNV pglProgramLocalParametersI4ivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramLocalParameterI4uiNV pglProgramLocalParameterI4uiNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramLocalParameterI4uivNV pglProgramLocalParameterI4uivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramLocalParametersI4uivNV pglProgramLocalParametersI4uivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameterI4iNV(Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramEnvParameterI4iNV pglProgramEnvParameterI4iNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameterI4ivNV(Int32 target, UInt32 index, Int32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramEnvParameterI4ivNV pglProgramEnvParameterI4ivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParametersI4ivNV(Int32 target, UInt32 index, Int32 count, Int32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramEnvParametersI4ivNV pglProgramEnvParametersI4ivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameterI4uiNV(Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramEnvParameterI4uiNV pglProgramEnvParameterI4uiNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameterI4uivNV(Int32 target, UInt32 index, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramEnvParameterI4uivNV pglProgramEnvParameterI4uivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParametersI4uivNV(Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glProgramEnvParametersI4uivNV pglProgramEnvParametersI4uivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glGetProgramLocalParameterIivNV pglGetProgramLocalParameterIivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glGetProgramLocalParameterIuivNV pglGetProgramLocalParameterIuivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterIivNV(Int32 target, UInt32 index, Int32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glGetProgramEnvParameterIivNV pglGetProgramEnvParameterIivNV;

			[RequiredByFeature("GL_NV_gpu_program4")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterIuivNV(Int32 target, UInt32 index, UInt32* @params);

			[RequiredByFeature("GL_NV_gpu_program4")]
			[ThreadStatic]
			internal static glGetProgramEnvParameterIuivNV pglGetProgramEnvParameterIuivNV;

		}
	}

}
